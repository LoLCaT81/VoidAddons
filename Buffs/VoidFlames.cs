using Terraria;
using Terraria.ModLoader;
using VoidAddons.NPCs;

namespace VoidAddons.Buffs
{
	public class VoidFlames : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Void Flames");
			Description.SetDefault("The Void is consuming you");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}
	}
}
