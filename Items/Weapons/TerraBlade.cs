using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items.Weapons
{
	public class TerraBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Woowee.");	//The (English) text shown below your weapon's name
		}
		
		public override void SetDefaults()
		{
			item.rare = 8;
			item.useStyle = 1;
			item.damage = 95;
			item.useAnimation = 16;
			item.useTime = 16;
			item.width = 30;
			item.height = 30;
			item.shoot = 132;
			item.scale = 1.1f;
			item.shootSpeed = 12f;
			item.knockBack = 6.5f;
			item.melee = true;
			item.value = Item.sellPrice(0, 20, 0, 0);
			item.autoReuse = true;
		}
	}
}	