

using BepInEx;
using Menu;
using UnityEngine;
using Menu.Remix.MixedUI;

[BepInPlugin("DLCFIX", "DLC loader fix", "1.0")]
public class DLCFIX : BaseUnityPlugin
{
    public void OnEnable()
    {
        // --- DLC FIX ---
        Logger.LogInfo("DLCFIX: loaded");
        On.RainWorld.Start += (orig, self) =>
        {
            orig(self);

            if (!self.dlcsInstalled.Contains("downpour"))
            {
                self.dlcsInstalled.Add("downpour");
                Logger.LogInfo("DLCFIX: added downpour back to remix");
            }
            if (!self.dlcsInstalled.Contains("watcher"))
            {
                self.dlcsInstalled.Add("watcher");
                Logger.LogInfo("DLCFIX: added watcher back to remix");
            }


            Logger.LogInfo("DLCFIX: reset and enabled detection of installed DLCs");
        };


    }

}