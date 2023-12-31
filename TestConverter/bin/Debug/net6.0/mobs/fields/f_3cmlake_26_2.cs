//--- Melia Script -----------------------------------------------------------
// f_3cmlake_26_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Lanko 22 Waters' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class F3Cmlake262MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_3cmlake_26_2.Id1", MonsterId.RootCrystal_A, 18, 23, TimeSpan.FromMilliseconds(10000), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_2.Id2", MonsterId.Lakegolem, 6, 7, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_2.Id3", MonsterId.Pondus, 27, 36, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_2.Id4", MonsterId.Anchor_Golem, 13, 17, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_2.Id5", MonsterId.Lily_Belly, 33, 44, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_3cmlake_26_2.Id6", MonsterId.Jelly_Belly, 35, 46, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'RootCrystal_A' GenType 61 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(765.927, 1451.1746, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(594.3167, 865.70166, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(1224.8016, 1092.8734, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(383.2664, 898.3427, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-222.12094, 1104.2004, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-793.1015, 1033.4653, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-1363.0862, 1011.571, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-1768.4524, 1013.8226, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-238.1845, 614.09564, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-313.60245, -104.79085, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-297.69025, -631.3008, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-285.9753, -1196.553, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-180.37589, -1689.1405, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(-553.19116, -1775.9662, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(248.4079, -678.9129, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(572.5966, -866.0591, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(999.55206, -818.6361, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(669.5252, -244.10724, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(646.53296, 178.14214, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(1425.2676, -1104.6572, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(1783.5209, -743.7071, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(1465.7047, -347.00473, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id1", "f_3cmlake_26_2", Rectangle(1617.3821, 62.831596, 40));

		// 'Lakegolem' GenType 70 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(677.36115, 899.8324, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(-372.72678, 49.086067, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(718.59296, 38.071335, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(1390.6343, -837.06494, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(1527.8348, 52.409477, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(-336.33414, -1634.8701, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id2", "f_3cmlake_26_2", Rectangle(730.9994, -808.23706, 40));

		// 'Pondus' GenType 72 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(466.65958, 1035.9548, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(525.5591, 674.4802, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(704.7686, 748.08624, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(961.5798, 804.72864, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1290.1787, 1127.698, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1484.9065, 893.8273, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1476.1682, 1202.3519, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-471.99622, 162.36977, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-433.9189, -62.910843, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1577.0779, 817.8256, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1678.6172, 1092.7499, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1338.2625, 864.33026, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(859.0354, 1091.9462, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(491.3488, 910.32153, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(733.7861, 1241.0427, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(669.41754, 1116.5365, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(818.59534, 869.4575, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(184.03981, 916.3045, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1026.2074, 1103.5043, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-250.36763, 402.3631, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1039.8054, 1053.0541, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-674.07764, 1024.313, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1702.6301, 901.2345, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1535.5021, 1038.8695, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-318.92798, 609.31036, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1836.0026, 791.816, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1865.9286, 1188.7133, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1276.2893, 1196.1713, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(827.5302, 691.8107, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1151.2335, 926.70264, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1415.9684, 1021.5703, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1679.3328, 1275.8986, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(1320.7501, 842.626, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-158.22198, -63.88211, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-598.6778, -113.25985, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id3", "f_3cmlake_26_2", Rectangle(-1884.365, 992.1131, 20));

		// 'Anchor_Golem' GenType 73 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(768.0251, 1333.0253, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(551.3648, 781.7075, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(757.4333, 1002.4451, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(1293.842, 964.75616, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(1593.923, 1174.3865, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-1514.1985, 1153.2716, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-1487.563, 905.735, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-508.99838, 61.105347, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-240.285, 213.36313, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-167.16168, -1466.7845, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(157.59338, -674.07587, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-145.81429, -1821.7325, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-333.51828, -736.8718, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-498.5485, -1772.8888, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-286.37302, -343.6688, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-125.35976, -710.21295, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-183.55083, -901.0038, 20));
		AddSpawnPoint("f_3cmlake_26_2.Id4", "f_3cmlake_26_2", Rectangle(-276.09885, -1201.6188, 20));

		// 'Lily_Belly' GenType 74 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(563.6876, -1003.1885, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(740.7352, -664.0275, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(811.1459, -904.85175, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(515.55914, 59.2928, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(838.0328, 169.8683, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(927.3132, -175.4112, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1211.6155, -809.5903, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1429.3335, -728.0414, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1712.4116, -1147.0306, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1436.871, -998.59045, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1591.9194, -1256.9619, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1028.6287, -826.098, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1702.0663, -985.01086, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1363.6584, -1109.1327, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(692.27454, -934.69476, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(656.72235, -388.34338, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(425.2134, -885.80206, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1271.5381, -1005.3289, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1845.2845, -1139.5347, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1800.0906, -868.1417, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1472.8932, -496.3085, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1467.1093, -273.2987, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1301.194, -221.80788, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1423.2671, 67.65735, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1320.4957, 87.005165, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1599.0476, -181.95206, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1612.1659, -16.532848, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1739.22, 3.2524061, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(541.04626, -773.80035, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(653.45447, -145.18433, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(942.8122, 86.97578, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(368.78198, 87.58212, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1193.4158, -1090.0764, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1939.321, -847.70215, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1541.3276, -880.1653, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1695.8864, -127.07306, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1697.1276, 139.2088, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1548.6024, -1113.846, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1331.6349, -933.80853, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1672.7675, -779.51306, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1382.4784, -153.49823, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(821.56055, -1014.8431, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1330.9797, -26.882427, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id5", "f_3cmlake_26_2", Rectangle(1562.359, 163.47049, 40));

		// 'Jelly_Belly' GenType 75 Spawn Points
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-269.4029, -1889.8595, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-478.79224, -1682.5437, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-223.12968, -1557.5409, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-295.74445, -214.0307, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-102.73128, -964.61426, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-226.33841, -705.9642, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-297.57965, -848.9318, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(434.615, -705.17126, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(712.9976, -1054.2815, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(652.4209, -756.2854, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(922.2029, -57.42057, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(700.1943, 191.75568, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(501.2392, -184.53311, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(467.41586, -62.682304, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(673.3386, -496.20972, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(571.4604, -629.15515, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-450.6584, -1883.0293, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-55.540565, -1587.351, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-376.62253, -1478.1771, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-296.72452, -1383.2242, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-189.88214, -1145.9015, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-458.29486, -856.353, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-59.66105, -689.8206, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-196.21698, -584.5939, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-391.58374, -701.4755, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-600.95166, 130.48386, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-502.6169, -150.96928, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-426.3126, 281.2022, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(54.91655, -683.6951, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(575.31335, -24.847305, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-185.26578, 37.86177, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-625.2235, -9.474468, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-338.4276, 139.01562, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-339.5813, -570.38965, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-532.7346, -692.84296, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-400.85022, -950.6241, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-193.3073, -801.3829, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-30.524307, -1893.0626, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(90.29733, -1700.1777, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-179.03, -1746.5381, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-372.6721, -1780.4053, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(-37.747437, -801.63696, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(450.07327, 181.51863, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(815.40424, -151.08641, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(807.0903, -779.0134, 40));
		AddSpawnPoint("f_3cmlake_26_2.Id6", "f_3cmlake_26_2", Rectangle(519.3876, -888.9964, 40));
	}
}
