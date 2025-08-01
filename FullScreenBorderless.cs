using MelonLoader;
using BTD_Mod_Helper;
using FullScreenBorderless;
[assembly: MelonInfo(typeof(FullScreenBorderless.FullScreenBorderless), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace FullScreenBorderless;

public class FullScreenBorderless : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        MelonLoader.MelonLogger.Msg("FullScreenBorderless loaded!");

        UnityEngine.Screen.fullScreenMode = UnityEngine.FullScreenMode.FullScreenWindow;
    }
}


