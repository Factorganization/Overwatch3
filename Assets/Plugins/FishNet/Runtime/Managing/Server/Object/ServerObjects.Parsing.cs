using Plugins.FishNet.Runtime.Connection;
using Plugins.FishNet.Runtime.Managing.Object;
using Plugins.FishNet.Runtime.Managing.Utility;
using Plugins.FishNet.Runtime.Object;
using Plugins.FishNet.Runtime.Serializing;
using Plugins.FishNet.Runtime.Transporting;

namespace Plugins.FishNet.Runtime.Managing.Server.Object
{
    public partial class ServerObjects : ManagedObjects
    {

        /// <summary>
        /// Parses a ServerRpc.
        /// </summary>
        
        internal void ParseServerRpc(PooledReader reader, NetworkConnection conn, Channel channel)
        {
            NetworkBehaviour nb = reader.ReadNetworkBehaviour();
            int dataLength = Packets.GetPacketLength((ushort)PacketId.ServerRpc, reader, channel);

            if (nb != null)
                nb.ReadServerRpc(reader, conn, channel);
            else
                SkipDataLength((ushort)PacketId.ServerRpc, reader, dataLength);
        }
    }

}