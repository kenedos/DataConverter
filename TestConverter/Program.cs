using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace TestConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            MonsterSpawnDb.Load();

            // Create mob spawns
            foreach (var map in MonsterSpawnDb.MapEntries)
            {
                if (map.ClassName == "Steam_f_coral_44_1")
                {
                    continue;
                }

                if (MonsterSpawnDb.Entries.ContainsKey(map.ClassName))
                {
                    // Creates mob spawns string
                    string mobs = "";

                    // ---------------- Monster Properties ---------------------

                    // If there is at least one monster stat property override for this map
                    if (MonsterSpawnDb.Entries[map.ClassName].Any(data => data.MonsterStat != null))
                    {
                        mobs += "\t\t// Property Overrides\r\n";
                    }

                    // Add mob property overrides
                    List<string> addedMobClasses = new List<string>();
                    foreach (var mob in MonsterSpawnDb.Entries[map.ClassName])
                    {
                        if (String.Equals(mob.Faction, "Monster", StringComparison.OrdinalIgnoreCase))
                        {
                            if (mob.MonsterStat != null && !addedMobClasses.Contains(mob.ClassName))
                            {
                                mobs += "\t\tAddPropertyOverrides(\"" + map.ClassName + "\", MonsterId." + ToTitleCase(mob.ClassName) + ", Properties(" +
                                    "\"MHP\", " + mob.MonsterStat.MHP + ", " +
                                    "\"MINPATK\", " + mob.MonsterStat.MINPATK + ", " +
                                    "\"MAXPATK\", " + mob.MonsterStat.MAXPATK + ", " +
                                    "\"MINMATK\", " + mob.MonsterStat.MINMATK + ", " +
                                    "\"MAXMATK\", " + mob.MonsterStat.MAXMATK + ", " +
                                    "\"DEF\", " + mob.MonsterStat.DEF + ", " +
                                    "\"MDEF\", " + mob.MonsterStat.MDEF + "));" + "\r\n";

                                addedMobClasses.Add(mob.ClassName);
                            }
                        }
                    }

                    // ---------------- Monster Populations ---------------------

                    // If there is at least one monster in this map
                    if (MonsterSpawnDb.Entries[map.ClassName].Any(data => data.Faction == "Monster"))
                    {
                        mobs += "\r\n\t\t// Monster Populations\r\n";
                    }

                    // Add monster populations
                    List<string> addedMobPopulations = new List<string>();
                    foreach (var mob in MonsterSpawnDb.Entries[map.ClassName])
                    {
                        if (String.Equals(mob.Faction, "Monster", StringComparison.OrdinalIgnoreCase) || String.Equals(mob.Faction, "RootCrystal", StringComparison.OrdinalIgnoreCase))
                        {
                            if (!addedMobPopulations.Contains(mob.PopulationCustomName))
                            {
                                mobs += "\t\tAddMonsterPopulation(\"" + map.ClassName + "\", \"" + mob.PopulationCustomName + "\", " + mob.MaxPop + ");" + "\r\n";

                                addedMobPopulations.Add(mob.PopulationCustomName);
                            } 
                        }
                    }

                    // ---------------- Monster Spawns ---------------------

                    // If there is at least one RootCrystal in this map
                    if (MonsterSpawnDb.Entries[map.ClassName].Any(data => data.Faction == "RootCrystal"))
                    {
                        mobs += "\r\n\t\t// RootCrystal Spawners\r\n";
                    }

                    foreach (var mobPopulation in addedMobPopulations)
                    {
                        foreach (var mob in MonsterSpawnDb.Entries[map.ClassName])
                        {
                            if (String.Equals(mob.Faction, "RootCrystal", StringComparison.OrdinalIgnoreCase) && string.Equals(mob.PopulationCustomName, mobPopulation))
                            {
                                mobs += "\t\tAddSpawner(MonsterId." + ToTitleCase(mob.ClassName) + ", \"" + mob.PopulationCustomName + "\", TimeSpan.FromMilliseconds(" + mob.RespawnTime + "), \"" + map.ClassName + "\", " + "Spot(" + mob.X + ", " + mob.Z + ", " + mob.GenRange + "));" + "\r\n";
                            }
                        }
                    }

                    // If there is at least one monster in this map
                    if (MonsterSpawnDb.Entries[map.ClassName].Any(data => data.Faction == "Monster"))
                    {
                        mobs += "\r\n\t\t// Monster Spawners\r\n";
                    }

                    // Add mob spawners
                    foreach (var mobPopulation in addedMobPopulations)
                    {
                        foreach (var mob in MonsterSpawnDb.Entries[map.ClassName])
                        {
                            if (String.Equals(mob.Faction, "Monster", StringComparison.OrdinalIgnoreCase) && string.Equals(mob.PopulationCustomName, mobPopulation))
                            {
                                mobs += "\t\tAddSpawner(MonsterId." + ToTitleCase(mob.ClassName) + ", \"" + mob.PopulationCustomName + "\", TimeSpan.FromMilliseconds(" + mob.RespawnTime + "), \"" + map.ClassName + "\", " + "Spot(" + mob.X + ", " + mob.Z + ", " + mob.GenRange + "));" + "\r\n";
                            }
                        }
                    }
                    
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
                        MonsterSpawnDb.AddMeliaMobSpawners(writer, map.ClassName, map.ClassName, mobs);
                    }

                }
            }
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