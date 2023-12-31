//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_41_4
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Sekta Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad414MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_41_4.Id1", MonsterId.Rootcrystal_05, 12, 16, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_41_4.Id2", MonsterId.Dumaro_Yellow, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_41_4.Id3", MonsterId.Repusbunny_Purple, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_41_4.Id4", MonsterId.Repusbunny_Bow_Purple, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 4 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-112.05358, 1084.1703, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-53.323242, 846.5178, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(477.59863, 740.96765, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(698.33795, 799.1021, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(773.0139, 535.7144, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1086.0294, 258.50568, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1371.9065, 220.51082, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1322.5323, -110.78996, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(445.73907, -200.79645, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(297.37775, -386.05252, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-166.49828, -14.904353, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-924.91077, -640.7529, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-171.76573, -636.7371, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-263.76434, -969.13196, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(150.50572, -1397.5828, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(591.39343, -1666.8269, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(626.7366, -1338.2312, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1184.3988, -684.10565, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1458.9583, -941.8796, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1855.4382, -885.3633, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1870.167, -1153.3481, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(1785.0444, 10.213736, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(2052.8506, 84.25784, 50));
		AddSpawnPoint("f_pilgrimroad_41_4.Id1", "f_pilgrimroad_41_4", Rectangle(-519.82306, 24.289803, 50));

		// 'Dumaro_Yellow' GenType 100 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1052.4365, -779.7386, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(2007.8903, -1125.4325, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1741.226, -906.4549, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1724.6206, -1020.7698, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(2023.7552, -944.12177, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1904.0356, -1166.4486, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1523.3097, -51.616825, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(564.21704, 560.3476, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(752.23865, 507.89514, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(824.8999, 697.2115, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(778.5686, 849.84094, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(134.35905, -355.26425, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(302.8996, -484.85706, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(550.8471, -440.1494, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(650.444, -224.9163, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(356.80948, -349.60822, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(428.605, -92.03163, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(259.2221, -75.63308, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-77.37207, 1.943039, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-394.42657, 159.90157, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-473.7945, -78.56843, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-202.18654, -114.15067, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(89.69057, -289.28024, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-23.981098, -501.4115, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-247.34978, -580.2066, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(34.450527, -752.9646, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-505.88, -699.628, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(882.788, -55.08915, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1352.7201, -539.25775, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1463.7437, -790.85004, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1294.9088, -827.8017, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1001.7366, -651.08527, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1337.9316, -934.1106, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1075.3639, -960.7835, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1221.5311, -520.27673, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1584.9388, 75.5726, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1134.8031, -581.4246, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(1557.6482, -921.63153, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-1009.3554, -826.02673, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-989.2324, -617.13763, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-1203.6365, -592.0773, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-1023.9565, -341.79587, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-919.49817, -798.9566, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id2", "f_pilgrimroad_41_4", Rectangle(-902.55493, -503.1463, 25));

		// 'Repusbunny_Purple' GenType 101 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(401.7178, -82.0705, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-526.2083, 127.5114, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(167.51562, -234.48999, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-200.98196, -892.1591, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-381.95844, -757.0183, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1066.2524, -620.04346, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1375.7115, -757.2107, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1925.1702, -1223.2776, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1378.3218, -577.2332, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1386.2491, -1005.7612, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(743.2793, -1684.4994, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(629.00275, -1758.1115, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(544.7986, -1712.6278, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(358.94983, -1685.858, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(827.3114, -1552.0742, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(879.5112, -1483.4769, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(812.1732, -1397.8604, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(749.17883, -1549.0812, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(686.30927, -1495.0852, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(509.8076, -1588.7445, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(714.19666, -1309.3616, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(532.5492, -1482.7211, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(499.42017, -1376.1318, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(151.96709, -1505.0153, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(253.83746, -1430.331, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(363.50858, -1508.2144, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(485.66, -1247.981, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(348.22897, -1325.1138, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(131.20288, -1235.6323, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-385.7724, -884.2843, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-446.77765, -982.9167, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-253.8215, -1070.8698, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-392.2264, -661.95776, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(16.532782, -945.2937, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-242.71034, -705.3234, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-276.2231, -554.3232, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-151.00786, -625.3454, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-89.214386, -734.2293, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(4.411322, -822.1182, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-112.48037, -1046.7631, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-696.86914, -656.7086, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-872.6228, -769.1169, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-817.53894, -619.88257, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-997.70526, -891.42664, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-1134.0302, -688.6072, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-1070.7446, -518.9572, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-929.54486, -661.8522, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-736.92334, -436.69617, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-920.6871, -505.24707, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-937.716, -269.06943, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-978.4258, -391.5979, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-564.7852, -6.699867, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-589.8957, -124.7744, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-284.14783, -240.81497, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-141.10794, -111.00465, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-440.05505, -101.55728, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-251.49702, 13.473313, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-367.3016, 94.722206, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-487.1926, -232.3502, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-468.29257, 231.7455, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-113.59521, 61.037663, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-300.54105, 174.36458, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(152.32986, -426.679, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(616.70087, -293.3473, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(315.49988, -542.8329, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(338.9818, -372.08792, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(563.77563, -441.07492, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(523.7301, -245.02635, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(330.89932, -225.93776, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(279.64832, -117.60873, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(518.6711, -59.02443, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(559.48145, -97.220604, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1696.9607, -990.0721, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1845.7501, -1340.1005, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1811.8542, -1215.8251, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1960.7842, -1113.3351, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1797.5878, -1070.1204, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1903.9438, -1031.5997, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1843.2313, -816.39777, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1970.3514, -887.50146, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1249.3672, -666.997, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1168.0657, -747.13995, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1228.0546, -905.68427, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1042.2501, -930.19305, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1062.171, -855.68744, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1020.5746, -725.65607, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1176.981, -567.3876, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(2151.7239, -29.92165, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1951.3341, -73.56036, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(2113.4978, 107.44709, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1929.2877, 202.1599, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1801.0668, 112.90498, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(1767.4954, -1.9537315, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(820.66473, 614.145, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(682.713, 650.5262, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(742.67773, 764.00085, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(543.4218, 659.0896, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(574.0602, 776.65485, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(697.4366, 536.9504, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(566.837, 907.4917, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(515.25995, 541.53625, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(407.16687, 736.1555, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(36.516113, 1153.5625, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-78.67058, 1153.8734, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(66.35816, 988.5996, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-99.926125, 1268.6239, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-116.71154, 988.8587, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-162.24997, 898.2107, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-268.7849, 783.65704, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-310.58502, 879.9299, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-26.846851, 780.09875, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(-239.35913, 1050.1168, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(105.82614, 798.52905, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(183.0259, 764.02673, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(189.32407, 837.3562, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id3", "f_pilgrimroad_41_4", Rectangle(276.96155, 818.305, 25));

		// 'Repusbunny_Bow_Purple' GenType 102 Spawn Points
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(278.43866, 746.3349, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(563.4444, 883.58685, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(473.3411, 745.81323, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(507.03046, 567.9659, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(809.4315, 662.3316, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(814.83, 483.35123, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(1818.9371, 43.58847, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(1918.3231, 176.10324, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(1962.0345, 58.470364, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(2097.6372, 87.49461, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(2078.582, -75.36538, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(1809.017, -106.91185, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(1955.1423, -99.080475, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(181.08746, -1494.448, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(376.1595, -1623.2429, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(476.72858, -1795.5809, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(656.71405, -1705.3307, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(531.7178, -1491.3303, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(778.9996, -1482.9493, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(741.5044, -1269.8766, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(466.2556, -1312.5972, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(198.1811, -1304.7859, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-505.5202, 133.75403, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-244.7063, 215.84818, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-145.0048, -87.523605, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-568.26556, -100.86602, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-1061.2972, -693.58966, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-938.8721, -347.8954, 25));
		AddSpawnPoint("f_pilgrimroad_41_4.Id4", "f_pilgrimroad_41_4", Rectangle(-416.0529, -99.56372, 25));
	}
}
