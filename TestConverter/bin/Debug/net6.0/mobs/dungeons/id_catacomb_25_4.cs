//--- Melia Script -----------------------------------------------------------
// id_catacomb_25_4
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Timerys Temple' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdCatacomb254MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners ---------------------------------

		AddSpawner("id_catacomb_25_4.Id1", MonsterId.Pagclamper_Yellow, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_25_4.Id2", MonsterId.PagDoper_Blue, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_25_4.Id3", MonsterId.PagNurse_Green, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_25_4.Id4", MonsterId.Pagshearer_Yellow, 23, 30, TimeSpan.FromMilliseconds(0), TendencyType.Aggressive);
		AddSpawner("id_catacomb_25_4.Id5", MonsterId.Rootcrystal_02, 19, 25, TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// 'Pagclamper_Yellow' GenType 22 Spawn Points
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(1022.0507, 955.12286, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(842.80347, 939.55457, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(727.16376, 935.0268, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(590.67664, 922.43945, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(482.8871, 971.97076, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(500.39566, 705.8938, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(597.4601, 732.47906, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(563.34937, 624.99493, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(280.9084, 674.6819, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(287.30905, 874.9639, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(87.40224, 886.42834, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(118.89395, 691.80164, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-72.59613, 697.5754, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-118.03722, 896.706, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(202.61525, 800.005, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(17.439392, 801.3604, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-432.58612, 723.3133, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-336.68234, 746.0926, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-673.4634, 728.6112, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-835.6533, 750.8514, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-912.41156, 678.65564, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-668.87537, 608.27783, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-877.3964, 437.23135, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-790.79095, 512.2325, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-939.4236, 838.92377, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1220.0332, 611.9834, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1144.0425, 552.98627, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1858.1605, 439.13492, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1733.7078, 467.26688, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1596.4921, 430.0459, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1523.071, 509.1431, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1689.7302, 642.16034, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1719.2595, 813.54297, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1534.8884, 667.8723, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1907.3944, 658.0959, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1932.5576, 827.8732, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1819.2507, 726.25, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-1475.5552, 779.0817, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(305.77652, 134.13972, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(233.40115, 31.878044, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(293.38727, 368.91293, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(120.09547, 347.33585, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-79.21286, 447.3838, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(161.04681, -596.6337, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(258.1473, -429.66333, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(130.00853, -412.54025, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-138.00975, -263.61548, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(274.0833, -205.38388, 40));
		AddSpawnPoint("id_catacomb_25_4.Id1", "id_catacomb_25_4", Rectangle(-130.24443, -509.37637, 40));

		// 'PagDoper_Blue' GenType 24 Spawn Points
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(47.845604, -878.25836, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-92.98065, -897.7673, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(204.34805, -853.7707, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(258.63544, -1080.22, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(75.531006, -657.3465, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(256.81927, -619.96326, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(274.51523, -323.00806, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(65.38324, -546.7394, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-23.495306, -183.09601, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(217.20853, -128.5852, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(233.00232, 98.013336, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-93.458, 93.71673, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(160.87259, 437.96307, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(21.731297, 458.78134, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-321.42328, 369.96628, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(213.96315, 345.11154, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(54.081787, 297.3483, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(112.63277, -245.95544, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-29.405762, -304.8305, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-50.967133, -573.41785, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-135.93723, 351.30103, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(315.5577, 465.1484, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-370.62622, 474.3781, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-457.4263, 400.06018, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-799.6271, 352.89554, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-700.04126, 384.9636, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-916.3468, 538.27747, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-741.1511, 773.93585, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-526.0116, 708.9793, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-677.2884, 494.02887, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-799.5287, 645.1965, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(4.2140226, -692.8836, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(878.9265, -744.07355, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(-133.63594, -1082.5831, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(850.31683, -549.08386, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(985.9635, -361.31866, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(1033.71, -239.0218, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(1078.5486, -613.90607, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(992.8635, -749.348, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(822.9253, -845.70074, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(949.65314, -623.50226, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(981.0814, -498.41293, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(880.44476, -339.58926, 40));
		AddSpawnPoint("id_catacomb_25_4.Id2", "id_catacomb_25_4", Rectangle(714.97845, -578.5689, 40));

		// 'PagNurse_Green' GenType 25 Spawn Points
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-927.04645, -512.9149, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-846.0992, -323.91727, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-702.0863, -182.23535, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-834.64496, -148.69682, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-971.6568, -32.0062, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-848.3245, 16.768276, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-652.1479, 131.12685, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-686.17377, -1.707367, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-963.5674, -270.26733, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-550.894, -485.20233, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-379.79614, -676.0059, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1198.5476, 5.6036506, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1235.1946, 98.042946, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1399.0935, 37.677006, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1462.0709, 99.05358, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1789.7407, 65.56409, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1890.7413, -46.084663, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1668.1904, -2.9334536, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1764.3716, 223.66238, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1776.754, -484.77518, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1690.7721, -272.0817, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1793.0846, -364.54376, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1465.6057, -401.28677, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1555.7013, -565.98065, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1370.7355, -412.97522, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1204.1588, -470.5849, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-1072.3362, -427.5598, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-843.7262, -446.89438, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-69.03975, -996.7558, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(124.17172, -968.7422, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(28.656265, -1103.0695, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-86.377945, -647.6018, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-34.63106, -478.6262, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(107.9567, -82.63324, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(191.73694, -261.49838, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(173.75992, -482.09637, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(141.02979, -735.06415, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-132.24664, -389.22433, 40));
		AddSpawnPoint("id_catacomb_25_4.Id3", "id_catacomb_25_4", Rectangle(-122.00148, -129.03906, 40));

		// 'Pagshearer_Yellow' GenType 26 Spawn Points
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1482.1316, -497.4036, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1680.4135, -578.948, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1564.6774, -291.7045, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1264.394, -399.29904, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-981.19824, -387.3875, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-789.828, -254.03633, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-961.07385, -166.82477, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-720.4387, -381.97467, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-643.26917, -301.75983, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-745.2803, -82.00105, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-770.91705, 101.46882, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-945.2955, 139.78613, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1122.8596, 113.7849, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-1100.5297, 30.546652, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-712.2897, -543.8559, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-403.54553, -563.25635, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-239.47911, -618.50525, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-82.82944, -776.4124, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(282.92813, -526.0095, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(3.7039642, -379.96387, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(233.9664, -707.63324, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(29.11158, -982.7828, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(137.37961, -1074.9222, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(248.86963, -983.6787, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(286.13034, -855.01855, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(92.58049, -793.3831, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(461.68564, -635.3203, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(581.9768, -623.2393, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(889.074, -206.4242, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(1067.7954, -374.02948, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(1041.9548, -540.33704, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(748.95166, -283.72095, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(892.23944, -457.58545, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(756.1105, -428.06668, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(979.8822, -849.11816, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(1068.3765, -818.3351, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(754.7243, -743.10504, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-639.62256, -90.12708, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(59.046635, -294.4137, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(144.93704, -324.80295, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(-21.235003, 47.714584, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(521.1231, -552.2909, 30));
		AddSpawnPoint("id_catacomb_25_4.Id4", "id_catacomb_25_4", Rectangle(1078.7192, -708.13885, 30));

		// 'Rootcrystal_02' GenType 27 Spawn Points
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(1292.45, 454.35, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(1234.36, 748.14, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(975.59, 941.63, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(595.72, 882.17, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(472.25, 685.93, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(118.57, 768.6, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-123.1, 785.21, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-590.93, 789.48, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-849.01, 729.53, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-815.8, 321.65, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1217.09, 541.08, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1457.52, 730.98, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1656.57, 458.08, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1912.44, 803.65, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-307.66, 410.9, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(22.15, 381.48, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(302.28, 62.89, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-120.87, -227.72, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(235.96, -521.72, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-85.09, -777.51, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(266.06, -1070.73, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-634.08, -504.79, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-783.85, -125, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1394.8, 10.17, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1536.83, -372.76, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(-1869.76, 194.01, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(848.41, -826.5, 15));
		AddSpawnPoint("id_catacomb_25_4.Id5", "id_catacomb_25_4", Rectangle(1064.3, -493.28, 15));
	}
}
