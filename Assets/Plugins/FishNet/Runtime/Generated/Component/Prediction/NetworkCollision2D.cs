namespace Plugins.FishNet.Runtime.Generated.Component.Prediction
{
    public sealed class NetworkCollision2D : NetworkCollider2D
    {
        protected override void Awake()
        {
            base.IsTrigger = false;
            base.Awake();
        }

    }

}