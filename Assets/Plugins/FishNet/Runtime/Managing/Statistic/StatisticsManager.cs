using UnityEngine;

namespace Plugins.FishNet.Runtime.Managing.Statistic
{

    [DisallowMultipleComponent]
    [AddComponentMenu("FishNet/Manager/StatisticsManager")]
    public class StatisticsManager : MonoBehaviour
    {
        /// <summary>
        /// Statistics for NetworkTraffic.
        /// </summary>
        public NetworkTraficStatistics NetworkTraffic = new();

        internal void InitializeOnce_Internal(NetworkManager manager)
        {
            NetworkTraffic.InitializeOnce_Internal(manager);
        }
  
    }

}