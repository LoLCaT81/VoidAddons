using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items
{
	public class CarKey : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("beep beep");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 30000;
			item.rare = 2;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = mod.MountType("Car");
		}

	}
}