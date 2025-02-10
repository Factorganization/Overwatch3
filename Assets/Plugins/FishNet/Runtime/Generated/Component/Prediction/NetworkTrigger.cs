namespace Plugins.FishNet.Runtime.Generated.Component.Prediction
{

    public sealed class NetworkTrigger : NetworkCollider
    {
        protected override void Awake()
        {
            base.IsTrigger = true;
            base.Awake();
        }

    }

}