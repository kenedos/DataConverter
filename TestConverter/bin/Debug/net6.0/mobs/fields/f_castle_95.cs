//--- Melia Script -----------------------------------------------------------
// f_castle_95
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Outer Wall District 13' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCastle95MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_castle_95", MonsterId.Ghoscandle, Properties("MHP", 679998, "MINPATK", 9245, "MAXPATK", 11265, "MINMATK", 9245, "MAXMATK", 11265, "DEF", 176835, "MDEF", 176835));
		AddPropertyOverrides("f_castle_95", MonsterId.Infrogremlin, Properties("MHP", 681483, "MINPATK", 9264, "MAXPATK", 11288, "MINMATK", 9264, "MAXMATK", 11288, "DEF", 177897, "MDEF", 177897));
		AddPropertyOverrides("f_castle_95", MonsterId.Velsoarer, Properties("MHP", 683037, "MINPATK", 9284, "MAXPATK", 11313, "MINMATK", 9284, "MAXMATK", 11313, "DEF", 179008, "MDEF", 179008));
		AddPropertyOverrides("f_castle_95", MonsterId.Boss_Moringponia_Q1, Properties("MHP", 3573912, "MINPATK", 23449, "MAXPATK", 28573, "MINMATK", 23449, "MAXMATK", 28573, "DEF", 454017, "MDEF", 454017));

		// Monster Spawners ---------------------------------

		AddSpawner("f_castle_95.Id1", MonsterId.Ghoscandle, 90, 120, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_95.Id2", MonsterId.Infrogremlin, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_castle_95.Id3", MonsterId.Velsoarer, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Ghoscandle' GenType 1 Spawn Points
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1180.289, -583.02576, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1255.5255, -614.4864, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1282.7833, -789.09784, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1228.0321, -434.895, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1105.0802, -661.00745, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-1138.626, -513.0333, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-974.7966, -584.185, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-985.5115, -730.96796, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-868.6518, -608.86383, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-663.01447, -582.32996, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-362.71594, -758.2332, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-296.87384, -789.4199, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-11.666109, -786.82587, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-145.55748, -933.1242, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-172.39406, -1006.9239, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-154.19356, -1189.6273, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-160.00127, -1505.8916, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-248.96873, -1568.1064, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-123.4489, -1619.4757, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-0.9577422, -1572.4614, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(2.770134, -610.417, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-320.81232, -545.59485, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-226.73909, -397.4453, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-302.29645, -401.10794, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-162.6188, -154.04562, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-159.12567, 36.572876, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-383.5041, 343.78027, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-63.274082, 257.7508, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(-231.42856, 150.23137, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(12.08606, 316.37704, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(7.015068, 184.60938, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(341.34454, 435.0267, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(238.78963, 368.19104, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(30.81097, 997.69995, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(134.64796, 1260.6565, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(211.85294, 1050.659, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(580.765, 968.4768, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(652.1467, 1173.174, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(521.2088, 1140.6052, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(727.156, 960.60956, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(759.2794, 1119.6421, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1161.3994, 1087.8818, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1346.2488, 1096.762, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1289.6182, 1284.5172, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1458.7646, 1278.0237, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1659.731, -1383.4392, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1611.0582, 1177.9032, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1704.4222, 977.5349, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1534.6195, 932.48975, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1814.2632, 1151.0703, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1623.9176, 981.42224, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1326.219, 897.3111, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1341.4009, 744.65515, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(197.8674, 348.31686, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1875.2512, 890.0464, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1802.6364, 754.69977, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1880.3169, 1129.3324, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1585.2888, -1311.707, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1684.6959, -808.92664, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1699.842, 763.1838, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1800.3435, -659.5874, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1405.6272, 350.2717, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1656.4625, -610.6787, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1448.9198, -430.66, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1453.7576, -790.4339, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1011.7212, 362.3537, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1611.5483, -268.15686, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(814.6912, 362.96527, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(538.8609, 421.0762, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(608.17834, 491.75055, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(567.36163, 261.91638, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(496.8415, 221.49458, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(685.50757, 148.83029, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(571.23615, 107.68425, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(351.33386, 267.43848, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(226.07796, -636.4695, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1601.5237, -1410.954, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(562.7719, -523.1883, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(516.4408, -448.65195, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(540.18787, -750.6606, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(917.76544, -656.76917, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(717.3355, -679.651, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(900.5295, -495.65875, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(923.2382, -769.2826, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1645.4154, 106.9418, 20));
		AddSpawnPoint("f_castle_95.Id1", "f_castle_95", Rectangle(1628.9727, -9.78035, 20));

		// 'Infrogremlin' GenType 2 Spawn Points
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1646.7554, 670.558, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-1217.5632, -661.20123, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-1079.2751, -545.4562, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-791.4607, -614.3562, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-528.5127, -589.44904, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-189.7537, -1657.185, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-77.31376, -1505.8928, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-140.21155, -1258.7996, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-147.36938, -801.3591, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(19.444483, -470.556, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-259.39307, -538.45526, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-177.67609, 223.769, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-237.41971, 414.13956, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(-332.1381, 348.75842, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(187.49069, 207.46779, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(300.4868, 351.66736, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(143.59576, 431.13452, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(509.598, 283.35297, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(597.04614, 440.99643, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(604.0879, 148.36781, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(885.02075, 368.85394, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(998.14087, 418.2786, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1839.206, -703.47595, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1295.353, 379.63614, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1631.0199, -210.02876, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1629.4119, 213.36191, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1761.3859, -729.6852, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1569.2213, -779.43884, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1757.0154, -421.37747, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1536.0337, -436.8899, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1625.6383, -1177.3605, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1524.011, -1472.3846, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1626.293, -1479.5469, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1533.8191, 1027.1051, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1734.0264, 1147.8055, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1542.5532, 1255.1073, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1768.6158, 791.83234, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1443.8583, 765.7092, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1324.6216, 1234.0408, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(871.2426, 1080.1632, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(576.21326, 1101.4146, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(117.84266, 1060.4547, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(212.48418, 1235.655, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(44.83496, 1237.6935, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(1434.2222, -610.1855, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(799.61487, -622.5198, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(823.8071, -828.27026, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(282.60898, -593.9894, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(699.44037, -393.78983, 20));
		AddSpawnPoint("f_castle_95.Id2", "f_castle_95", Rectangle(543.2836, -672.0382, 20));

		// 'Velsoarer' GenType 3 Spawn Points
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(1591.647, -662.92053, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(1639.5464, 1089.2107, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(1618.3688, 747.27435, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(1263.6044, 1085.6055, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(685.09155, 1057.4231, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(141.66687, 1155.4672, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(-139.79962, 397.85065, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(181.94281, 297.2313, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(602.8711, 348.07318, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(773.5602, -749.75543, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(629.9587, -472.08353, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(-149.77235, -477.54724, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(-1121.4211, -708.5549, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(1629.8689, -377.20453, 40));
		AddSpawnPoint("f_castle_95.Id3", "f_castle_95", Rectangle(-340.44394, 207.29271, 40));
	}
}
