using Plugins.FishNet.Runtime.Connection;
using Plugins.FishNet.Runtime.Object.Synchronizing;
using UnityEngine;

namespace Plugins.FishNet.Runtime.Object
{
    public partial class NetworkObject : MonoBehaviour
    {
        /// <summary>
        /// Writes SyncTypes for previous and new owner where permissions apply.
        /// </summary>
        
        private void WriteSyncTypesForManualOwnershipChange(NetworkConnection prevOwner)
        {
            if (prevOwner.IsActive)
                WriteForConnection(prevOwner, ReadPermission.ExcludeOwner);
            if (Owner.IsActive)
                WriteForConnection(Owner, ReadPermission.OwnerOnly);
            
            void WriteForConnection(NetworkConnection conn, ReadPermission permission)
            {
                for (int i = 0; i < NetworkBehaviours.Count; i++)
                    NetworkBehaviours[i].WriteSyncTypesForConnection(conn, permission);
            }
        }
    }
}