using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VoidAddons.Items.Bosses.Weed
{
	//ported from my tAPI mod because I don't want to make more artwork
	public class MoltenDrill : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("nice?");
		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.melee = true;
			item.width = 20;
			item.height = 12;
			item.useTime = 2;
			item.useAnimation = 20;
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.pick = 42000;
			item.tileBoost++;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 22, 50, 0);
			item.rare = 9;
			item.UseSound = SoundID.Item23;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("MoltenDrill");
			item.shootSpeed = 40f;
		}
	}
}