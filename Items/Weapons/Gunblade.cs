using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace VoidAddons.Items.Weapons
{
	public class Gunblade : ModItem
	{
		public void SetStaticDefault()
		{
			DisplayName.SetDefault("Gunblade");
			Tooltip.SetDefault("A gun and a blade /nGUNBLADE!");
		}
		
		public override void SetDefaults()
		{
			item.melee = true;
			item.width = 26;
			item.height = 26;
			item.damage = 13;
			item.useTime = 10;
			item.useAnimation = 10;
			item.UseSound = SoundID.Item1;
			item.useStyle = 1;
			item.knockBack = 2f;
			item.value = 110;
			item.useTurn = true;
			item.autoReuse = true;
			item.rare = 2;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if(player.altFunctionUse == 2)
			{
				item.useTime = 10;
				item.useAnimation = 10;
				item.shootSpeed = 16f;
				item.shoot = ProjectileID.Bullet;
			} else
			{
				item.useTime = 10;
				item.useAnimation = 10;
				item.shootSpeed = 0f;
				item.shoot = 0;
			}
			return base.CanUseItem(player);
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			if(player.altFunctionUse == 2)
			{
				target.AddBuff(BuffID.OnFire, 60);
			} else
			{
				target.AddBuff(BuffID.Frostburn, 120);
			}
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if(player.altFunctionUse == 2)
			{
				player.AddBuff(BuffID.Inferno, 60);
			} else
			{
				player.AddBuff(BuffID.Swiftness, 80);
			}	
		}
	}
}	
				
				
				
				