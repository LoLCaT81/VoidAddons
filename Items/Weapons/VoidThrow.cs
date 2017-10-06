using System;
using Microsoft.Xna.Framework;
using VoidAddons.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items.Weapons
{
	public class VoidThrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("xD");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 2;
			item.useTime = 1;
			item.shootSpeed = 16f;
			item.knockBack = 2.5f;
			item.damage = 300;
			item.rare = 12;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 1);
			item.shoot = mod.ProjectileType<VoidThrowing>();
			
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
