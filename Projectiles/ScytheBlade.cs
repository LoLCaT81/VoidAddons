using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace VoidAddons.Projectiles
{
    public class ScytheBlade : ModProjectile
    {
		public void SetStatisticDefaults()
		{
			DisplayName.SetDefault("Scythe Blade");
		}
		
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 20;
            projectile.aiStyle = 3;
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