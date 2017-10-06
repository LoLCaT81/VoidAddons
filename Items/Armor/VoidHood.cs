using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class VoidHood : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Hood");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 11;
			item.defense = 30;
		}
		
		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 50;
			player.statLifeMax2 += 100;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("VoidBreastplate") && legs.type == mod.ItemType("VoidLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "idk how";
			player.AddBuff(BuffID.Wrath, 2);
			player.AddBuff(BuffID.Swiftness, 5);
			player.AddBuff(BuffID.Spelunker, 2 );
			player.AddBuff(BuffID.Rage, 5 );
			player.AddBuff(BuffID.Lovestruck, 10 );
		    player.AddBuff(BuffID.Shine, 2);
			player.AddBuff(BuffID.Regeneration, 5);
			player.AddBuff(BuffID.Lifeforce, 2);
			player.AddBuff(BuffID.Hunter, 2);
			player.AddBuff(BuffID.ObsidianSkin, 2);
			player.AddBuff(BuffID.Featherfall, 2);
			player.AddBuff(BuffID.Swiftness, 5);
			player.AddBuff(BuffID.WaterWalking, 2);
		}

	}
}