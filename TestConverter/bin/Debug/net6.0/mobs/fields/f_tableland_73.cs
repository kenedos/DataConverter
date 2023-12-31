//--- Melia Script -----------------------------------------------------------
// f_tableland_73
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Kadumel Cliff' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland73MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_tableland_73", MonsterId.Wendigo_Archer_Gray, Properties("MHP", 395071, "MINPATK", 5581, "MAXPATK", 6761, "MINMATK", 5581, "MAXMATK", 6761, "DEF", 43182, "MDEF", 43182));
		AddPropertyOverrides("f_tableland_73", MonsterId.Tiny_Bow_Blue, Properties("MHP", 396463, "MINPATK", 5599, "MAXPATK", 6783, "MINMATK", 5599, "MAXMATK", 6783, "DEF", 43625, "MDEF", 43625));
		AddPropertyOverrides("f_tableland_73", MonsterId.Hohen_Gulak_Blue, Properties("MHP", 398003, "MINPATK", 5619, "MAXPATK", 6808, "MINMATK", 5619, "MAXMATK", 6808, "DEF", 44116, "MDEF", 44116));

		// Monster Spawners ---------------------------------

		AddSpawner("f_tableland_73.Id1", MonsterId.Wendigo_Archer_Gray, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_73.Id2", MonsterId.Tiny_Bow_Blue, 45, 60, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_73.Id3", MonsterId.Hohen_Gulak_Blue, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_tableland_73.Id4", MonsterId.Rootcrystal_03, 19, 25, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_tableland_73.Id5", MonsterId.Tiny_Bow_Blue, 4, 5, TimeSpan.FromMilliseconds(40000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Wendigo_Archer_Gray' GenType 1 Spawn Points
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(1163.4784, -182.88493, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(928.6006, -243.35081, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(342.18597, 13.519333, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(-123.74695, 153.67111, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(-358.56937, 578.68823, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(-1407.4718, -388.0772, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(-1155.983, -288.20752, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(-845.28436, -208.10414, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(-735.8999, -664.49066, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(-842.95135, -987.0322, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(-852.0322, -1228.0957, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(320.11462, -1360.9601, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(392.13074, -1162.2239, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(115.39487, -1147.7969, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(116.15191, -731.9041, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(41.65725, -461.88965, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(1445.792, 196.88799, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(1277.6085, 758.2844, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(1005.0402, 507.35504, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(897.1247, 783.9432, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(738.3719, 512.37286, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(238.1584, 706.6896, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(327.38937, 975.2203, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(514.5646, 946.92993, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(150.72432, 846.2317, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(-606.05194, 670.39685, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(540.0649, 251.62274, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(243.61453, 178.42168, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(848.8988, -90.6376, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(1079.4073, 53.64847, 30));
		AddSpawnPoint("f_tableland_73.Id1", "f_tableland_73", Rectangle(1376.2535, 495.07367, 30));

		// 'Tiny_Bow_Blue' GenType 2 Spawn Points
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-93.8185, -616.8168, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(395.53577, -158.56929, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-83.050446, 168.8258, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-370.2242, 462.78644, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-296.45804, 690.9464, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-603.13434, 643.4405, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-948.6117, -202.84702, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-815.28033, -490.60233, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-700.8174, -803.1997, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-983.5505, -1055.0701, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-779.56976, -1261.7667, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-788.01227, -871.9064, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-1473.8568, -461.7625, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-1581.1962, -216.88553, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-1099.941, -312.58844, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(371.01773, 156.65945, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1143.7173, 38.528328, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1392.123, 192.46638, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1265.8118, 770.9482, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(738.3198, 626.93097, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(738.3198, 626.93097, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(867.9205, 1106.2473, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(496.05017, 926.829, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(324.86896, 1046.3729, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(204.44301, 729.84753, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(72.74461, -420.32312, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(239.46613, -363.23282, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-39.078266, -168.79593, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(256.18237, -47.93696, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1203.5034, 522.3592, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1057.262, 814.36914, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1248.0502, 1046.3259, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1074.405, 1081.2909, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1179.2024, 1275.1313, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1337.7429, 1264.6107, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1222.5603, 1165.9438, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1404.4727, 1063.3693, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(873.3629, 461.6254, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(974.2046, 662.562, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1002.7637, -220.99193, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1340.3027, -185.56343, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1320.813, -36.97234, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(830.5028, -172.75891, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1168.7888, -264.36703, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(1089.8843, -113.29924, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-738.3482, -315.44138, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-229.51923, 367.1068, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-488.5821, -295.0084, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(82.6364, -600.4984, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(153.41081, -1018.5123, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(151.23474, -1197.4962, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(187.03049, -1314.5503, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(396.79855, -1321.8971, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(315.24872, -1192.1868, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(244.25813, -1054.4012, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-956.1859, -1261.2274, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-833.93036, -1180.6764, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-1643.5795, -384.11212, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-1369.0258, -323.46103, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-1461.6086, -320.64273, 30));
		AddSpawnPoint("f_tableland_73.Id2", "f_tableland_73", Rectangle(-851.85187, -337.9791, 30));

		// 'Hohen_Gulak_Blue' GenType 3 Spawn Points
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(250.82367, -1192.5671, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(143.32529, -459.65582, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(-1500.2622, -357.2382, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(-886.8115, -1163.4266, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(-744.3014, -328.9267, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(-354.9857, 567.95953, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(1052.9849, -233.98682, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(1207.7087, 618.1361, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(293.5898, 61.041237, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(-804.09094, -890.1731, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(-823.9658, -874.8289, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(-180.99243, 299.05786, 30));
		AddSpawnPoint("f_tableland_73.Id3", "f_tableland_73", Rectangle(297.08636, 890.16254, 30));

		// 'Rootcrystal_03' GenType 8 Spawn Points
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(1235.0723, -1296.2388, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(926.5205, -1280.2971, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(600.3348, -1315.2461, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(262.4656, -1227.0198, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(146.74762, -782.0784, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(168.88066, -399.19882, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-151.30313, -139.95921, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(441.63892, -176.19316, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(307.12592, 181.50967, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-496.28326, -365.66583, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-896.1836, -1191.1588, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-754.3007, -928.5487, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-803.3622, -457.11026, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-1065.789, -214.73181, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-1494.3949, -301.6688, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-1515.3748, -525.1985, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-124.32533, 301.26617, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-357.93146, 506.05655, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-533.2109, 743.6689, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(-98.95297, 759.8958, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(241.71632, 711.0537, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(417.11356, 933.5137, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(721.5085, 982.0627, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(1052.4088, 1124.7577, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(1358.4172, 1423.2029, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(1313.617, 1059.3925, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(884.02026, 480.51288, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(915.3694, -240.15167, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(1278.1122, -195.1915, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(1320.5112, 88.68729, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(1399.6953, 537.6924, 40));
		AddSpawnPoint("f_tableland_73.Id4", "f_tableland_73", Rectangle(1204.531, 700.62146, 40));

		// 'Tiny_Bow_Blue' GenType 28 Spawn Points
		AddSpawnPoint("f_tableland_73.Id5", "f_tableland_73", Rectangle(-683.771, -1131.1244, 40));
		AddSpawnPoint("f_tableland_73.Id5", "f_tableland_73", Rectangle(-911.2254, -895.73596, 40));
		AddSpawnPoint("f_tableland_73.Id5", "f_tableland_73", Rectangle(-794.8904, -1302.6974, 40));
		AddSpawnPoint("f_tableland_73.Id5", "f_tableland_73", Rectangle(-970.8607, -1302.9135, 40));
		AddSpawnPoint("f_tableland_73.Id5", "f_tableland_73", Rectangle(-1004.7429, -1104.2147, 40));
	}
}
