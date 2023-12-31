//--- Melia Script -----------------------------------------------------------
// d_velniasprison_54_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for '2nd Demon Prison' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DVelniasprison541MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_velniasprison_54_1.Id1", MonsterId.FD_Yognome, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_54_1.Id2", MonsterId.FD_Long_Arm, 18, 23, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_54_1.Id3", MonsterId.FD_Firent_Yellow, 1, 1, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_54_1.Id4", MonsterId.Treasure_Goblin, 0, 0, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_velniasprison_54_1.Id5", MonsterId.Rootcrystal_04, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_velniasprison_54_1.Id6", MonsterId.FD_Infrogalas_Bow, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_velniasprison_54_1.Id7", MonsterId.FD_Yognome, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'FD_Yognome' GenType 20 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id1", "d_velniasprison_54_1", Rectangle(9.248821, -11.835621, 9999));

		// 'FD_Long_Arm' GenType 32 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-1137.6249, -693.8376, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-1372.2626, -806.58435, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-1264.819, -566.6502, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-1001.8707, -798.14343, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-971.7458, -579.6299, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-133.55797, 709.1034, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-302.0043, 842.6755, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(463.7983, 828.3593, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(872.7762, 39.478195, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(915.62494, 253.87227, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(1100.5916, -9.715155, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(1239.9385, 231.82744, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(292.373, 740.62036, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(-396.93817, 685.27167, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id2", "d_velniasprison_54_1", Rectangle(1072.2236, 166.91063, 25));

		// 'FD_Firent_Yellow' GenType 33 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id3", "d_velniasprison_54_1", Rectangle(932.30347, 94.19976, 100));

		// 'Treasure_Goblin' GenType 34 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-1028.7721, 304.53156, 20));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-913.9122, 858.90564, 20));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-149.49362, 768.46423, 20));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(1119.2732, 103.15617, 20));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(92.734184, 50.609787, 20));
		AddSpawnPoint("d_velniasprison_54_1.Id4", "d_velniasprison_54_1", Rectangle(-1196.7982, -739.2802, 20));

		// 'Rootcrystal_04' GenType 41 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-170.41786, 19.547928, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(258.24307, 93.21041, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-7.4845753, 445.65512, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(441.64288, 764.59985, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-266.74362, 891.3008, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-986.93994, 828.04, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-1059.4888, 234.21434, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-1395.4532, -45.958687, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-1297.8217, -784.77734, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-1004.7156, -588.94604, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(-467.21982, -498.21396, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(833.3135, -501.8186, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(779.1224, 57.26957, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(1267.4897, 156.44907, 10));
		AddSpawnPoint("d_velniasprison_54_1.Id5", "d_velniasprison_54_1", Rectangle(979.73425, 627.0676, 10));

		// 'FD_Infrogalas_Bow' GenType 45 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(182.12701, -87.12333, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(102.05772, 192.40996, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-224.22858, 234.95244, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-39.24786, 410.4346, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-399.1001, 799.83655, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-192.24069, 835.2691, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(839.77136, -559.0459, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(374.05243, 207.43678, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1093.2949, -580.3272, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1084.7949, 862.50854, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-945.9262, 949.0055, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1193.8787, -855.74396, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-1035.0659, 269.32343, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-55.48613, -397.7105, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(966.6663, 191.17017, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(789.4263, -549.4807, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(950.05804, -10.45192, 35));
		AddSpawnPoint("d_velniasprison_54_1.Id6", "d_velniasprison_54_1", Rectangle(-201.91447, 16.607489, 35));

		// 'FD_Yognome' GenType 50 Spawn Points
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-591.74097, -547.1952, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-466.77084, -479.87738, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-476.38364, -556.9702, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(829.1923, -608.61035, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(817.7796, -530.32764, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(841.9343, -467.38446, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(29.925982, 27.552189, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-292.52243, 287.9556, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(80.359695, 321.24698, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(379.35666, 183.2175, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1365.8701, -177.53683, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1396.0887, -101.6291, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1241.0667, -69.35966, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1326.9047, -671.1837, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1086.4121, -820.82227, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1151.7217, -613.08215, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1012.0925, 901.8627, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1114.4243, 953.9806, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1183.6467, 822.2934, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-252.63615, 737.7336, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-121.36774, 837.0146, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-371.96725, 905.5397, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(345.84283, 794.20197, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(444.46088, 678.9735, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(341.78513, 698.48724, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(977.29083, 256.99225, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(1158.1249, -52.45826, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(845.6094, 34.495922, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(1022.7618, 104.84167, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1180.9557, 202.65273, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1017.4752, 190.20494, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-1111.9473, 307.36957, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-193.58435, 175.32166, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-359.56204, -46.51871, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(-159.17162, -49.68956, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(152.63197, -77.99835, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(205.90977, 287.86267, 25));
		AddSpawnPoint("d_velniasprison_54_1.Id7", "d_velniasprison_54_1", Rectangle(205.72893, 86.28242, 25));
	}
}
