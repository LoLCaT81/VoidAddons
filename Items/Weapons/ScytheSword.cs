using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items.Weapons
{
	public class ScytheSword : ModItem
	{
		public void SetStatisticDefaults()
		{
			DisplayName.SetDefault("Scythe Sword");
			Tooltip.SetDefault("This is uhhhh something");
		}
		
		public override void SetDefaults()
		{
			item.damage = 562;
			item.melee = true;
			item.width = 60;
			item.height = 30;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000000;
			item.rare = 13;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			if (Main.dayTime);
			{
			    item.shoot = mod.ProjectileType("ScytheBlade");
			}
            if (!Main.dayTime);
            {
				item.shoot = mod.ProjectileType("ScytheBladeOnStick");
			}
			
			item.shootSpeed = 10f;
		}
	}
}	