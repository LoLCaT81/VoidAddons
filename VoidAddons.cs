using Terraria.ModLoader;

namespace VoidAddons
{
	class VoidAddons : Mod
	{
		public VoidAddons()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
