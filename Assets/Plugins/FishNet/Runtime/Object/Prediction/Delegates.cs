using System.Runtime.CompilerServices;
using Plugins.FishNet.Runtime.Connection;
using Plugins.FishNet.Runtime.Documenting;
using Plugins.FishNet.Runtime.Serializing;
using Plugins.FishNet.Runtime.Transporting;
using Plugins.FishNet.Runtime.Utility;

[assembly: InternalsVisibleTo(UtilityConstants.CODEGEN_ASSEMBLY_NAME)]
namespace Plugins.FishNet.Runtime.Object.Prediction
{
    [APIExclude]
    public delegate void ReplicateRpcDelegate(PooledReader reader, NetworkConnection sender, Channel channel);
    [APIExclude]
    public delegate void ReconcileRpcDelegate(PooledReader reader, Channel channel);

    [APIExclude]
    public delegate void ReplicateUserLogicDelegate<T>(T data, ReplicateState state, Channel channel);
    [APIExclude]
    public delegate void ReconcileUserLogicDelegate<T>(T data, Channel channel);
}