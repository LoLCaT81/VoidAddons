using Terraria;
using Terraria.ModLoader;

namespace VoidAddons.Items.Bosses.Weed
{
	public class Bubble : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 8;
			item.value = Item.sellPrice(0, 0, 50, 0);
		}
	}
}