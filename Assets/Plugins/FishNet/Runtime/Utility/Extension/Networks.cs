using Plugins.FishNet.Runtime.Documenting;
using Plugins.FishNet.Runtime.Managing;
using Plugins.FishNet.Runtime.Object;

namespace Plugins.FishNet.Runtime.Utility.Extension
{
    [APIExclude]
    public static class NetworksFN
    {
        /// <summary>
        /// Returns if logic could have potentially called already on server side, and is calling a second time for clientHost side.
        /// </summary>
        public static bool DoubleLogic(this NetworkObject nob, bool asServer) => (!asServer && nob.NetworkManager.IsServerStarted);
        /// <summary>
        /// Returns if logic could have potentially called already on server side, and is calling a second time for clientHost side.
        /// </summary>
        public static bool DoubleLogic(this NetworkManager manager, bool asServer) => (!asServer && manager.IsServerStarted);
        /// <summary>
        /// Returns if logic could have potentially called already on server side, and is calling a second time for clientHost side.
        /// </summary>
        public static bool DoubleLogic(this NetworkBehaviour nb, bool asServer) => (!asServer && nb.NetworkManager.IsServerStarted);

    }

}