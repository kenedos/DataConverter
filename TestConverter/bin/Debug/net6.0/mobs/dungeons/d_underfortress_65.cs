//--- Melia Script -----------------------------------------------------------
// d_underfortress_65
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Sentry Bailey' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DUnderfortress65MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_underfortress_65", MonsterId.Ticen_Blue, Properties("MHP", 284230, "MINPATK", 4156, "MAXPATK", 5010, "MINMATK", 4156, "MAXMATK", 5010, "DEF", 18382, "MDEF", 18382));
		AddPropertyOverrides("d_underfortress_65", MonsterId.Ticen_Bow_Blue, Properties("MHP", 285848, "MINPATK", 4177, "MAXPATK", 5035, "MINMATK", 4177, "MAXMATK", 5035, "DEF", 18682, "MDEF", 18682));
		AddPropertyOverrides("d_underfortress_65", MonsterId.Socket_Red, Properties("MHP", 287536, "MINPATK", 4199, "MAXPATK", 5062, "MINMATK", 4199, "MAXMATK", 5062, "DEF", 18995, "MDEF", 18995));
		AddPropertyOverrides("d_underfortress_65", MonsterId.Socket_Bow_Purple, Properties("MHP", 289290, "MINPATK", 4221, "MAXPATK", 5090, "MINMATK", 4221, "MAXMATK", 5090, "DEF", 19320, "MDEF", 19320));
		AddPropertyOverrides("d_underfortress_65", MonsterId.Silvertransporter_Qm, Properties("MHP", 291108, "MINPATK", 4244, "MAXPATK", 5118, "MINMATK", 4244, "MAXMATK", 5118, "DEF", 19657, "MDEF", 19657));

		// Monster Spawners ---------------------------------

		AddSpawner("d_underfortress_65.Id1", MonsterId.Silvertransporter_Qm, 3, 4, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id2", MonsterId.Ticen_Blue, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id3", MonsterId.Ticen_Bow_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_65.Id4", MonsterId.Socket_Red, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_65.Id5", MonsterId.Silvertransporter_Qm, 1, 1, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id6", MonsterId.Silvertransporter_Qm, 1, 1, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id7", MonsterId.Silvertransporter_Qm, 1, 1, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id8", MonsterId.Silvertransporter_Qm, 1, 1, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_underfortress_65.Id9", MonsterId.Socket_Bow_Purple, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_underfortress_65.Id10", MonsterId.Rootcrystal_05, 11, 14, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Silvertransporter_Qm' GenType 6 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id1", "d_underfortress_65", Rectangle(458.2367, -709.408, 20));

		// 'Ticen_Blue' GenType 10 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(942.2028, 50.914707, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(853.06976, -411.94156, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-53.440044, -447.90323, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(652.75653, -941.1945, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-756.7163, -36.57689, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(50.949566, -1078.0887, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1280.2754, 92.11101, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(58.0715, -157.84583, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(462.4886, 416.08954, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-592.5507, -560.2704, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-678.4597, -961.8331, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-208.64761, -936.3377, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(781.70685, -103.83162, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1511.182, 653.9873, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1927.1041, 339.29465, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-564.2165, -253.56628, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-61.29343, -166.99678, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(280.0296, -721.91486, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(626.1226, -457.53207, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(410.92227, -71.25177, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(355.9235, -1132.5176, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-601.41174, -725.4871, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-315.30716, -624.91437, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-968.8908, -57.916, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1542.3632, 379.97034, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(424.91968, 640.02594, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1407.8871, 226.97653, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1748.5092, 173.02643, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1819.3762, 243.95879, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1844.955, 333.92212, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1731.1714, 460.99762, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1526.4252, 247.61801, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1489.3367, 175.71796, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1652.3867, 171.93881, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1580.0392, 233.30118, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1574.1498, 111.42027, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1868.4698, 431.87045, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1776.9016, 529.5735, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1658.6329, 470.72025, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1744.6682, 294.1883, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1864.8771, 165.09097, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1669.9607, 384.26746, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1658.7825, 280.22708, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1527.9236, 433.93408, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1522.344, 551.5451, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1550.8992, 646.47046, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1351.3901, 841.0658, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1344.2358, 912.6107, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1511.4528, 966.6347, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1463.3788, 800.2992, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1436.6951, 949.8923, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1521.0402, 860.72205, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1557.5319, 912.7251, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1572.9325, 986.45917, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1374.6086, 996.3914, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-1620.637, 936.5154, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-652.29724, -1007.7497, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-643.5775, -880.34045, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-576.69635, -701.86743, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-45.8907, -625.26276, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(-22.10951, -548.0762, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(325.21783, -739.05743, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(240.96237, -725.8526, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(410.01065, -732.71814, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(588.1014, -626.65137, 60));
		AddSpawnPoint("d_underfortress_65.Id2", "d_underfortress_65", Rectangle(591.7043, -590.43646, 60));

		// 'Ticen_Bow_Blue' GenType 11 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(442.9946, 743.5035, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(460.11548, 353.37085, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(574.79224, -331.72577, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(639.5468, -581.06635, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(467.83948, -720.9336, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(195.81017, -721.8739, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-250.2285, -649.4924, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-454.6681, -581.9023, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-569.78217, -935.3669, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-596.00574, -773.4429, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-49.180485, -591.60333, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(307.00058, -1099.1012, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-123.60304, -1073.9622, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(867, -125.11084, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(1059.9692, -184.90863, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(835, -385, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(595.3488, 514.10205, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(303.71597, 545.5613, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-1019.5855, -18.840788, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-739.02234, 6.2417297, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-1792.1462, 88.70067, 30));
		AddSpawnPoint("d_underfortress_65.Id3", "d_underfortress_65", Rectangle(-1470.0032, 311.55963, 30));

		// 'Socket_Red' GenType 12 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1528.6956, 493.8097, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-927.41254, -2.9091644, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-623.82056, -94.465996, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-521.6066, -565.5877, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-611.6519, -917.1038, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-195.30101, -933.48895, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-59.77623, -1249.0918, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(253.66168, -1047.1486, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-85.17091, -1097.7019, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(175.85559, -1151.3563, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-49.169968, -715.18164, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(8.554375, -466.38824, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(154.66196, -199.51091, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-33.90425, -132.99797, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(273.59338, -774.7699, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(606.8295, -339.51233, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(378.31808, -51.440063, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(377.38184, 468.56305, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(582.4705, 723.07965, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(357.35806, 627.763, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(990.2122, 322.58878, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(894.7051, -157.76805, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1044.8469, -178.33853, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(890.72156, -385.7891, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(844.5654, 45.1868, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1916.9994, 253.4094, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1600.5234, 346.5564, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1871.1641, 509.6286, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1624.8016, 38.956863, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-594.9884, -745.0379, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-231.61356, -640.41376, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-394.6514, -953.05975, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-723.111, -95.71769, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1060.5137, -10.140991, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1769.9425, 403.0368, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(30.650826, -263.58276, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-109.21569, -452.80917, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-50.13746, -657.8847, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-57.283943, -583.0014, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-182.24818, -448.19168, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(422.6822, -702.41174, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(648.0299, -516.3441, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(130.40489, -1039.4996, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(644.14014, -973.4568, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(892.8865, -801.3502, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(860.87585, -203.33963, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(795.83997, -869.208, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(900.70575, -567.6445, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(466.85303, 252.29347, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(506.2433, 79.314606, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(488.50616, 675.7792, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(550.2685, 533.4782, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(606.13184, -575.6177, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-648.5785, -290.05676, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1253.6985, 63.48017, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-1433.8755, 884.6215, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1016.0695, 374.4969, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(959.847, 279.90793, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(903.6221, 321.1323, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(959.1166, 385.5963, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(863.003, 364.50787, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1026.3973, 427.8376, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1035.0763, 494.95425, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(992.49835, 537.86487, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(931.18005, 540.239, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(838.95624, 475.9927, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(878.9013, 268.2528, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(790.80365, 434.79416, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(907.6519, 436.4039, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(949.8322, 480.4222, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(948.65497, 335.602, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(868.45233, -22.125954, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(932.98926, -63.955566, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(814.8848, -164.58116, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(938.50085, -131.37201, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(914.1905, -230.21196, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1039.3174, -231.80219, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1120.5582, -212.37395, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1117.6077, -133.5449, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1047.7821, -108.9438, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(996.9772, -170.88579, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(943.4772, -354.60477, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(886.1977, -317.53174, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(813.9609, -330.953, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(985.5879, -308.4461, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(988.4352, -254.14465, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(836.5543, -245.61728, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(913.63824, -272.37262, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1162.4144, -161.84537, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(1101.5424, -62.370415, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(987.6539, -63.352127, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(924.40576, -638.29504, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(881.9904, -851.0827, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(834.08374, -805.3198, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(741.402, -876.5671, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(771.2135, -812.7402, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(706.1221, -966.58936, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(697.2545, -912.94354, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(611.4215, -919.23706, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(603.29504, -1000.8066, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(636.61774, -1017.1202, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(318.24957, -1149.8894, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(346.94928, -1051.4546, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(300.35223, -1047.8715, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(251.04507, -1119.0719, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(269.36932, -1181.8914, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(201.97173, -1223.6757, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(118.27049, -1181.9127, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(127.60699, -1114.0721, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(203.9188, -1092.0936, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(92.0768, -1064.9453, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(17.611197, -1131.5701, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-62.261314, -1179.777, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-140.18411, -1181.0973, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-44.05945, -1088.4374, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-69.659615, -1025.7726, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-165.71193, -1046.2684, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-148.04607, -1132.0045, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-155.7469, -969.5372, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-608.3207, -1039.511, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-577.70013, -981.7855, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-678.3217, -904.93756, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-622.9685, -971.74365, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-406.09723, -616.2753, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-405.54315, -577.4974, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-282.66724, -660.06226, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-162.1836, -408.9687, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-188.32132, -493.37885, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(-150.7318, -370.99084, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(145.01213, -244.61401, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(153.23636, -137.24995, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(88.40973, -243.0064, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(0.349411, -209.48787, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(20.29769, -132.75574, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(105.03505, -117.17041, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(123.74106, -281.436, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(498.91208, 298.96503, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(426.90674, 305.09805, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(509.58835, 372.20895, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(521.2048, 434.70767, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(426.44333, 405.72073, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(282.27435, 497.51788, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(372.82678, 553.74835, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(304.88266, 600.8778, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(429.70633, 589.0779, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(363.94833, 691.0939, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(506.10272, 725.2708, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(428.60397, 699.92413, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(426.60294, 793.5377, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(510.30182, 757.3119, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(494.15826, 48.789528, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(464.86923, 111.06983, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(526.77295, 126.86536, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(434.5207, 40.563206, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(386.21378, -100.05887, 30));
		AddSpawnPoint("d_underfortress_65.Id4", "d_underfortress_65", Rectangle(397.09128, -139.202, 30));

		// 'Silvertransporter_Qm' GenType 17 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id5", "d_underfortress_65", Rectangle(965.4435, -746.9342, 20));

		// 'Silvertransporter_Qm' GenType 18 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id6", "d_underfortress_65", Rectangle(-22.83236, -446.5052, 20));

		// 'Silvertransporter_Qm' GenType 19 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id7", "d_underfortress_65", Rectangle(-649.72894, -107.09027, 20));

		// 'Silvertransporter_Qm' GenType 21 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id8", "d_underfortress_65", Rectangle(550.0936, -1030.8451, 20));

		// 'Socket_Bow_Purple' GenType 33 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id9", "d_underfortress_65", Rectangle(-560.6277, -256.36035, 9999));

		// 'Rootcrystal_05' GenType 37 Spawn Points
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(26.63301, -1146.1262, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(1009.542, -867.47833, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(1022.1497, -57.56157, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(933.94543, 410.0882, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(-593.33594, -1026.2644, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(-767.48755, -108.52126, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(-1499.1063, 170.23013, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(-1530.6952, 1015.0682, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(105.10297, -311.1862, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(635.3095, -742.22577, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(488.24503, 17.528393, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(494.72327, 606.966, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(263.31543, 1151.9095, 40));
		AddSpawnPoint("d_underfortress_65.Id10", "d_underfortress_65", Rectangle(28.364513, 1564.9803, 40));
	}
}
