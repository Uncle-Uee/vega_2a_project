using UnityEngine;

namespace Vega.LU3
{
    public class RandomColourChanger : MonoBehaviour
    {
        #region FIELDS

        public SpriteRenderer _spriteRenderer;

        #endregion

        #region UNITY METHODS

        private void Awake()
        {
            // _spriteRenderer = GetComponent<SpriteRenderer>();
            SpriteRenderer[] spriteRenderers = GetComponentsInChildren<SpriteRenderer>();
            SpriteRenderer eye_1 = spriteRenderers[1];
            SpriteRenderer eye_2 = spriteRenderers[2];
            _spriteRenderer.color = Random.ColorHSV();

            eye_1.color = Random.ColorHSV();
            eye_2.color = Random.ColorHSV();
        }

        #endregion

        #region METHODS

        #endregion
    }
}