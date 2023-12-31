//--- Melia Script -----------------------------------------------------------
// f_farm_47_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Tenants' Farm' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFarm471MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_farm_47_1", MonsterId.Pino_White, Properties("MHP", 176768, "MINPATK", 2774, "MAXPATK", 3311, "MINMATK", 2774, "MAXMATK", 3311, "DEF", 5216, "MDEF", 5216));
		AddPropertyOverrides("f_farm_47_1", MonsterId.Geppetto_White, Properties("MHP", 177760, "MINPATK", 2787, "MAXPATK", 3327, "MINMATK", 2787, "MAXMATK", 3327, "DEF", 5306, "MDEF", 5306));

		// Monster Spawners ---------------------------------

		AddSpawner("f_farm_47_1.Id1", MonsterId.Pino_White, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_1.Id2", MonsterId.Geppetto_White, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_1.Id3", MonsterId.Pino_White, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_farm_47_1.Id4", MonsterId.Rootcrystal_01, 23, 30, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Pino_White' GenType 45 Spawn Points
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1279.0878, 390.10654, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-524.14703, 933.3321, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-570.031, 753.034, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-243.0736, -1261.012, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-32.58866, -434.46704, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(286.16183, 373.71765, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1070.0825, 159.42735, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1196.8018, 513.24915, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(256.0715, 273.26685, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(120.47566, -504.91037, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(35.41337, -421.3738, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-89.41778, -394.3752, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-96.012245, -340.1147, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(157.0082, -428.45306, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(213.24081, -396.06873, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(211.45522, -342.9827, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(178.80263, -274.3097, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(111.7901, -272.26334, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(16.072994, -296.5089, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(13.80374, -363.57382, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(87.440865, -354.85327, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(32.784786, -464.70813, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-230.854, -172.92111, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-148.14716, -242.99721, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-70.20195, -220.66101, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-293.6359, -117.53346, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-252.56143, -90.36818, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-44.270405, -285.9281, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-332.4985, -119.92153, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-334.5677, -1152.7565, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-397.07303, -1092.9081, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-240.75313, -1138.9326, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-197.8622, -1188.8027, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-172.97061, -1263.3284, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-168.26404, -1123.2784, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-300.07135, -1035.1185, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-262.7324, -1003.9783, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-209.95909, -1014.0553, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-201.97296, -1070.2223, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-110.37013, -1150.3451, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-62.434166, -1155.4563, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-36.52233, -1099.1315, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(548.11774, -1245.7115, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(589.51, -1207.2341, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(457.82544, -1282.7695, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(360.5342, -1234.9415, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(265.40063, -1145.3177, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(320.42047, -1050.7462, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(422.6207, -979.44446, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(487.40738, -979.7001, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(561.5877, -1020.3775, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(605.8074, -1079.8568, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(535.75836, -1117.464, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(464.6993, -1129.899, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(369.20538, -1153.234, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(337.6724, -994.9875, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(414.07162, -1017.3639, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-980.4966, 226.7357, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1092.4519, 214.98668, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1084.7926, 291.0304, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-969.7477, 362.81326, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-938.5575, 308.4515, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-879.0368, 282.4757, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-942.47156, 170.0442, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-818.55414, 246.15161, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-828.73486, 325.40057, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-827.3196, 379.438, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1024.6521, 276.9148, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-988.24365, 102.29476, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-895.3108, 136.28563, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1234.7825, 673.6474, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1157.6365, 442.7608, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1290.6638, 605.18274, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1166.9326, 727.60657, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1113.5607, 663.39984, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1105.5917, 557.05914, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-1033.2081, 605.53125, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-996.4875, 523.0228, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-589.0636, 849.5147, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-738.17017, 871.24854, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-699.4174, 960.1942, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-561.21375, 972.11536, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-521.0158, 863.10406, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-541.2998, 666.723, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-673.75916, 713.1063, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-754.86646, 766.98065, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-641.6637, 930.5488, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-463.21255, 788.7671, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-406.4124, 820.2367, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-459.51276, 688.2032, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-34.806824, 1020.2744, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(163.73512, 976.02594, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(42.056076, 1139.8619, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-45.907646, 1113.1896, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(-25.254898, 1192.6554, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(32.48034, 1254.3969, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(167.81094, 1235.9635, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(180.32446, 1084.0289, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(103.48203, 1016.8356, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(329.94107, 1083.998, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(348.35706, 1142.2416, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(294.3687, 1166.7491, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(145.96179, 1184.5128, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(142.25098, 1316.5952, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(311.0567, 1250.0024, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(259.02383, 1448.0432, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(190.07649, 1402.779, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(92.54387, 1379.6711, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(627.4475, 233.66035, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(567.0525, 153.17632, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(497.06827, 183.35872, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(373.44632, 185.98979, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(305.58856, 243.07535, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(208.85793, 388.15982, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(457.03674, 331.90594, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(549.46014, 443.6157, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(308.8429, 478.47467, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(376.3162, 489.3485, 25));
		AddSpawnPoint("f_farm_47_1.Id1", "f_farm_47_1", Rectangle(357.5214, 348.43823, 25));

		// 'Geppetto_White' GenType 46 Spawn Points
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(838.5214, 287.201, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1303.9583, 198.147, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(702.1288, -100.05706, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1419.3867, -905.1768, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1392.8119, 922.4491, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(-353.2739, -1088.4767, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(-104.57017, -1057.8112, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(358.2611, -1102.5142, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(539.43604, -1072.5752, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(510.09244, -1269.5312, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1232.66, 312.7343, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1350.7747, -1264.5216, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1470.8103, -1273.8217, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1307.5247, -1139.4899, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1208.6005, -1214.1562, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1157.4076, -1128.6499, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1162.0355, -1020.1219, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1423.006, -1155.7327, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1539.4521, -1269.0602, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1597.594, -1144.3402, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1489.1053, -1070.8466, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1379.3912, -1068.9824, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1381.5487, -976.6958, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1268.3905, -1017.739, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1230.6439, -824.4109, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1202.9429, -925.33203, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1321.1952, -807.66315, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(677.4528, -130.4472, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(688.4007, -62.78395, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(741.08075, -82.12555, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(790.416, 368.56863, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(998.9899, 374.3108, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1009.828, 138.34644, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(846.58136, 129.06209, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(924.8301, 184.66325, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1081.6792, 206.22206, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1064.3174, 316.91232, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1054.402, 484.67215, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(914.3333, 356.56354, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(874.1562, 482.72485, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(946.14, 502.61646, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1088.8925, 384.9925, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1356.6249, 276.8682, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1273.0579, 177.33363, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1326.5547, 83.619354, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1431.6356, 131.33244, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1548.8867, 195.58398, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1464.2743, 233.88634, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1423.3649, 363.11334, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1298.1002, 408.14618, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1523.092, 315.40128, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1504.9791, 396.73453, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1367.1401, 463.12878, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1135.5267, 1100.4539, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1426.6215, 1037.7925, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1553.3434, 1015.4596, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1509.8829, 950.9916, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1300.5197, 854.0773, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1179.0536, 927.9478, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1320.3636, 1080.6604, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1240.6615, 1214.2592, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1339.3414, 1220.6301, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(1436.9398, 1190.6139, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(255.86853, -114.80277, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(156.98405, -113.93848, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(98.29892, -47.001656, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(-51.739456, 109.56873, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(-159.74403, 200.96472, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(13.255564, 38.982918, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(153.02534, 39.21856, 25));
		AddSpawnPoint("f_farm_47_1.Id2", "f_farm_47_1", Rectangle(397.33652, -74.61423, 25));

		// 'Pino_White' GenType 47 Spawn Points
		AddSpawnPoint("f_farm_47_1.Id3", "f_farm_47_1", Rectangle(315.51193, 471.60495, 9999));

		// 'Rootcrystal_01' GenType 49 Spawn Points
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-1226.0215, -216.43379, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-994.4216, -304.11343, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-1104.571, -1123.1056, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-750.32404, -1112.0879, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-297.4526, -1146.5016, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-398.22763, -555.3722, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(275.5695, -1104.9153, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(567.8399, -1173.7593, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-823.71204, -838.13617, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-568.65356, -227.32721, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-608.8809, 99.42105, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-1013.0719, 237.17256, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-1168.7964, 613.77734, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-587.21, 838.85345, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-153.74026, 686.6226, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(62.17588, 1073.1508, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(208.80981, 1297.3323, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(-258.06766, 230.78587, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(218.52739, 416.5855, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(480.03766, 409.73746, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(3.1063995, -316.02625, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(185.82751, -58.32109, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(597.10333, -328.39346, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(832.15674, -646.1972, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1367.4937, -823.89343, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1302.4802, -1229.8955, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1341.3641, 106.58267, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1481.6022, 424.375, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1047.0807, 258.93677, 20));
		AddSpawnPoint("f_farm_47_1.Id4", "f_farm_47_1", Rectangle(1117.7179, 630.77637, 20));
	}
}
