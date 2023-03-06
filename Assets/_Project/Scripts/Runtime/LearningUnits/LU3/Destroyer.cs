using UnityEngine;

namespace Vega.LU3
{
    public class Destroyer : MonoBehaviour
    {
        #region METHODS

        public void DestroySelf()
        {
            Destroy(gameObject);
        }

        #endregion
    }
}