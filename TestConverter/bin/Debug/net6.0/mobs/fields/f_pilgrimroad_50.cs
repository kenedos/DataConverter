//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_50
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Altar Way' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad50MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_pilgrimroad_50", MonsterId.Kodomor, Properties("MHP", 129828, "MINPATK", 2171, "MAXPATK", 2570, "MINMATK", 2171, "MAXMATK", 2570, "DEF", 2270, "MDEF", 2270));
		AddPropertyOverrides("f_pilgrimroad_50", MonsterId.Romor, Properties("MHP", 130890, "MINPATK", 2184, "MAXPATK", 2586, "MINMATK", 2184, "MAXMATK", 2586, "DEF", 2331, "MDEF", 2331));
		AddPropertyOverrides("f_pilgrimroad_50", MonsterId.Lapasape_Bow, Properties("MHP", 132020, "MINPATK", 2199, "MAXPATK", 2604, "MINMATK", 2199, "MAXMATK", 2604, "DEF", 2396, "MDEF", 2396));
		AddPropertyOverrides("f_pilgrimroad_50", MonsterId.Siaulav_Mage, Properties("MHP", 133215, "MINPATK", 2214, "MAXPATK", 2623, "MINMATK", 2214, "MAXMATK", 2623, "DEF", 2465, "MDEF", 2465));

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_50.Id1", MonsterId.Kodomor, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_50.Id2", MonsterId.Romor, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_50.Id3", MonsterId.Rootcrystal_01, 6, 8, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_50.Id4", MonsterId.Lapasape_Bow, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_50.Id5", MonsterId.Siaulav_Mage, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Kodomor' GenType 8 Spawn Points
		AddSpawnPoint("f_pilgrimroad_50.Id1", "f_pilgrimroad_50", Rectangle(-564.25, -49.79, 9999));

		// 'Romor' GenType 9 Spawn Points
		AddSpawnPoint("f_pilgrimroad_50.Id2", "f_pilgrimroad_50", Rectangle(71.80345, -276.67358, 9999));

		// 'Rootcrystal_01' GenType 13 Spawn Points
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(-1447.08, -1027.91, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(-1177.19, 55.06, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(-511.82, 386.87, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(156.11, 1121.14, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(-490.17, -111, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(427.36, 236.09, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(1086.5111, -779.4527, 30));
		AddSpawnPoint("f_pilgrimroad_50.Id3", "f_pilgrimroad_50", Rectangle(2058.69, -929.81, 30));

		// 'Lapasape_Bow' GenType 35 Spawn Points
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(-623.8253, 508.86005, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(-723.4815, 791.40564, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(136.92972, 1110.2388, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(244.92505, 1437.6438, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(844.5469, 1683.3661, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(45.59518, 1415.1426, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(-508.00668, 770.4643, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(-820.1994, 1041.7272, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(444.06808, 1189.1832, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(1028.6655, 1009.8408, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(590.53406, 1666.9731, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(860.517, -793.923, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(1123.406, -508.25772, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(2209.626, -858.3371, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(1067.4619, -737.4142, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(2076.5369, -1159.8933, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id4", "f_pilgrimroad_50", Rectangle(1904.2487, -965.01666, 40));

		// 'Siaulav_Mage' GenType 36 Spawn Points
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(549.04175, 449.30536, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(497.32196, 13.07795, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(715.5898, -27.714928, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(1021.6694, 696.1128, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(710.5813, 238.09367, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(805.5497, 477.0374, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(1009.0795, 452.77258, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(427.17584, 215.43683, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(58.10875, 1450.4271, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(134.23503, 1069.0028, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(986.56287, 1128.269, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(364.32733, 1443.7363, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(1261.9366, -791.8169, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(947.4216, -557.44867, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(2276.0015, -1081.8774, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(2102.2537, -1019.2909, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(2054.2927, -843.5032, 40));
		AddSpawnPoint("f_pilgrimroad_50.Id5", "f_pilgrimroad_50", Rectangle(1023.4756, -910.4776, 40));
	}
}
