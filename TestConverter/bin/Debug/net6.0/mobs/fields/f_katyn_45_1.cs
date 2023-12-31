//--- Melia Script -----------------------------------------------------------
// f_katyn_45_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Grynas Trails' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn451MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_45_1.Id1", MonsterId.Stoulet_Bow_Blue, 38, 50, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_1.Id2", MonsterId.Socket_Green, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_1.Id3", MonsterId.Socket_Mage_Green, 9, 12, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("f_katyn_45_1.Id4", MonsterId.Socket_Green, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_1.Id5", MonsterId.Rootcrystal_04, 15, 19, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_1.Id6", MonsterId.Stoulet_Gray, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_45_1.Id7", MonsterId.Stoulet_Bow_Blue, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Stoulet_Bow_Blue' GenType 1 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-804.1369, 375.41162, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-805.23474, -61.65834, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-1023.6589, -395.67523, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-789.6072, -391.81696, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-823.48083, -760.6533, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-1058.93, -1205.98, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-755.7777, -1253.0851, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-337.69614, -1233.2142, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-83.30733, -747.9286, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-101.62602, -1064.0786, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(218.59789, -1091.3977, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(647.1201, -938.96484, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(330.1427, -595.30634, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(713.6006, -583.8012, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(651.0037, -79.62616, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(647.32776, 300.07773, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(268.31152, 427.6044, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-66.21681, 413.62878, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-435.0379, 437.85995, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(-405.96866, 181.1537, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(920.58093, -554.8876, 30));
		AddSpawnPoint("f_katyn_45_1.Id1", "f_katyn_45_1", Rectangle(375.5628, -1017.8506, 30));

		// 'Socket_Green' GenType 2 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-969.84753, -357.86172, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1331.9929, -474.56934, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-810.67914, -715.2987, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-761.49506, -15.719107, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1505.8011, 401.8216, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1872.172, 386.95438, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1659.4564, 583.44574, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1174.4368, 614.1745, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-906.5047, 702.1022, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-715.83496, 292.23315, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-439.09338, 364.88336, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-400.21494, 91.49889, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-205.6085, 221.43199, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-166.20642, 213.0304, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(334.7657, 245.39735, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-884.9373, -1113.9021, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-763.6793, -1232.1185, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-1108.7115, -1246.4546, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-928.69775, -1417.6034, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-315.20996, -1287.2866, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-73.83018, -1165.152, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-181.47461, -1024.9663, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-63.649166, -1053.3329, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-9.894696, -900.6647, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(236.50089, -932.8901, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(364.2157, -1075.661, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(425.05502, -806.608, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(599.2729, -577.99536, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(667.2875, -427.30554, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-261.10925, 454.3698, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(-70.211266, 405.3756, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(514.72723, 377.518, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(638.17487, 114.76839, 30));
		AddSpawnPoint("f_katyn_45_1.Id2", "f_katyn_45_1", Rectangle(755.76733, 380.65665, 30));

		// 'Socket_Mage_Green' GenType 8 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id3", "f_katyn_45_1", Rectangle(-573.61237, 236.50331, 9999));

		// 'Socket_Green' GenType 9 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1523.0105, -804.26855, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1730.6359, -473.95496, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1352.5023, -592.6624, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1523.4753, -361.4617, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1393.7855, -726.80646, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1715.6555, -754.1342, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1223.4341, -463.7653, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-809.2047, -88.35955, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-811.5367, -419.23672, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-863.62524, 133.13925, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-930.08484, 421.499, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1804.4044, 320.509, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1703.8851, 521.9181, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1554.0243, 395.54788, 30));
		AddSpawnPoint("f_katyn_45_1.Id4", "f_katyn_45_1", Rectangle(-1687.7556, 702.00305, 30));

		// 'Rootcrystal_04' GenType 14 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-1722.2848, -595.5652, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-1090.775, -458.37396, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-762.3385, -976.6461, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-894.5003, 467.66183, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-1763.4114, 464.8118, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-318.93692, 437.63403, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(392.47855, 351.57294, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(1123.5591, 784.1466, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(907.9976, 358.16693, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(574.5833, -36.307693, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(922.07837, -165.50462, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(908.97833, -450.1279, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(415.08487, -654.23706, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(682.3122, -833.24554, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(302.4113, -1139.8708, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-112.62897, -847.36896, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-323.1801, -1174.0245, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-1020.6904, -1392.6757, 50));
		AddSpawnPoint("f_katyn_45_1.Id5", "f_katyn_45_1", Rectangle(-851.9715, -340.72995, 50));

		// 'Stoulet_Gray' GenType 18 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id6", "f_katyn_45_1", Rectangle(-442.68488, 371.62527, 9999));

		// 'Stoulet_Bow_Blue' GenType 19 Spawn Points
		AddSpawnPoint("f_katyn_45_1.Id7", "f_katyn_45_1", Rectangle(-340.6856, 233.80743, 9999));
	}
}
