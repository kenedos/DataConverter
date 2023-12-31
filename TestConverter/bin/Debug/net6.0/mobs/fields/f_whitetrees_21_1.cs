//--- Melia Script -----------------------------------------------------------
// f_whitetrees_21_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Yudejan Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FWhitetrees211MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_whitetrees_21_1.Id1", MonsterId.Moringaga, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_1.Id2", MonsterId.Nabu, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_1.Id3", MonsterId.Moringbird, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_1.Id4", MonsterId.Moringbird, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_whitetrees_21_1.Id5", MonsterId.Rootcrystal_01, 9, 12, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Moringaga' GenType 1 Spawn Points
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(663.25885, 202.84615, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(768.303, 270.50616, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(847.8262, 81.697845, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(613.2855, 463.299, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(761.98224, 790.99725, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(705.84174, 972.22266, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(561.3082, 992.9375, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(328.5919, 997.1051, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(29.332415, 861.93225, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(53.740635, 1065.4086, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-236.96103, 961.5284, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-330.49258, 1122.4987, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-458.59375, 1024.6383, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-349.49222, 904.7077, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(466.52847, 275.64893, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(815.43494, 635.07983, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(518.7108, 83.8425, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(785.10333, 510.2278, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(840.85486, 345.26907, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-88.43466, 295.93948, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(46.80081, 416.07574, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-220.11638, 431.06104, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-113.90025, 517.09564, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-1.03404, 559.6456, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(177.9302, 325.67554, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-56.791878, 413.63336, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-83.31041, 86.999466, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-9.650215, 1.645441, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(127.28752, -336.70636, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(101.522, -496.52448, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-119.41117, -453.98712, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-101.98214, -596.6034, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(332.10666, -280.6259, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(246.04822, -316.21115, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(433.64435, -370.09375, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id1", "f_whitetrees_21_1", Rectangle(-465.42975, 445.43018, 30));

		// 'Nabu' GenType 2 Spawn Points
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-685.59625, -119.7969, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-939.4922, -238.3641, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-927.8851, -411.5627, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-685.7326, -448.01663, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-575.7733, -342.15164, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-412.5211, -510.99396, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-203.88559, -640.3015, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(23.160267, -421.66876, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(79.26041, -257.1406, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(360.08054, -399.49988, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(601.6601, -484.96817, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(622.8468, -612.6477, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(918.5697, -436.70792, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(877.0942, -706.8636, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1046.6349, -606.39435, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(749.4073, -360.86368, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-193.07335, -515.23596, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-139.15718, -345.67017, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-4.437271, -57.284653, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(811.41406, -543.52203, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1118.0127, -527.8475, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1517.7471, -357.48083, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1427.3784, -186.72687, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1611.9352, -432.59775, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1554.1136, -553.07416, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1348.4661, -574.39044, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(331.53815, -309.339, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-1104.1514, -308.20746, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-870.2868, -86.1792, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-741.12836, -253.1911, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(-533.7213, 26.795942, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id2", "f_whitetrees_21_1", Rectangle(1392.1013, -461.22748, 30));

		// 'Moringbird' GenType 3 Spawn Points
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1149.0975, 731.0922, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1115.9733, 300.4265, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1324.7128, 197.54793, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1191.9116, 390.01117, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1236.4417, 215.34485, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1035.8992, 350.59644, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1612.0734, 998.4832, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1056.7308, 1178.296, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1243.6741, 1083.2994, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-903.74774, 885.2903, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-810.35944, 784.4077, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(612.6399, 903.9016, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(711.8503, 981.023, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(905.1078, 833.6067, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(848.9459, 966.477, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(780.2291, 698.6027, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(734.0588, 611.7116, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(584.54193, 421.25314, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(832.61694, 456.1861, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(806.40674, 258.72174, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(682.435, 289.56332, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(566.946, 226.51013, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(716.1988, 31.557726, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(821.21545, 85.25629, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(662.4547, 112.26275, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(269.83362, 335.84534, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-112.66161, 285.30753, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1403.5524, 964.1107, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-993.76953, 793.85486, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-805.96405, 422.61462, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-582.40894, 459.12015, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-515.84064, 416.1909, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-407.96896, 459.70633, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-289.2962, 388.30728, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-115.4308, 527.82715, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1186.9817, 937.51733, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1020.6777, 996.8839, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(55.86457, 338.36685, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(10.015675, 502.0205, 30));
		AddSpawnPoint("f_whitetrees_21_1.Id3", "f_whitetrees_21_1", Rectangle(-1040.8191, 198.8222, 30));

		// 'Moringbird' GenType 4 Spawn Points
		AddSpawnPoint("f_whitetrees_21_1.Id4", "f_whitetrees_21_1", Rectangle(-76.60073, 459.72104, 9999));

		// 'Rootcrystal_01' GenType 7 Spawn Points
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-1730.04, 1038.98, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-1086.66, 912.3, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-1268.61, 183.11, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-679.02, -451.26, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-380.91888, 921.0224, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(298.79, 996.65, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(778.99, 635.18, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(1401.66, -86.18, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(1215.02, -532.45, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(375.37, -345.76, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(403.14, 279.04, 100));
		AddSpawnPoint("f_whitetrees_21_1.Id5", "f_whitetrees_21_1", Rectangle(-840.97, 427.59, 100));
	}
}
