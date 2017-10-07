using Terraria;
using Terraria.ModLoader;

namespace VoidAddons.Buffs
{
	public class PurityWisp : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Purity Wisp");
			Description.SetDefault("The purity wisp will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}