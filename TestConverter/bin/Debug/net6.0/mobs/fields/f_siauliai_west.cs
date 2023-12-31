//--- Melia Script -----------------------------------------------------------
// f_siauliai_west
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'West Siauliai Woods' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliaiWestMobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_siauliai_west", MonsterId.Leaf_Diving, Properties("MHP", 632, "MINPATK", 111, "MAXPATK", 119, "MINMATK", 111, "MAXMATK", 119, "DEF", 10, "MDEF", 10));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Onion, Properties("MHP", 660, "MINPATK", 112, "MAXPATK", 120, "MINMATK", 112, "MAXMATK", 120, "DEF", 10, "MDEF", 10));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Hanaming, Properties("MHP", 722, "MINPATK", 115, "MAXPATK", 123, "MINMATK", 115, "MAXMATK", 123, "DEF", 10, "MDEF", 10));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Bokchoy, Properties("MHP", 810, "MINPATK", 119, "MAXPATK", 128, "MINMATK", 119, "MAXMATK", 128, "DEF", 11, "MDEF", 11));
		AddPropertyOverrides("f_siauliai_west", MonsterId.InfroRocktor, Properties("MHP", 923, "MINPATK", 124, "MAXPATK", 133, "MINMATK", 124, "MAXMATK", 133, "DEF", 11, "MDEF", 11));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Mushcarfung_Summon, Properties("MHP", 1057, "MINPATK", 130, "MAXPATK", 140, "MINMATK", 130, "MAXMATK", 140, "DEF", 12, "MDEF", 12));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Boss_Mushcaria, Properties("MHP", 5451, "MINPATK", 247, "MAXPATK", 266, "MINMATK", 247, "MAXMATK", 266, "DEF", 23, "MDEF", 23));
		AddPropertyOverrides("f_siauliai_west", MonsterId.Onion_Big, Properties("MHP", 1385, "MINPATK", 145, "MAXPATK", 156, "MINMATK", 145, "MAXMATK", 156, "DEF", 14, "MDEF", 14));

		// Monster Spawners ---------------------------------

		AddSpawner("f_siauliai_west.Id1", MonsterId.Leaf_Diving, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_west.Id2", MonsterId.Onion, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_west.Id3", MonsterId.Hanaming, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_west.Id4", MonsterId.Bokchoy, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_west.Id5", MonsterId.InfroRocktor, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_west.Id6", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_siauliai_west.Id7", MonsterId.Leaf_Diving, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_west.Id8", MonsterId.Onion, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_siauliai_west.Id9", MonsterId.Hanaming, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Leaf_Diving' GenType 13 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id1", "f_siauliai_west", Rectangle(-1603.15, -634.68, 80));
		AddSpawnPoint("f_siauliai_west.Id1", "f_siauliai_west", Rectangle(-1714.7524, -793.508, 80));
		AddSpawnPoint("f_siauliai_west.Id1", "f_siauliai_west", Rectangle(-1803.3267, -929.4419, 80));
		AddSpawnPoint("f_siauliai_west.Id1", "f_siauliai_west", Rectangle(-1026, 188, 80));
		AddSpawnPoint("f_siauliai_west.Id1", "f_siauliai_west", Rectangle(-1722.4156, -1102.7019, 80));

		// 'Onion' GenType 15 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1545.54, -1109.33, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1942.16, -1147.45, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1719.87, -765.17, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1977.31, -439.09, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1893.74, 58.53, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1681.28, -1208.48, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-2062.05, -1299.38, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1846.83, -994.09, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1934.44, -120.54, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1832.73, 282.38, 80));
		AddSpawnPoint("f_siauliai_west.Id2", "f_siauliai_west", Rectangle(-1812.4, -419.44, 80));

		// 'Hanaming' GenType 16 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-110.76, 489.29, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-225, 11, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-282.3, 396.72, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-238.77695, 158.16531, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(95.63397, 707.74457, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(175.14964, 317.86343, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(273.77383, 234.6051, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-56.41, -3.03, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-95.29, 668.32, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-204.94, 294.26, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-114.69363, 90.31695, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(-120.04311, 204.01993, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(26.070072, 541.89716, 40));
		AddSpawnPoint("f_siauliai_west.Id3", "f_siauliai_west", Rectangle(146.00055, 568.16766, 40));

		// 'Bokchoy' GenType 17 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(1259.76, 529.01, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(791.93, 531.71, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(664.91, 225.13, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(819.83, 269.73, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(591.93, -1.3, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(1384.75, 586.68, 100));
		AddSpawnPoint("f_siauliai_west.Id4", "f_siauliai_west", Rectangle(1079.73, 581.51, 100));

		// 'InfroRocktor' GenType 18 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(401.1112, -664.0809, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(721.9501, -1189.7433, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(303.38373, -1000.8208, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(535.5456, -1103.0784, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(532.48914, -832.1878, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(722.12, -979.13, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(349.93726, -805.65936, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(700.8045, -761.5143, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(445.07562, -978.70404, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(415.18753, -1181.1592, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(853.22394, -867.65826, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(275.24368, -673.52057, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(563.9787, -693.516, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(651.077, -894.8208, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(636.0251, -1056.4208, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(622.9086, -1180.351, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(416.22202, -1042.7969, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(132.84497, -963.0672, 30));
		AddSpawnPoint("f_siauliai_west.Id5", "f_siauliai_west", Rectangle(567.9872, -924.31006, 30));

		// 'Rootcrystal_01' GenType 30 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-2094, -397, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1903, -134, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-978, 291, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-902, 378, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-776, 696, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-280, 310, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-741, 1117, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-423, 1518, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-527, 406, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-571, 85, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-377, 51, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-193, -6, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-193, 415, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-8, 529, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(324, 248, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(99, 622, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1059, -517, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-2035, -977, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-2062, -1019, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-2002, -1318, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1698, -639, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1557, -1179, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1388, -1092, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1239, -765, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1437, -837, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(851, -120, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(639, -55, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(624, 128, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(922, 553, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1085, 620, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1356, 632, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1372, 419, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1506, 428, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1695, 276, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1465.34, -342.55, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1222, -496, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1289, -472, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1139, -745, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(958, -746, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(174, -960, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(377, -996, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(488, -1158, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(750.64, -1131.45, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1018, -943, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1205, -1040, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1434, -1049, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1876, -1031, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1960, -1265, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1622, -684, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1694, -791, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1331, -135, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1677, -399, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1850, -2, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1959, 95, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1823, 246, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-1827, -435, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-463, -17, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-686, 592, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-665, 753, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-575, 1189, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-630, 1297, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-121, 51, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-172, 172, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(-18, 648, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(193, 591, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(130, 285, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(725.19745, -798.011, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(474, -725, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(565, -921, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(899.47, -830.37, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1471, -675, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1230, -778, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1057, -829, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(766, -260, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(742, 141, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(734, 327, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(776, 579, 200));
		AddSpawnPoint("f_siauliai_west.Id6", "f_siauliai_west", Rectangle(1557, 258, 200));

		// 'Leaf_Diving' GenType 201 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id7", "f_siauliai_west", Rectangle(-1781.9281, -1018.5216, 450));

		// 'Onion' GenType 2022 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1177.66, -1054.04, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1001.69, -836.29, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1189.93, -723.68, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1319.06, -955.69, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1424.26, -1090.98, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1452.22, -730.84, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1565.16, -997.15, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1425.8, -848.94, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1251.56, -542.03, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(848.53, -889.72, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1220.48, -888.65, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(968.82, -746.32, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1040.098, -970.4837, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1584.1724, -726.68915, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1304.9529, -774.51385, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1366.5094, -355.94708, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1268.8126, -388.10223, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(1491.8073, -378.33514, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(740.5776, -779.10535, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(602.00836, -958.42303, 20));
		AddSpawnPoint("f_siauliai_west.Id8", "f_siauliai_west", Rectangle(621.4966, -1044.5498, 20));

		// 'Hanaming' GenType 2023 Spawn Points
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1236.1011, -920.07666, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1085.3743, -937.3985, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(789.39, -897.39, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(645.48456, -1092.2927, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(426.1242, -1013.5668, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1240.63, -638.18, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(941.2956, -831.4015, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(375.53973, -761.9308, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1350.451, -830.8346, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1320.4756, -907.94244, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1358.0465, -996.2719, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1421.4456, -1078.0254, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1507.1022, -1025.1508, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1462.4896, -914.4913, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1458.9062, -781.9322, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(1464.4084, -694.63, 20));
		AddSpawnPoint("f_siauliai_west.Id9", "f_siauliai_west", Rectangle(592.6201, -804.83813, 20));
	}
}
