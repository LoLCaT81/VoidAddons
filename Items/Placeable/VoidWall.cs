using Terraria.ModLoader;

namespace VoidAddons.Items.Placeable
{
	public class VoidWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Hollow The Void");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = mod.WallType("VoidWall");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "VoidBlock");
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}