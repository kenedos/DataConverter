//--- Melia Script -----------------------------------------------------------
// f_remains_37_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Nuoridin Falls' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRemains371MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_remains_37_1.Id1", MonsterId.Rootcrystal_04, 38, 50, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_remains_37_1.Id2", MonsterId.Wendigo_Magician, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_remains_37_1.Id3", MonsterId.Wendigo_Archer, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_remains_37_1.Id4", MonsterId.Templeslave_Sword, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_remains_37_1.Id5", MonsterId.Wendigo_Archer, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_remains_37_1.Id6", MonsterId.Wendigo_Magician, 19, 25, TimeSpan.FromMilliseconds(35000), TendencyType.Aggressive);
		AddSpawner("f_remains_37_1.Id7", MonsterId.Templeslave_Sword, 30, 40, TimeSpan.FromMilliseconds(35000), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_04' GenType 4 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-121.18535, -2210.9106, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-371.85904, -2019.6923, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-466.66336, -1761.7412, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-415.56708, -1540.8044, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-101.72962, -1365.324, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(144.27538, -1447.1954, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(43.462444, -1095.3683, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-233.79813, -1105.3285, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-435.62988, -1261.5154, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-601.49774, -1012.4724, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-931.8616, -1181.8348, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1220.388, -1018.6588, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1385.387, -1096.5969, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(27.468943, -864.1717, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(332.0056, -1243.7234, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(629.1877, -1164.2926, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(858.9826, -1214.2535, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(955.2484, -1012.2401, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1211.8616, -1142.5835, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1489.9625, -1203.2081, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(853.2223, -758.74664, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(804.48206, -570.74316, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(589.1209, -354.46082, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(997.6404, -215.32024, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(827.6769, 162.86859, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1065.7994, 421.1493, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1368.163, -47.043118, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1449.0957, 220.762, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1414.2786, -223.51086, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1574.3843, -12.484781, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1623.418, -260.12646, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(1686.0688, -483.40506, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-62.925007, -137.5976, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-394.74863, -219.30746, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-352.90366, -508.53796, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-194.5643, 135.91864, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-954.1151, 36.46193, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1312.0367, -148.05412, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1068.4104, 339.07864, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-672.8675, 785.2892, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-238.09987, 785.81433, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(503.5923, 833.99646, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(278.2459, 766.7521, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(621.9204, 1093.0034, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(771.50995, 589.1136, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-556.7644, 1425.6382, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-318.97855, 1541.0265, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1705.1063, 1610.1945, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-1923.2296, 1302.6346, 40));
		AddSpawnPoint("f_remains_37_1.Id1", "f_remains_37_1", Rectangle(-2249.7004, 1254.8969, 40));

		// 'Wendigo_Magician' GenType 17 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(788.18854, -600.41113, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(868.982, -221.15584, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(1004.7922, 343.58505, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(401.8874, 689.82336, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(792.14514, 950.3395, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-215.51825, -337.1703, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-266.3698, 252.30914, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-29.448252, -1037.445, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(1014.8912, -1064.0134, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(6.255924, -1373.9705, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(1289.8273, -1162.8406, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(1572.1073, -1089.5715, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-222.24367, -1345.2701, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-395.12793, -1308.8196, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-1139.348, -1096.1388, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-1248.9166, -988.05084, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-369.99026, -306.04053, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(-95.35683, -41.506138, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(739.70166, -108.1431, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(822.26904, 128.75177, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(569.32465, -139.43954, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(637.78296, 400.45038, 25));
		AddSpawnPoint("f_remains_37_1.Id2", "f_remains_37_1", Rectangle(588.1654, 951.6136, 25));

		// 'Wendigo_Archer' GenType 18 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-265.08563, -1270.3574, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(247.97836, -1245.0085, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(929.8819, -1097.9756, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(677.9525, 23.77855, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(571.9456, -279.66138, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(977.05853, 80.70419, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(566.9629, 474.95782, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(434.57233, 974.5395, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(679.83936, 773.8117, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-140.56343, -613.61554, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(1.5381241, -126.83794, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-173.95851, -72.73068, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-465.3419, -33.073074, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-408.646, -383.2536, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(1484.6537, -1151.3271, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-1193.966, -1098.6884, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-1192.9148, -1253.6658, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-1050.384, -969.03845, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-368.96945, -1465.0508, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-450.51013, -1280.2429, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-71.15127, -1392.0524, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(256.8456, -1367.2318, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-56.07265, -408.19916, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-360.14905, -255.98926, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(-178.48921, 225.62675, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(769.7274, -205.68466, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(616.0733, -96.594055, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(914.2807, 298.71402, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(512.47565, 650.68835, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(312.0585, 793.6818, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(730.7453, 1016.6088, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(1305.7269, -1138.1827, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(1483.5719, -1019.8372, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(917.94604, -946.6686, 25));
		AddSpawnPoint("f_remains_37_1.Id3", "f_remains_37_1", Rectangle(1109.7792, -1197.0453, 25));

		// 'Templeslave_Sword' GenType 19 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1250.9269, -180.9566, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1039.7349, -49.49824, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-670.55237, 720.85254, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-459.1673, 818.5737, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-712.57166, 1413.2379, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-444.83304, 1582.8417, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1707.2816, 1417.4867, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1974.3179, 1245.2872, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-473.45364, -1961.3265, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-493.04977, -1732.8937, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(113.84551, -1202.0203, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1782.6492, 1211.3877, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-487.0635, 1361.75, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-258.28882, 1504.0721, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-112.72501, -1392.6187, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(1420.1814, -1171.2972, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-183.31429, -503.07324, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-249.04608, -292.15826, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-183.08716, -650.20306, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-70.31746, 65.86512, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(701.1002, -93.776245, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(824.9565, -432.12372, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(949.9309, -101.02297, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(878.5796, -1094.3257, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(478.07523, -1286.7257, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(296.39566, -1269.3531, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(141.09987, -1359.7145, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(868.52686, -840.5886, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(757.3695, -1189.5482, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(635.7272, -322.59348, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(768.3432, 119.92229, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-230.37335, -53.641777, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-771.11066, 796.11755, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1184.9982, -63.250694, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(933.4464, 83.701324, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(528.7634, -158.20744, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(849.9335, -214.98137, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-407.9029, -201.65251, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-398.99518, 239.35138, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-489.23126, -1.357811, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-362.2164, -521.00354, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1045.8689, -241.3277, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-505.30344, 922.0758, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-528.2469, 1513.9746, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-853.42334, 1339.028, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-748.55707, 1252.4932, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-1973.5991, 1417.7896, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-315.83826, 1445.5334, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-416.3398, -1342.7294, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-135.4793, -1215.6475, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-360.85553, -1226.2501, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-106.61847, -1053.5355, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-258.6519, -1422.1826, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-78.31407, -213.45798, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(42.609318, -91.40089, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-80.088264, 277.13513, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(70.63312, 60.145638, 25));
		AddSpawnPoint("f_remains_37_1.Id4", "f_remains_37_1", Rectangle(-214.72311, 199.61504, 25));

		// 'Wendigo_Archer' GenType 20 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id5", "f_remains_37_1", Rectangle(-631.86145, 673.83325, 9999));

		// 'Wendigo_Magician' GenType 29 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(446.9574, 536.1796, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(593.0712, 569.1238, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(442.668, 705.2978, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(634.90247, 756.39124, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(444.0971, 899.7326, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(732.00836, 991.4009, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(800.64014, 690.75024, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(653.9053, 347.76996, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(488.1928, 391.53473, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(240.6576, 689.3774, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(582.2876, 1044.8752, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-2032.1047, 1200.4075, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1954.987, 1298.215, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1982.1921, 1420.365, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1784.3478, 1511.9475, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1828.3344, 1395.5618, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1698.3906, 1244.7755, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1614.5677, 1424.7239, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1592.2032, 1625.9528, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1698.8892, 1587.9028, 30));
		AddSpawnPoint("f_remains_37_1.Id6", "f_remains_37_1", Rectangle(-1540.6499, 1518.4158, 30));

		// 'Templeslave_Sword' GenType 30 Spawn Points
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(573.2119, 343.35144, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(722.5411, 449.00064, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(497.28934, 505.5127, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(324.38406, 632.0122, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(493.71597, 715.44385, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(281.68326, 881.9547, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(629.2374, 870.5492, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(456.81415, 858.58374, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(496.01907, 1009.5798, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(841.34534, 1059.8867, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(796.2181, 825.1387, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(789.431, 674.89856, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(659.68726, 602.3179, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1306.0154, -1169.8114, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1305.4556, -1020.4899, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1220.4884, -923.29565, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1142.2408, -1041.5405, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1176.1624, -1161.8234, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1133.3577, -1283.985, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-978.47626, -1243.8857, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1064.0415, -1165.425, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-980.85004, -1086.8403, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-863.14374, -983.19354, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-871.77875, -1179.3779, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1045.4705, -1363.3295, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1378.4, -898.89844, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1433.4321, -1029.6428, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1081.8801, -961.8051, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(686.7381, 1076.7474, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1978.2904, 1217.801, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1920.6376, 1383.3945, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1948.6132, 1495.4589, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1765.5735, 1295.2814, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1644.6469, 1537.3772, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1699.7104, 1440.2974, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1593.5157, 1321.0483, 25));
		AddSpawnPoint("f_remains_37_1.Id7", "f_remains_37_1", Rectangle(-1697.5944, 1640.0293, 25));
	}
}
