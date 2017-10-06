using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items.Placeable
{
	public class VoidDoor : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Enter The Void");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 28;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 150;
			item.createTile = mod.TileType("VoidDoorClosed");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenDoor);
			recipe.AddIngredient(null, "VoidBlock", 10);
			recipe.AddTile(null, "VoidWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}