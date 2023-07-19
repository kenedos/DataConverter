//--- Melia Script -----------------------------------------------------------
// id_Unknownsanctuary_2
//
//--- Description -----------------------------------------------------------
// Sets up mobs for 'Unknown Sanctuary 2F' map.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdUnknownsanctuary2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides -------------------------------

		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Froster_Lord, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Kucarry_Balzermancer, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Wastrel, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Ignas, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Asiomage, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Skiaclipse, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Moringponia, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Tantaliser, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Pbeta, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Glacier, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Velcoffer, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners ---------------------------------

		AddSpawner("id_Unknownsanctuary_2.Id1", MonsterId.FD_Boss_Froster_Lord, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id2", MonsterId.FD_Boss_Kucarry_Balzermancer, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id3", MonsterId.FD_Boss_Wastrel, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id4", MonsterId.FD_Boss_Ignas, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id5", MonsterId.FD_Boss_Asiomage, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id6", MonsterId.FD_Boss_Skiaclipse, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id7", MonsterId.FD_Boss_Moringponia, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id8", MonsterId.FD_Boss_Tantaliser, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id9", MonsterId.FD_Boss_Pbeta, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id10", MonsterId.FD_Boss_Glacier, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id11", MonsterId.FD_Boss_Velcoffer, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id12", MonsterId.FD_Boss_Skiaclipse, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner("id_Unknownsanctuary_2.Id13", MonsterId.FD_Boss_Skiaclipse, 1, 1, TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// 'FD_Boss_Froster_Lord' GenType 1 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id1", "id_Unknownsanctuary_2", Rectangle(198.3233, 1156.4188, 20));

		// 'FD_Boss_Kucarry_Balzermancer' GenType 2 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id2", "id_Unknownsanctuary_2", Rectangle(-1055.728, -135.6764, 20));

		// 'FD_Boss_Wastrel' GenType 3 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id3", "id_Unknownsanctuary_2", Rectangle(866.08954, 1069.8341, 20));

		// 'FD_Boss_Ignas' GenType 4 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id4", "id_Unknownsanctuary_2", Rectangle(-426.4594, -1035.8777, 20));

		// 'FD_Boss_Asiomage' GenType 5 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id5", "id_Unknownsanctuary_2", Rectangle(68.01238, -1364.7366, 20));

		// 'FD_Boss_Skiaclipse' GenType 6 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id6", "id_Unknownsanctuary_2", Rectangle(-372.66635, -435.87714, 20));

		// 'FD_Boss_Moringponia' GenType 7 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id7", "id_Unknownsanctuary_2", Rectangle(-1057.1002, -807.03094, 20));

		// 'FD_Boss_Tantaliser' GenType 8 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id8", "id_Unknownsanctuary_2", Rectangle(1055.4669, 561.7357, 20));

		// 'FD_Boss_Pbeta' GenType 9 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id9", "id_Unknownsanctuary_2", Rectangle(541.70825, -1062.0155, 20));

		// 'FD_Boss_Glacier' GenType 10 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id10", "id_Unknownsanctuary_2", Rectangle(-803.96027, 767.3518, 20));

		// 'FD_Boss_Velcoffer' GenType 11 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id11", "id_Unknownsanctuary_2", Rectangle(86.288925, -17.487818, 20));

		// 'FD_Boss_Skiaclipse' GenType 13 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id12", "id_Unknownsanctuary_2", Rectangle(591.1201, -383.408, 20));

		// 'FD_Boss_Skiaclipse' GenType 14 Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2.Id13", "id_Unknownsanctuary_2", Rectangle(-66.70287, 534.97064, 20));
	}
}
