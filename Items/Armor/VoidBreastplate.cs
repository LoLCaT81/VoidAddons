using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class VoidBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Void Breastplate");
			Tooltip.SetDefault("tittie."
				+ "\nImmunity to 'On Fire!'"
				+ "\n+300 max mana and life");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 60;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 300;
			player.statLifeMax2 += 300;
			player.maxMinions++;
		}
		
		
	}
}