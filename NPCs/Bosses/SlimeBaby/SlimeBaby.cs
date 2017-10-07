using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.NPCs.Bosses.SlimeBaby
{
	public class SlimeBaby : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slime Baby");
		}
		
		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 22;
			npc.aiStyle = 15;
			npc.damage = 25;
			npc.defense = 12;
			npc.lifeMax = 500;
			npc.knockBackResist = 0f;
			npc.noGravity = false;
			npc.noTileCollide = false;
			npc.timeLeft = NPC.activeTime * 30;
			npc.boss = true;
			npc.value = 30000f;
			npc.npcSlots = 5f;
		}
	}
}	
	