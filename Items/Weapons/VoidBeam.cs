using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace VoidAddons.Items.Weapons
{
	public class VoidBeam : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This Baby can take up to 1000°C");
		}

		public override void SetDefaults()
		{
			item.damage = 330;
			item.noMelee = true;
			item.magic = true;
			item.channel = true;                            //Channel so that you can held the weapon [Important]
			item.mana = 2;
			item.rare = 10;
			item.width = 28;
			item.height = 30;
			item.useTime = 5;
			item.UseSound = SoundID.Item13;
			item.useStyle = 5;
			item.shootSpeed = 14f;				//Speed is not important here
			item.useAnimation = 20;                         
			item.shoot = mod.ProjectileType("Deathbeam");
			item.value = Item.sellPrice(0, 3, 0, 0);
		}

	}
}
