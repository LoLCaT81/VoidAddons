using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace VoidAddons.Items.Bosses.Mytholon
{
	public class MythicalBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mythical Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 1;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 12;
			item.expert = true;
			bossBagNPC = mod.NPCType("Mytholon");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor();
			if(Main.rand.Next(3) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("VoidBlock")); //add Mythical Bar
			}
			player.QuickSpawnItem(mod.ItemType("VoidBlock")); //add Medal used for a certain town npc
		}
	}
}	