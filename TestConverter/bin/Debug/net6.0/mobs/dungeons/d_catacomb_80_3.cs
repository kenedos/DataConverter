//--- Melia Script -----------------------------------------------------------
// d_catacomb_80_3
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Michmas Temple' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DCatacomb803MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_catacomb_80_3.Id1", MonsterId.ERD_Cronewt_Blue, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id2", MonsterId.ERD_Infroholder_Red, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id3", MonsterId.ERD_Cronewt_Bow_Blue, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id4", MonsterId.ERD_Cronewt_Mage_Blue, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id5", MonsterId.ERD_Hohen_Gulak, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id6", MonsterId.ERD_Socket_Green, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id7", MonsterId.ERD_Socket_Mage_Green, 11, 14, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id8", MonsterId.ERD_Siaulav_Bow_Blue, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id9", MonsterId.ERD_Siaulav_Blue, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id10", MonsterId.ERD_Siaulav_Mage_Blue, 14, 18, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id11", MonsterId.ERD_Nuka, 18, 24, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id12", MonsterId.ERD_Elma, 18, 24, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_catacomb_80_3.Id13", MonsterId.Rootcrystal_05, 23, 30, TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'ERD_Cronewt_Blue' GenType 8 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-699.30505, -2544.3264, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-597.1467, -2690.9375, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-566.08795, -2383.5308, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-431.00653, -2345.9502, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-284.53766, -2301.8271, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-198.44026, -2136.223, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-158.6977, -1751.256, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-24.136736, -2072.5642, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(155.53146, -2085.2524, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(190.65707, -1821.4297, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(270.95438, -1705.9504, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(4.6126595, -1592.5956, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-162.03029, -1172.3954, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(144.07526, -1116.6437, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-131.06659, -963.0621, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(171.31041, -980.51556, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-478.83783, -2606.4788, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-124.22125, -1863.5962, 25));
		AddSpawnPoint("d_catacomb_80_3.Id1", "d_catacomb_80_3", Rectangle(-120.33106, -790.06006, 25));

		// 'ERD_Infroholder_Red' GenType 9 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-534.6194, -2511.8774, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-644.7955, -2613.5823, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-353.9234, -2260.4143, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(22.443134, -1769.8403, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(121.60693, -1972.0707, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-98.86423, -1968.3981, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(70.41471, -2099.5903, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(213.07373, -1909.266, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-4.794443, -1331.0415, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-239.91743, -1037.2947, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(148.50249, -740.4412, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-206.1332, -812.3478, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(29.718243, -1131.6954, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(264.8673, -1101.9733, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(137.27771, -840.3366, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(771.57416, -907.63873, 25));
		AddSpawnPoint("d_catacomb_80_3.Id2", "d_catacomb_80_3", Rectangle(-691.561, -959.9029, 25));

		// 'ERD_Cronewt_Bow_Blue' GenType 10 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-718.2156, -1151.349, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-815.8042, -998.9527, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-836.20557, -808.9809, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-707.42926, -733.38165, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-930.63464, -1169.5397, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-1013.3104, -1000.0464, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-1033.0508, -821.0948, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-938.7344, -716.14264, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(812.48083, -1162.461, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(943.0082, -1061.671, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(988.1887, -829.23016, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(867.2935, -700.2803, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(1171.2051, -700.16516, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(1223.8925, -862.60474, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(1221.558, -1025.8431, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(1119.1294, -1112.8009, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(58.271946, -757.78613, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-242.47525, -906.45953, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-63.70818, -1108.8026, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(98.74685, -1028.4401, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(303.38147, -793.65125, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(319.5213, -970.7849, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(-1121.7107, -938.45447, 25));
		AddSpawnPoint("d_catacomb_80_3.Id3", "d_catacomb_80_3", Rectangle(1114.4639, -963.56104, 25));

		// 'ERD_Cronewt_Mage_Blue' GenType 11 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1268.886, -190.05951, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1273.4387, 106.94523, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-877.7893, -235.97952, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-847.46326, 70.70862, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1068.6956, -259.81003, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1067.2026, 118.77677, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(909.2272, -217.932, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1065.7855, -205.29115, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1227.1146, -199.01524, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(941.773, 86.97646, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1085.4711, 94.82449, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1221.8799, 79.10514, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1370.8208, -1157.7351, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1463.3386, -1130.3854, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1305.8126, -752.61237, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(1401.0509, -692.93964, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1413.4744, -1179.5312, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1286.7308, -1139.8761, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1440.4615, -740.20764, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-1308.7118, -776.33527, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(-77.717255, -704.7915, 25));
		AddSpawnPoint("d_catacomb_80_3.Id4", "d_catacomb_80_3", Rectangle(104.72385, -650.8339, 25));

		// 'ERD_Hohen_Gulak' GenType 12 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(19.647501, -934.794, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(-1338.2491, -978.9608, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(1465.8081, -907.3217, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(794.4517, 965.10657, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(-694.19415, 952.6029, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(34.771187, 2330.0073, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(46.1681, -1990.5758, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(1436.0764, 1030.706, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(99.87804, 822.95544, 40));
		AddSpawnPoint("d_catacomb_80_3.Id5", "d_catacomb_80_3", Rectangle(-1416.6044, 938.8653, 40));

		// 'ERD_Socket_Green' GenType 13 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1132.6843, -762.85223, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1119.6454, -1114.8612, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1345.5559, -1064.6376, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1199.241, -793.1043, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(905.66754, -42.318737, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1002.1531, -138.88765, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1167.5149, -20.442352, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1237.6025, -97.73393, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1260.6342, 13.876163, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1128.7401, -125.21803, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1016.5915, -28.531128, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-918.85254, -148.35378, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-925.96716, 466.49017, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1211.3115, 486.94852, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1430.5587, 669.7919, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1292.6318, 748.5651, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(-1068.4186, 629.1352, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(970.58167, 342.68027, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(874.4138, 644.7206, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(985.77277, 736.47406, 25));
		AddSpawnPoint("d_catacomb_80_3.Id6", "d_catacomb_80_3", Rectangle(1148.9818, 699.8751, 25));

		// 'ERD_Socket_Mage_Green' GenType 14 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-749.12836, 686.6713, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-888.94324, 842.1164, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-910.3197, 1089.145, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-774.2024, 1187.7806, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1412.4249, 751.6217, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1257.5648, 940.0056, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1293.9937, 1090.5693, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1433.2538, 1180.2343, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(935.417, 1142.9165, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1138.14, 1132.1024, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-1298.8816, 1133.4381, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-1147.3501, 1130.5774, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-1020.2614, -125.44229, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-928.9706, 28.088799, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(-1153.3892, 124.62891, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1025.1, 25.92698, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1153.3774, -162.9906, 25));
		AddSpawnPoint("d_catacomb_80_3.Id7", "d_catacomb_80_3", Rectangle(1090.3564, -338.01157, 25));

		// 'ERD_Siaulav_Bow_Blue' GenType 15 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(1315.8555, 682.1503, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(1208.9888, 797.41113, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(1047.6267, 866.6339, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(791.9684, 708.1228, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(910.3246, 798.63794, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-1299.7958, 643.1752, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-1172.7001, 810.9645, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-1032.2449, 728.55, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-909.68353, 611.95874, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-829.6, 752.718, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-281.2636, 791.61926, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-244.9028, 1096.8689, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-156.99182, 825.9759, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-145.22931, 1012.6871, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(319.71878, 1071.2203, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(327.9607, 817.06067, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(240.81012, 1071.322, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(214.63855, 808.41675, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-79.90561, 1271.9703, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(100.39831, 1243.9614, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-1267.7817, -93.783966, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(-901.2163, -70.63141, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(921.8428, -128.00946, 30));
		AddSpawnPoint("d_catacomb_80_3.Id8", "d_catacomb_80_3", Rectangle(1273.0522, -13.695278, 30));

		// 'ERD_Siaulav_Blue' GenType 16 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-1249.1504, 943.0641, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-1013.4005, 914.62744, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1074.1184, 974.2432, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1245.88, 1016.995, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-134.70642, 668.58264, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-1.6916466, 599.99445, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(116.5217, 619.5301, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(178.0526, 675.84705, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-103.12063, 1126.9661, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(72.622665, 1116.8129, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(185.77771, 1015.8566, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(89.033516, 755.55554, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-117.82333, 1661.8342, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-0.3783245, 1733.6143, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(112.95354, 1719.6945, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(227.99509, 1671.5773, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(81.92119, 963.113, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(341.77972, 927.1505, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-312.454, 952.19086, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-891.67633, -867.99854, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-878.7291, -1046.8748, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-1172.1682, -834.36804, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(-1177.8005, -1051.1427, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1038.3457, -1016.5203, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1066.4768, -798.6656, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1288.6788, -1139.9579, 30));
		AddSpawnPoint("d_catacomb_80_3.Id9", "d_catacomb_80_3", Rectangle(1279.9232, -961.7385, 30));

		// 'ERD_Siaulav_Mage_Blue' GenType 17 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-211.61266, 1723.7129, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-131.52596, 1860.7383, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(25.4929, 1883.8087, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(178.07521, 1836.3281, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(263.60178, 1752.8657, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-197.29053, 2345.1626, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-73.23519, 2202.6677, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(104.35065, 2150.9907, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(245.71375, 2196.124, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(250.14096, 2334.0588, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(120.97065, 847.3719, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-40.450195, 784.2355, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-73.83421, 944.6148, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(202.90906, 1135.5986, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-218.4767, 891.0402, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-1154.0159, 999.6987, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-904.62274, 953.0546, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(-1317.8431, 835.3714, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(969.5577, 1014.7992, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(1343.1663, 808.2999, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(1457.2584, 873.72, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(1258.2332, 1186.0099, 25));
		AddSpawnPoint("d_catacomb_80_3.Id10", "d_catacomb_80_3", Rectangle(1086.9172, 761.6488, 25));

		// 'ERD_Nuka' GenType 18 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(4.4617157, 2036.9266, 300));
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(1166.846, 942.87787, 300));
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(29.557459, 941.27606, 300));
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(-1108.1938, 918.6049, 300));
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(-1068.6271, -47.208363, 300));
		AddSpawnPoint("d_catacomb_80_3.Id11", "d_catacomb_80_3", Rectangle(1096.1085, -35.590717, 300));

		// 'ERD_Elma' GenType 19 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id12", "d_catacomb_80_3", Rectangle(-1005.363, -906.3904, 250));
		AddSpawnPoint("d_catacomb_80_3.Id12", "d_catacomb_80_3", Rectangle(36.246033, -923.24963, 250));
		AddSpawnPoint("d_catacomb_80_3.Id12", "d_catacomb_80_3", Rectangle(1174.4512, -887.47595, 250));
		AddSpawnPoint("d_catacomb_80_3.Id12", "d_catacomb_80_3", Rectangle(47.78746, -1905.278, 250));
		AddSpawnPoint("d_catacomb_80_3.Id12", "d_catacomb_80_3", Rectangle(-580.7147, -2542.356, 250));

		// 'Rootcrystal_05' GenType 20 Spawn Points
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-647.57306, -2519.0012, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-67.81196, -2004.5747, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(199.474, -1752.7734, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-174.41183, -1140.3926, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-153.05219, -726.20667, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(166.89154, -1091.0356, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(154.81042, -793.1558, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-1291.221, -1145.7843, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-1063.8057, -778.6212, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-795.45715, -1139.7966, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-1221.4716, -120.48985, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-838.9956, 60.433975, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-1381.4888, 747.64923, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-1218.7664, 1149.4155, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-838.7029, 745.0253, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-154.96591, 1077.2607, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-165.08006, 689.01715, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(123.42355, 1132.3446, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(163.38367, 736.2557, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-168.8186, 1727.0511, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(227.39627, 1776.466, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(14.580471, 1995.7869, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(-178.26776, 2293.5242, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(225.28809, 2271.9177, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(880.19745, 1125.7792, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(939.5668, 748.03064, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(1377.426, 805.6005, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(1402.724, 1178.0931, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(982.23206, 45.864838, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(1225.1375, -178.53978, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(911.61127, -742.4106, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(1080.8716, -1082.3031, 100));
		AddSpawnPoint("d_catacomb_80_3.Id13", "d_catacomb_80_3", Rectangle(1368.9381, -744.3154, 100));
	}
}
