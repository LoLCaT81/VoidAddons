using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace VoidAddons.Tiles
{
	public class VoidTree : ModTree
	{
		private Mod mod
		{
			get
			{
				return ModLoader.GetMod("VoidAddons");
			}
		}

		public override int CreateDust()
		{
			return mod.DustType("Sparkle");
		}

		public override int GrowthFXGore()
		{
			return mod.GetGoreSlot("Gores/VoidTreeFX");
		}

		public override int DropWood()
		{
			return mod.ItemType("VoidBlock");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/VoidTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
		{
			return mod.GetTexture("Tiles/VoidTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
		{
			return mod.GetTexture("Tiles/VoidTree_Branches");
		}
	}
}