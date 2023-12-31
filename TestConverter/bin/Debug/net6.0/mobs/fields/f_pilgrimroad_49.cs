//--- Melia Script -----------------------------------------------------------
// f_pilgrimroad_49
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Genar Field' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FPilgrimroad49MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_pilgrimroad_49.Id1", MonsterId.Rootcrystal_05, 12, 15, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id2", MonsterId.Sec_Beetle, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id3", MonsterId.Sec_Dandel_Orange, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id4", MonsterId.Sec_Kepari_Mage, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id5", MonsterId.Sec_Dandel_Orange, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id6", MonsterId.Sec_Beetle, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id7", MonsterId.Sec_Beetle, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_pilgrimroad_49.Id8", MonsterId.Sec_Kepari_Mage, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 4 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-1009.3834, -2132.183, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-379.29855, -1661.1545, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-84.85939, -789.94714, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-894.70056, -136.61125, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-1798.5159, -317.35815, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(265.33597, -364.38242, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-25.522402, 990.8072, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-1218.1726, 480.82623, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(-1236.7085, 901.5762, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(983.09674, 1409.8427, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(1688.4888, -50.24346, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(2065.7778, -1313.1234, 10));
		AddSpawnPoint("f_pilgrimroad_49.Id1", "f_pilgrimroad_49", Rectangle(1193.0577, 31.586166, 10));

		// 'Sec_Beetle' GenType 10 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-1087.7933, -2408.89, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-943.9082, -2567.75, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-1024.1394, -2577.1414, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-879.3451, -2684.4805, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-777.0493, -2567.9678, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-639.7716, -2514.307, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-952.1457, -2309.4766, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-967.67615, -2170.7712, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-881.4822, -2094.028, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-744.2153, -2420.3274, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-715.8692, -2114.5417, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-783.9944, -2309.8801, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-564.53674, -2314.5857, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-652.2747, -1978.422, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-646.09515, -1758.8135, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-377.9636, -1725.1271, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-415.0408, -1576.149, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id2", "f_pilgrimroad_49", Rectangle(-237.61044, -1570.2925, 30));

		// 'Sec_Dandel_Orange' GenType 11 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1341.1375, -93.53097, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1629.5942, -296.6161, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1810.6317, -450.02783, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1825.7754, -273.08475, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1579.9243, -107.13173, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1523.6475, 107.55484, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1818.5579, 31.672707, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1986.6316, 52.67576, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(2097.084, 42.174988, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(2154.546, -296.17862, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(2051.8657, -506.7033, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1537.7019, -400.1205, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1772.4966, -94.88627, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1700.7499, 197.46973, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1917.2756, 238.70454, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1236.2913, 197.12587, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(2191.0806, -150.02255, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1371.7355, 25.9839, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1520.1932, -199.89374, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1670.0991, 131.35815, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1229.5708, 1781.8971, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1024.2069, 1644.7504, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1112.3502, 1802.904, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1248.1659, 1415.6771, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1107.1992, 1385.7957, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1007.874, 1493.7777, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(977.92725, 1365.45, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1057.8866, 1201.788, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1134.3611, 1122.3035, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1313.32, 1270.0303, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1219.2524, 1219.791, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id3", "f_pilgrimroad_49", Rectangle(1172.3076, 1627.5133, 30));

		// 'Sec_Kepari_Mage' GenType 12 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-604.7788, 865.65247, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-494.2548, 915.50397, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-172.70915, 856.823, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-173.54175, 537.15594, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(212.58473, 920.4419, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(143.16171, 729.45166, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(26.125954, 856.64746, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(57.70657, 620.8208, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(30.128414, 445.8517, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-79.822815, 651.9976, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(74.57906, 1005.503, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(298.34238, 984.77014, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-2069.8943, -455.21494, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-2029.9722, -264.94238, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1874.7219, -498.8704, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1686.747, -584.0759, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1709.4164, -397.12024, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1929.8202, -126.70476, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1507.4315, -334.4777, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1581.2853, -446.56253, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1888.7566, -353.13028, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1778.5151, -182.3081, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1853.9603, -38.976147, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-1642.0361, -302.12604, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id4", "f_pilgrimroad_49", Rectangle(-2164.0078, -548.70074, 30));

		// 'Sec_Dandel_Orange' GenType 13 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-1145.1943, -219.96144, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-1072.7156, -113.9627, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-985.3737, -26.603134, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-960.439, -146.64807, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-995.37885, -293.15167, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-1128.1373, -360.07745, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-918.40076, -416.01367, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-1246.9116, -359.32904, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-791.1511, -340.48068, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-204.35907, -576.2923, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-253.95924, -824.30597, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(17.53966, -925.0621, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-79.139786, -714.1396, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(80.45273, -1111.9548, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(293.50595, -1065.8425, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(565.31335, -923.382, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(154.77296, -610.2137, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(516.6514, -480.62793, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(465.4961, -588.206, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(345.01813, -510.44113, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(257.3943, -882.4675, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-883.44745, -239.9852, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-820.5748, -143.38094, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id5", "f_pilgrimroad_49", Rectangle(-676.93884, -316.91376, 30));

		// 'Sec_Beetle' GenType 14 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1830.3815, 264.63187, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1721.713, 424.9487, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1469.6621, 481.83148, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1073.0054, 632.0494, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-895.906, 691.9115, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1019.5217, 862.24524, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1221.6842, 917.75653, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1511.2472, 707.4213, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1011.2758, 832.10864, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-723.9847, 875.8467, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-1244.4596, 526.228, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-256.33987, -654.5645, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(160.59967, -490.3794, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(-100.27809, -1042.8995, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(210.18034, -1149.1875, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(419.351, -971.7844, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(652.5829, -465.4769, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(10.451035, -468.36017, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(225.7844, -197.5357, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(1569.4053, -243.63278, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(1783.8044, -1393.8398, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id6", "f_pilgrimroad_49", Rectangle(1930.9026, -1254.4225, 30));

		// 'Sec_Beetle' GenType 15 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2031.8431, -1527.7911, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1740.3407, -1315.5271, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1908.5388, -1501.638, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1971.8892, -1233.7688, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2137.2583, -1083.5076, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2180.924, -1274.9961, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2160.5996, -1475.3064, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2238.4353, -1552.8223, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2408.4717, -1255.0178, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2255.329, -1164.956, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2447.0876, -1136.3668, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2410.0598, -1535.1063, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2489.048, -1373.5149, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2088.9912, -1336.3298, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2047.7434, -1086.9094, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1859.3759, -1201.4824, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1879.3467, -1359.9247, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(1735.4573, -1457.185, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id7", "f_pilgrimroad_49", Rectangle(2012.0271, -1630.6045, 30));

		// 'Sec_Kepari_Mage' GenType 16 Spawn Points
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(-162.04536, -843.9207, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(-38.456116, -595.94037, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(39.87442, -757.355, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(-32.975792, -1196.9315, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(171.79495, -941.97504, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(407.74072, -1145.8053, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(545.69916, -716.5303, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(371.17365, -360.45776, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(214.28842, -373.3102, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(-261.74634, -493.72403, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(428.7676, -836.22095, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(636.3351, -313.92258, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(1963.3441, -1115.8003, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2250.224, -1178.9578, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2082.7903, -1282.0419, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(1782.3262, -1376.2642, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2015.4335, -1545.923, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2048.4624, -1384.696, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2231.4778, -1587.3916, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2316.289, -1327.4358, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2407.024, -1493.694, 30));
		AddSpawnPoint("f_pilgrimroad_49.Id8", "f_pilgrimroad_49", Rectangle(2441.9272, -1194.4082, 30));
	}
}
