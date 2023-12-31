//--- Melia Script -----------------------------------------------------------
// f_3cmlake_26_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Lanko 26 Waters' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake261MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_3cmlake_26_1", MonsterId.KindronWielder, Properties("MHP", 601007, "MINPATK", 8229, "MAXPATK", 10016, "MINMATK", 8229, "MAXMATK", 10016, "DEF", 128412, "MDEF", 128412));
		AddPropertyOverrides("f_3cmlake_26_1", MonsterId.KindronLilter, Properties("MHP", 601985, "MINPATK", 8242, "MAXPATK", 10031, "MINMATK", 8242, "MAXMATK", 10031, "DEF", 128998, "MDEF", 128998));
		AddPropertyOverrides("f_3cmlake_26_1", MonsterId.Ravisher_Mage, Properties("MHP", 603019, "MINPATK", 8255, "MAXPATK", 10048, "MINMATK", 8255, "MAXMATK", 10048, "DEF", 129617, "MDEF", 129617));
		AddPropertyOverrides("f_3cmlake_26_1", MonsterId.Ravisher, Properties("MHP", 604106, "MINPATK", 8269, "MAXPATK", 10065, "MINMATK", 8269, "MAXMATK", 10065, "DEF", 130268, "MDEF", 130268));

		// Monster Spawners ---------------------------------

		AddSpawner("f_3cmlake_26_1.Id1", MonsterId.RootCrystal_A, 12, 16, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_1.Id2", MonsterId.KindronWielder, 51, 67, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_1.Id3", MonsterId.KindronLilter, 20, 26, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_1.Id4", MonsterId.Ravisher_Mage, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_1.Id5", MonsterId.Ravisher, 15, 19, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'RootCrystal_A' GenType 51 Spawn Points
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-156.26907, 1189.6903, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-734.2925, 911.6563, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-1669.18, 1148.9933, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(838.7262, 712.195, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(1059.4806, 1272.1598, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(906.9091, -895.2809, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(1028.4988, -1268.1965, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(1616.2148, -1199.5873, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(539.72644, -1186.0118, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(142.17184, -1701.9231, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(81.711296, -1357.8457, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(139.75882, -2088.8022, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-143.67172, 853.18164, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(1615.1665, 602.13257, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-567.0429, -1256.8286, 40));
		AddSpawnPoint("f_3cmlake_26_1.Id1", "f_3cmlake_26_1", Rectangle(-874.7147, -1271.6384, 40));

		// 'KindronWielder' GenType 55 Spawn Points
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-961.9755, 1012.5627, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-1237.464, 862.2638, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-908.5628, 850.74524, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-475.62195, 919.4004, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-1394.6147, 929.33167, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-1165.6243, 1053.4299, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-76.20791, 1080.1997, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-289.06314, 826.0559, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(40.26735, 718.1696, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(175.33145, 1008.217, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(249.68967, 830.2419, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-304.16125, 658.2361, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(538.0899, 825.7436, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(709.37604, 699.04346, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(861.798, 561.45496, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(971.8153, 679.7205, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(923.8878, 836.6309, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(1157.7904, 788.63525, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(911.6097, 1036.5138, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(992.0176, -853.5421, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(466.915, -1190.4219, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(1354.3439, -1213.2195, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-733.24347, -1273.6155, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-775.8066, -1086.2449, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-812.71716, -1438.2162, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-990.5787, -1271.9799, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-350.32816, -1231.9457, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(104.34451, -1594.1543, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(348.66315, -1902.8529, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-81.27721, -2015.3928, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(205.54654, -1885.0668, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-598.61383, -1333.6572, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(270.70535, -1372.9586, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-77.598656, -1291.2692, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(941.7868, -725.1522, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-100.01539, 549.3339, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(111.59851, -2005.0988, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-1063.9161, 803.06146, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-1250.383, 981.12415, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-690.0657, 891.0736, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(92.77948, 834.32227, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-240.27237, 1093.0747, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(149.93686, 607.3864, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(388.70908, 842.41095, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(742.28577, 595.5359, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(1014.2376, 735.6523, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(764.5495, 857.1508, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(628.52423, -1160.1239, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-570.85205, -1178.9655, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-597.4594, -1435.2357, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-938.0709, -1103.0919, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-49.973785, -1453.3489, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(298.03497, -2176.543, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(143.69843, -2229.7048, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(-112.47919, -1844.4508, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(279.6277, -1760.4161, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id2", "f_3cmlake_26_1", Rectangle(56.73631, -2076.7024, 20));

		// 'KindronLilter' GenType 56 Spawn Points
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-1831.052, 821.6871, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-1829.4432, 1050.6437, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-1593.7202, 1054.1531, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-1596.1556, 817.1953, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-239.12675, 989.3192, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-138.78317, 702.52374, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(43.67221, 1033.9037, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(260.6305, 714.938, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(842.165, 1361.6505, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1065.894, 1358.2339, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(950.6965, 1637.9846, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1073.2521, 597.8848, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1067.813, 878.48785, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(672.8055, 861.3029, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-856.5081, -1152.9431, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-939.5977, -1422.5242, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-674.2597, -1420.2076, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-676.6315, -1153.3602, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(18.103596, -2152.8445, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(299.55502, -2064.2686, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(11.440554, -1864.8461, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(-1113.1775, 950.4528, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(874.2141, -1238.8989, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1126.6758, -1243.595, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1942.695, -1144.704, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id3", "f_3cmlake_26_1", Rectangle(1742.2158, -1213.7802, 20));

		// 'Ravisher_Mage' GenType 57 Spawn Points
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1092.3376, -1334.0112, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1054.422, -1035.2847, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(810.48114, -1293.3373, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(796.89124, -1077.3907, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1183.7614, -1275.5713, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1848.7264, -1048.8702, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1931.9938, -1228.1737, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1644.7356, -1333.1301, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1635.6503, -1057.8547, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1467.2023, -1151.1665, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(646.94763, -1219.9542, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1779.4504, -1153.937, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(2022.2797, -1317.3317, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id4", "f_3cmlake_26_1", Rectangle(1237.9158, -1038.8408, 20));

		// 'Ravisher' GenType 58 Spawn Points
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(938.33685, 1308.5878, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(780.7998, 1477.8749, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(1089.4941, 1463.701, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(1060.5906, 1597.0411, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(826.0703, 1596.4474, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(891.0668, 1458.7526, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(777.4218, -1178.7194, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(1185.9237, -1150.8003, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(874.97406, -980.8145, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(929.94855, -1366.8975, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-1730.1061, 1097.174, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-1564.8234, 928.9561, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-1733.072, 752.00916, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-1884.5184, 938.4361, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-1677.9954, 934.3677, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(771.0555, -1350.5437, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(1047.4464, -930.7104, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(1017.6053, 1483.4349, 20));
		AddSpawnPoint("f_3cmlake_26_1.Id5", "f_3cmlake_26_1", Rectangle(-2018.6036, 939.25653, 20));
	}
}
