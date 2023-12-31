//--- Melia Script -----------------------------------------------------------
// f_katyn_7_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Owl Burial Ground' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn72MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("f_katyn_7_2.Id1", MonsterId.Rootcrystal_02, 15, 20, TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id2", MonsterId.Ellomago, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id3", MonsterId.Ridimed, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id4", MonsterId.Jellyfish_Red, 15, 20, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id5", MonsterId.Sakmoli, 5, 6, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id6", MonsterId.Ridimed, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id7", MonsterId.Sakmoli, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id8", MonsterId.Ellomago, 6, 8, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id9", MonsterId.Ridimed, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id10", MonsterId.Sakmoli, 8, 10, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner("f_katyn_7_2.Id11", MonsterId.Jellyfish_Red, 12, 15, TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Rootcrystal_02' GenType 800 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id1", "f_katyn_7_2", Rectangle(2311, -2971, 9999));

		// 'Ellomago' GenType 10010 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id2", "f_katyn_7_2", Rectangle(725.72, -3299.43, 9999));

		// 'Ridimed' GenType 10011 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id3", "f_katyn_7_2", Rectangle(1319.47, -1858.61, 9999));

		// 'Jellyfish_Red' GenType 10012 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id4", "f_katyn_7_2", Rectangle(1830.32, -139.9, 9999));

		// 'Sakmoli' GenType 10013 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id5", "f_katyn_7_2", Rectangle(1852.43, 2080.07, 9999));

		// 'Ridimed' GenType 10015 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(814.16693, -668.23676, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(555.4757, -688.7901, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(5.1734233, -807.70593, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(246.0877, -655.12366, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(163.3001, -403.9061, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(134.97844, -1049.4647, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(600.05255, -430.4473, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(304.1275, -452.10873, 30));
		AddSpawnPoint("f_katyn_7_2.Id6", "f_katyn_7_2", Rectangle(406.69522, -911.7665, 30));

		// 'Sakmoli' GenType 10016 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3652.808, -606.1737, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(2436.572, -774.11017, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(1815.5126, 193.33215, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(2749.3389, 679.14935, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(1896.8071, 682.15656, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(1580.6152, -692.2109, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3296.9216, 995.8112, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3591.0994, 1071.8228, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(2583.4377, -465.67258, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3262.8738, -566.27386, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3640.3103, -780.198, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(4013.5354, -329.07007, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3978.412, -738.3221, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3839.1353, 954.8383, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3719.3767, 704.18506, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3333.2437, 1325.8007, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(654.2148, 1663.5824, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(556.5151, 1967.1969, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(949.5519, 2180.8523, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(872.56696, 1897.1222, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(2642.0144, 2310.9841, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(2793.5542, 2637.8616, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(3013.7292, 2410.6091, 30));
		AddSpawnPoint("f_katyn_7_2.Id7", "f_katyn_7_2", Rectangle(1935.0173, 2258.6252, 30));

		// 'Ellomago' GenType 10017 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2464.644, -2739.793, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(1592.018, -3334.4238, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(1982.746, -3039.6775, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2343.1821, -3172.0054, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2089.0476, -2862.7014, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2743.986, -2775.0244, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2527.4734, -3175.554, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2897.6245, -3314.4358, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2727.2969, -3069.8845, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2582.9531, -2610.2493, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(3386.3037, -3503.3313, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2332.9033, -2893.9927, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(2130.38, -2599.554, 40));
		AddSpawnPoint("f_katyn_7_2.Id8", "f_katyn_7_2", Rectangle(1783.045, -2648.9465, 40));

		// 'Ridimed' GenType 10021 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1961.3566, -2980.7239, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1835.8516, -129.49632, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2347.1519, -2738.8472, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2462.1726, -3123.7034, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2688.07, -2691.8591, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1345.5215, -2146.6482, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1580.5732, -3330.2063, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1526.3036, -790.74225, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(687.66846, -3253.3572, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2414.35, -696.00464, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2640.5974, -498.7213, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2789.239, -524.4944, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3648.3477, -550.87134, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3761.6611, -727.6808, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3992.058, -299.27264, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(243.29056, -959.2448, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(319.16788, -499.961, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(637.3417, -666.73505, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1738.0664, 1338.4263, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2566.8438, 2413.0479, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2929.5, 2611.5947, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(2890.335, 2226.7727, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(912.0979, 1936.5778, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(654.7805, 1568.172, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(711.9628, 2128.2136, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1064.6743, 1723.2633, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(1743.0881, 2072.608, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3191.2566, 1008.9775, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3740.1506, 1132.1013, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3740.4983, 662.92645, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3532.7842, 991.07654, 40));
		AddSpawnPoint("f_katyn_7_2.Id9", "f_katyn_7_2", Rectangle(3365.3557, 1390.2305, 40));

		// 'Sakmoli' GenType 10022 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1365.3912, -690.01794, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(2607.5432, -2694.3484, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(2272.71, -2944.8904, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(2708.327, -3275.1633, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1281.7896, -1447.5345, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(2617.4692, -622.70746, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(2027.177, -2571.1763, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1797.2969, -81.248634, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1618.4758, -3355.3743, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(779.9641, -676.42175, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1312.71, -2194.4067, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(1591.6123, -701.4279, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(617.9758, -3059.8633, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(743.91376, -3365.3547, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3566.9595, -629.9711, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3711.4727, -3216.3574, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3660.564, -3482.9832, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3633.865, -3961.9148, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3354.666, -4466.397, 30));
		AddSpawnPoint("f_katyn_7_2.Id10", "f_katyn_7_2", Rectangle(3530.9785, -4680.442, 30));

		// 'Jellyfish_Red' GenType 10028 Spawn Points
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3193.736, 964.9245, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3653.8833, 1153.4297, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3673.3845, 867.49524, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3378.5735, 1142.3925, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2860.0598, 2369.6409, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2474.3567, 2283.7312, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2808.179, 2678.5322, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1877.8324, 2107.0752, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1572.3514, 2034.9144, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(960.3103, 1980.3082, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2077.8564, 649.67334, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2442.6982, -719.6521, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2636.5906, -444.96542, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3228.2383, -626.55286, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3832.2236, -699.73456, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3918.153, -352.49887, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(3623.058, -633.5064, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(2950.3745, -544.17017, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1792.4247, 2315.2322, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(587.9742, 1602.2262, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1735.6196, 1405.7661, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1756.821, 1207.5598, 30));
		AddSpawnPoint("f_katyn_7_2.Id11", "f_katyn_7_2", Rectangle(1838.8812, 932.92883, 30));
	}
}
