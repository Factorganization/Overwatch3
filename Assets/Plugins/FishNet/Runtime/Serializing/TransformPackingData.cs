namespace Plugins.FishNet.Runtime.Serializing
{
    [System.Serializable]
    internal class TransformPackingData
    {
        public AutoPackType Position = AutoPackType.Packed;
        public AutoPackType Rotation = AutoPackType.Packed;
        public AutoPackType Scale = AutoPackType.Packed;
    }
}
