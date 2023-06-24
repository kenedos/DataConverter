using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;

namespace TestConverter
{
    public class MapData
    {
        public string ClassName { get; set; }
        public string MapType { get; set; }
    }

    public class MonsterStat
    {
        public int ClassID { get; set; }
        public int MHP { get; set; }
        public int MINPATK { get; set; }
        public int MAXPATK { get; set; }
        public int MINMATK { get; set; }
        public int MAXMATK { get; set; }
        public int DEF { get; set; }
        public int MDEF { get; set; }
    }

    public class MonsterSpawnAnchorData
    {
        public int ClassID { get; set; }
        public int GenType { get; set; }
        public float PosX { get; set; }
        public float PosY { get; set; }
        public float PosZ { get; set; }
        public float Direction { get; set; }
        public int AnchorRange { get; set; }
        public int NPCID { get; set; }
        public string Name { get; set; }
    }

    public class MonsterSpawnGenTypeData
    {
        public int ClassID { get; set; }
        public int GenType { get; set; }
        public int Lv { get; set; }
        public int Range { get; set; }
        public int GenRange { get; set; }
        public int RespawnTime { get; set; }
        public int MaxPop { get; set; }
        public int Minimap { get; set; }
        public int Hide { get; set; }
        public int UseAIOufOfPC { get; set; }
        public int AnchorCount { get; set; }
        public int UP_ReturnRange { get; set; }
        public int P_MaxDialog { get; set; }
        public string ClassType { get; set; }
        public string Name { get; set; }
        public int UniqueName { get; set; }
        public int QuestName { get; set; }
        public int Tag { get; set; }
        public int Tactics { get; set; }
        public int BTree { get; set; }
        public int SimpleAI { get; set; }
        public int Dialog { get; set; }
        public int Enter { get; set; }
        public int Leave { get; set; }
        public int Save { get; set; }
        public int OnlyPCCheck { get; set; }
        public int SmartGen { get; set; }
        public int Faction { get; set; }
        public int ArgStr1 { get; set; }
        public int ArgStr2 { get; set; }
        public int ArgStr3 { get; set; }
        public int Tendency { get; set; }
    }

    public class MonsterSpawnData
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public string Map { get; set; }
        public int Direction { get; set; }
        public string Name { get; set; }
        public string Dialog { get; set; }
        public string Enter { get; set; }
        public string Leave { get; set; }
        public float Range { get; set; }
        public int GenRange { get; set; }
        public int RespawnTime { get; set; }
        public int MaxPop { get; set; }
        public string ArgStr1 { get; set; }
        public string ArgStr2 { get; set; }
        public string ArgStr3 { get; set; }
        public string Faction { get; set; }
        public string Tendency { get; set; }
        public string PopulationCustomName { get; set; }
        public int HideNPC { get; set; } = -1;
        public MonsterStat? MonsterStat { get; set; } = null;
    }

    public class MonsterDialogData
    {
        public string ClassName { get; set; }
        public string CMM_Name { get; set; }
        public string SelectDialog { get; set; }
        public string IdleDialog { get; set; }
    }

    public static class MonsterSpawnDb
    {
        public readonly static Dictionary<string, List<MonsterSpawnData>> Entries = new Dictionary<string, List<MonsterSpawnData>>();
        public static Dictionary<string, MonsterDialogData> DialogEntries = new Dictionary<string, MonsterDialogData>();
        public static Dictionary<string, int> HideNPCEntries = new Dictionary<string, int>();
        public static List<MapData> MapEntries = new List<MapData>();
        public static Dictionary<string, string> FunctionEntries = new Dictionary<string, string>();
        public static Dictionary<string, string> WarpEntries = new Dictionary<string, string>();
        public static Dictionary<string, string> MeliaWarpEntries = new Dictionary<string, string>();

        /// <summary>
        /// Search recursively for given ".ies" fileName and returns all class names of a given file
        /// </summary>
        /// <param name="fileName">.ies file name</param>
        /// <param name="classList">return by reference</param>
        /// <returns></returns>
        public static bool TryGetClasses(string fileName, out List<IesRow> classList)
        {
            classList = null;

            string[] filePaths = Directory.GetFiles(".", fileName, SearchOption.AllDirectories)
                .Where(path => string.Equals(Path.GetFileName(path), Path.GetFileName(fileName), StringComparison.OrdinalIgnoreCase))
                .ToArray();

            if (filePaths.Length == 0)
                return false;

            string iesFilePath = filePaths[0];

            using (var iesFile = new IesFile(File.OpenRead(iesFilePath)))
            {
                var classNameColumn = iesFile.Columns.FirstOrDefault(c => string.Equals(c.Name, "ClassID", StringComparison.OrdinalIgnoreCase));

                if (classNameColumn == null)
                    return false;

                classList = iesFile.Rows.ToList();

                return true;
            }
        }

        /// <summary>
        /// Search recursively for given ".ies" fileName and returns all matching class name of a given file
        /// </summary>
        /// <param name="fileName">.ies file name</param>
        /// <param name="className">Class name to match</param>
        /// <param name="classList">return by reference</param>
        /// <returns></returns>
        public static bool TryGetClassByName(string fileName, string className, out string[] classList)
        {
            classList = null;

            string[] filePaths = Directory.GetFiles(".", fileName, SearchOption.AllDirectories)
                .Where(path => string.Equals(Path.GetFileName(path), Path.GetFileName(fileName), StringComparison.OrdinalIgnoreCase))
                .ToArray();

            if (filePaths.Length == 0)
                return false;

            string iesFilePath = filePaths[0];

            using (var iesFile = new IesFile(File.OpenRead(iesFilePath)))
            {
                var classNameColumn = iesFile.Columns.FirstOrDefault(c => string.Equals(c.Name, "ClassName", StringComparison.OrdinalIgnoreCase));

                if (classNameColumn == null)
                    return false;

                classList = iesFile.Rows
                    .Where(row => row.ContainsKey(classNameColumn.Name) && string.Equals(row.GetString(classNameColumn.Name), className, StringComparison.OrdinalIgnoreCase))
                    .Select(row => row.GetString(classNameColumn.Name))
                    .ToArray();

                return true;
            }
        }

        /// <summary>
        /// Converts a given string to pascal case
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToPascalCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            string[] words = input.Split(new[] { ' ', '_' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                words[i] = textInfo.ToTitleCase(word.ToLower());
            }

            return string.Concat(words);
        }

        public static void Load()
        {
            // Read "map.ies"
            if (!TryGetClasses("map.ies", out var mapClsList))
                throw new Exception("Class list not found.");

            // Read "hidenpc.ies"
            if (!TryGetClasses("hidenpc.ies", out var hideNpcClsList))
                throw new Exception("Class list not found.");
            else
            {
                foreach (var hideCls in hideNpcClsList)
                {
                    var npcDialog = hideCls.GetString("ClassName");
                    var npcState = hideCls.GetInt("Default");
                    HideNPCEntries.Add(npcDialog, npcState);
                }
            }

            // Read "npcselectdialog.ies"
            if (!TryGetClasses("npcselectdialog.ies", out var dialogClsList))
                throw new Exception("Class list not found.");
            else
            {
                foreach (var dialogCls in dialogClsList)
                {
                    var dialogData = new MonsterDialogData();
                    dialogData.ClassName = dialogCls.GetString("ClassName");
                    dialogData.CMM_Name = dialogCls.GetString("CMM_Name");
                    dialogData.SelectDialog = dialogCls.GetString("SelectDialog");
                    dialogData.IdleDialog = dialogCls.GetString("IdleDialog");
                    DialogEntries.Add(dialogData.ClassName, dialogData);
                }
            }

            // Iterate over map.ies
            foreach (var mapCls in mapClsList)
            {
                // Adds map entry
                MapData m = new MapData();
                Dictionary<int, int> usedGenTypes = new Dictionary<int, int>(); // Associates a gentype to a arbitrary counter
                int usedGenTypesCounter = 1;
                m.ClassName = mapCls.GetString("ClassName");
                m.MapType = mapCls.GetString("MapType");
                MapEntries.Add(m);

                // Read maps anchor file
                if (!TryGetClasses("Anchor_" + mapCls.GetString("ClassName") + ".ies", out var anchorClsList))
                {
                    Trace.TraceWarning("Anchor file not found for map: {0}", mapCls.GetString("ClassName"));
                    continue;
                }

                // Read maps gentype
                if (!TryGetClasses("GenType_" + mapCls.GetString("ClassName") + ".ies", out var genTypeClsList))
                    throw new Exception("Class list not found.");

                // Read maps monster status file
                if (!TryGetClasses("field_monster_status_" + mapCls.GetString("ClassName") + ".ies", out var monsterStatClsList))
                    Trace.TraceWarning("MobStat file not found for map: {0}", mapCls.GetString("ClassName"));

                // Iterate over anchor
                foreach (var anchorCls in anchorClsList)
                {
                    var genType = anchorCls.GetInt("GenType");
                    var genTypeCls = genTypeClsList.FirstOrDefault(a => a.GetInt("GenType") == genType);

                    if (genTypeCls == null)
                    {
                        Trace.TraceWarning("GenType {0} not found for map: {1}", genType, mapCls.GetString("ClassName"));
                        continue;
                    }

                    if (genTypeCls.GetString("ClassType") == "Warp_arrow")
                    {
                        var warpName = genTypeCls.GetString("Dialog");
                        if (string.IsNullOrWhiteSpace(warpName))
                            warpName = genTypeCls.GetString("Enter");

                        if (!TryGetClassByName("warp.ies", warpName, out var warpCls))
                        {
                            var secWarpName = warpName;

                            if (secWarpName.StartsWith("WS_"))
                                secWarpName = secWarpName.Substring(3);

                            if (TryGetClassByName("warp.ies", secWarpName, out warpCls))
                            {
                                continue;
                            }
                            else
                            {
                                Trace.TraceWarning("Warp not found: {0}", warpName);
                            }
                        }
                    }

                    var data = new MonsterSpawnData();

                    data.Name = genTypeCls.GetString("Name");
                    if (data.Name == "UnvisibleName")
                        data.Name = " ";
                    data.ClassName = genTypeCls.GetString("ClassType");
                    data.Direction = anchorCls.GetInt("Direction") + 90;
                    data.Map = mapCls.GetString("ClassName");
                    data.X = anchorCls.GetFloat("PosX");
                    data.Y = anchorCls.GetFloat("PosY");
                    data.Z = anchorCls.GetFloat("PosZ");
                    data.Dialog = genTypeCls.GetString("Dialog");
                    if (data.Dialog.StartsWith("3CM"))
                    {
                        data.Dialog = data.Dialog.Replace("3CMLAKE", "THREECMLAKE");
                    }
                    data.Enter = genTypeCls.GetString("Enter");
                    if (data.Enter.StartsWith("3CM"))
                    {
                        data.Enter = data.Enter.Replace("3CMLAKE", "THREECMLAKE");
                    }
                    data.Leave = genTypeCls.GetString("Leave");
                    if (data.Leave.StartsWith("3CM"))
                    {
                        data.Leave = data.Dialog.Replace("3CMLAKE", "THREECMLAKE");
                    }
                    data.Range = genTypeCls.GetFloat("Range");
                    data.MaxPop = genTypeCls.GetInt("MaxPop");
                    data.GenRange = genTypeCls.GetInt("GenRange");
                    if (data.GenRange <= 5)
                    { 
                        data.GenRange = 20;
                    }
                    else if (mapCls.GetString("ClassName").Equals("f_siauliai_2") && data.ClassName.Equals("Rootcrystal_01", StringComparison.OrdinalIgnoreCase))
                    {
                        data.GenRange = 100;
                    }
                    data.RespawnTime = genTypeCls.GetInt("RespawnTime");
                    data.ArgStr1 = genTypeCls.GetString("ArgStr1");
                    data.ArgStr2 = genTypeCls.GetString("ArgStr2");
                    data.ArgStr3 = genTypeCls.GetString("ArgStr3");

                    data.Faction = genTypeCls.GetString("Faction");
                    if (data.Faction == "Nuetral")
                        data.Faction = "Neutral";
                    if (data.ClassName.Equals("hiddentrigger2", StringComparison.OrdinalIgnoreCase))
                        data.Faction = "Neutral";

                    data.Tendency = genTypeCls.GetString("Tendency");


                    // Exceptions
                    if (data.ClassName.Equals("Pokubu", StringComparison.OrdinalIgnoreCase) && anchorCls.GetInt("ClassID") == 127)
                    {
                         continue;
                    }
                    else if (data.ClassName.Equals("TransmutationMerchant", StringComparison.OrdinalIgnoreCase) && anchorCls.GetInt("ClassID") == 1128)
                    {
                        continue;
                    }
                    else if (data.ClassName.Equals("Rambear_Brown", StringComparison.OrdinalIgnoreCase) && anchorCls.GetInt("ClassID") == 389)
                    {
                        continue;
                    }

                    // Builds population name string for monster types
                    if (data.Faction == "Monster" || data.Faction == "RootCrystal")
                    {
                        if (!usedGenTypes.Keys.Contains(genTypeCls.GetInt("GenType")))
                        {
                            usedGenTypes.Add(genTypeCls.GetInt("GenType"), usedGenTypesCounter);
                            usedGenTypesCounter++;
                        }
                        data.PopulationCustomName = "population_" + genTypeCls.GetString("ClassType").ToLower() + "_" + usedGenTypes[genTypeCls.GetInt("GenType")].ToString();
                    }
                    
                    if (!string.IsNullOrWhiteSpace(data.Dialog))
                    {
                        if (HideNPCEntries.TryGetValue(data.Dialog, out var hideNpcEntry))
                            data.HideNPC = hideNpcEntry;
                    }

                    if (!string.IsNullOrWhiteSpace(data.Enter) && !FunctionEntries.ContainsKey(data.Enter))
                    {
                        FunctionEntries.Add(data.Enter, data.Enter);
                    }
                    if (!string.IsNullOrWhiteSpace(data.Leave) && !FunctionEntries.ContainsKey(data.Leave))
                    {
                        FunctionEntries.Add(data.Leave, data.Leave);
                    }

                    if (!string.IsNullOrWhiteSpace(data.Enter) && data.Enter.Trim().Contains("STOUP_CAMP"))
                    {
                        var sb = new StringBuilder();
                        sb = new StringBuilder();
                        sb.AppendFormat("\t\t[DialogFunction(\"{0}\")]\n", data.Dialog);
                        sb.AppendFormat("\t\tpublic static async Task STOUP_CAMP_{0}(Dialog dialog)\n", data.Dialog);
                        sb.AppendFormat("\t\t\t=> await STOUP_CAMP(dialog, PropertyName.{0});", data.Dialog);
                        MeliaWarpEntries.Add(data.Dialog, sb.ToString());
                    }

                    if (monsterStatClsList != null)
                    {
                        bool monsterHasStat = monsterStatClsList.Any(a => a.GetString("ClassName") == genTypeCls.GetString("ClassType"));

                        if (monsterHasStat)
                        {
                            var monStatCls = monsterStatClsList.FirstOrDefault(a => a.GetString("ClassName") == genTypeCls.GetString("ClassType"));

                            MonsterStat ms = new MonsterStat();
                            ms.ClassID = monStatCls.GetInt("ClassID");
                            ms.MHP = monStatCls.GetInt("MHP");
                            ms.DEF = monStatCls.GetInt("DEF");
                            ms.MDEF = monStatCls.GetInt("MDEF");
                            ms.MINPATK = monStatCls.GetInt("MINPATK");
                            ms.MAXPATK = monStatCls.GetInt("MAXPATK");
                            ms.MINMATK = monStatCls.GetInt("MINMATK");
                            ms.MAXMATK = monStatCls.GetInt("MAXMATK");

                            data.MonsterStat = ms;
                        }
                    }
                    
                    if (!Entries.TryGetValue(mapCls.GetString("ClassName"), out var dataList))
                        Entries[mapCls.GetString("ClassName")] = dataList = new List<MonsterSpawnData>();

                    dataList.Add(data);
                }
            }
        }

        public static void ExportMeliaWarpTriggersCSharp(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            var triggerCsFile = Path.Combine(folderPath, "WarpTriggers.cs");
            using (var fs = new FileStream(triggerCsFile, FileMode.Create))
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine("using System.Threading.Tasks;");
                sw.WriteLine("using Melia.Zone.Scripting.Dialogues;");
                sw.WriteLine("using static Melia.Zone.Scripting.Shortcuts;");
                sw.WriteLine();
                sw.WriteLine("namespace Melia.Zone.Scripting.Shared");
                sw.WriteLine("{");
                sw.WriteLine("\tpublic static class Triggers");
                sw.WriteLine("\t{");
                var ordered = MeliaWarpEntries.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                foreach (var entry in ordered.Values)
                {
                    if (!string.IsNullOrWhiteSpace(entry))
                    {
                        sw.WriteLine("{0}", entry);
                        sw.WriteLine();
                    }
                }
                sw.WriteLine("\t}");
                sw.WriteLine("}");
            }
        }

        public static void ExportTriggersCSharpMelia(string folderPath)
        {
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            var triggerCsFile = Path.Combine(folderPath, "Triggers.cs");
            using (var fs = new FileStream(triggerCsFile, FileMode.Create))
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine("using System.Threading.Tasks;");
                sw.WriteLine("using Melia.Zone.Scripting.Dialogues;");
                sw.WriteLine("using static Melia.Zone.Scripting.Shortcuts;");
                sw.WriteLine();
                sw.WriteLine("namespace Melia.Zone.Scripting.Shared");
                sw.WriteLine("{");
                sw.WriteLine("\tpublic static class Triggers");
                sw.WriteLine("\t{");
                var ordered = FunctionEntries.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                foreach (var entry in ordered.Values)
                {
                    if (!string.IsNullOrWhiteSpace(entry))
                    {
                        sw.WriteLine("\t\t[DialogFunction(\"{0}\")]", entry);
                        sw.WriteLine("\t\tpublic static async Task {0}(Dialog dialog)", entry);
                        sw.WriteLine("\t\t{");
                        if (entry.StartsWith("TUTO_") && entry.EndsWith("_NPC"))
                        {
                            sw.WriteLine("\t\t\tdialog.ShowHelp({0});", entry.Replace("_NPC", ""));
                        }
                        else
                            sw.WriteLine("\t\t\tawait Task.Yield();");
                        sw.WriteLine("\t\t}");
                        sw.WriteLine();
                    }
                }

                sw.WriteLine("\t}");
                sw.WriteLine("}");
            }
        }

        public static void AddMeliaMobSpawners(StreamWriter sb, string className, string mapName, string mobs)
        {
            var customMapName = ToPascalCase(className);
            sb.WriteLine("//--- Melia Script -----------------------------------------------------------");
            sb.WriteLine("// " + mapName);
            sb.WriteLine("//");
            sb.WriteLine("//--- Description -----------------------------------------------------------");
            sb.WriteLine("// Sets up the " + mapName + " mobs.");
            sb.WriteLine("//---------------------------------------------------------------------------");
            sb.WriteLine();
            sb.WriteLine("using System;");
            sb.WriteLine("using Melia.Zone.Scripting;");
            sb.WriteLine("using static Melia.Zone.Scripting.Shortcuts;");
            sb.WriteLine();
            sb.WriteLine("public class " + customMapName + "MobScript : GeneralScript");
            sb.WriteLine("{");
            sb.WriteLine("\tpublic override void Load()");
            sb.WriteLine("\t{");
            sb.WriteLine(mobs);
            sb.WriteLine("\t}");
            sb.WriteLine("}");
        }

        public static void AddMeliaNPCScript(StreamWriter sb, string npcName, string npcDescription, string mapName,
            int npcModelId, float x, float y, float z, float direction, string npcFunc, bool printHeader = false, bool addConstUsing = false)
        {
            /**
			 AddNpc(20111, "[Equipment Merchant] Dunkel", "c_Klaipe", 394, -475, 90.0, async dialog =>
			{
				dialog.SetTitle("Dunkel");
				dialog.SetPortrait("KLAPEDA_Akalabeth_basic28");
				var response = await dialog.Select("A lot of people seem to be coming thanks to Sir Uska's recruitment notice.{nl}Take a look around at your own pace without feeling anxious.",
					Option("Weapons", "weapon"),
					Option("Armor", "armor"),
					Option("Cancel", "cancel")
				);
				if (response == "weapon")
					await dialog.OpenShop("Klapeda_Weapon");
				else if (response == "armor")
					await dialog.OpenShop("Klapeda_Armor");
			});
			**/
            var map = MapEntries.Find(m => m.ClassName == mapName);
            if (map == null)
            {
                Trace.TraceInformation("AddMeliaNPCScript: generation failed for {0} on map {1}.", npcName, mapName);
                return;
            }
            var customMapName = ToPascalCase(map.ClassName);
            if (printHeader)
            {
                sb.WriteLine("//--- Melia Script ----------------------------------------------------------");
                sb.WriteLine("// " + customMapName);
                sb.WriteLine("//--- Description -----------------------------------------------------------");
                sb.WriteLine("// NPCs found in and around " + customMapName + ".");
                sb.WriteLine("//---------------------------------------------------------------------------");
                sb.WriteLine();
                sb.WriteLine("using Melia.Shared.Tos.Const;");
                sb.WriteLine("using Melia.Zone.Scripting;");
                sb.WriteLine("using static Melia.Zone.Scripting.Shortcuts;");
                sb.WriteLine();
                sb.WriteLine("public class " + customMapName + "NpcScript : GeneralScript");
                sb.WriteLine("{");
                sb.WriteLine("\tpublic override void Load()");
                sb.WriteLine("\t{");

            }
            sb.WriteLine("\t\t// " + npcDescription);
            sb.WriteLine("\t\t//-------------------------------------------------------------------------");
            sb.WriteLine("");
            sb.WriteLine(string.Format("\t\tAddNpc({0}, \"{1}\", \"{2}\", {3}, {4}, {5}, async dialog =>", npcModelId, npcName, map.ClassName, x, z, direction));
            sb.WriteLine("\t\t{");
            sb.Write(npcFunc);
            sb.WriteLine("\t\t});");
            sb.WriteLine("\t\t");
        }

        public static void AddMeliaNPCScriptV2(StreamWriter sb, string npcName, string npcDescription, string mapName,
            int npcModelId, float x, float y, float z, float direction, string dialog, string enter, string leave, bool printHeader = false, bool addConstUsing = false)
        {
            /**
			 AddNpc(20111, "[Equipment Merchant] Dunkel", "c_Klaipe", 394, -475, 90.0, async dialog =>
			{
				dialog.SetTitle("Dunkel");
				dialog.SetPortrait("KLAPEDA_Akalabeth_basic28");
				var response = await dialog.Select("A lot of people seem to be coming thanks to Sir Uska's recruitment notice.{nl}Take a look around at your own pace without feeling anxious.",
					Option("Weapons", "weapon"),
					Option("Armor", "armor"),
					Option("Cancel", "cancel")
				);
				if (response == "weapon")
					await dialog.OpenShop("Klapeda_Weapon");
				else if (response == "armor")
					await dialog.OpenShop("Klapeda_Armor");
			});
			**/
            var map = MapEntries.Find(m => m.ClassName == mapName);
            if (map == null)
            {
                Trace.TraceInformation("AddMeliaNPCScript: generation failed for {0} on map {1}.", npcName, mapName);
                return;
            }
            var customMapName = ToPascalCase(map.ClassName);
            if (printHeader)
            {
                sb.WriteLine("//--- Melia Script ----------------------------------------------------------");
                sb.WriteLine("// " + customMapName);
                sb.WriteLine("//--- Description -----------------------------------------------------------");
                sb.WriteLine("// NPCs found in and around " + customMapName + ".");
                sb.WriteLine("//---------------------------------------------------------------------------");
                sb.WriteLine();
                sb.WriteLine("using Melia.Shared.Tos.Const;");
                sb.WriteLine("using Melia.Zone.Scripting;");
                sb.WriteLine("using static Melia.Zone.Scripting.Shortcuts;");
                sb.WriteLine();
                sb.WriteLine("public class " + customMapName + "NpcScript : GeneralScript");
                sb.WriteLine("{");
                sb.WriteLine("\tpublic override void Load()");
                sb.WriteLine("\t{");

            }
            sb.WriteLine("\t\t// " + npcDescription);
            sb.WriteLine("\t\t//-------------------------------------------------------------------------");
            sb.WriteLine("");
            if (!string.IsNullOrEmpty(leave) && !string.IsNullOrEmpty(enter) && !string.IsNullOrEmpty(dialog))
                sb.WriteLine(string.Format("\t\tAddNpc({0}, \"{1}\", \"{2}\", {3}, {4}, {5}, \"{6}\", \"{7}\", \"{8}\");", npcModelId, npcName, map.ClassName, x, z, direction, dialog, enter, leave));
            else if (!string.IsNullOrEmpty(enter) && !string.IsNullOrEmpty(dialog))
                sb.WriteLine(string.Format("\t\tAddNpc({0}, \"{1}\", \"{2}\", {3}, {4}, {5}, \"{6}\", \"{7}\");", npcModelId, npcName, map.ClassName, x, z, direction, dialog, enter));
            else if (string.IsNullOrEmpty(enter) && string.IsNullOrEmpty(leave) && !string.IsNullOrEmpty(dialog))
                sb.WriteLine(string.Format("\t\tAddNpc({0}, \"{1}\", \"{2}\", {3}, {4}, {5}, \"{6}\");", npcModelId, npcName, map.ClassName, x, z, direction, dialog));
            else if (!string.IsNullOrEmpty(dialog))
                sb.WriteLine(string.Format("\t\tAddNpc({0}, \"{1}\", \"{2}\", {3}, {4}, {5}, \"{6}\");", npcModelId, npcName, map.ClassName, x, z, direction, dialog));
            else if (!string.IsNullOrEmpty(leave) || !string.IsNullOrEmpty(enter) || !string.IsNullOrEmpty(dialog))
            {
                Trace.TraceInformation("Missing case: Dialog: {0} Enter: {1} Leave {2}", dialog, enter, leave);
                sb.WriteLine(string.Format("\t\tAddNpc({0}, \"{1}\", \"{2}\", {3}, {4}, {5});", npcModelId, npcName, map.ClassName, x, z, direction));
            }
            sb.WriteLine("\t\t");
        }
    }
}