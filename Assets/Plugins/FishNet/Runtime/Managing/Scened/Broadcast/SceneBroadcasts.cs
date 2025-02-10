using Plugins.FishNet.Runtime.Broadcast;
using Plugins.FishNet.Runtime.Documenting;
using Plugins.FishNet.Runtime.Managing.Scened.LoadUnloadDatas;

namespace Plugins.FishNet.Runtime.Managing.Scened.Broadcast
{

    /// <summary>
    /// Sent when there are starting scenes for the client to load.
    /// </summary>
    public struct EmptyStartScenesBroadcast : IBroadcast { }
    /// <summary>
    /// Sent to clients to load networked scenes.
    /// </summary>
    [APIExclude]
    public struct LoadScenesBroadcast : IBroadcast
    {
        public LoadQueueData QueueData;
    }

    /// <summary>       
    /// Sent to clients to unload networked scenes.
    /// </summary>     
    [APIExclude]
    public struct UnloadScenesBroadcast : IBroadcast
    {
        public UnloadQueueData QueueData;
    }

    /// <summary> 
    /// Sent to server to indicate which scenes a client has loaded.
    /// </summary>
    [APIExclude]
    public struct ClientScenesLoadedBroadcast : IBroadcast
    {
        public SceneLookupData[] SceneLookupDatas;
    }

}