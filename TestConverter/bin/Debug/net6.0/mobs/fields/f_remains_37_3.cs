//--- Melia Script -----------------------------------------------------------
// f_remains_37_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Istora Ruins' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FRemains373MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_remains_37_3.Id1", MonsterId.Rootcrystal_04, 30, 40, TimeSpan.FromMilliseconds(60000), TendencyType.Peaceful);
		AddSpawner("f_remains_37_3.Id2", MonsterId.Hallowventor_Bow, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_remains_37_3.Id3", MonsterId.Hallowventor_Mage, 18, 23, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_remains_37_3.Id4", MonsterId.Gravegolem_Blue, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_remains_37_3.Id5", MonsterId.Gravegolem_Blue, 75, 100, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_04' GenType 3 Spawn Points
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-550.6834, -1423.7885, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-484.28986, -1088.6875, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-773.70715, -992.41907, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-1002.7051, -1137.3541, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-1443.0801, -1248.5543, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-671.2426, -816.45996, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-756.5719, -306.31873, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-1176.9601, -434.42566, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-1406.7146, -511.58398, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-1708.9005, -476.8744, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-2020.4995, -466.1067, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-42.98626, -497.27795, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(433.8116, -545.14526, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(236.18689, -989.9939, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(145.25284, -1310.9121, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(569.9773, -1434.015, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-581.63, -627.5182, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-1167.0414, 209.4558, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-1449.8876, 490.21643, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-1327.5361, 1146.6765, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-1702.6774, 1401.8494, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-2258.0437, 1321.0035, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-2732.7544, 1541.9141, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-2718.615, 1971.222, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-745.1338, 470.1064, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(-368.0549, 186.3439, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(104.20036, 37.70671, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(509.46494, 134.19461, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(770.3299, -147.69865, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(881.35785, 409.91873, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(1223.0547, -15.50415, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(1613.1216, 109.75835, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(2057.45, 26.409012, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(2438.3293, -162.22005, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(750.1806, 815.026, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(910.67566, 1120.0337, 40));
		AddSpawnPoint("f_remains_37_3.Id1", "f_remains_37_3", Rectangle(479.20892, 1207.2494, 40));

		// 'Hallowventor_Bow' GenType 19 Spawn Points
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1935.0314, -576.5055, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1698.0435, -532.55817, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1795.5525, -342.25763, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1606.2207, 1337.8214, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1292.2257, 1200.4517, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1188.5566, 1412.3699, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1588.6046, 185.72934, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1403.703, 13.681137, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1162.0365, 355.12106, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1398.2686, 434.30276, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1413.5172, 264.70224, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-2737.6199, 1523.8444, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-2503.357, 1302.8265, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-2503.7974, 1517.6615, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1490.3258, -1237.1628, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1356.2643, -1396.8352, 40));
		AddSpawnPoint("f_remains_37_3.Id2", "f_remains_37_3", Rectangle(-1321.9365, -1011.1594, 40));

		// 'Hallowventor_Mage' GenType 20 Spawn Points
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(83.10481, -443.62772, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(404.72626, -621.4092, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(450.48944, -418.90558, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(656.57733, 38.561203, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(966.4826, 80.41556, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(1113.9, 267.15338, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(685.2808, 301.41943, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(-754.9486, -982.0398, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(-574.2095, -1121.1963, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(-533.8475, -1001.0529, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(-262.6568, 225.56897, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(-39.035576, 44.295498, 40));
		AddSpawnPoint("f_remains_37_3.Id3", "f_remains_37_3", Rectangle(919.4996, -175.51938, 40));

		// 'Gravegolem_Blue' GenType 37 Spawn Points
		AddSpawnPoint("f_remains_37_3.Id4", "f_remains_37_3", Rectangle(834.8967, 84.41411, 9999));

		// 'Gravegolem_Blue' GenType 40 Spawn Points
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(79.01529, -531.9113, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(296.33447, -417.5515, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(363.66254, -571.3885, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(548.5055, -431.89978, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1559.4564, -1203.8462, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1467.13, -1030.114, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1295.841, -1262.9219, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1986.0023, -449.44745, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1804.6555, -268.10068, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1684.2562, -595.5973, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-735.1847, -1141.0444, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-675.7696, -966.57446, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-446.91803, -1134.7385, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1615.1204, 1194.0768, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(912.9664, 213.72551, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(816.43665, 9.574799, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(899.2147, -226.39536, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(568.08466, 123.22202, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(502.24365, -57.89226, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(779.91437, 393.5844, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-302.2668, 146.50584, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-219.12915, 284.50568, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-11.56234, 139.33807, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-271.8646, 65.809784, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(701.19476, 1305.8286, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(580.45416, 1181.369, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(536.6075, 1274.7642, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1554.3683, -113.96239, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1387.5367, 248.0063, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1198.3972, 55.21805, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1116.3085, 531.3103, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1399.7219, 511.07776, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1124.1552, 1459.8503, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1613.5038, 1289.0154, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1395.9333, 1486.3672, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(383.12482, -286.38333, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(152.44327, -411.28726, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-43.61644, 65.99262, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1612.9117, 361.37518, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-130.17728, 397.1717, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1553.0625, 1441.3901, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1679.7157, -479.7812, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1700.4866, -1103.8267, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(511.4243, -328.9765, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(251.41035, 1220.6622, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(1158.4812, -42.554127, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(1165.8583, -173.48996, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(1065.8414, -196.62585, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1798.6229, 1304.0502, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(1041.7115, -338.20267, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(746.38617, -347.45233, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(603.98865, -210.35413, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(406.59604, -119.85662, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(745.07404, -138.19846, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(388.2871, 9.46619, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(480.4804, 110.31815, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(731.45087, 148.93819, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(543.56793, 253.59457, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(812.13214, 287.24268, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(640.2115, 400.6709, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(879.51105, 397.9726, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(1086.5029, 142.4237, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(1265.3339, 170.28844, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(1303.8497, 50.98358, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(977.87646, -39.979874, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(622.6182, -30.966911, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(926.0807, 108.86919, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1158.086, 1344.2992, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(1269.4801, -68.82899, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(1120.05, 370.45367, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(894.78546, 1152.486, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(858.088, 951.37177, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(751.49994, 999.69135, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(639.0236, 1027.4451, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(527.3835, 1062.6267, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(297.3686, 1119.8811, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1090.2081, 1192.0986, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(582.03094, 1379.8073, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(753.3208, 1395.4218, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(935.51196, 1370.4146, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(980.78094, 1226.4159, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(1007.431, 1117.5073, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(983.1313, 1006.2744, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1305.8542, 1091.5143, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-172.50766, 56.79851, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-469.86774, 278.7256, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-416.67258, 47.802376, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1417.912, 1317.4647, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(733.50494, 1157.1848, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(679.23615, 1447.5773, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(371.46594, 1225.0156, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(300.0289, 1363.8784, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(459.8157, 1354.1548, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-1454.0135, 1160.8964, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(604.75024, 954.44806, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(599.7596, -565.72644, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(553.0401, -712.7095, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(429.29672, -743.7615, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(468.20306, -587.4903, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(294.80194, -748.1304, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(259.94888, -555.7075, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(152.9327, -711.1988, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(4.5099106, -636.0803, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-96.410126, -523.59827, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(-4.2485065, -359.49954, 20));
		AddSpawnPoint("f_remains_37_3.Id5", "f_remains_37_3", Rectangle(197.03635, -277.3984, 20));
	}
}
