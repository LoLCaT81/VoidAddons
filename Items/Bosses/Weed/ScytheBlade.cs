using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace VoidAddons.Items.Bosses.Weed
{
    public class ScytheBlade : ModItem
    {
		public void SetStatisticDefaults()
		{
			DisplayName.SetDefault("Scythe Blade");
			Tooltip.SetDefault("It used to be of great Power");
		}
		
        public override void SetDefaults()
        {
            item.damage = 200;            
            item.melee = true;
            item.width = 30;
            item.height = 20;
            item.useTime = 15;
            item.useAnimation = 15;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 8;
            item.rare = 12;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType ("ScytheBlade");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
    }
}