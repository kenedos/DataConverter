//--- Melia Script -----------------------------------------------------------
// f_maple_23_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Pystis Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FMaple232MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_maple_23_2", MonsterId.Leafnut_Yellow, Properties("MHP", 708532, "MINPATK", 9612, "MAXPATK", 11716, "MINMATK", 9612, "MAXMATK", 11716, "DEF", 197228, "MDEF", 197228));
		AddPropertyOverrides("f_maple_23_2", MonsterId.Grummer_Orange, Properties("MHP", 710847, "MINPATK", 9642, "MAXPATK", 11752, "MINMATK", 9642, "MAXMATK", 11752, "DEF", 198883, "MDEF", 198883));
		AddPropertyOverrides("f_maple_23_2", MonsterId.Colimen_Red, Properties("MHP", 713207, "MINPATK", 9672, "MAXPATK", 11790, "MINMATK", 9672, "MAXMATK", 11790, "DEF", 200569, "MDEF", 200569));
		AddPropertyOverrides("f_maple_23_2", MonsterId.Caro_Yellow, Properties("MHP", 715610, "MINPATK", 9703, "MAXPATK", 11828, "MINMATK", 9703, "MAXMATK", 11828, "DEF", 202287, "MDEF", 202287));

		// Monster Spawners ---------------------------------

		AddSpawner("f_maple_23_2.Id1", MonsterId.Rootcrystal_05, 10, 13, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_maple_23_2.Id2", MonsterId.Leafnut_Yellow, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_23_2.Id3", MonsterId.Grummer_Orange, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_23_2.Id4", MonsterId.Colimen_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_23_2.Id5", MonsterId.Caro_Yellow, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_maple_23_2.Id6", MonsterId.Caro_Yellow, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_05' GenType 5 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(1315.2864, -213.21678, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(949.62646, 126.93922, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(337.46753, 55.7637, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(75.64025, 288.91437, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-213.56548, 77.34254, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-741.81335, 60.3191, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-1207.9235, 120.1469, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-998.0873, 1464.8643, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(130.11612, 864.7275, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-66.80233, 1485.3157, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(324.0011, 1462.3481, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(861.802, 1611.1348, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(1167.9976, 1553.8171, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(1166.307, 616.3252, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(894.21027, 563.8945, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-218.04189, -510.9965, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(526.3489, -674.76434, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(888.4131, -569.16034, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(1307.574, -1011.9697, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(1566.3, -504.43903, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-775.6914, -678.0433, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-1286.0887, -707.2014, 50));
		AddSpawnPoint("f_maple_23_2.Id1", "f_maple_23_2", Rectangle(-1216.41, -1283.9623, 50));

		// 'Leafnut_Yellow' GenType 100 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(826.5339, 139.24161, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(1025.7454, 87.44974, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(940.25055, -173.92178, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(1194.1215, -250.3523, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(1164.981, -72.40085, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(1333.6304, 25.064346, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(1249.5859, -110.124, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-4.4388194, -20.2702, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(76.42181, 444.77423, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-265.90018, 176.79774, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(381.17865, 135.68918, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(186.41812, -62.75276, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-1158.9459, 56.324593, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-934.5735, 7.202757, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-844.47046, -22.421051, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-1024.796, 81.716385, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-613.8553, 68.6719, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-795.2302, 169.21262, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(32.208138, 257.64246, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(195.88043, 143.73158, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-24.557966, 130.03763, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-27.67885, 431.83417, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(194.41917, 255.29236, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-211.72119, -85.62508, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(363.81305, -111.17772, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-1081.4338, 175.80989, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-1120.576, 314.7789, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-1252.3889, 83.9608, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(-973.3329, 201.92754, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(994.50287, -50.578392, 50));
		AddSpawnPoint("f_maple_23_2.Id2", "f_maple_23_2", Rectangle(617.92035, 143.50075, 50));

		// 'Grummer_Orange' GenType 103 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-1287.9996, 1624.8224, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-1155.9792, 1262.6808, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-929.427, 1263.4766, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-903.9832, 1521.7723, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-1035.5201, 1580.6063, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(70.96894, 807.29504, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(332.62057, 828.01355, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(107.30626, 719.4608, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(138.16995, 950.2129, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(84.34153, 1147.2231, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(674.6413, 1650.0463, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(832.82153, 1837.0692, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(946.37317, 1655.917, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(896.70856, 1500.615, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1095.5085, 1432.8218, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1236.6318, 1676.8568, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1120.6646, 1809.3367, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(839.588, 2084.75, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-1261.4723, 1405.4896, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(-1069.1653, 1413.3627, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1073.528, -1030.5309, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1008.2152, -837.3148, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1193.6184, -902.3627, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1229.1973, -1275.0187, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1392.6666, -952.8043, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1251.9, -1078.753, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1416.1763, -1290.8779, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1499.7167, -1117.5305, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1563.7203, -1231.9927, 40));
		AddSpawnPoint("f_maple_23_2.Id3", "f_maple_23_2", Rectangle(1372.3627, -1144.4353, 40));

		// 'Colimen_Red' GenType 106 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-1075.7057, -591.7917, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-1249.6259, -768.7444, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-880.5072, -723.22766, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-1296.8625, -528.49207, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-952.0513, -450.50244, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(-769.69086, -581.5432, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(194.82397, -708.74274, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(356.8063, -590.42834, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(520.86456, -655.7172, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(634.4481, -526.6501, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(695.5663, -676.32947, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(950.4656, -465.73898, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(910.2051, -696.4545, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1310.6213, -529.10785, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1386.1466, -382.2638, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1534.5355, -501.9488, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1543.3784, -301.60077, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1670.0371, -410.72726, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(1098.0392, -578.0446, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(812.81506, -572.37445, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(724.8484, -382.6102, 50));
		AddSpawnPoint("f_maple_23_2.Id4", "f_maple_23_2", Rectangle(468.73193, -520.35187, 50));

		// 'Caro_Yellow' GenType 110 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id5", "f_maple_23_2", Rectangle(380.0072, -625.03424, 9999));

		// 'Caro_Yellow' GenType 111 Spawn Points
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1222.7054, -1003.1465, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1365.1204, -727.80597, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-975.9346, -601.9339, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1012.8274, -435.46295, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1240.4294, -1258.5214, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1083.6848, -1253.2654, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1255.4674, -1110.3544, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1105.3248, -1095.2535, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-793.35065, -591.87897, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(437.4106, -594.1028, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(774.57135, -544.8165, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(657.5973, -680.02386, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(627.9277, -544.9095, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1095.406, -932.2368, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1295.3236, -1105.8518, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1385.2839, -1042.2844, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1205.1974, -48.913033, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(932.912, 97.4809, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(885.58185, -143.45999, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1098.3148, -59.421867, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(222.49774, 936.91406, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(239.14029, 813.62885, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(227.35887, 712.3962, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(346.80957, 729.2211, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-933.7968, 1541.8258, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1253.6085, 1524.065, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-1148.9625, 1334.0502, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(-996.62823, 1397.5056, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(734.8689, 1905.49, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(977.1768, 1894.6581, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(1080.8951, 1636.9731, 40));
		AddSpawnPoint("f_maple_23_2.Id6", "f_maple_23_2", Rectangle(911.62213, 1732.6772, 40));
	}
}
