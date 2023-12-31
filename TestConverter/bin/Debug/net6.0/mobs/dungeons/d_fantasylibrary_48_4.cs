//--- Melia Script -----------------------------------------------------------
// d_fantasylibrary_48_4
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Valandis Room 3' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DFantasylibrary484MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("d_fantasylibrary_48_4", MonsterId.Lapinel, Properties("MHP", 557143, "MINPATK", 7665, "MAXPATK", 9323, "MINMATK", 7665, "MAXMATK", 9323, "DEF", 106194, "MDEF", 106194));
		AddPropertyOverrides("d_fantasylibrary_48_4", MonsterId.Lapindal, Properties("MHP", 560242, "MINPATK", 7705, "MAXPATK", 9372, "MINMATK", 7705, "MAXMATK", 9372, "DEF", 107727, "MDEF", 107727));
		AddPropertyOverrides("d_fantasylibrary_48_4", MonsterId.Wisnol, Properties("MHP", 563433, "MINPATK", 7746, "MAXPATK", 9422, "MINMATK", 7746, "MAXMATK", 9422, "DEF", 109305, "MDEF", 109305));
		AddPropertyOverrides("d_fantasylibrary_48_4", MonsterId.Lampal, Properties("MHP", 566714, "MINPATK", 7788, "MAXPATK", 9474, "MINMATK", 7788, "MAXMATK", 9474, "DEF", 110927, "MDEF", 110927));
		AddPropertyOverrides("d_fantasylibrary_48_4", MonsterId.Boss_Lucy_Q1, Properties("MHP", 2907421, "MINPATK", 18796, "MAXPATK", 22865, "MINMATK", 18796, "MAXMATK", 22865, "DEF", 270222, "MDEF", 270222));

		// Monster Spawners ---------------------------------

		AddSpawner("d_fantasylibrary_48_4.Id1", MonsterId.Rootcrystal_03, 12, 15, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_4.Id2", MonsterId.Lapinel, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_4.Id3", MonsterId.Lapindal, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_4.Id4", MonsterId.Wisnol, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("d_fantasylibrary_48_4.Id5", MonsterId.Lampal, 49, 65, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_03' GenType 6 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1134.5206, -1379.6611, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-989.09973, -1231.4913, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-969.7705, -1476.3635, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1166.2251, -1525.0631, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-465.0904, -1483.9729, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-397.3468, -1148.3463, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-271.67267, -1343.43, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1146.332, -518.7826, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1125.0372, -305.55655, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-994.45636, -434.52054, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-687.5599, 5.5283823, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-690.38, 244.65353, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-391.828, 342.22507, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-545.0738, 151.52997, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-360.80728, 3.6111965, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(54.51652, 290.56512, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(294.244, 514.51514, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(106.91659, 516.12305, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(264.74496, 332.1578, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(479.61475, 14.948986, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(458.1632, -358.35324, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(658.2558, -301.4735, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(823.29645, 296.73047, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(795.8264, 543.1282, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(973.0222, 567.5462, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1091.7722, 414.3975, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1076.7476, 265.45428, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(943.6579, 368.4554, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(941.6919, 997.1467, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(988.04376, 1112.5554, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1326.422, 879.8909, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1621.488, 786.6807, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1561.2914, 1008.3436, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1789.3525, 1033.489, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1849.9755, 812.6355, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(1671.9332, 895.29987, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-158.64929, 609.4406, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-305.80823, 749.8493, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-557.84735, 883.3318, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-787.7302, 928.2226, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-677.72986, 1151.8268, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-416.58932, 1110.5831, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-578.5103, 993.0508, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-245.35735, 1135.5388, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1085.2411, 825.55225, 100));
		AddSpawnPoint("d_fantasylibrary_48_4.Id1", "d_fantasylibrary_48_4", Rectangle(-1029.2681, 978.2351, 100));

		// 'Lapinel' GenType 18 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1163.4834, -245.94392, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1098.0262, -293.93933, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1204.4055, -386.10577, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1118.2144, -399.85352, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1242.8835, -558.3682, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1128.0349, -482.1349, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1036.6644, -525.3047, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-979.5729, -369.6482, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1015.3399, -250.10474, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-989.7271, -608.5961, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1033.0967, -1134.5603, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-962.27484, -1213.2888, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1138.8655, -1229.2255, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1090.5273, -1327.2346, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1242.7659, -1369.2483, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1105.2852, -1413.2374, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1193.8188, -1538.3685, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-965.81165, -1547.9528, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-1024.1326, -1391.9082, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-904.2562, -1369.3325, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-607.3044, -1360.933, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-515.42896, -1356.543, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-460.12872, -1490.3644, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-399.74765, -1323.3716, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-280.33206, -1367.134, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-325.02127, -1491.0862, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-213.83032, -1213.3201, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-384.7322, -1126.8605, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-423.82358, -1246.489, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id2", "d_fantasylibrary_48_4", Rectangle(-568.84076, -1170.9812, 40));

		// 'Lapindal' GenType 19 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-1120.7291, 955.6426, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-983.82025, 1001.1643, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-1043.5857, 910.76245, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-1107.6394, 783.5933, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-1191.4633, 863.6559, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-644.52057, 953.6997, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-620.90704, 1053.5668, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-488.0721, 1014.2466, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-556.71625, 897.7216, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-455.97604, 904.0089, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-301.9455, 1179.788, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-352.3428, 921.6724, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-229.47054, 1108.2148, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-361.76102, 756.90735, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-549.62775, 670.4043, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-742.8513, 349.84158, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-567.07446, 397.69556, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-637.51514, 192.49312, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-479.9878, 333.68265, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-378.01343, 145.68185, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-559.7796, 121.25316, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-713.7645, 55.824417, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-701.7332, -49.181557, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-463.5875, 17.27645, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-348.61398, 357.7419, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(68.06267, 513.4143, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(96.77382, 213.10802, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(-40.321693, 357.66788, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(386.16776, 355.57492, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id3", "d_fantasylibrary_48_4", Rectangle(241.11688, 602.3579, 40));

		// 'Wisnol' GenType 20 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(752.84973, 447.48514, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(866.07104, 590.3238, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(882.8303, 405.36127, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1025.6974, 559.3295, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1053.1174, 280.2007, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(937.18427, 1035.6191, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(947.88873, 1147.154, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1086.9868, 1089.4165, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1268.3953, 1031.1367, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1445.2799, 835.3069, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1641.3557, 1115.9122, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1565.7657, 959.9642, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1707.0966, 1023.1536, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1665.5651, 852.5683, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1799.1295, 880.98236, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1846.9813, 1106.1178, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1644.0728, 680.4797, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1928.7893, 884.4195, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(1487.8951, 1113.7935, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(999.2372, 355.7958, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(823.34174, 228.27109, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(353.25735, 168.63391, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(500.16357, 61.028614, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(127.90601, 376.7025, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(278.1997, 378.70508, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(550.4783, -95.52411, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(935.87976, 677.4305, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(194.51973, 456.51797, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(485.8637, 382.38696, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id4", "d_fantasylibrary_48_4", Rectangle(604.4156, 382.43835, 40));

		// 'Lampal' GenType 21 Spawn Points
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1111.725, 874.2183, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1047.4818, 1018.6533, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1021.6224, 824.67804, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-913.4173, 973.537, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-949.8846, 878.66876, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-744.1163, 1028.5022, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-725.86707, 914.8468, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-531.36554, 1083.0264, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-589.4272, 830.952, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-411.7716, 1059.9666, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-427.60574, 792.9416, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-289.83124, 793.49493, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-313.68872, 688.1552, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-163.8393, 556.8808, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-82.15341, 635.4315, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-17.81118, 472.42035, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(114.70308, 579.5842, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(60.857296, 311.19608, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(270.17105, 291.48477, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(277.65067, 477.15454, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(502.3612, -312.26294, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(489.21307, -438.8632, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(658.72217, -344.5082, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(653.84296, -473.05682, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(587.0914, -213.91867, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(758.1324, 536.9573, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(785.31537, 362.36624, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(933.0798, 569.0427, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1052.6268, 445.9231, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(914.3455, 249.13748, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(872.0144, 1064.5052, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(943.733, 968.17035, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1090.3527, 1028.8623, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(993.0981, 1058.761, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1023.8353, 1176.0814, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1203.3704, 1004.9952, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1211.6481, 883.9784, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1328.488, 899.22546, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1510.1635, 895.9953, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1536.4336, 1044.0006, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1610.8156, 793.9943, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1752.817, 765.5791, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(1790.2017, 988.90015, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(425.2897, 129.76546, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(510.4387, -39.822952, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-628.59973, 312.6268, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-707.53125, 168.11603, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-604.2204, 1.563591, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-398.69702, 64.865875, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-452.90527, 210.15857, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1197.5938, -309.1252, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1202.1735, -445.2524, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1158.6105, -553.4415, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1032.4548, -451.3937, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-944.1447, -270.61853, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1163.4475, -1289.4667, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1245.5386, -1447.6449, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1005.9182, -1307.6891, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-1071.5858, -1530.938, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-955.7223, -1434.4325, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-566.4586, -1285.4536, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-487.09155, -1211.3661, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-536.1859, -1423.5837, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-387.6219, -1401.6353, 40));
		AddSpawnPoint("d_fantasylibrary_48_4.Id5", "d_fantasylibrary_48_4", Rectangle(-318.29654, -1214.8223, 40));
	}
}
