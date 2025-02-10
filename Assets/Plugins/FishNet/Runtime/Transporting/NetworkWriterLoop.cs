using Plugins.FishNet.Runtime.Managing.Timing;
using UnityEngine;

namespace Plugins.FishNet.Runtime.Transporting
{
    [DisallowMultipleComponent]
    [DefaultExecutionOrder(short.MaxValue)]
    internal class NetworkWriterLoop : MonoBehaviour
    {
        #region Private.
        /// <summary>
        /// TimeManager this loop is for.
        /// </summary>
        private TimeManager _timeManager;
        #endregion

        private void Awake()
        {
            _timeManager = GetComponent<TimeManager>();
        }

        private void LateUpdate()
        {
            Iterate();
        }

        /// <summary>
        /// Performs read on transport.
        /// </summary>
        private void Iterate()
        {
            _timeManager.TickLateUpdate();
        }

    }


}