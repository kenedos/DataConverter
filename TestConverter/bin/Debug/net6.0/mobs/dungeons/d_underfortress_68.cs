//--- Melia Script -----------------------------------------------------------
// d_underfortress_68
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Storage Quarter' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress68MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_underfortress_68", MonsterId.Deadbornscab_Red, Properties("MHP", 312402, "MINPATK", 4518, "MAXPATK", 5455, "MINMATK", 4518, "MAXMATK", 5455, "DEF", 23605, "MDEF", 23605));
		AddPropertyOverrides("d_underfortress_68", MonsterId.Infroholder_Green, Properties("MHP", 314813, "MINPATK", 4549, "MAXPATK", 5493, "MINMATK", 4549, "MAXMATK", 5493, "DEF", 24052, "MDEF", 24052));
		AddPropertyOverrides("d_underfortress_68", MonsterId.Deadbornscab_Mage_Red, Properties("MHP", 317271, "MINPATK", 4581, "MAXPATK", 5532, "MINMATK", 4581, "MAXMATK", 5532, "DEF", 24508, "MDEF", 24508));

		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_68.Id1", MonsterId.Deadbornscab_Red, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_68.Id2", MonsterId.Infroholder_Green, 49, 65, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_68.Id3", MonsterId.Deadbornscab_Mage_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_68.Id4", MonsterId.Deadbornscab_Red, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_underfortress_68.Id5", MonsterId.Rootcrystal_05, 18, 23, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Deadbornscab_Red' GenType 9 Spawn Points
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1279.6091, -1978.4677, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(110.42744, -1587.8768, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1289.261, -299.61356, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-480.58807, 352.52606, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(545.4354, 350.0946, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(892.6898, 495.99265, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(281.3819, -620.328, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1398.1287, -585.88403, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1889.692, -550.02936, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1939.5503, 1260.6156, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(250.14294, -1505.187, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-251.65312, -729.3157, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2145.3662, 714.4461, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2149.5872, 336.69458, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2541.8843, -639.1645, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2243.6511, -187.35847, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2551.7212, -213.58621, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(690.1041, 530.2803, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(883.77466, 353.35196, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(126.53944, 523.1939, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-386.8426, -873.44824, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-709.27203, -971.08606, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1392.3682, -1127.1914, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-429.2288, -1677.0204, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-862.1105, -1854.3146, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1091.7814, -1058.1866, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-801.8981, 118.66216, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2611.4917, -632.72687, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2597.0715, -571.1642, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2448.6929, -607.86566, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2494.7568, -575.70166, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2570.6438, -602.84186, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2469.3093, -421.6278, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2475.0112, -372.95322, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2554.8608, -345.88513, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2526.5508, -261.59177, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2598.5037, -248.76103, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2545.004, -78.246445, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2470.5813, -22.236431, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2547.4517, -12.340988, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2518.3206, 44.610947, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2469.1584, 32.04609, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2396.8706, 104.74614, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2414.537, 51.61666, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2486.0522, 89.05435, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2446.938, 84.01372, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2585.8513, -120.87384, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2134.3025, 285.43927, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2239.9246, 274.31436, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2306.4033, 264.97095, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2358.4172, 330.0612, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2232.3997, 328.93332, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2180.9907, 384.8367, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2116.7224, 391.18427, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2134.8257, 476.47598, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2208.6147, 458.30505, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2136.0337, 424.10834, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2329.0903, 366.84613, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2283.7117, 380.60477, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2236.9172, 402.3533, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2286.2656, 464.21536, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2360.276, 419.025, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2354.8613, 482.7144, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2255.0208, 517.4687, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2195.646, 535.5423, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2194.7527, 609.8571, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2273.2446, 631.7727, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1376.8734, -631.40625, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1446.3275, -597.9538, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1409.8284, -540.189, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1378.7126, -520.3438, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1352.1941, -573.50134, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1284.5803, -595.7375, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1291.5917, -555.6381, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1231.6726, -601.15424, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1157.5171, -619.33466, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1169.1125, -563.1503, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1152.6099, -520.37427, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1092.8438, -560.6769, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1113.2765, -619.43, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1135.034, -574.5062, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(788.70105, -647.83813, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(783.9063, -571.15283, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(739.9166, -490.45944, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(681.5767, -536.8509, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(621.96185, -662.2306, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(655.3301, -733.00586, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(685.0778, -684.77704, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(736.8897, -662.2163, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(773.5973, -719.20715, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(677.05206, -796.8385, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(630.1305, -789.62427, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(702.86566, -743.50415, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(739.0811, -820.22473, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(778.4418, -759.8504, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(724.51086, -781.03656, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(740.5812, -605.8198, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(185.3003, -573.03357, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(142.7313, -637.36847, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(79.91411, -610.08215, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(155.21964, -689.49963, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(102.45177, -677.1777, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(160.1554, -750.2207, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(106.70428, -745.73584, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(63.23703, -787.05365, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(43.220165, -736.7142, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2.731926, -802.88275, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-101.33429, -800.40283, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-90.83139, -876.0207, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-45.74254, -939.9628, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-76.45946, -970.69824, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-205.17453, -871.2172, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-320.61978, -761.15015, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-643.0462, -954.25714, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-521.0312, -919.49207, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-799.33435, -1005.819, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-979.0832, -1053.4413, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1238.4271, -1127.9331, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1292.6273, -1164.7589, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1363.4893, -1032.4578, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1486.3077, -1042.862, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1463.674, -1246.9799, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1373.6632, -1262.2616, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1583.1709, -1198.3734, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1604.511, -1001.1609, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1244.8574, -988.29614, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(269.06784, -1784.6658, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(185.90486, -1793.0427, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(204.94087, -1678.6638, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(321.33072, -1698.6842, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(303.50443, -1602.5454, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(348.0057, -1487.8131, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(197.69208, -1522.7303, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(118.67708, -1476.827, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(16.154297, -1616.9528, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-31.55912, -1537.2002, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-378.68417, -1674.9706, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-622.5119, -1750.7555, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1011.5685, -1876.3268, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1204.2074, -1900.6138, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1282.1816, -1917.2987, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1228.854, -1996.1418, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1316.2496, -1939.9371, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1274.5201, -1670.1108, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1248.0989, -1872.3763, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1284.7854, -1621.6324, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1687.746, -1472.4696, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1813.91, -1429.7793, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-2033.6332, -1371.4224, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1184.2913, -215.0329, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(-1220.1719, -144.85063, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2035.4453, 1290.7327, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2104.8962, 1369.0956, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2043.4989, 1431.0049, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1988.6808, 1398.4802, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2058.6357, 1345.527, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(2005.7795, 1534.2081, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1795.4983, 1378.0651, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1731.7164, 1476.6526, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1795.0334, 1556.7158, 30));
		AddSpawnPoint("d_underfortress_68.Id1", "d_underfortress_68", Rectangle(1823.5542, 1649.2413, 30));

		// 'Infroholder_Green' GenType 16 Spawn Points
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1232.039, -1074.065, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1523.3064, -1205.0156, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1454.2628, -986.4707, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1379.3838, -1178.4027, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1318.4633, -1332.5748, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1364.0131, -717.44037, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1366.0023, -558.226, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1273.9845, -1594.6711, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1305.7101, -1883.1603, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-923.167, -996.6277, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1968.0481, -1377.7153, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1759.6558, -1448.2579, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(160.64087, -1544.1877, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1508.8698, 41.1995, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(169.05373, -1638.3826, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-652.4995, 250.60583, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(8.031212, 481.17007, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(709.8196, 210.78813, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(545.59283, 484.2514, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-994.69836, -1825.754, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-587.8217, -1703.9406, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-283.4815, -839.8464, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(200.32341, -641.358, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(590.69684, -660.9447, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(708.07983, -703.9628, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2571.4973, -272.59677, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1278.7236, -1741.3671, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1140.6251, -1916.0994, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-411.74988, -1633.3007, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-831.27075, -1784.4585, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1419.1176, -1076.706, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1315.8904, -933.9065, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1604.0347, -1092.097, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-586.7375, -925.97833, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-424.03558, -881.18115, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(694.9719, -600.22797, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(1776.559, -589.0915, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2246.9592, 242.94072, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(1891.3527, -478.69232, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(1893.0319, -572.1274, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(1834.6971, -608.31793, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(1720.5428, -636.79803, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(1691.2992, -567.3815, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(1616.1788, -582.11804, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(812.694, -534.8204, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(34.120773, -1663.2256, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1223.0142, -244.84384, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(205.20581, -1766.229, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(254.17569, -1532.8937, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1285.2947, 18.458488, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1340.3135, 59.76327, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1224.142, 66.46603, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1331.0884, -17.358139, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1222.9508, -334.83887, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1384.9143, -386.25592, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1411.7893, -265.28784, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1533.3892, -8.350523, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1338.0353, -84.18957, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-1407.9766, -79.29825, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(303.30518, -1622.8738, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2179.329, 475.8359, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2306.3066, 349.84872, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(1956.0494, 1473.6509, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(1868.55, 1563.891, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(1964.8014, 1628.1743, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2155.4385, 615.42114, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(1889.6675, 1409.7329, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2348.459, 448.4281, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2175.0928, 350.03577, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2469.6514, -301.93118, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2555.4402, -427.55142, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2482.9353, -418.9286, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2563.1125, -604.1415, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(2473.0425, -579.46204, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(788.7207, 465.0153, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(916.84186, 552.91626, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(964.46545, 411.5169, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(518.04144, 259.8898, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(758.63983, 564.4768, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(614.74316, 441.2655, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(819.3362, 286.858, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(58.64669, -707.57007, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-86.78611, -845.08704, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(98.64577, -596.38806, 30));
		AddSpawnPoint("d_underfortress_68.Id2", "d_underfortress_68", Rectangle(-80.62313, -765.1581, 30));

		// 'Deadbornscab_Mage_Red' GenType 18 Spawn Points
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(565.5225, 416.35672, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(753.3182, 654.57806, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(681.46094, 530.3538, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(891.119, 286.4654, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(131.86266, -1647.7242, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(48.937706, -1501.2648, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(-110.8726, -1618.2966, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(68.68083, -1737.203, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(1601.0564, -615.65063, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(1601.0564, -615.65063, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(1239.1307, -571.91003, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(2498.5164, -619.0597, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(2167.6313, -472.82986, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(2547.396, -297.02008, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(2501.92, -47.05226, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(2184.8608, 326.36615, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(2317.5273, 525.62994, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(780.1888, -641.26917, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(-94.72538, -708.3646, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(120.55293, -589.96136, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(141.52701, -807.2343, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(52.893127, -700.5521, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(641.0431, -610.5818, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(916.1198, 503.7581, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(244.10611, -1584.9596, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(2422.9893, -391.17282, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(2403.416, 154.02089, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(2133.0933, 211.24008, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(2126.0803, 533.7582, 30));
		AddSpawnPoint("d_underfortress_68.Id3", "d_underfortress_68", Rectangle(2648.7178, -568.1796, 30));

		// 'Deadbornscab_Red' GenType 22 Spawn Points
		AddSpawnPoint("d_underfortress_68.Id4", "d_underfortress_68", Rectangle(-1304, -122, 400));

		// 'Rootcrystal_05' GenType 23 Spawn Points
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(-2566.875, -1286.565, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(-1699.3512, -1474.0022, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(-1378.9105, -1071.5886, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(-1275.5115, -1698.2815, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(-1280.8406, -2093.608, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(-216.08287, -1617.9299, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(337.60663, -1498.5082, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(-1353.1273, -453.60266, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(-1147.8848, 14.54454, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(-257.55768, 464.65234, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(952.458, 567.6498, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(669.1256, 216.05, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(-715.46136, -981.72473, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(-91.69158, -849.83813, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(660.52246, -690.6792, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(1380.7756, -575.35364, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(1897.0236, -575.44604, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(2555.2878, -581.87067, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(2589.2722, -94.34546, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(2130.074, 270.73938, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(2136.1128, 778.0775, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(1793.6854, 1335.1088, 40));
		AddSpawnPoint("d_underfortress_68.Id5", "d_underfortress_68", Rectangle(1999.646, 1660.5043, 40));
	}
}
