using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class VoidLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Speedy."
				+ "\n20% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.20f;
			player.statManaMax2 += 50;
			player.statLifeMax2 += 100;
		}
		
	}
}