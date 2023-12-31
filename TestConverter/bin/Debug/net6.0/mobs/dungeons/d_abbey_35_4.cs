//--- Melia Script -----------------------------------------------------------
// d_abbey_35_4
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Elgos Monastery Main Building' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DAbbey354MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_abbey_35_4", MonsterId.Hohen_Mane_Brown, Properties("MHP", 371614, "MINPATK", 5279, "MAXPATK", 6391, "MINMATK", 5279, "MAXMATK", 6391, "DEF", 37135, "MDEF", 37135));
		AddPropertyOverrides("d_abbey_35_4", MonsterId.Hohen_Orben_Green, Properties("MHP", 377974, "MINPATK", 5361, "MAXPATK", 6491, "MINMATK", 5361, "MAXMATK", 6491, "DEF", 38706, "MDEF", 38706));
		AddPropertyOverrides("d_abbey_35_4", MonsterId.Harugal_Brown, Properties("MHP", 384630, "MINPATK", 5447, "MAXPATK", 6596, "MINMATK", 5447, "MAXMATK", 6596, "DEF", 40351, "MDEF", 40351));
		AddPropertyOverrides("d_abbey_35_4", MonsterId.Boss_Glutton_Q1, Properties("MHP", 3269610, "MINPATK", 17438, "MAXPATK", 21124, "MINMATK", 17438, "MAXMATK", 21124, "DEF", 132505, "MDEF", 132505));

		// Monster Spawners ---------------------------------

		AddSpawner("d_abbey_35_4.Id1", MonsterId.Hohen_Mane_Brown, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_4.Id2", MonsterId.Hohen_Orben_Green, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_4.Id3", MonsterId.Harugal_Brown, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_4.Id4", MonsterId.Hohen_Mane_Brown, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_abbey_35_4.Id5", MonsterId.Rootcrystal_01, 14, 18, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Hohen_Mane_Brown' GenType 2 Spawn Points
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-28.308714, -376.1368, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(70.396095, -495.8914, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(175.80211, -442.97388, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(151.58818, -281.6361, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(36.67926, -262.0204, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-47.370716, -141.1928, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(143.56631, -41.89409, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(462.66797, 189.13794, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(358.65652, -140.91792, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-88.37451, 219.42871, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(150.80202, 256.83438, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-64.653786, -435.18918, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-67.872696, -218.52644, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(454.99866, 55.53602, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(439.258, 268.0286, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(588.44727, 103.93492, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(647.2065, 202.74184, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(604.3429, -399.38583, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(715.91956, -331.0419, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(804.19507, -506.15158, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(961.2816, -665.1087, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1019.6812, -606.70935, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1683.0997, -833.5048, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1654.4153, -1232.5414, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1601.6123, -1011.6166, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1519.3419, -1198.0504, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1553.7965, -778.6572, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1670.2183, -995.8355, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1244.491, -836.97284, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1382.9568, -1281.7113, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1463.8064, -1144.1155, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1637.4215, -1118.6432, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1691.604, -1272.5768, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1541.9828, -892.8205, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1739.4507, -915.1775, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(1085.4808, -1165.0887, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(795.2924, -1292.2765, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(848.181, -1111.3849, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(947.9208, -1294.8925, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(908.5888, -1109.387, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(773.6997, -1117.9258, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-68.99524, 32.14322, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(199.31381, 224.80191, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-4.442848, 348.8085, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(139.83585, 401.96945, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(-30.216202, 548.3407, 30));
		AddSpawnPoint("d_abbey_35_4.Id1", "d_abbey_35_4", Rectangle(129.09161, 500.49252, 30));

		// 'Hohen_Orben_Green' GenType 3 Spawn Points
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-1437.381, 760.38275, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-1174.8201, 781.8458, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-1347.2057, -390.7002, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-1321.6442, -652.8311, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-489.4588, 641.1586, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-543.50104, -331.4868, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(70.903625, 588.08093, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(486.73813, 131.46509, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(48.932106, -291.45096, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(54.464985, 1001.5483, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(664.70306, 140.66464, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(593.92426, -317.11847, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1643.0741, -890.0589, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1590.5717, -1179.6503, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(807.7962, -459.20166, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1107.4309, -710.6255, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1519.5125, -896.9102, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1699.9639, -1101.0924, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1413.7928, -1228.0664, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1668.6104, -1307.6947, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-338.8353, 190.43275, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-52.03673, 287.99713, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(274.24893, 110.19647, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(-595.1862, 152.65012, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(283.61108, -61.56775, 30));
		AddSpawnPoint("d_abbey_35_4.Id2", "d_abbey_35_4", Rectangle(1752.8108, -858.76447, 30));

		// 'Harugal_Brown' GenType 4 Spawn Points
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(1549.3406, -936.21295, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(-504.00818, -358.14075, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(-508.78268, 644.5081, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(567.53815, 147.78967, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(63.68974, -320.6246, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(50.693604, 916.0093, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(42.22579, 555.3586, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(1787.1735, -1277.7782, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(1297.3401, -1255.256, 30));
		AddSpawnPoint("d_abbey_35_4.Id3", "d_abbey_35_4", Rectangle(48.314495, 276.77182, 30));

		// 'Hohen_Mane_Brown' GenType 5 Spawn Points
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(2.1008854, 721.291, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(164.24554, 569.1638, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-68.23035, 621.5417, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(47.778122, 655.88776, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-57.031322, 398.56158, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(108.48633, 348.2767, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(19.079948, 542.5355, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(157.69266, 702.9627, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-419.45953, 214.98495, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-452.17242, 85.81027, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-649.3436, 174.53386, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-496.86246, 424.89862, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-544.12256, 653.10034, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-450.74255, 533.48773, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-524.58954, -23.515347, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-558.9623, -296.15988, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-573.7627, -438.68945, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-419.57175, -354.86423, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-481.46698, -398.30142, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1369.1194, 619.8134, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1441.5555, 703.7624, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1375.4181, 867.80194, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1213.6829, 845.5819, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1186.45, 683.3021, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1372.423, -344.68335, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1473.8755, -471.63736, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1410.6442, -670.9582, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1242.3196, -646.68463, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1188.7936, -500.27954, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1156.2137, -360.76935, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1503.958, -383.43222, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1146.1886, 142.73882, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1192.126, 70.94912, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1139.4613, 26.766891, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-1079.5686, 131.50928, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-558.7927, 101.10207, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-440.1967, 685.648, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-56.59439, 153.71799, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-146.15823, 131.23453, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(-280.02338, 160.12456, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(201.50935, 101.08788, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(236.21016, 212.15843, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(272.5688, 80.39105, 30));
		AddSpawnPoint("d_abbey_35_4.Id4", "d_abbey_35_4", Rectangle(30.090977, -27.48633, 30));

		// 'Rootcrystal_01' GenType 13 Spawn Points
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1306.3746, 892.2633, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1316.3934, 590.5261, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1520.5056, 106.35666, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1229.5507, 123.16199, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1324.1102, -359.73257, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-1328.2767, -671.10376, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-501.35492, 611.4688, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-558.249, 130.36984, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-529.4545, -346.78476, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(-208.22298, 131.83253, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(355.67047, 123.12664, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(75.79805, -380.1925, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(62.054718, -125.95667, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(67.13857, 411.643, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(57.246258, 648.4966, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(68.76263, 1239.1742, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(652.40704, 132.57407, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(289.71317, -1193.4899, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(952.49695, -1247.5527, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1387.0853, -1256.0685, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1713.0156, -1248.5775, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1749.5775, -919.59314, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1453.4437, -898.65924, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1554.666, -855.4487, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(679.55505, -370.14996, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(869.1138, -544.4384, 100));
		AddSpawnPoint("d_abbey_35_4.Id5", "d_abbey_35_4", Rectangle(1114.6117, -740.3705, 100));
	}
}
