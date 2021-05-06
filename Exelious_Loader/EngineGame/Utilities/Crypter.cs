using System;

namespace Exelious_Loader.EngineGame.Utilities
{
	public sealed class Crypter
	{
		private static Random _0001;

		static Crypter()
		{
			//IL_000d: Incompatible stack heights: 0 vs 1
			new Random();
			_0001 = (Random)/*Error near IL_0007: Stack underflow*/;
		}
	}
}
