using Terraria;
using Terraria.ModLoader;

namespace VoidAddons.Items.Bosses.Weed
{
	public class OrganicBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Organic Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 12;
			item.expert = true;
			bossBagNPC = mod.NPCType("Leaf");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor();
			if (Main.rand.Next(7) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("AbominationMask"));
			}
			player.QuickSpawnItem(mod.ItemType("MoltenDrill"));
			player.QuickSpawnItem(mod.ItemType("ElementResidue"));
			player.QuickSpawnItem(mod.ItemType("PurityTotem"));
			player.QuickSpawnItem(mod.ItemType("SixColorShield"));
		}
	}
}