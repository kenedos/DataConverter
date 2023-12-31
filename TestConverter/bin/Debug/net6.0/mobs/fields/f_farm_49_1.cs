//--- Melia Script -----------------------------------------------------------
// f_farm_49_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Greene Manor' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FFarm491MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_farm_49_1", MonsterId.Lizardman_Orange, Properties("MHP", 218985, "MINPATK", 3317, "MAXPATK", 3978, "MINMATK", 3317, "MAXMATK", 3978, "DEF", 9064, "MDEF", 9064));
		AddPropertyOverrides("f_farm_49_1", MonsterId.Tama_Orange, Properties("MHP", 219256, "MINPATK", 3320, "MAXPATK", 3982, "MINMATK", 3320, "MAXMATK", 3982, "DEF", 9100, "MDEF", 9100));
		AddPropertyOverrides("f_farm_49_1", MonsterId.Rambear_Bow, Properties("MHP", 219750, "MINPATK", 3327, "MAXPATK", 3990, "MINMATK", 3327, "MAXMATK", 3990, "DEF", 9166, "MDEF", 9166));

		// Monster Spawners ---------------------------------

		AddSpawner("f_farm_49_1.Id1", MonsterId.Lizardman_Orange, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_1.Id2", MonsterId.Lizardman_Orange, 15, 20, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_1.Id3", MonsterId.Tama_Orange, 19, 25, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_1.Id4", MonsterId.Tama_Orange, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Aggressive);
		AddSpawner("f_farm_49_1.Id5", MonsterId.Rambear_Bow, 12, 15, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner("f_farm_49_1.Id6", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Lizardman_Orange' GenType 4 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-235.41682, -1334.5485, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(55.763515, -1238.7554, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-248.85463, -1188.2494, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1176.7516, -415.0188, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1208.9819, -625.62537, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1053.459, -597.2372, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1018.3329, -432.5054, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1412.7449, -519.5086, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1075.7845, -800.7436, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-1125.0028, -205.19783, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-890.61884, -553.1397, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-48.988068, -1278.231, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-301.41968, -1421.7988, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(-85.555626, -1464.838, 25));
		AddSpawnPoint("f_farm_49_1.Id1", "f_farm_49_1", Rectangle(77.10103, -1462.6211, 25));

		// 'Lizardman_Orange' GenType 5 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2227.7622, -402.26837, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2404.1094, -391.63815, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1744.6232, -114.20374, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2265.9875, -199.04251, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2430.3528, -16.99744, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2287.3347, 20.08095, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1201.6609, -915.1346, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1376.54, -1246.3975, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1541.632, -1046.4554, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1148.6647, -1143.4158, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1436.3667, -243.19083, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1328.5933, -30.523407, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1633.1499, -237.28693, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1519.6154, -61.496246, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1352.5311, -1017.8901, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1723.8711, 33.34102, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2488.349, -203.03673, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2103.2834, -514.5723, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2407.256, 105.21729, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1362.7687, -1120.5533, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1362.9437, -858.57434, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1168.9531, -1008.4937, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1568.5055, 43.936157, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1514.6072, -149.9625, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2411.089, -141.75755, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2360.024, -288.4577, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(2102.1973, -248.34085, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1162.2937, -100.25309, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1593.9214, 329.7978, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1323.6924, 246.57295, 30));
		AddSpawnPoint("f_farm_49_1.Id2", "f_farm_49_1", Rectangle(1127.5348, 58.141945, 30));

		// 'Tama_Orange' GenType 6 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(599.2363, 850.7784, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(796.48505, 689.6938, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(595.2994, 488.3968, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(445.8094, 747.2615, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(366.59354, 484.5518, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(173.4006, 933.2012, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(476.97736, 1097.4851, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-619.6948, 604.5285, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-687.2253, 868.33044, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-360.54962, 803.08997, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-295.81897, 555.97394, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(599.93616, -581.45605, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(665.7822, -363.98456, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(870.83026, -615.0724, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(932.61115, -368.72983, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-476.674, 712.34033, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-602.3315, 428.99338, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-349.78906, 498.46274, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-737.2421, 540.27277, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-776.30347, 715.0436, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-469.05374, 881.8803, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(-230.76186, 781.99304, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(581.37195, 650.4261, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(758.4502, 410.0992, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(276.95374, 703.7202, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(791.25867, -480.35446, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(710.7109, -125.7838, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(1027.7095, -250.93532, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(482.10184, -465.56354, 25));
		AddSpawnPoint("f_farm_49_1.Id3", "f_farm_49_1", Rectangle(689.7938, -722.4826, 25));

		// 'Tama_Orange' GenType 7 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id4", "f_farm_49_1", Rectangle(568.2588, 246.25778, 9999));

		// 'Rambear_Bow' GenType 8 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1049.0701, -449.35037, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-935.7313, -1422.8204, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-736.6309, -1375.0466, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-827.2724, -1117.1088, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-958.9066, -1180.2117, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1272.2942, -568.9276, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1183.9015, 260.34418, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1162.8494, 652.56915, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-944.75134, 300.07352, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1927.3054, 310.2733, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1898.3492, -58.26934, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-820.8494, -1591.1411, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-731.1949, -1249.6953, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1287.8685, -378.44205, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1060.0148, 437.8436, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1098.4595, 61.20079, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1291.4305, 484.94748, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-910.49536, 538.01416, 25));
		AddSpawnPoint("f_farm_49_1.Id5", "f_farm_49_1", Rectangle(-1068.2673, -627.61194, 25));

		// 'Rootcrystal_01' GenType 33 Spawn Points
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(290.75974, 550.47125, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(1576.138, -14.640915, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(1527.6458, -255.8555, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(1298.078, -1054.1649, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(1450.4464, -1153.428, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(2316.6145, -378.77167, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(2389.2246, -123.71835, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(896.8309, 675.7899, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(496.67432, 917.9286, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(659.73474, 478.9793, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-344.03806, 740.0416, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-638.77026, 548.56323, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(789.3286, -289.46402, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(974.6723, -592.4241, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(692.9347, -547.19006, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-89.78693, -1137.3213, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-69.01866, -1406.3617, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1026.3429, -499.7965, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1258.8026, -648.2118, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-840.35913, -1256.7782, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-819.8685, -1531.072, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1044.4266, 192.22464, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1141.9974, 676.2736, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1811.8018, 309.1311, 50));
		AddSpawnPoint("f_farm_49_1.Id6", "f_farm_49_1", Rectangle(-1826.9899, -186.90366, 50));
	}
}
