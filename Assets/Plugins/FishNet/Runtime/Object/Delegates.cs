using System.Runtime.CompilerServices;
using Plugins.FishNet.Runtime.Connection;
using Plugins.FishNet.Runtime.Serializing;
using Plugins.FishNet.Runtime.Transporting;
using Plugins.FishNet.Runtime.Utility;

[assembly: InternalsVisibleTo(UtilityConstants.CODEGEN_ASSEMBLY_NAME)]
namespace Plugins.FishNet.Runtime.Object
{
    public delegate void ServerRpcDelegate(PooledReader reader, Channel channel, NetworkConnection sender);
    public delegate void ClientRpcDelegate(PooledReader reader, Channel channel);
    public delegate bool SyncVarReadDelegate(PooledReader reader, byte index, bool asServer);
}
