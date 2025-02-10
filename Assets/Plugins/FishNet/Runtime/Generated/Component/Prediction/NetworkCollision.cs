namespace Plugins.FishNet.Runtime.Generated.Component.Prediction
{
    public sealed class NetworkCollision : NetworkCollider
    {
        protected override void Awake()
        {
            base.IsTrigger = false;
            base.Awake();
        }
    }

}