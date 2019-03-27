using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using BepInEx;
using Harmony;

namespace ResourceRedirector_MLSP
{
    [BepInPlugin("ResourceRedirectorPatch", "ResourceRedirectorPatch", "1.0")]
    [BepInDependency(ResourceRedirector.ResourceRedirector.GUID)]
    public class ResourceRedirector_MLS : BaseUnityPlugin
    {
        //private static ModLoaderSupport _mls;

        public ResourceRedirector_MLS()
        {
            Hooks.InstallHooks();
        }

    }

}
