//--- Melia Script -----------------------------------------------------------
// d_limestonecave_52_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Tevhrin Stalactite Cave Section 1' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DLimestonecave521MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_limestonecave_52_1", MonsterId.Rockon, Properties("MHP", 468964, "MINPATK", 6531, "MAXPATK", 7929, "MINMATK", 6531, "MAXMATK", 7929, "DEF", 67778, "MDEF", 67778));
		AddPropertyOverrides("d_limestonecave_52_1", MonsterId.Tala_Sorcerer, Properties("MHP", 470713, "MINPATK", 6554, "MAXPATK", 7957, "MINMATK", 6554, "MAXMATK", 7957, "DEF", 68480, "MDEF", 68480));
		AddPropertyOverrides("d_limestonecave_52_1", MonsterId.Flak_Green, Properties("MHP", 472537, "MINPATK", 6577, "MAXPATK", 7986, "MINMATK", 6577, "MAXMATK", 7986, "DEF", 69212, "MDEF", 69212));
		AddPropertyOverrides("d_limestonecave_52_1", MonsterId.Rockoff, Properties("MHP", 474432, "MINPATK", 6602, "MAXPATK", 8016, "MINMATK", 6602, "MAXMATK", 8016, "DEF", 69972, "MDEF", 69972));

		// Monster Spawners ---------------------------------

		AddSpawner("d_limestonecave_52_1.Id1", MonsterId.Rockon, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_1.Id2", MonsterId.Rockon, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_1.Id3", MonsterId.Rockon, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_1.Id4", MonsterId.Tala_Sorcerer, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_1.Id5", MonsterId.Flak_Green, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_limestonecave_52_1.Id6", MonsterId.Rootcrystal_04, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("d_limestonecave_52_1.Id7", MonsterId.Rockoff, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rockon' GenType 8 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-801.3113, -935.88794, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-702.9247, -701.9902, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1214.6849, -137.73378, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1459.4496, 299.24628, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-730.82965, 441.11548, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1335.019, 1386.7914, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1141.2296, 1298.7267, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-101.77222, 1076.4377, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-42.388794, 1305.9618, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(451.9677, 156.88158, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-40.39853, 164.79974, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(696.1711, 168.73322, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1094.5184, 86.22862, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1421.8307, -29.130028, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1277.5768, -210.16484, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(609.5041, 831.2087, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(646.8879, 620.94696, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1335.6554, 979.8554, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1284.7216, 1528.6089, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1542.8602, 1488.7527, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(642.38684, 1380.0785, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(414.5558, 1425.0464, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1386.577, 360.62085, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(561.14764, 743.9491, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(610.86426, 609.7208, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(938.2197, 804.781, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1354.2388, 721.09485, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1502.48, 746.5023, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1599.2853, 929.389, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1539.0472, 996.7513, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1484.4459, 828.86884, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1404.2477, 927.6215, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1234.9353, 837.8524, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(1433.4557, 1022.9799, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-857.49115, -999.384, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-647.11957, -914.8646, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-809.2191, -801.04144, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-930.7502, -943.73364, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-1078.597, -1053.5337, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-705.43616, -791.55096, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-381.34467, -871.9239, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id1", "d_limestonecave_52_1", Rectangle(-451.52274, -794.26166, 35));

		// 'Rockon' GenType 9 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-738.71606, 555.51917, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-1136.6715, 296.43524, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-1216.9105, -77.60137, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-948.06805, -85.43295, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-1057.2383, -862.6208, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-733.3946, -879.4588, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(31.297644, 206.03825, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(396.72076, 200.35591, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(552.0194, 185.83234, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-88.02266, 1057.0494, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(-49.40011, 1338.631, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(1337.4655, 203.983, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(1278.1149, -306.95972, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(1335.6355, 854.6227, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(1327.3364, 1488.3232, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id2", "d_limestonecave_52_1", Rectangle(580.88165, 1436.3119, 30));

		// 'Rockon' GenType 10 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(532.6231, 1450.3807, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(1424.2604, 1541.834, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(1311.0614, 940.96277, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(1351.4315, 140.33588, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(611.65027, 176.52904, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(700.9666, 709.9803, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(434.76782, 130.64366, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(92.75785, 158.35338, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-101.06102, 1123.1267, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-54.304665, 1364.4059, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1135.2292, 1350.2211, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1262.269, 1349.8009, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1153.9777, 434.98676, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-837.42596, 499.62613, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1115.0897, -167.54692, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1005.363, -951.7001, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-623.09546, -836.7391, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id3", "d_limestonecave_52_1", Rectangle(-1036.6349, 461.095, 35));

		// 'Tala_Sorcerer' GenType 11 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-854.8988, -723.919, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-861.97656, -865.62836, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1124.8712, -244.50092, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1324.7487, 291.9037, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-918.4305, 471.56485, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1395.1702, 1292.7108, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1075.4677, 1408.7246, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-84.624176, 1076.5856, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-69.682724, 1338.0961, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(569.427, 1529.5521, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(630.3569, 1281.8729, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1038.4757, 1602.6669, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1448.7214, 1480.2996, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1311.7784, 1070.7656, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(672.151, 680.8892, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(814.13855, 657.03265, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1488.8036, 926.8325, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1309.5702, 250.78143, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1338.3828, 20.221054, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1296.5718, -260.97568, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(517.0545, -9.068314, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(392.11996, 173.91983, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(96.4326, 79.58727, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1025.7583, -106.43419, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(-1147.3104, -30.25988, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1179.7716, 1559.9814, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1255.8512, 1422.3234, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1365.4102, 1616.4419, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1407.9999, 1337.5557, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1438.909, 1432.8589, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1566.2382, 1567.8715, 30));
		AddSpawnPoint("d_limestonecave_52_1.Id4", "d_limestonecave_52_1", Rectangle(1665.1741, 1425.7377, 30));

		// 'Flak_Green' GenType 12 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-498.1798, -870.2447, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-960.0023, -1016.0823, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1262.1456, -74.01079, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1127.94, -90.876656, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1253.3663, 331.0751, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1235.8112, 230.18292, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-903.3455, 588.49023, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1052.0348, 1391.3151, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1243.8938, 1291.3679, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-286.1269, 70.4092, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-173.41496, 121.31673, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1066.2699, 39.88364, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-330.67886, -43.539173, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-184.92781, 37.178402, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1285.2405, 13.262032, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1222.1929, 157.16011, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1477.787, -5.014642, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1309.3832, -231.41682, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-105.32101, 235.15501, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(20.735073, 220.37193, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(68.38599, 140.02081, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1103.0659, 857.0023, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(659.6221, 1383.6166, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(508.74582, 1536.3732, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-1065.1417, -19.803585, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-320.05988, -228.17911, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-231.19789, 117.01841, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-96.08354, 295.97534, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-34.142426, 276.7707, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-104.57207, 29.15727, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1381.3525, -100.71221, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(81.96845, 49.02961, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-102.19186, 177.21677, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-200.4065, -147.83289, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-73.73215, 78.9679, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1505.5844, 135.15953, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-212.62431, -53.989986, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(941.8, 30.17512, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-202.22003, 190.07413, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-29.116356, 89.2269, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-401.552, -440.33685, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(-8.9355, 163.82718, 35));
		AddSpawnPoint("d_limestonecave_52_1.Id5", "d_limestonecave_52_1", Rectangle(1355.4198, 254.83769, 35));

		// 'Rootcrystal_04' GenType 26 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(208.3, -1115.36, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-436.13, -859.38, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-789.19, -870.37, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1023.36, -1027.7, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-845.54, -687.45, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-835.93, -131.96, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1299.16, -142.72, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1193.7, 126.33, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1195.51, 353.81, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1506.12, 291.48, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-845.02, 380.4, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-734.74, 616.38, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-174.53, 1249.84, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(16.51, 1021.91, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(75.5, 1335.06, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-233.73, 1445.59, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1234.61, 1488.94, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1485.73, 1410.44, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1641.43, 1504.89, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1410.2, 1626.66, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1395.86, 1806.79, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(557.91, 1611.37, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(609.36, 1925.66, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1077.76, 1276.75, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-1383.4, 1350.31, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-430.08, -242.63, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(-202.82, -37.27, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(45.5, 142.14, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(518.64, 127.06, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(899.12, 2.86, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1244.14, 211.65, 15));
		AddSpawnPoint("d_limestonecave_52_1.Id6", "d_limestonecave_52_1", Rectangle(1414.48, -199.11, 15));

		// 'Rockoff' GenType 1001 Spawn Points
		AddSpawnPoint("d_limestonecave_52_1.Id7", "d_limestonecave_52_1", Rectangle(-212.05, -23.47, 9999));
	}
}
