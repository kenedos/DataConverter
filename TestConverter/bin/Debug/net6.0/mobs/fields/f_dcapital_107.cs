//--- Melia Script -----------------------------------------------------------
// f_dcapital_107
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Frienel Memorial' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FDcapital107MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_dcapital_107", MonsterId.Kigle, Properties("MHP", 759679, "MINPATK", 10270, "MAXPATK", 12524, "MINMATK", 10270, "MAXMATK", 12524, "DEF", 235317, "MDEF", 235317));
		AddPropertyOverrides("f_dcapital_107", MonsterId.Kiglelops, Properties("MHP", 761094, "MINPATK", 10288, "MAXPATK", 12547, "MINMATK", 10288, "MAXMATK", 12547, "DEF", 236509, "MDEF", 236509));
		AddPropertyOverrides("f_dcapital_107", MonsterId.Bishop_Blanco, Properties("MHP", 762561, "MINPATK", 10307, "MAXPATK", 12570, "MINMATK", 10307, "MAXMATK", 12570, "DEF", 237744, "MDEF", 237744));
		AddPropertyOverrides("f_dcapital_107", MonsterId.Bishop_Gray, Properties("MHP", 764078, "MINPATK", 10326, "MAXPATK", 12594, "MINMATK", 10326, "MAXMATK", 12594, "DEF", 239021, "MDEF", 239021));

		// Monster Spawners ---------------------------------

		AddSpawner("f_dcapital_107.Id1", MonsterId.Rootcrystal_01, 27, 35, TimeSpan.FromMilliseconds(25000), TendencyType.Peaceful);
		AddSpawner("f_dcapital_107.Id2", MonsterId.Kigle, 44, 58, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_107.Id3", MonsterId.Kiglelops, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_107.Id4", MonsterId.Bishop_Blanco, 18, 24, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_dcapital_107.Id5", MonsterId.Bishop_Gray, 18, 24, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 3 Spawn Points
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(384.04193, -1096.564, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(772.69037, -1134.4691, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1175.63, -1111.113, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1351.7126, -816.7527, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1397.4807, -1026.7319, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(373.74884, -572.0837, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(251.68275, -379.51736, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(550.6423, -283.49567, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(615.74567, -509.7247, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-81.549225, -860.2294, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-314.15683, -927.6736, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-424.144, -691.6666, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-177.57509, -623.22516, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-769.7166, -860.7496, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1040.6719, -922.75726, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1341.2944, -892.94226, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1514.3278, -766.91833, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1340.0724, -544.8356, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1276.7955, -701.5758, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1101.0272, -242.16347, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-925.53467, 155.45279, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-924.3823, 562.9143, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-920.0848, 827.17896, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-719.3696, 807.0946, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1130.0334, 740.1437, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1496.319, 289.18753, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1465.9828, 541.4606, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-1297.1942, 392.72253, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-228.59612, 5.7594247, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-208.9967, 198.65231, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(182.4229, 255.01532, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-15.866967, 102.55044, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(20.732124, 250.64958, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(138.82469, -190.18289, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(568.4133, 26.719744, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(412.73868, 200.93428, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(645.4029, 170.7239, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1104.2498, 138.54944, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1222.7174, 14.795301, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1270.4829, 375.93417, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1370.1029, 218.8567, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1521.3722, 404.05157, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1583.9613, 217.78738, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1789.37, 421.45926, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1841.9105, 248.01749, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1157.7384, 664.03253, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1152.0715, 913.2797, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(838.26025, 846.5001, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(1014.4024, 780.514, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(229.61848, 821.35046, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-39.386272, 786.5136, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(78.68796, 651.531, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-280.6421, 695.7873, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(25.129946, 1311.8921, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(-35.947823, 1554.6339, 100));
		AddSpawnPoint("f_dcapital_107.Id1", "f_dcapital_107", Rectangle(135.68752, 1455.292, 100));

		// 'Kigle' GenType 15 Spawn Points
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1256.7908, -809.9263, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1393.5969, -806.78516, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1420.1677, -1092.6843, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1230.1168, -1113.8928, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1018.7307, -1058.763, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(950.48755, -1269.2125, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(739.6495, -1129.7306, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(439.1801, -1157.5321, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(477.0662, -1016.062, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(208.14465, -955.65173, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(385.41974, -892.94806, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(346.81015, -711.0485, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-131.24197, -855.8512, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-349.63156, -925.901, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-550.5255, -885.1566, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-498.9044, -585.8971, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-293.93042, -726.2342, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-203.31363, -401.1894, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-769.7388, -869.56525, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1143.0692, -890.9386, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1654.2257, -744.57336, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1511.3912, -957.6275, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1476.7794, -620.6814, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1328.4126, -887.727, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1265.9441, -531.4995, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1233.4807, -724.9736, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1184.0549, -256.70557, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-940.66144, -83.85296, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1094.3102, 37.331074, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-770.3682, -12.338173, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-743.9748, 221.707, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-901.3949, 222.60593, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-913.06506, 492.93207, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-812.70917, 697.58356, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-829.3365, 901.6768, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-914.81104, 814.9639, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1082.8632, 917.3092, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1221.9099, 733.5541, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1084.2692, 670.73517, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1252.9084, 349.1453, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1368.966, 554.6691, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1547.4349, 223.37413, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1558.3334, 407.8424, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1705.1637, 476.39517, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1629.923, 657.52954, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(247.11162, -419.20917, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(542.09204, -600.4029, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(548.0349, -298.9222, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(122.21391, -130.89601, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-199.53317, 126.02164, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(162.02252, 250.43475, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(668.8092, 194.36436, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-100.98564, -562.89075, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-64.277855, -714.15405, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-1481.8771, -789.63293, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(-918.3618, 53.382957, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(578.6344, -1067.9705, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(1225.8035, -977.72266, 25));
		AddSpawnPoint("f_dcapital_107.Id2", "f_dcapital_107", Rectangle(322.08975, -1058.473, 25));

		// 'Kiglelops' GenType 16 Spawn Points
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(1336.9932, -874.96625, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(1040.196, -1143.7621, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(321.54645, -1052.3468, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-161.52072, -587.28345, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-443.0159, -827.3365, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-906.76447, -860.9045, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-1327.2776, -888.3694, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-1475.2452, -622.6863, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-1084.0353, -86.43897, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-783.508, 187.98152, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-915.40375, 820.4575, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(-1427.6339, 425.69357, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(460.05032, -529.37756, 25));
		AddSpawnPoint("f_dcapital_107.Id3", "f_dcapital_107", Rectangle(559.0695, 128.74629, 25));

		// 'Bishop_Blanco' GenType 17 Spawn Points
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(578.40454, 286.1455, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(456.99774, -462.6981, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-40.85491, 266.59283, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(545.3508, -5.3684273, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(1166.2493, 116.97848, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(1237.8505, 515.32043, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(1542.0487, 247.23782, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(1754.7874, 437.8977, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(904.21, 920.0297, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(443.20175, 724.31854, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(205.63226, 962.3209, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(127.5938, 614.4605, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-217.29192, 775.2245, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-18.641602, 1166.3035, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-36.818405, 1568.1095, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(143.61719, 1436.6035, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-20.620459, 668.67096, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(-124.87167, 81.76118, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(616.05414, -276.00128, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(174.99487, -162.35834, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(191.49338, -510.08044, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(944.0487, 147.40714, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(1410.3278, 428.73483, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(446.456, 908.96216, 25));
		AddSpawnPoint("f_dcapital_107.Id4", "f_dcapital_107", Rectangle(326.4247, -345.8718, 25));

		// 'Bishop_Gray' GenType 18 Spawn Points
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(324.39447, -579.6212, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(189.52008, -301.7526, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(457.39804, 164.69336, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(39.406815, 90.27475, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(286.41275, 790.15344, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-48.398235, 851.11017, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(649.3354, 897.99866, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(885.7725, 694.0033, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1080.482, 840.31836, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1311.3351, 299.6024, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1570.456, 421.2295, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1764.9966, 292.91623, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-51.718414, 1369.1582, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-259.13153, -87.10201, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-295.6707, 295.2315, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(81.52133, 427.7556, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1132.892, 344.55652, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(485.01205, -141.6127, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(578.9125, -647.0126, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(119.72644, 808.20447, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(1175.2134, 721.12427, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(721.62103, 93.19296, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-295.4818, 130.67203, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(231.49625, 281.5006, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(-309.11218, 670.16644, 25));
		AddSpawnPoint("f_dcapital_107.Id5", "f_dcapital_107", Rectangle(427.504, -675.7312, 25));
	}
}
