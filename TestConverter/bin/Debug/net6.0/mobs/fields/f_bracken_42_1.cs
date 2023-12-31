//--- Melia Script -----------------------------------------------------------
// f_bracken_42_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Khonot Forest' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FBracken421MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("f_bracken_42_1", MonsterId.Tanu_Blue, Properties("MHP", 462787, "MINPATK", 6452, "MAXPATK", 7832, "MINMATK", 6452, "MAXMATK", 7832, "DEF", 65300, "MDEF", 65300));
		AddPropertyOverrides("f_bracken_42_1", MonsterId.Doyor_Blue, Properties("MHP", 464199, "MINPATK", 6470, "MAXPATK", 7854, "MINMATK", 6470, "MAXMATK", 7854, "DEF", 65866, "MDEF", 65866));
		AddPropertyOverrides("f_bracken_42_1", MonsterId.Gosaru_Blue, Properties("MHP", 465703, "MINPATK", 6489, "MAXPATK", 7878, "MINMATK", 6489, "MAXMATK", 7878, "DEF", 66470, "MDEF", 66470));
		AddPropertyOverrides("f_bracken_42_1", MonsterId.Folibu_Yellow, Properties("MHP", 467293, "MINPATK", 6510, "MAXPATK", 7903, "MINMATK", 6510, "MAXMATK", 7903, "DEF", 67107, "MDEF", 67107));

		// Monster Spawners ---------------------------------

		AddSpawner("f_bracken_42_1.Id1", MonsterId.Rootcrystal_01, 12, 15, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_1.Id2", MonsterId.Tanu_Blue, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_1.Id3", MonsterId.Doyor_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_1.Id4", MonsterId.Gosaru_Blue, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_1.Id5", MonsterId.Folibu_Yellow, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_bracken_42_1.Id6", MonsterId.Gosaru_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_01' GenType 5 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-1019.1104, -528.30536, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-813.99274, -482.49237, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-824.90704, -295.45184, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-506.0483, 85.92135, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-467.81744, 448.87744, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-1183.7922, 289.9943, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-344.41068, -341.37653, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-446.73175, -625.0893, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(-743.1105, 893.2053, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(63.36149, 822.2166, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(168.90297, 961.77527, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(762.24347, 674.4773, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(1079.4319, 563.66315, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(274.34717, 422.75003, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(356.48828, -178.44296, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(92.957375, 86.97126, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(134.6326, -450.27225, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(905.16406, -599.0763, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(711.4374, -172.76227, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(1004.5899, -2.8945103, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(1787.3322, -172.43341, 50));
		AddSpawnPoint("f_bracken_42_1.Id1", "f_bracken_42_1", Rectangle(2007.0947, -389.3542, 50));

		// 'Tanu_Blue' GenType 100 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-906.6536, -327.25, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-991.5913, -582.05963, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-1044.7108, -572.94464, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-913.96844, -519.51, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-898.36035, -429.5808, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-861.8837, 174.37477, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-728.57764, 218.0836, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-572.52966, 223.23798, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-1152.6621, 341.74777, 30));
		AddSpawnPoint("f_bracken_42_1.Id2", "f_bracken_42_1", Rectangle(-963.25555, 272.55154, 30));

		// 'Doyor_Blue' GenType 101 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-603.57086, 239.29771, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-554.33203, 57.069885, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-415.62073, 226.96622, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-475.98856, -547.7301, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-416.25446, -717.977, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-369.21667, -516.5885, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-223.81738, -510.7156, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-213.27425, -580.044, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-498.74, -480.39105, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-882.74255, 848.58057, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-766.6797, 936.23566, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-687.8616, 619.55634, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-646.2388, 795.13605, 30));
		AddSpawnPoint("f_bracken_42_1.Id3", "f_bracken_42_1", Rectangle(-290.78577, -453.31677, 30));

		// 'Gosaru_Blue' GenType 103 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-22.142948, -142.7724, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(146.2748, -255.95256, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(325.86584, -277.36844, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(417.57587, -174.89023, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(208.06345, 220.18149, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-4.9466715, 767.68097, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(68.3875, 891.33325, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(104.08302, 799.3336, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(192.83157, 532.1925, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(213.85463, 346.5204, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(854.07416, -601.14374, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(797.3716, -524.78735, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(722.8746, -348.0858, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(706.8423, -221.6021, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(853.68677, -431.95676, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1023.7296, -414.07318, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(860.52374, -341.80725, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(673.084, -109.99751, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(900.90497, -90.13181, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(833.2329, -184.65724, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1008.2418, -168.937, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(820.6365, 2.7267609, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(949.69055, 17.615213, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1036.7688, -47.537514, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(910.49976, 339.8058, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(767.20264, 384.56158, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(733.60443, 527.6488, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(767.60815, 729.1974, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(914.1431, 736.01965, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1102.3652, 656.56616, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1132.2385, 597.9043, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(1064.508, 469.42834, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(963.3784, 472.56302, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(874.87726, 486.6811, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(832.75134, 574.76117, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(994.3597, 638.60474, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(351.77823, -141.76784, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(164.67212, -354.31314, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(23.503061, -338.99393, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-63.98709, -6.3284264, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-0.99798965, 50.604263, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(225.89116, -114.0145, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(256.62006, 24.296497, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(230.72038, 119.17892, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(124.54146, 31.2235, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(110.85326, -139.40935, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-413.2651, -591.85693, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-465.6441, -625.30756, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-288.62198, -416.94608, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-412.6735, -460.08475, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-396.8714, -362.7647, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-289.8697, -570.09235, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-188.01956, -459.18967, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1019.2015, -646.4444, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1032.5731, -529.44885, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-918.30304, -555.0375, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1019.0345, -479.04935, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-947.8093, -443.81607, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-981.5462, -390.73846, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-810.419, -511.62704, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-772.3146, -346.2279, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-806.44507, -293.14157, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-338.02945, -99.49479, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-367.9893, -175.08054, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-403.9419, 34.93445, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-463.58295, -4.052368, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-547.83905, 29.610798, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-607.51733, 81.8755, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-593.86993, 157.8966, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-515.0547, 167.3049, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-392.46237, 261.97516, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-688.5257, 231.2445, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-636.056, 225.00381, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-710.7428, 181.78346, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-889.7114, 224.04507, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-927.24384, 292.3751, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-956.7589, 229.08191, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1190.6609, 320.8875, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1229.7908, 222.74896, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1300.1239, 240.26273, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-1250.1178, 181.04596, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-839.1385, 894.843, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-829.8981, 802.1247, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-771.2858, 734.7536, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-633.49756, 633.33704, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-698.006, 785.11127, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-743.9333, 967.5647, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-723.1381, 879.0285, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(-647.29694, 839.7341, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(212.95105, 446.33545, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(286.14032, 427.9191, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(244.11507, 482.3459, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(245.81444, 411.64273, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(221.50832, 389.4681, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(10.118592, 819.941, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(272.42316, 926.7545, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(199.36276, 811.83813, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(211.19394, 960.5843, 30));
		AddSpawnPoint("f_bracken_42_1.Id4", "f_bracken_42_1", Rectangle(119.54857, 989.411, 30));

		// 'Folibu_Yellow' GenType 104 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(843.4811, 739.56934, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(731.80695, 603.92395, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(1079.8813, 660.832, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(956.5759, 674.8797, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(1080.9106, 791.5587, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(878.0611, 318.58344, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(1110.8279, 473.24527, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(748.4048, -411.1576, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(880.7563, -533.72095, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(730.8722, -129.32672, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(887.91656, 12.880224, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(1043.889, -126.38797, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(854.4557, -146.49167, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(750.5209, 8.665512, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(993.392, -271.26154, 30));
		AddSpawnPoint("f_bracken_42_1.Id5", "f_bracken_42_1", Rectangle(855.4387, -255.67798, 30));

		// 'Gosaru_Blue' GenType 105 Spawn Points
		AddSpawnPoint("f_bracken_42_1.Id6", "f_bracken_42_1", Rectangle(188.75525, 362.49765, 9999));
	}
}
