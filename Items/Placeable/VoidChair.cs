using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items.Placeable
{
	public class VoidChair : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("uhhhhhhh");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("VoidChair");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenChair);
			recipe.AddIngredient(null, "VoidBlock", 10);
			recipe.AddTile(null, "VoidWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}