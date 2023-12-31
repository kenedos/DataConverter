//--- Melia Script -----------------------------------------------------------
// f_farm_47_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Aqueduct Bridge Area' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFarm472MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_farm_47_2", MonsterId.Dandel_Orange, Properties("MHP", 178794, "MINPATK", 2800, "MAXPATK", 3343, "MINMATK", 2800, "MAXMATK", 3343, "DEF", 5400, "MDEF", 5400));
		AddPropertyOverrides("f_farm_47_2", MonsterId.Cronewt_Mage, Properties("MHP", 179869, "MINPATK", 2814, "MAXPATK", 3360, "MINMATK", 2814, "MAXMATK", 3360, "DEF", 5498, "MDEF", 5498));
		AddPropertyOverrides("f_farm_47_2", MonsterId.Kepari_Mage, Properties("MHP", 180982, "MINPATK", 2829, "MAXPATK", 3378, "MINMATK", 2829, "MAXMATK", 3378, "DEF", 5600, "MDEF", 5600));
		AddPropertyOverrides("f_farm_47_2", MonsterId.Ashrong, Properties("MHP", 182134, "MINPATK", 2843, "MAXPATK", 3396, "MINMATK", 2843, "MAXMATK", 3396, "DEF", 5705, "MDEF", 5705));

		// Monster Spawners ---------------------------------

		AddSpawner("f_farm_47_2.Id1", MonsterId.Dandel_Orange, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_2.Id2", MonsterId.Cronewt_Mage, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_2.Id3", MonsterId.Kepari_Mage, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_2.Id4", MonsterId.Dandel_Orange, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_2.Id5", MonsterId.Ashrong, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_2.Id6", MonsterId.Rootcrystal_01, 23, 30, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_farm_47_2.Id7", MonsterId.Ashrong, 60, 80, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Dandel_Orange' GenType 4 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-708.4024, 1023.4204, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-432.9643, 1196.0784, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-493.54028, 960.00446, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-666.0597, 1165.251, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-615.76294, 1724.132, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-393.79636, 1858.6307, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-327.45966, 1662.1616, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(357.5348, 1938.6703, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(460.99, 4.5232697, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(529.5753, 287.6607, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1463.3947, 771.63586, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(500.2262, 530.37305, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(328.23544, -146.88992, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(-733.2467, 1606.9556, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1515.3545, 1707.4237, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(154.76654, 1608.7651, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(70.21516, 1659.5863, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(66.97427, 1768.4604, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(176.9072, 1744.537, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(346.61002, 1602.971, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(511.38272, 1742.6259, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(408.53467, 1772.0437, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(314.54016, 1732.3312, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(414.5913, 2003.0442, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(476.5799, 1928.4993, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(157.87917, 1851.9897, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(154.44754, 1908.5867, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(277.9949, 1912.7988, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1279.9658, 907.56305, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1206.348, 1053.8833, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1163.9723, 1153.6298, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1263.7494, 1201.3372, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1679.1987, 1138.0302, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1504.1896, 964.8881, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1609.9431, 1039.3998, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1491.6005, 1086.5385, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1479.768, 1261.2943, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1557.4727, 1256.7985, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1502.1505, 1330.6752, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1626.3237, 969.7653, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1306.4589, 1067.8265, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1315.7878, 1319.6161, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1412.3475, 986.88696, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1410.9952, 1178.3187, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1304.7119, 1574.0632, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(953.9696, 1807.9806, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(957.50525, 1715.9442, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1194.0537, 1892.8022, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1103.8899, 1839.3541, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1295.8806, 1850.886, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1116.6233, 1647.375, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1213.654, 1579.8732, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1340.1691, 1641.9736, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1206.9667, 1776.021, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1396.0847, 1566.6736, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1569.4791, 1644.8315, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1380.6547, 1942.6393, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1486.9847, 1904.8075, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1398.8682, 1849.5339, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1438.3828, 1758.8947, 25));
		AddSpawnPoint("f_farm_47_2.Id1", "f_farm_47_2", Rectangle(1264.6182, 1696.7023, 25));

		// 'Cronewt_Mage' GenType 37 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(69.03667, -1104.6006, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(221.80739, -552.11115, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(97.58552, -1565.5651, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(136.96675, -930.19653, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(864.2753, -1647.5282, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(1123.135, -1727.9503, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(910.2272, -1324.4983, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(1559.96, -1136.1061, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(2117.875, -1247.237, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(2206.3367, -1387.8036, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(2240.3965, -1119.8972, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(2021.5667, -1397.8148, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(991.31744, -1017.5274, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(882.37085, -1453.3074, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(1514.6647, -1526.774, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(1325.7068, -1677.0573, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(2004.917, -1158.6975, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(8.7524395, -1957.664, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(142.89563, -2060.13, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(227.55524, -1795.1702, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(35.042126, -1740.6794, 30));
		AddSpawnPoint("f_farm_47_2.Id2", "f_farm_47_2", Rectangle(756.4395, -1082.7358, 30));

		// 'Kepari_Mage' GenType 38 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id3", "f_farm_47_2", Rectangle(302.63425, -582.0866, 9999));

		// 'Dandel_Orange' GenType 39 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id4", "f_farm_47_2", Rectangle(134.1986, 1026.6052, 1500));

		// 'Ashrong' GenType 41 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id5", "f_farm_47_2", Rectangle(844.2698, -1315.7561, 9999));

		// 'Rootcrystal_01' GenType 42 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1982.129, -1230.106, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1734.5298, -1396.1083, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1440.782, -1121.8284, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(926.9137, -1366.9607, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1242.0033, -1682.9584, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(2268.326, -1476.4921, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(327.98685, -1014.2756, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(42.50117, -1265.1129, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-477.59113, -1130.8591, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-990.7586, -1138.9575, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(133.34778, -1834.0656, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(51.67364, -516.3364, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(460.0386, 215.1245, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(88.55757, 446.93463, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(229.76895, -2.5413165, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1135.5614, 541.9246, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1215.8329, 50.594795, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1514.1823, 772.5147, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1415.2334, 1142.7137, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(1382.9594, 1600.0696, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(988.2164, 1784.9193, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(444.3646, 1722.4166, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(110.43249, 1725.4121, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(188.71347, 1177.6415, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(120.27988, 887.0439, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-403.43677, 969.82324, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-755.2089, 1132.667, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-613.5604, 1665.382, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-1137.4335, 1088.011, 10));
		AddSpawnPoint("f_farm_47_2.Id6", "f_farm_47_2", Rectangle(-1528.9125, 1019.3622, 10));

		// 'Ashrong' GenType 56 Spawn Points
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(458.09442, -472.0818, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(132.24455, -516.1469, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2374.4602, -1397.6913, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2386.8455, -1342.3732, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2416.7524, -1302.6337, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2477.6987, -1270.5142, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2316.2842, -1385.0822, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2259.028, -1452.8862, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2211.69, -1469.2108, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2163.936, -1487.9072, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2127.3232, -1456.0511, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2254.1243, -1401.4713, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2240.9087, -1354.0723, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2124.4915, -1315.2096, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2183.1274, -1251.764, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2259.7368, -1228.758, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2306.503, -1171.7266, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2321.5312, -1244.8903, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2188.4111, -1152.7593, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2062.6282, -1220.606, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1997.8114, -1214.2594, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2082.2258, -1268.0232, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(2000.6123, -1276.8231, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1940.5146, -1191.3123, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1928.8978, -1269.7115, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1929.4807, -1409.7043, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1874.4628, -1355.3313, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1842.6813, -1278.2507, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1918.5388, -1328.1937, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1883.2195, -1230.6464, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1959.5802, -1239.8618, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1533.8585, -1396.4298, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1514.0046, -1418.5916, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1576.9814, -1445.3376, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1636.3754, -1467.5884, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1586.3643, -1477.3713, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1757.6304, -1306.1274, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1671.9785, -1286.5768, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1630.2968, -1334.711, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1596.564, -1382.617, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1548.6294, -1355.7339, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1489.477, -1351.9111, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1616.4283, -1285.7556, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1511.5988, -1222.0006, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1479.7562, -1494.3917, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1263.2272, -1667.7314, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1213.9615, -1641.1346, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1212.0317, -1717.026, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1156.4548, -1681.0502, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1153.1667, -1595.0474, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1076.7611, -1593.5454, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1107.0906, -1651.0062, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1066.7583, -1710.2982, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1050.1469, -1775.0071, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1048.1816, -1635.3109, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(987.4987, -1622.5787, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1045.2864, -1553.4917, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(991.49426, -1546.0547, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(936.1169, -1598.2548, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(903.616, -1668.7417, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(799.79395, -1525.4917, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(805.3944, -1595.7998, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(846.68256, -1275.6967, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(897.8111, -1362.5443, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(915.9492, -1285.6686, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(979.52576, -1303.2725, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(795.6435, -1171.8536, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(871.1849, -1180.2406, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(841.36163, -1101.5245, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(789.7619, -1033.1718, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(845.4723, -994.9412, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(902.92633, -1116.7211, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1050.8359, -1096.6621, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1131.9355, -1137.2173, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1164.8593, -1071.7792, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1102.6414, -1077.1031, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1140.7723, -991.3919, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1073.2549, -1002.8336, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(1023.8068, -962.4375, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(242.49171, -2009.7921, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(88.03661, -2072.7166, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(43.373573, -2086.0208, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-19.310898, -2074.9475, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-15.461353, -1996.2625, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(40.750835, -2026.2948, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(268.9761, -1928.0111, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(297.49954, -1871.6378, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(223.28796, -1876.6116, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(289.31677, -1806.6356, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(271.7819, -1751.4985, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(235.14671, -1716.2982, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-67.05505, -1812.9915, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-46.445633, -1751.0204, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(6.6148515, -1789.2068, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(89.54419, -1812.3198, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(72.779724, -1758.382, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(58.144215, -1680.6741, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(133.55466, -1740.6449, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(96.66768, -1473.5416, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(77.12592, -1435.7372, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(185.44913, -1392.4384, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(275.08337, -1373.224, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(321.93896, -1400.3665, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(379.1961, -1311.8418, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(313.34387, -1318.588, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-12.955609, -1272.9277, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-35.567192, -1194.4342, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-40.727554, -1099.1927, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(25.462086, -1057.3048, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(14.943178, -1140.2185, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(43.096485, -1216.9529, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(114.99088, -1149.3925, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(220.48537, -1015.962, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(257.54913, -979.6158, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(326.75677, -1034.472, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(275.22995, -1085.5227, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(344.12744, -1134.879, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(285.81793, -1048.2903, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(415.78577, -1211.7078, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(300.76544, -1228.2164, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(370.81522, -1355.8466, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-6.920542, -438.0974, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-10.552816, -500.00018, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(284.8293, -623.4044, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(249.85512, -599.2034, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(366.81784, -617.4098, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(440.28284, -535.5983, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(408.26328, -528.01227, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(403.19675, -575.0679, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(374.02307, -474.76935, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(435.57373, -401.84595, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(347.20197, -384.74078, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(285.85242, -404.4332, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(204.72386, -430.74573, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(439.4517, -181.342, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(498.7351, -122.63805, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(558.9417, -155.11728, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(557.1277, -67.12573, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(610.9566, -108.60919, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(476.9279, -79.08135, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(388.0584, -83.78746, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(362.1984, -87.29245, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(560.5553, 4.2316475, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(644.1744, -21.30416, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(728.1702, 15.778, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(794.25854, 138.18156, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(780.5426, 233.25447, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(720.42505, 317.1602, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(672.2042, 270.38928, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(630.6418, 174.24326, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(697.4125, 469.54047, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(676.739, 526.85876, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(592.37115, 551.99774, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(562.2568, 403.99188, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(613.8739, 475.85947, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(553.5586, 443.47778, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(618.2681, 40.12407, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(491.8933, 328.75336, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(216.21507, -133.35948, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(35.65899, -100.99892, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(190.13583, 61.860443, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(286.51776, -43.82184, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(94.29933, -2.7718322, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-194.01086, 368.1035, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-182.48933, 450.4214, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-82.040375, 482.2833, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-36.016415, 578.3298, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(38.924557, 497.59296, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(110.26194, 597.0123, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(136.71785, 491.29498, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(288.12885, 341.40393, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(299.83493, 255.64078, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(331.83875, 401.41318, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(324.4411, 520.0578, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(444.1965, 510.1108, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(125.74608, 1235.9894, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(166.54701, 1318.9344, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(261.06485, 1285.1515, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(338.4913, 1293.4507, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(360.35776, 1187.6157, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(430.2948, 1138.5676, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(267.80466, 772.9132, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(239.41057, 747.1811, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(204.5735, 919.25635, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(190.00931, 818.84576, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(293.7298, 901.5329, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(3.5672455, 981.71075, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(79.705185, 925.75946, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(173.3817, 1011.8052, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(83.765884, 1045.7817, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(379.54105, 961.7517, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(291.02866, 1018.8768, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(385.6306, 1093.3104, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(278.15747, 1111.8822, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(187.19911, 1092.6821, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(94.294785, 1170.6956, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(191.86324, 1189.2292, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(269.79242, 1225.2697, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-733.0891, 955.38385, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-821.927, 1009.5488, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-658.1785, 842.16296, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-669.1037, 786.2367, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-761.72675, 854.1745, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-560.7046, 823.871, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-657.6722, 1179.7775, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-600.62946, 910.6542, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-488.7173, 901.3124, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-337.77322, 929.22504, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-304.62985, 983.7451, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-476.9714, 1120.5978, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-468.3572, 978.49854, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-427.97537, 1035.68, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-333.48788, 1047.0924, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-452.753, 1217.6447, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-471.8892, 1281.6671, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-353.6833, 1199.1095, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-588.47107, 1193.564, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-626.4399, 1257.1664, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-561.0068, 988.6209, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-735.10974, 1192.2784, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-763.72, 1130.2744, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-536.5433, 1072.9078, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-644.8904, 1018.4708, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-635.8639, 1100.4377, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-752.18494, 1059.312, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-424.77234, 1609.4279, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-786.9883, 1612.5964, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-749.71844, 1687.6396, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-687.6856, 1604.2317, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-615.6484, 1544.6282, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-561.2558, 1582.0143, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-635.748, 1687.6694, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-662.7931, 1773.7045, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-759.9043, 1795.2919, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-701.21936, 1873.7526, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-553.4448, 1926.1788, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-546.7912, 1821.5321, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-476.787, 1856.2072, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-522.38184, 1714.9812, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-420.69275, 1733.6278, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-510.8626, 1631.3362, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-314.32953, 1672.7084, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-305.52075, 1766.2883, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-256.19443, 1832.37, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-354.04532, 1912.2076, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(-196.14584, 1680.2639, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(47.78993, 374.0286, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(255.45326, 435.41418, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(207.74571, 608.8879, 25));
		AddSpawnPoint("f_farm_47_2.Id7", "f_farm_47_2", Rectangle(378.1412, 270.59286, 25));
	}
}
