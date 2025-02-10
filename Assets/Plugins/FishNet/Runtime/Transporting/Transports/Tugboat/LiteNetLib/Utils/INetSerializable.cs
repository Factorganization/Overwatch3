namespace Plugins.FishNet.Runtime.Transporting.Transports.Tugboat.LiteNetLib.Utils
{
    public interface INetSerializable
    {
        void Serialize(NetDataWriter writer);
        void Deserialize(NetDataReader reader);
    }
}
