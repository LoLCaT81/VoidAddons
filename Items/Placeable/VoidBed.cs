using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items.Placeable
{
	public class VoidBed : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Sleep in The Void");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 2000;
			item.createTile = mod.TileType("VoidBed");
		}
	}
}