using System.Collections.Generic;
using GameKit.Dependencies.Utilities;
using Plugins.FishNet.Runtime.Broadcast;
using Plugins.FishNet.Runtime.CodeGenerating;
using Plugins.FishNet.Runtime.Serializing;

namespace Plugins.FishNet.Runtime.Managing.Server
{
    public struct ClientConnectionChangeBroadcast : IBroadcast
    {
        public bool Connected;
        public int Id;
    }

    [UseGlobalCustomSerializer]
    public struct ConnectedClientsBroadcast : IBroadcast
    {
        public List<int> Values;
    }

    
    internal static class ConnectedClientsBroadcastSerializers
    {
        public static void WriteConnectedClientsBroadcast(this Writer writer, ConnectedClientsBroadcast value)
        {
            writer.WriteList(value.Values);
        }

        public static ConnectedClientsBroadcast ReadConnectedClientsBroadcast(this Reader reader)
        {
            List<int> cache = CollectionCaches<int>.RetrieveList();
            reader.ReadList(ref cache);
            return new()
            {
                Values = cache
            };
        }

    }
}

