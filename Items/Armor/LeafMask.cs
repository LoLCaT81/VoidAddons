using Terraria.ModLoader;

namespace VoidAddons.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class LeafMask : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 20;
			item.rare = 1;
			item.vanity = true;
		}

		public override bool DrawHead()
		{
			return false;
		}
	}
}