//--- Melia Script -----------------------------------------------------------
// d_startower_60_1
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Residence of the Fallen Legwyn Family' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DStartower601MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("d_startower_60_1.Id1", MonsterId.FD_Raffly_Blue, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id2", MonsterId.FD_NightMaiden, 27, 35, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id3", MonsterId.FD_TerraNymph, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id4", MonsterId.Rootcrystal_01, 11, 14, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("d_startower_60_1.Id5", MonsterId.FD_TerraNymph, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id6", MonsterId.FD_Raffly_Blue, 30, 40, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("d_startower_60_1.Id7", MonsterId.FD_TerraNymph_Bow, 19, 25, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'FD_Raffly_Blue' GenType 1 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id1", "d_startower_60_1", Rectangle(1533.5519, -333.35114, 200));
		AddSpawnPoint("d_startower_60_1.Id1", "d_startower_60_1", Rectangle(2024.6632, -330.5523, 200));
		AddSpawnPoint("d_startower_60_1.Id1", "d_startower_60_1", Rectangle(2015.9701, 344.34982, 200));
		AddSpawnPoint("d_startower_60_1.Id1", "d_startower_60_1", Rectangle(1495.5914, 363.54562, 200));
		AddSpawnPoint("d_startower_60_1.Id1", "d_startower_60_1", Rectangle(1462.6082, -1215.6637, 200));

		// 'FD_NightMaiden' GenType 2 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1873.443, -1215.838, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1830.1228, 634.776, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1887.6718, -374.0196, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-959.07605, -281.5133, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-2010.5924, 636.63916, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1692.1315, 823.5914, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1871.0228, 406.94235, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1941.3481, 853.6821, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-2058.347, -1066.6343, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-2078.9385, -1411.2488, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-2026.4886, -1254.5803, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1840.8907, -1419.9338, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1722.3204, -1055.9675, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1673.4518, -1294.1387, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1158.3276, -297.9623, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1165.8145, -26.106133, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-657.8818, -10.379688, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-697.625, -471.6647, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1240.8579, -532.5846, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1865.0974, -14.496063, 70));
		AddSpawnPoint("d_startower_60_1.Id2", "d_startower_60_1", Rectangle(-1863.132, -737.67975, 70));

		// 'FD_TerraNymph' GenType 3 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(-227.87978, -1289.0072, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(144.10188, -327.47403, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1101.3422, -1249.525, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1625.4054, -1456.2968, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1445.6854, -1013.7725, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1701.2771, -1111.9285, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(509.94037, -1271.5468, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(157.73293, -971.5396, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(196.44951, -1662.3966, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(-72.61998, -313.6423, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(404.19257, -292.5415, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(141.90054, -514.2021, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(168.30426, -111.60319, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(137.85516, -1150.1616, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(-30.4189, -1460.5146, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(379.66556, -1486.6122, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(381.52545, -1014.0502, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(155.38431, -1329.2645, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1335.861, -1242.4921, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1363.8477, -1474.7991, 70));
		AddSpawnPoint("d_startower_60_1.Id3", "d_startower_60_1", Rectangle(1571.3337, -1261.7695, 70));

		// 'Rootcrystal_01' GenType 4 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(-1140.7477, -1022.9521, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(-2103.9224, -1381.9102, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(-1554.4441, 426.94974, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(234.91176, 1131.1993, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(22.792831, 530.7649, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(361.87817, -191.39825, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(-50.9329, -1575.6084, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(500.09125, -1391.3099, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(1636.7604, -1402.7097, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(1401.9877, -129.72783, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(2200.3997, 156.77704, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(1478.6752, 964.8784, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(1983.2263, -2442.0369, 100));
		AddSpawnPoint("d_startower_60_1.Id4", "d_startower_60_1", Rectangle(-660.18634, -37.330734, 100));

		// 'FD_TerraNymph' GenType 16 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id5", "d_startower_60_1", Rectangle(1399.8418, -2249.2693, 200));
		AddSpawnPoint("d_startower_60_1.Id5", "d_startower_60_1", Rectangle(2045.2601, -2219.105, 200));
		AddSpawnPoint("d_startower_60_1.Id5", "d_startower_60_1", Rectangle(1700.9769, -2223.98, 200));

		// 'FD_Raffly_Blue' GenType 17 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id6", "d_startower_60_1", Rectangle(243.01598, -1278.825, 9999));

		// 'FD_TerraNymph_Bow' GenType 25 Spawn Points
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1122.8171, -1198.9102, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1852.11, 564.36176, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1968.3339, 448.9758, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1846.4955, 875.6804, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-775.1229, -1218.1764, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-940.49023, -948.2371, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-893.2386, -1464.6725, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-2104.1384, -1216.4034, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1929.2642, -1451.4922, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1719.5414, -1114.9731, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1957.3413, -1051.0288, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1771.1073, -1365.3185, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1041.8894, -377.83075, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-736.4074, -97.540085, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1077.088, -198.39856, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-800.9783, -491.7996, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1142.5206, -1421.5474, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-715.7404, -1042.7023, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1184.4193, -528.54333, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1238.2147, 622.5802, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1048.5955, 666.6073, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-964.14606, 343.97934, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-2041.3049, 756.6155, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1885.7238, -24.059586, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1903.696, -366.94482, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(-1868.2933, -762.515, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(2066.4727, -1570.472, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(2097.0984, -1254.9363, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(2039.1995, -882.9327, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1452.3368, 271.39893, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(2027.3647, 411.36844, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1879.6228, 271.72116, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1402.1338, 451.20746, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1704.444, -283.1819, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1638.9419, -479.17142, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1929.9739, -244.68086, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1902.261, -484.07773, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1685.3516, -2317.0852, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1777.0037, -2111.466, 40));
		AddSpawnPoint("d_startower_60_1.Id7", "d_startower_60_1", Rectangle(1848.677, -2325.6606, 40));
	}
}
