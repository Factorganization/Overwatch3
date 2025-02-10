using Plugins.FishNet.Runtime.Managing.Timing;
using UnityEngine;

namespace Plugins.FishNet.Runtime.Transporting
{
    [DisallowMultipleComponent]
    [DefaultExecutionOrder(short.MinValue)]
    internal class NetworkReaderLoop : MonoBehaviour
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

        private void FixedUpdate()
        {
            _timeManager.TickFixedUpdate();
        }
        private void Update()
        {
            _timeManager.TickUpdate();
        }
    }


}