using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vega.LU3
{
    public class ObjectCreatorButton : MonoBehaviour
    {
        #region FIELDS

        public GameObject ExplosionPrefab;

        #endregion

        #region UNITY METHODS

        private void Update()
        {
            bool isEnterPressed = Input.GetKeyDown(KeyCode.O);
            if (isEnterPressed)
            {
                // Instantiate our Explosion
                Instantiate(ExplosionPrefab,
                            new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0f),
                            Quaternion.identity);
            }
        }

        #endregion

        #region METHODS

        #endregion
    }
}