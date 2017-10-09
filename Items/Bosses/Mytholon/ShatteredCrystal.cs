using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace VoidAddons.Items.Bosses.Mytholon
{
	public class ShatteredCrystal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shattered Crystal");
			Tooltip.SetDefault("Don't anger it");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 2;
			item.value = 110;
			item.rare = 12;
			item.useAnimation = 40;
			item.useTime = 45;
			item.consumable = true;
			item.useStyle = 4;
		}

		public override bool CanUseItem(Player player)
		{
			bool moonLord = NPC.downedMoonlord;
			
			bool alreadySpawned = NPC.AnyNPCs(mod.NPCType("Mytholon"));
			
			return !alreadySpawned;
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Mytholon"));
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}
	}
}	