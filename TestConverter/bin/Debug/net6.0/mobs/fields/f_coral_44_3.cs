//--- Melia Script -----------------------------------------------------------
// f_coral_44_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Epherotao Coast' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FCoral443MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_coral_44_3.Id1", MonsterId.VarleAnchor, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_3.Id2", MonsterId.VarleSkipper, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_3.Id3", MonsterId.VarleHenchman, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_3.Id4", MonsterId.VarleHelmsman, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_3.Id5", MonsterId.NimrahPricker, 4, 5, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_coral_44_3.Id6", MonsterId.Rootcrystal_03, 23, 30, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'VarleAnchor' GenType 23 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-757.3532, 484.94888, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-632.17535, 517.95856, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-610.48444, 205.82559, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-603.60626, 324.7719, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-476.35513, 430.24594, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-375.161, 551.86365, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-312.14102, 476.8196, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-89.22882, 723.1822, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-148.59578, 839.8608, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-2.0685768, 826.69183, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-85.167854, 955.00055, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(76.99476, 880.9179, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(47.37706, 1022.6924, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(108.29951, 1184.6168, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(609.0486, 384.96182, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(545.552, 248.4436, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(727.14056, 304.28256, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(582.37585, 158.21896, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(714.1086, 108.29096, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(859.93964, 121.96761, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-895.96564, 221.91518, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-972.42316, 120.89955, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-1026.375, -111.35339, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-908.179, -94.51198, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-568.3931, -51.546627, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(638.68475, 260.3654, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(64.916145, 1274.068, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(74.88305, 1402.8132, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(124.53844, 1058.1155, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(1275.7549, -617.5161, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(1184.8591, -526.8403, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(1192.3738, -414.667, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(1270.4789, -337.89667, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(804.599, -675.3899, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(721.0113, -592.5219, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(914.11395, -158.77708, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-1536.772, -82.10761, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-1546.2314, 3.0380154, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-1342.714, -65.30476, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-1044.1042, 11.840203, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-795.2821, 2.7851882, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-719.2195, 248.45766, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-235.49245, 660.70294, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-464.1173, -78.37976, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-153.42511, -271.9475, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(-54.405834, 8.526936, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(584.9423, -531.90405, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(1129.1942, -466.50662, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(843.97015, -265.65018, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(963.12225, 60.935772, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(901.91925, -542.3925, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(899.8222, -23.675985, 40));
		AddSpawnPoint("f_coral_44_3.Id1", "f_coral_44_3", Rectangle(4.723789, -147.93817, 40));

		// 'VarleSkipper' GenType 24 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-694.4924, 378.79614, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-764.1262, 244.19363, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-801.52856, 92.80544, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-674.31586, 110.18966, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-987.13885, 18.29124, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(791.0301, -85.00035, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(816.3006, 6.953415, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(925.17847, -67.287865, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(854.9502, -237.78763, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(931.88495, -273.48013, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(978.33905, 43.41549, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1156.2954, 140.63806, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1347.459, 166.99107, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1346.3438, 263.79395, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1486.914, 165.4636, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1476.6196, 390.69394, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1562.4167, 309.0657, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1109.8436, 5.1603994, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1310.0453, -74.525856, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1447.4832, -124.81252, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1431.7091, -6.2422867, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1532.9963, 95.88432, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1648.2141, -42.251713, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-1719.9122, 45.680767, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-485.05295, -159.08253, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1275.9453, -238.9962, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1366.9128, -62.34624, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1306.6029, -151.54498, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1302.1833, -522.0772, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1360.9131, -398.46088, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1483.2958, -654.2005, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1584.357, -705.7361, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(1059.9117, -524.5135, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(952.0745, -508.1388, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-183.08052, -215.35358, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-148.88351, -62.264336, 40));
		AddSpawnPoint("f_coral_44_3.Id2", "f_coral_44_3", Rectangle(-904.46326, -502.68936, 40));

		// 'VarleHenchman' GenType 25 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(-697.3369, 207.03224, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(882.4193, 46.72032, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(1269.4991, 199.13074, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(3.7379856, -276.6693, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(1236.3876, -476.15622, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(1370.1328, -228.15736, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(58.209282, -726.96655, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(-990.4001, -516.86475, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(-1621.1676, 78.837326, 40));
		AddSpawnPoint("f_coral_44_3.Id3", "f_coral_44_3", Rectangle(70.63698, 1347.5941, 40));

		// 'VarleHelmsman' GenType 26 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-41.77173, -154.83928, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-119.4873, -328.71368, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-2.052887, -49.363747, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(117.74957, -6.0210342, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(174.61516, -150.01389, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(82.36097, -185.18631, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(161.98692, -300.35336, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(161.2576, -411.03217, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(324.4613, -482.46317, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(536.9258, -545.3727, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(618.37805, -649.52496, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(744.054, -729.6955, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(853.2328, -869.55133, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1375.8351, -613.526, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1663.551, -675.29565, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1882.6995, -557.85974, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1550.533, -162.79874, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1804.7612, -576.45636, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-175.13994, -777.8429, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-72.512955, -858.145, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(46.748146, -824.1614, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-72.28059, -706.7541, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-887.0131, -571.7029, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-936.1944, -429.4458, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-1076.1185, -577.29346, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-1100.7546, -463.56433, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-1196.9902, -430.55438, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-1358.874, -477.4159, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(58.025703, -352.9857, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(42.058914, -913.28876, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(967.7035, -974.4203, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(1685.765, -247.15619, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-209.3799, -687.05225, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-178.02383, -600.2576, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-246.20665, -862.4243, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-58.180103, 26.396503, 40));
		AddSpawnPoint("f_coral_44_3.Id4", "f_coral_44_3", Rectangle(-1182.6045, -516.95544, 40));

		// 'NimrahPricker' GenType 27 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id5", "f_coral_44_3", Rectangle(-9.430426, 899.79944, 40));
		AddSpawnPoint("f_coral_44_3.Id5", "f_coral_44_3", Rectangle(-16.494377, -821.3589, 40));
		AddSpawnPoint("f_coral_44_3.Id5", "f_coral_44_3", Rectangle(1259.3978, 176.33455, 40));
		AddSpawnPoint("f_coral_44_3.Id5", "f_coral_44_3", Rectangle(734.21155, 202.55057, 40));
		AddSpawnPoint("f_coral_44_3.Id5", "f_coral_44_3", Rectangle(699.9697, -661.48486, 40));

		// 'Rootcrystal_03' GenType 32 Spawn Points
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-756.6381, 446.92526, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-1030.1958, 18.549706, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-653.46045, 126.1059, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-591.1182, 468.46085, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-268.5045, 491.9452, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-129.43631, 803.7457, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(47.913708, 1008.4373, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(619.7102, 320.87903, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(712.8506, 119.31756, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(858.2185, -176.6719, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(938.4827, 78.52958, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1224.4535, 184.18736, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1554.073, 272.01257, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1361.1621, -175.17253, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1603.3951, -305.47025, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1459.472, -445.7083, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1327.676, -556.81055, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(1622.8475, -573.6952, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(801.72516, -633.25854, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(612.215, -627.5676, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(223.85916, -427.54666, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(237.50342, -155.05365, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(77.16912, -285.51285, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-6.4122043, -158.66177, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-147.23198, -713.1739, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(30.988653, -860.99115, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-1234.6287, -469.23282, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-958.37286, -468.98102, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-1538.8818, 23.964655, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-1301.9702, -22.154984, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-941.7567, 142.6175, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-647.674, 176.87225, 40));
		AddSpawnPoint("f_coral_44_3.Id6", "f_coral_44_3", Rectangle(-751.2228, 492.08755, 40));
	}
}
