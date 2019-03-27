using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;

namespace ResourceRedirector_MLSP
{
    static class Hooks
    {
        public static void InstallHooks()
        {
            HarmonyInstance.Create("com.snw.bepinex.resourceredirector_mlsp").PatchAll(typeof(Hooks));
        }

        [HarmonyPostfix]
        [HarmonyPatch(typeof(ResourceRedirector.ResourceRedirector), nameof(ResourceRedirector.ResourceRedirector.AssetBundleExists))]
        public static void AssetBundleExistsPostfix(string assetBundleName, ref bool __result)
        {
            __result = __result || ModLoaderSupport.AssetBundleFileExist(assetBundleName);
        }
    }
}
