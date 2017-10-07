using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace VoidAddons.Projectiles
{
    public class ScytheBladeOnStick : ModProjectile
    {
		public void SetStatisticDefaults()
		{
			DisplayName.SetDefault("Scythe Blade on a Stick");
		}
		
        public override void SetDefaults()
        {
            projectile.width = 50;
            projectile.height = 20;
            projectile.aiStyle = 18;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.magic = false;
            projectile.penetrate = 3;
            projectile.timeLeft = 600;
            projectile.light = 0.5f;
            projectile.extraUpdates = 1;
        }
    }
}