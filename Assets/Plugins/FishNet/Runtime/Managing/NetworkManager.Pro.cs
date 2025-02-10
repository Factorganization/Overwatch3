using Plugins.FishNet.Runtime.Plugins.ColliderRollback.Scripts;
using UnityEngine;

namespace Plugins.FishNet.Runtime.Managing
{
    public sealed partial class NetworkManager : MonoBehaviour
    {

        #region Public.
        /// <summary>
        /// RollbackManager for this NetworkManager.
        /// </summary>
        public RollbackManager RollbackManager { get; private set; }
        #endregion


    }


}