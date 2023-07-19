using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace TestConverter
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.AutoFlush = true;

            

            MonsterSpawnDb.Load();

            // Create mob spawns
            foreach (var map in MonsterSpawnDb.MapEntries)
            {
                if (map.ClassName == "Steam_f_coral_44_1")
                {
                    continue;
                }

                if (String.IsNullOrEmpty(map.MapName))
                {
                    throw new Exception("Map with empty name found");
                }

                if (MonsterSpawnDb.Entries.ContainsKey(map.ClassName))
                {
                    var entries = MonsterSpawnDb.Entries[map.ClassName].OrderBy(p => p.GenType);

                    // Creates mob spawns string
                    string mobs = "";

                    // No monsters or crystals in this map, skip this map.
                    if ( (!entries.Any(data => data.Faction == "RootCrystal")) &&
                        (!entries.Any(data => data.Faction == "Monster")) )
                    {
                        continue;
                    }

                    // ---------------- Monster Properties ---------------------

                            // If there is at least one monster stat property override for this map
                    if (map.MonsterStat != null)
                    {
                        mobs += "\t\t// Property Overrides -------------------------------\r\n\r\n";
                    }

                    if (map.MonsterStat != null)
                    {
                        var statList = map.MonsterStat;
                        // Add mob property overrides
                        foreach (var stat in statList)
                        {
                            mobs += "\t\tAddPropertyOverrides(\"" + map.ClassName + "\", MonsterId." + ToTitleCase(stat.ClassName) + ", Properties(" +
                                "\"MHP\", " + stat.MHP + ", " +
                                "\"MINPATK\", " + stat.MINPATK + ", " +
                                "\"MAXPATK\", " + stat.MAXPATK + ", " +
                                "\"MINMATK\", " + stat.MINMATK + ", " +
                                "\"MAXMATK\", " + stat.MAXMATK + ", " +
                                "\"DEF\", " + stat.DEF + ", " +
                                "\"MDEF\", " + stat.MDEF + "));" + "\r\n";
                        }
                    }

                    // ---------------- Monster Spawners ---------------------

                    // If there is at least one monster in this map
                    if (entries.Any(data => data.Faction == "Monster"))
                    {
                        mobs += "\r\n\t\t// Monster Spawners ---------------------------------\r\n\r\n";
                    }

                    // Add monster populations
                    List<int> addedMobGenTypes = new List<int>();
                    int i = 1;
                    foreach (var mob in entries)
                    {
                        if (String.Equals(mob.Faction, "Monster", StringComparison.OrdinalIgnoreCase) || String.Equals(mob.Faction, "RootCrystal", StringComparison.OrdinalIgnoreCase))
                        {
                            if (!addedMobGenTypes.Contains(mob.GenType))
                            {
                                string tendency = "TendencyType.Peaceful";
                                if (mob.Tendency.Equals("Attack", StringComparison.OrdinalIgnoreCase))
                                    tendency = "TendencyType.Aggressive";
                                var minPop = (int)Math.Ceiling(mob.MaxPop * 3.0 / 4.0);
                                string identifier = map.ClassName + "." + "Id" + i.ToString();
                                mobs += "\t\tAddSpawner(\"" + identifier + "\", MonsterId." + ToTitleCase(mob.ClassName) + ", " + minPop + ", " + mob.MaxPop + ", TimeSpan.FromMilliseconds(" + mob.RespawnTime + "), " + tendency + ");" + "\r\n";

                                i++;
                                mob.Identifier = identifier;
                                addedMobGenTypes.Add(mob.GenType);
                            } 
                        }
                    }

                    /// Fills identifiers (dumb way)
                    foreach (var mob in entries)
                    {
                        foreach (var mob2 in entries)
                        {
                            if (mob.Identifier == null)
                            {
                                if ( (mob.GenType == mob2.GenType) && (mob.ClassName == mob2.ClassName) && (mob.Map == mob2.Map) )
                                {
                                    mob.Identifier = mob2.Identifier;
                                }
                            }
                        }
                    }

                    // ---------------- Monster Spawn Points ---------------------

                    // If there is at least one monster in this map
                    if (entries.Any(data => data.Faction == "Monster"))
                    {
                        mobs += "\r\n\t\t// Monster Spawn Points -----------------------------\r\n";
                    }

                    // mobs
                    int currentGentype = -1;
                    bool set = false;
                    foreach (var mob in entries)
                    {
                        foreach (var genType in addedMobGenTypes)
                        {
                            if ((String.Equals(mob.Faction, "Monster", StringComparison.OrdinalIgnoreCase) || String.Equals(mob.Faction, "RootCrystal", StringComparison.OrdinalIgnoreCase)) && (genType == mob.GenType))
                            {
                                if (mob.MonsterId == -1)
                                {
                                    throw new Exception("Invalid monster id found");
                                }

                                if (currentGentype != mob.GenType)
                                {
                                    mobs += "\r\n\t\t// '" + ToTitleCase(mob.ClassName) + "' GenType " + genType.ToString() +  " Spawn Points\r\n";
                                    currentGentype = mob.GenType;
                                }
                                var X = mob.X;
                                set = true;
                                mobs += "\t\tAddSpawnPoint(\"" + mob.Identifier + "\", \"" + map.ClassName + "\", " + "Rectangle(" + mob.X + ", " + mob.Z + ", " + mob.GenRange + "));" + "\r\n";
                            }
                        }
                    }
                    if (set)
                        mobs = mobs.Substring(0, mobs.Length - 2);

                    // Sets the type of map by some arbitraty naming convention
                    string type;
                    if (map.ClassName.Contains("f_") && (!map.ClassName.Contains("GuildColony")))
                    {
                        type = "fields";
                    }
                    else if (map.ClassName.Contains("d_") && (!map.ClassName.Contains("raid_")) && (!map.ClassName.Contains("GuildColony")))
                    {
                        type = "dungeons";
                    }
                    else if (map.ClassName.Contains("c_"))
                    {
                        type = "cities";
                    }
                    else
                    {
                        if (map.MapType == "Instance")
                        {
                            type = "instances";
                        }
                        else
                        {
                            type = "others";
                        }
                    }

                    // Sets directory path
                    string filePath = "mobs/" + type + "/" + map.ClassName + ".cs";

                    // Create the directory if it doesn't exist
                    string directoryPath = Path.GetDirectoryName(filePath);
                    Directory.CreateDirectory(directoryPath);

                    // Write to file
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        MonsterSpawnDb.AddMeliaMobSpawners(writer, map.ClassName, map.MapName, mobs);
                    }

                }
            }
        }

        public static (double, double)[] GetSquareCorners(double center_x, double center_y, double range, double direction)
        {
            (double, double)[] corners = new (double, double)[4];

            // Convert the direction angle to radians
            double angleRad = direction * Math.PI / 180;

            // Calculate the coordinates of the corners
            double halfDiagonal = range * Math.Sqrt(2) / 2;
            double cornerAngleRad = Math.Atan2(halfDiagonal, halfDiagonal) + angleRad;

            corners[0] = (center_x + range * Math.Cos(cornerAngleRad), center_y + range * Math.Sin(cornerAngleRad)); // Top-left
            corners[1] = (center_x + range * Math.Cos(cornerAngleRad + Math.PI / 2), center_y + range * Math.Sin(cornerAngleRad + Math.PI / 2)); // Top-right
            corners[2] = (center_x + range * Math.Cos(cornerAngleRad + Math.PI), center_y + range * Math.Sin(cornerAngleRad + Math.PI)); // Bottom-left
            corners[3] = (center_x + range * Math.Cos(cornerAngleRad + Math.PI * 3 / 2), center_y + range * Math.Sin(cornerAngleRad + Math.PI * 3 / 2)); // Bottom-right

            return corners;
        }
        public static string ToTitleCase(string input)
        {
            string[] words = input.Split('_');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    char[] letters = words[i].ToCharArray();
                    letters[0] = char.ToUpper(letters[0]);
                    words[i] = new string(letters);
                }
            }

            return string.Join("_", words);
        }

        static void ConvertIESToCSV()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string[] iesFiles = Directory.GetFiles(currentDirectory, "*.ies");

            foreach (string iesFilePath in iesFiles)
            {
                string csvFilePath = Path.ChangeExtension(iesFilePath, ".csv");

                try
                {
                    using (FileStream iesFileStream = File.OpenRead(iesFilePath))
                    {
                        IesFile iesFile = new IesFile(iesFileStream);

                        using (StreamWriter csvWriter = new StreamWriter(csvFilePath))
                        {
                            // Write CSV header
                            foreach (var column in iesFile.Columns)
                            {
                                csvWriter.Write(column.Name);
                                csvWriter.Write(",");
                            }
                            csvWriter.WriteLine();

                            // Write CSV rows
                            foreach (var row in iesFile.Rows)
                            {
                                foreach (var column in iesFile.Columns)
                                {
                                    if (column.IsNumber)
                                        csvWriter.Write(row.GetFloat(column.Name));
                                    else
                                        csvWriter.Write(row.GetString(column.Name));

                                    csvWriter.Write(",");
                                }
                                csvWriter.WriteLine();
                            }
                        }
                    }

                    Console.WriteLine("Conversion completed. CSV file saved: " + csvFilePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred during the conversion of file " + iesFilePath + ": " + ex.Message);
                }
            }
        }
    }
}