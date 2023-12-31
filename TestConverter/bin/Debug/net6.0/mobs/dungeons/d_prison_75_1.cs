//--- Melia Script -----------------------------------------------------------
// d_prison_75_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Narcon Prison' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DPrison751MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_prison_75_1.Id1", MonsterId.ERD_Stoulet_Bow, 10, 13, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id2", MonsterId.ERD_Escape_Wendigo, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id3", MonsterId.ERD_Stoulet, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id4", MonsterId.ERD_Colifly_Black, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id5", MonsterId.ERD_Socket, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id6", MonsterId.ERD_Chromadog, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id7", MonsterId.ERD_Socket_Bow, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id8", MonsterId.ERD_Stoulet_Mage, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id9", MonsterId.ERD_InfroRocktor_Red, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id10", MonsterId.ERD_New_Desmodus_Black, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id11", MonsterId.ERD_Zigri, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id12", MonsterId.ERD_Hook, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_prison_75_1.Id13", MonsterId.Rootcrystal_01, 19, 25, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Stoulet_Bow' GenType 1 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1447.98, -103.49, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1375.69, 96.14, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1175.95, -69.76, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1189.13, -100.25, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1408.98, 18.71, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1583.76, -126.53, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1320.3, -248.13, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1057.32, 177.61, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1531.04, 220.34, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1207.84, 283.21, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1268.8, -98.61, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1112.04, -255.53, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-1050.92, -53.07, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-904.66, -64.24, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-702.76, 130.59, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-628.28, -63.91, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-504.59, 90.06, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-466.99, -56.1, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-483.86, -145.84, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-672.11, -160.26, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-752.22, 109.89, 30));
		AddSpawnPoint("d_prison_75_1.Id1", "d_prison_75_1", Rectangle(-465.58, 178.89, 30));

		// 'ERD_Escape_Wendigo' GenType 2 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id2", "d_prison_75_1", Rectangle(-480.32, -87.66, 9999));

		// 'ERD_Stoulet' GenType 3 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-50.69, -799.24, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-208.22, -871.87, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-139.61, -1012.04, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-110.41, -1082.14, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(128.34637, -906.9609, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-20.74, -966.68, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(119.36, -823.66, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-158.41, 657.1, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-113.92, 856.83, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-113.92, 856.83, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-179.61, 738.16, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-11.19, 717.77, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-17.27, 565.7, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(23.73, 854.7, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-175.42, 564.24, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-336.74, 672.54, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-508.93, 708.28, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-587.9963, 676.4376, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(36.01, 399.4, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-7.22, 268.79, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(49.72, 81.83, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-30.62, -0.52, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(28.53, -116.81, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(34.92, -411.35, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-5.45, -286.09, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(63.26, -314.61, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-12.04, -498.33, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(6.25, -602.44, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(72.25, -713.19, 30));
		AddSpawnPoint("d_prison_75_1.Id3", "d_prison_75_1", Rectangle(-117.63, -735.99, 30));

		// 'ERD_Colifly_Black' GenType 4 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id4", "d_prison_75_1", Rectangle(-145.18, -1323.94, 9999));

		// 'ERD_Socket' GenType 5 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(13.65, -1431.08, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-70.47172, -1327.6989, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-337.83, -1452.28, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(13.290929, -1589.457, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-153.85, -1443.18, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(41.4, -1300.21, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-611.6, -1528.57, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-779.22, -1539.18, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-849.98627, -1192.9216, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-515.18396, -1238.9097, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-474.01306, -1149.1937, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-552.57, -1312.56, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-692.04, -1362.31, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-856.56, -1296.58, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-575.5192, -1176.72, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-677.39, -1228.57, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-308.37, -1589.14, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-337.09, -1323.32, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-710.01337, -1147.8229, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-877.9424, -1451.7358, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-896.24805, -1566.2253, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-460.28644, -1307.7014, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-635.4728, -1553.7965, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-229.52994, -1447.4293, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-182.59349, -1297.7083, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(-15.543701, -1544.0947, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(115.51955, -1414.5643, 30));
		AddSpawnPoint("d_prison_75_1.Id5", "d_prison_75_1", Rectangle(140.45302, -1548.1837, 30));

		// 'ERD_Chromadog' GenType 6 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1387.7772, -622.1914, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1587.8204, -699.59076, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1757.8047, -629.7469, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1706.9547, -714.3185, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1746.9391, -545.41547, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1563.7385, -599.9033, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1405.2325, -480.0842, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1343.9, -697.7, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1225.15, -714.98, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1188.76, -548.22, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1198.14, -450.02, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1259.78, -404.04, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1390.75, -387.25, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1496.81, -405.32, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1593.273, -525.9828, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1698.1271, -524.7855, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1768.593, -442.26935, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1665.9366, -624.77466, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(-808.62054, 1334.7505, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1489.9705, -739.69403, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1285.4261, -565.9704, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1425.2334, -783.6157, 30));
		AddSpawnPoint("d_prison_75_1.Id6", "d_prison_75_1", Rectangle(1632.4414, -757.8861, 30));

		// 'ERD_Socket_Bow' GenType 7 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1459.9606, -21.297335, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1496.7456, 90.467316, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1548.953, -162.82375, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1689.45, -159.97, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1812.7383, 210.385, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1771.5397, -58.250973, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(2019.6476, 211.8165, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1913.6284, -1.2842216, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(2018.71, -171.64, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1675.3563, 84.003555, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1324.15, 160.71, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1280.34, -156.44, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1294.732, 22.713305, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1634.8967, 253.08533, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(1472.3241, 225.667, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(2024.523, 32.208706, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(938.83, 11.9, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(747.33, -39.64, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(597.85, -33.95, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(614.81, 103.61, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(746.04, 58.27, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(661.91, 218.81, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(776.59, 202.7, 40));
		AddSpawnPoint("d_prison_75_1.Id7", "d_prison_75_1", Rectangle(883.35, -26.73, 40));

		// 'ERD_Stoulet_Mage' GenType 8 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1406, -119.31, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1524.79, -2.74, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1409.36, 132.63, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1690.4, 171.66, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1707.12, 27, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1803.95, -133.28, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1928.85, -189.43, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1943.15, -23.48, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(2006.09, 162.03, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(595.01, -66.12, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(547.3, 36.42, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(731.9, -15.91, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(627.14, 178.51, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(688.16, 267.06, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(766.88, 97.98, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(905.46, 47.74, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(729.46, -148.14, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(583.32, -216.78, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(666.46, -235.53, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(730.7, -252.53, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(537.51, 84.34, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(594.84, 286.46, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(857.33, -52.03, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(657.22, 408.99, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(707.54, 482.72, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(599.1, 579.84, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(620.1, 700.25, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(807.47, 648.69, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(777.97, 806.22, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(647.51, 787.3, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(621.1, 890.24, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(750.96, 712.55, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1092.94, -7.14, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1266.5421, 128.15001, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1261.8456, -0.8496971, 30));
		AddSpawnPoint("d_prison_75_1.Id8", "d_prison_75_1", Rectangle(1255.86, -129.37, 30));

		// 'ERD_InfroRocktor_Red' GenType 9 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-620.2848, 1161.7341, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-679.3425, 1315.1731, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-744.2233, 1287.7935, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1022.0842, 1326.5664, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-757.5926, 1210.3528, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-709.75, 1082.51, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-508.89, 1144.92, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-508.89, 1144.92, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-396.30548, 1231.317, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-815.18, 1322.88, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-929.99, 1301.74, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1202.8, 1251.19, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1342.25, 1181.48, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1413.22, 1261.83, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1283.39, 1395.89, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1126.48, 1420.99, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1158.44, 1333.96, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1305.29, 1294.28, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1100.44, 1130.13, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1239.23, 1140.46, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1432.87, 1387.06, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1175.3335, 1392.3203, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-576.14044, 1355.2435, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-401.82556, 1333.3761, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-488.71426, 1259.1124, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-557.91, 1045.24, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-504.3307, 1376.9208, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-432.02646, 1417.5736, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-768.72864, 1073.254, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-563.34033, 1248.0415, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1411.7074, 1097.2771, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1125.7881, 1206.3772, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1137.3688, -233.47984, 40));
		AddSpawnPoint("d_prison_75_1.Id9", "d_prison_75_1", Rectangle(-1038.5544, 57.41432, 40));

		// 'ERD_New_Desmodus_Black' GenType 10 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1551.23, -215.95, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1629.02, -56.99, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1510.47, 210.68, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1269.1395, 144.45897, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1322.333, -174.02449, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1289.873, 43.12834, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1187.7263, 194.36958, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1071.6782, -6.890526, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1135.4001, -228.61227, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1048.8545, -126.4041, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1061.3711, 164.59035, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1372.2344, -55.51124, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1248.78, 415.35, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1115.57, 562.69, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1247.4551, 543.73883, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1212.0996, 840.70526, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1159.7, 925.16, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1358.32, 1094.29, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1229.56, 722.97, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-967.57, 707.89, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-853.31, 733.94, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-694.57385, 677.71625, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-608.99, 742.52, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-517.22, 691.15, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-486.25, 620.73, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-599.54, 643.41, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-899.03, 601.64, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1060.86, 680.8, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-741.6597, 648.04626, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1207.0006, 628.47614, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1165.559, 491.9466, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-1130.8582, 696.8939, 40));
		AddSpawnPoint("d_prison_75_1.Id10", "d_prison_75_1", Rectangle(-842.0266, 674.0264, 40));

		// 'ERD_Zigri' GenType 11 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(677.34, -1590.37, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(760.45514, -1339.6389, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(874.34564, -1321.2605, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(987.27026, -1424.1033, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(907.4102, -1514.5493, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(887.87, -1647.57, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(1000.27, -1642.31, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(1132.95, -1585.55, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(799.42, -1715.84, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(662.66534, -771.1536, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(764.39374, -1551.1273, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(843.5913, -1423.6844, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(1033.65, -1297.35, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(657.73, -1491.43, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(793.6, -1477.31, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(893.64, -1596.22, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(663.88, -1694.04, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(1068.6, -1704.8, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(943.56, -1260.63, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(675.39, -1204.02, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(719.31, -1129.73, 40));
		AddSpawnPoint("d_prison_75_1.Id11", "d_prison_75_1", Rectangle(701.82, -1031.6, 40));

		// 'ERD_Hook' GenType 12 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(657.78, -1175.7, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(734.66, -1169.77, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(685.21, -1069.45, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(734.44, -967.92, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(593.2, -968.93, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(442.34, -1020.73, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(265.46, -966.43, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(361.0603, -942.20294, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(261.08624, -896.11194, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(537.24, -883.62, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(737.33, -849.93, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(671.73, -774.62, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(706.9, -708.13, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(663.38, -639.07, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(741.95, -503.34, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(701.36, -417.68, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(700.82, -252.08, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(671.79, -200.14, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(595.09, -231.05, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(676.34863, -485.79846, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(706.23, -932.13, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(459.89392, -906.62646, 40));
		AddSpawnPoint("d_prison_75_1.Id12", "d_prison_75_1", Rectangle(529.76337, -978.2967, 40));

		// 'Rootcrystal_01' GenType 14 Spawn Points
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-1019.9398, 707.12665, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-1315.16, -29.61, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-1217.27, 1316.25, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-474.1, 1320.6, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(4.18, 705.91, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(68.95, 107.4, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(24.74, -541.41, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-54.92, -915.96, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-654.52, -1174.7, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-88.05, -1439.67, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(894.58, -1524.84, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(666.36, -725.78, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(698, 55.75, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(678.56, 765.57, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(1459.86, -9.99, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(1786.37, 260.48, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(1533.5, -656.29, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(1289.55, -681.05, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-521.5, -112.75, 200));
		AddSpawnPoint("d_prison_75_1.Id13", "d_prison_75_1", Rectangle(-1185.49, 594.02, 200));
	}
}
