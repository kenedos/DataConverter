//--- Melia Script -----------------------------------------------------------
// f_tableland_28_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Stogas Plateau' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland282MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_tableland_28_2.Id1", MonsterId.Rootcrystal_03, 9, 11, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_2.Id2", MonsterId.Siaulav_Blue, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_2.Id3", MonsterId.Siaulav_Mage_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_2.Id4", MonsterId.Siaulav_Bow_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_28_2.Id5", MonsterId.Lapasape_Blue, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 3 Spawn Points
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(1392.402, 1220.2368, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(933.92584, 1032.3647, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(422.00372, 1060.4524, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-25.885551, 1486.519, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-358.4848, 1528.2122, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(294.7456, 678.8673, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(230.13979, 300.9753, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-87.85376, 490.506, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-957.4042, -502.97327, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-1467.5846, -544.401, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-1253.0908, 119.56799, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-869.63, 325.96576, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-1128.3059, 586.80237, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-1374.5454, 1230.6267, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(-1050.6511, 1272.1375, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(984.4451, -470.72488, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(1332.4445, -405.4555, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(1739.187, -31.708527, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(92.534805, -1378.7771, 50));
		AddSpawnPoint("f_tableland_28_2.Id1", "f_tableland_28_2", Rectangle(173.43106, -1863.7079, 50));

		// 'Siaulav_Blue' GenType 30 Spawn Points
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1218.0889, 1151.6741, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-110.88169, 1527.2874, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-269.01974, 1468.3481, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-376.4004, 1662.2955, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(96.125046, 653.579, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-83.96735, 410.3494, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1373.0013, -405.6552, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1412.0286, -268.11304, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1192.9175, -317.08408, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-921.84845, -473.31036, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1035.5863, -752.63226, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1065.8914, -552.8058, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1251.9258, -627.79675, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1354.668, -747.3291, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1220.9744, -495.83093, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1512.7686, -514.81915, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1507.0211, -652.6879, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1422.827, 282.06107, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1303.3424, 724.4274, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1361.3584, 576.15283, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1391.0266, 456.49396, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1226.3273, 562.9677, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1122.2415, 724.6399, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-784.5351, 492.6864, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-928.8526, 614.2711, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-961.6074, 334.56485, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1080.6833, 512.02325, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1151.5133, 348.3833, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1186.4432, 184.58922, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-933.76733, 159.62694, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-803.60345, 284.27536, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-666.7076, 493.0586, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-658.8885, 307.16272, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1012.9023, 49.35369, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1338.5673, 136.15894, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1262.2394, 1404.3635, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1460.573, 1079.903, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1292.4268, 1264.522, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1386.0753, 1343.0343, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1420.5466, 1209.5016, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1202.9972, 1110.4243, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-1129.6349, 1271.5304, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-177.23598, 541.96075, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(92.13305, 499.9135, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-39.09034, 580.62, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(123.396, 286.74057, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(236.40201, 352.55536, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(289.99573, 568.5366, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(227.35541, 759.7904, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-378.71948, 1347.183, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-493.5788, 1540.4565, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-495.31686, 1663.4197, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-394.76837, 1743.4111, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-302.69794, 1765.8685, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-201.3023, 1766.7404, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-165.86967, 1456.0724, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-211.2478, 1284.6954, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-52.059456, 1376.2502, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-158.44595, 1577.5494, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-22.58754, 1575.2936, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-203.29666, 1411.1486, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(-56.034245, 1428.1305, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(481.7199, 1056.6255, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(582.33936, 1145.5696, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(341.85336, 1163.9794, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(287.29974, 1021.8961, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1303.4583, 984.25684, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(983.8241, 1105.1302, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1419.4683, 1264.2816, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1109.2317, 1020.6537, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1353.1794, 1128.4805, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1148.9937, 1304.7422, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1010.0436, -443.768, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1140.5756, -563.8244, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1064.9677, -365.3256, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1322.0743, -447.37967, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1213.4657, -382.0017, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1270.5356, -551.58887, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1323.2389, -627.0968, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1580.7291, -111.72371, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1603.0946, 21.841011, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1753.3771, 82.63402, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1726.7065, -31.675838, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1854.6478, -52.09325, 30));
		AddSpawnPoint("f_tableland_28_2.Id2", "f_tableland_28_2", Rectangle(1665.2458, -175.60197, 30));

		// 'Siaulav_Mage_Blue' GenType 35 Spawn Points
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-265.84506, 1590.3455, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-128.90605, 1308.4352, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(1138.0004, -414.39096, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(906.5167, -411.24683, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(1176.017, -623.711, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-74.57547, -1530.1874, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(274.7243, -1431.1571, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(174.57469, -1852.5262, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-117.21452, -1685.9412, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(226.30862, -1633.0592, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1260.4833, -391.19873, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1467.6337, -569.63727, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1194.4391, -685.89545, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1158.7886, 267.44522, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1484.2188, -310.4664, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-956.5264, 277.43362, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-1254.1945, 681.1259, 30));
		AddSpawnPoint("f_tableland_28_2.Id3", "f_tableland_28_2", Rectangle(-443.67117, 1455.3036, 30));

		// 'Siaulav_Bow_Blue' GenType 40 Spawn Points
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-845.2044, 541.0245, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-938.8951, 392.57782, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1326.8291, 475.2678, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1344.7363, 220.67505, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1374.2803, 1129.7417, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1422.7443, 1305.9147, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1222.7454, 1229.2653, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-1054.8108, -476.92328, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(164.34328, -1489.2334, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(62.29022, -1830.1198, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(1045.659, -402.46344, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(1353.7627, -337.35693, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-758.1968, -538.29675, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-551.31226, -692.4097, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(351.9559, 677.5586, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(27.593739, 536.5581, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(-244.6643, 1597.3065, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(108.16539, 1275.6625, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(1082.7079, 1030.658, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(1669.6564, 63.83821, 30));
		AddSpawnPoint("f_tableland_28_2.Id4", "f_tableland_28_2", Rectangle(1237.122, -616.7253, 30));

		// 'Lapasape_Blue' GenType 43 Spawn Points
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(407.22833, 969.9014, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(95.95073, 437.23346, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1225.4781, -539.6893, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(38.40236, -1354.6017, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(34.762283, -1799.5546, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(892.5574, -512.72766, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1294.4403, -418.88873, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1717.2314, -34.580147, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1276.7798, 1289.4291, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-223.20041, 1540.8708, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(183.47658, 1237.3738, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(259.73468, -1797.8209, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(18.797077, -1980.6042, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-135.83704, -1697.7954, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(97.65615, -1497.7668, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(309.05005, -1627.7705, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(993.47925, -394.9284, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1147.8494, -358.02057, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1100.2076, -560.7784, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1268.4258, -527.45416, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(357.6189, 420.51123, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(22.387054, 566.0089, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(454.83002, 1124.4487, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(306.3236, 1141.32, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-221.41891, 1366.0068, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-406.81592, 1403.5756, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-357.66742, 1627.4714, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-56.912724, 1603.593, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1027.7129, 1309.5076, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1188.2994, 1407.6708, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1371.952, 1347.943, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1373.7052, 1158.063, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1112.5255, 1142.2195, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1233.5035, 635.10706, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-964.57056, 627.6035, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-842.1701, 236.18246, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1249.4797, 180.21878, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1412.4053, -316.72086, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1534.4102, -521.1748, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1453.364, -682.9886, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1204.4635, -744.0792, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-946.8265, -502.40915, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(-1039.6346, 383.19766, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1601.2701, -19.667633, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1686.3591, -129.05084, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(1770.3802, 70.42053, 30));
		AddSpawnPoint("f_tableland_28_2.Id5", "f_tableland_28_2", Rectangle(235.04288, 293.0755, 30));
	}
}
