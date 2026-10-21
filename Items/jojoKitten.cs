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
			// Scaling happens around the draw origin, so keep Jojo's origin on the sprite and halve its
			// distance from the hitbox centre instead of halving Jojo's offsets
			DrawOffsetX = -13;
			DrawOriginOffsetY = -23;
			DrawOriginOffsetX = -20;
			Projectile.minionSlots = 0.25f;
			Projectile.light = 0.25f;
		}
	}
}
