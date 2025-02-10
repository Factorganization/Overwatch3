using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Plugins.FishNet.Runtime.Serializing
{
	internal sealed class SceneHandleEqualityComparer : EqualityComparer<Scene>
	{
		public override bool Equals(Scene a, Scene b)
		{
			return (a.handle == b.handle);
		}

        public override int GetHashCode(Scene obj)
        {
			return obj.handle;
        }
    }
}
