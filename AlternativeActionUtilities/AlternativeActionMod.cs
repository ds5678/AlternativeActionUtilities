using MelonLoader;

namespace AlternativeActionUtilities
{
	internal class AlternativeActionMod : MelonMod
    {
		public override void OnApplicationStart()
		{
			Settings.instance.AddToModSettings("Alternative Action Settings");
		}
	}
}
