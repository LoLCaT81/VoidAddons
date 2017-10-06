using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.NPCs
{
	public class Eye : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("weed");
			Main.npcFrameCount[npc.type] = 6;
		}
		
		public override void SetDefaults()
		{
			npc.width = 100;
			npc.height = 110;
			npc.aiStyle = 4;
			npc.damage = 15;
			npc.defense = 12;
			npc.lifeMax = 2800;
			npc.knockBackResist = 0f;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.timeLeft = NPC.activeTime * 30;
			npc.boss = true;
			npc.value = 30000f;
			npc.npcSlots = 5f;
		}
	}
}	
			