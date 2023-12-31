//--- Melia Script -----------------------------------------------------------
// f_whitetrees_23_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Emmet Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees231MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_whitetrees_23_1", MonsterId.Kucarry_Somy, Properties("MHP", 545736, "MINPATK", 7519, "MAXPATK", 9142, "MINMATK", 7519, "MAXMATK", 9142, "DEF", 100554, "MDEF", 100554));
		AddPropertyOverrides("f_whitetrees_23_1", MonsterId.Kucarry_Tot, Properties("MHP", 548433, "MINPATK", 7553, "MAXPATK", 9185, "MINMATK", 7553, "MAXMATK", 9185, "DEF", 101887, "MDEF", 101887));
		AddPropertyOverrides("f_whitetrees_23_1", MonsterId.Kucarry_Lioni, Properties("MHP", 551235, "MINPATK", 7589, "MAXPATK", 9229, "MINMATK", 7589, "MAXMATK", 9229, "DEF", 103273, "MDEF", 103273));

		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_23_1.Id1", MonsterId.Rootcrystal_03, 11, 14, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_1.Id2", MonsterId.Kucarry_Somy, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_1.Id3", MonsterId.Kucarry_Somy, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_1.Id4", MonsterId.Kucarry_Tot, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_1.Id5", MonsterId.Kucarry_Lioni, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_1.Id6", MonsterId.Kucarry_Lioni, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_1.Id7", MonsterId.Kucarry_Somy, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_1.Id8", MonsterId.Kucarry_Tot, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_1.Id9", MonsterId.Kucarry_Lioni, 10, 13, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_23_1.Id10", MonsterId.Kucarry_Somy, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 5 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1474.6232, 1235.4061, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1045.4186, 1323.6304, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(604.8794, 1230.1764, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(237.13437, 1431.5969, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-629.5713, 1159.2919, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-881.8404, 1134.6344, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(393.64532, 764.82135, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(423.90207, 336.11392, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-52.254612, 409.56955, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(977.2864, 505.36612, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1411.1055, 432.34912, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-688.5693, 240.42108, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-902.2313, 491.3577, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-1252.3599, 494.2961, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-1030.4135, -58.26267, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-1175.2041, -454.3426, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-1514.0112, -187.4926, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-292.15106, -1342.381, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(-625.3791, -1081.7029, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(34.58011, -1065.3196, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(690.9718, -1073.5189, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(462.7839, -553.62866, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1938.0372, -652.485, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1475.1199, -677.42236, 50));
		AddSpawnPoint("f_whitetrees_23_1.Id1", "f_whitetrees_23_1", Rectangle(1087.8757, -290.6642, 50));

		// 'Kucarry_Somy' GenType 100 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-760.65344, -1152.9344, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-547.97876, -1349.3125, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-575.3899, -978.4366, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-310.804, -1188.5526, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-190.54124, -1284.0776, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-151.3577, -1113.294, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(-5.8210807, -1183.2365, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id2", "f_whitetrees_23_1", Rectangle(69.87016, -991.3004, 40));

		// 'Kucarry_Somy' GenType 101 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1000.1975, 506.99747, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1042.0736, 370.2205, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1176.7832, 285.85757, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1270.8397, 436.5344, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1358.9803, 308.7419, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1503.266, 340.14536, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id3", "f_whitetrees_23_1", Rectangle(1143.0874, 530.5552, 40));

		// 'Kucarry_Tot' GenType 102 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1413.2423, -165.89508, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1365.6515, -477.6635, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1238.1124, -496.00336, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1525.672, -307.87125, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1064.0775, -440.0114, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1204.2169, 40.40551, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-992.8514, -143.55013, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1017.8493, -345.40695, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-845.46674, -258.16052, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-752.656, 62.831165, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-751.59235, 290.75214, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-667.4386, 650.5433, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-342.65, 262.93, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-147.91406, 368.52744, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-91.54, 731.65, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-87.33, 453.16, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(155.41, 278.49, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(159.79, 568.67, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(316.92, 438.83, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(433.6486, 629.8477, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(378.72, 823.51, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(780.38715, 435.52734, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(500.84, 323.68, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(92.86784, 931.34485, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-225.05418, 588.66895, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-621.12115, 198.19334, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-455.8352, 239.57713, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-644.6497, 486.3407, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-628.88763, 355.02, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1337.5842, -316.02652, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1131.4554, -323.16568, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(-1145.3468, -158.70517, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(60.569897, 573.5787, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id4", "f_whitetrees_23_1", Rectangle(252.13736, 733.6791, 40));

		// 'Kucarry_Lioni' GenType 105 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(589.6206, 1273.1727, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(354.64084, 1562.8882, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1305.6235, 1249.6938, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(77.16196, 1403.742, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(404.90485, 1169.2081, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(273.64755, 1276.5845, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1101.9275, 1279.479, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(370.90067, 1440.5345, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1161.6008, 1122.916, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1105.7457, 1484.6528, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(894.35455, 1331.2062, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1436.6738, 1389.8551, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id5", "f_whitetrees_23_1", Rectangle(1471.3767, 1216.2006, 40));

		// 'Kucarry_Lioni' GenType 106 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1306.9512, 390.26096, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1164.8756, 336.60696, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1213.647, 525.6757, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1009.5188, 313.21774, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1024.5817, 429.094, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-926.625, 336.48965, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-904.7287, 459.3458, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-1084.3237, 642.67694, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-947.91266, 587.92804, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-954.07, 1432.98, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-987.7, 1346.63, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-853.08, 1280.95, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-898.8, 1146.76, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-782.21, 1120.72, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-660.94, 1296.02, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-643.12, 1188.55, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-532.21, 1409.28, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-557.91, 1260.82, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id6", "f_whitetrees_23_1", Rectangle(-376.01, 1263.13, 40));

		// 'Kucarry_Somy' GenType 107 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-1262.89, 385.94, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-1143.44, 435.56, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-1037.57, 617.83, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-913.14, 512.34, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-1002.78, 466.35, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-1122.94, 282.32, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(-905.77, 332.25, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(349.74188, 1469.1199, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1161.4615, 1456.5312, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(249.65005, 1222.6501, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1136.4803, 1263.0361, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(421.66583, 1196.6053, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(828.95514, 1304.0856, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(142.65205, 1437.6991, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(598.2504, 1220.901, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(46.44419, 968.2157, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(368.78003, 1591.6504, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1041.2032, 1137.3284, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1417.6127, 1211.7578, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1330.5182, 1388.0522, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(1056.1445, 1411.0819, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id7", "f_whitetrees_23_1", Rectangle(442.35138, 1295.6769, 40));

		// 'Kucarry_Tot' GenType 108 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id8", "f_whitetrees_23_1", Rectangle(294.5, -423.6, 9999));

		// 'Kucarry_Lioni' GenType 109 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-299.41, -1200.68, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-218.29568, -1065.931, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(22.47, -987.98, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-43.54, -1191.09, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(138.4, -1285.86, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-671.33, -1054.53, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-577.68, -1326.27, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(-409.29, -895.07, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(7.56, -819.64, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(274.6352, -613.53925, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(488.19254, -320.19147, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(489.0132, -622.37305, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(429.5877, -535.59906, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(123.60607, -587.8585, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id9", "f_whitetrees_23_1", Rectangle(444.31503, -472.69528, 40));

		// 'Kucarry_Somy' GenType 110 Spawn Points
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(981, -532.52, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(900.13007, -347.5766, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1431.37, -718.88, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1612.9768, -482.25992, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1819.4867, -680.39087, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(885.06, -477.45, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1668.201, -823.4024, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1275.91, -798.19, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1080.6892, -244.77626, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1687.7915, -586.64417, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1584.0282, -627.10254, 40));
		AddSpawnPoint("f_whitetrees_23_1.Id10", "f_whitetrees_23_1", Rectangle(1010.626, -381.88638, 40));
	}
}
