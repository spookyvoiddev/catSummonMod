using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace catSummonMod.Items
{
	public class jojoBuff : ModBuff
	{
		public override void SetStaticDefaults() {
			// Display name and description live in Localization/en-US_Mods.catSummonMod.hjson
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			if (player.ownedProjectileCounts[ProjectileType<jojoCat>()] > 0) {
				player.buffTime[buffIndex] = 18000;
			} else {
				player.DelBuff(buffIndex);
				buffIndex--;
			}
		}
	}
}
