using Plugins.FishNet.Runtime.Managing;
using Plugins.FishNet.Runtime.Managing.Logging;
using UnityEngine;

namespace Plugins.FishNet.Runtime.Object
{

    public abstract partial class NetworkBehaviour : MonoBehaviour
    {

        /// <summary>
        /// True if can log for loggingType.
        /// </summary>
        /// <param name="loggingType">Type of logging being filtered.</param>
        /// <returns></returns>
        public bool CanLog(LoggingType loggingType)
        {
            return NetworkManager.CanLog(loggingType);
        }
    }


}