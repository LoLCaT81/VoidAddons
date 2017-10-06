using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.UI;
using Terraria.ModLoader;

namespace VoidAddons.Items.Weapons	
{
    public class Boomerang : ModItem
    {
        public void SetStatisticDefaults()	
		{
			Tooltip.SetDefault("Don't question it");
		}
		
		public override void SetDefaults()
		{
			item.noMelee = true;
			item.useStyle = 1;
			item.shootSpeed = 10f;
			item.shoot = 6;
			item.damage = 300;
			item.knockBack = 8f;
			item.width = 14;
			item.height = 28;
			item.useAnimation = 15;
			item.useTime = 15;
			item.noUseGraphic = true;
			item.rare = 12;
			item.value = 50000;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType ("BoomerangProjectile");
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		
				        //--------------------------------------------------Shotgun style: Multiple Projectiles, Random spread ---------------------------------------------------------
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4 + Main.rand.Next(2); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // This defines the projectiles random spread . 30 degree spread.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
	} 
}	