using Terraria.ModLoader;

namespace catSummonMod.Items
{
	// A small kitten that follows Jojo into battle. Same AI as Jojo, drawn at half size.
	public class jojoKitten : jojoCat
	{
		// Reuse Jojo's sprite sheet until there is dedicated kitten art
		public override string Texture => "catSummonMod/Items/jojoCat";

		public override void SetDefaults() {
			base.SetDefaults();
			Projectile.scale = 0.5f;
			Projectile.width = 8;
			Projectile.height = 8;
			DrawOffsetX = -8;
			DrawOriginOffsetY = -10;
			DrawOriginOffsetX = -10;
			Projectile.minionSlots = 0.25f;
			Projectile.light = 0.25f;
		}
	}
}
