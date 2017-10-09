using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace VoidAddons.Items.Weapons
{
    public class ScytheBladeOnStick : ModItem
    {
		public void SetStatisticDefaults()
		{
			DisplayName.SetDefault("Scythe Blade on a Stick");
			Tooltip.SetDefault("Is it cooler? \nWho knows");
		}
		
        public override void SetDefaults()
        {
            item.damage = 250;            
            item.melee = true;
            item.width = 50;
            item.height = 20;
            item.useTime = 13;
            item.useAnimation = 13;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 8;
            item.rare = 12;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType ("ScytheBladeOnStick");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ScytheBlade");
			recipe.AddIngredient(null, "TerraBlade");
			recipe.AddTile(null, "VoidWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}