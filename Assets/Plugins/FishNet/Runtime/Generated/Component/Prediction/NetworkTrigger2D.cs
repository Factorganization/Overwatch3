namespace Plugins.FishNet.Runtime.Generated.Component.Prediction
{

    public sealed class NetworkTrigger2D : NetworkCollider2D
    {
        protected override void Awake()
        {
            base.IsTrigger = true;
            base.Awake();
        }
    }

}