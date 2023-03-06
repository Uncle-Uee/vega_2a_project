using UnityEngine;

namespace Vega.Weapon
{
    public class WeaponOrientationHandler : MonoBehaviour
    {
        #region FIELDS

        [Header("References")]
        [SerializeField]
        private SpriteRenderer _weaponRenderer;

        [Header("Weapon Rotation Settings")]
        public bool WeaponRotationStopped = false;

        #endregion

        #region METHODS

        public void MotionHandler(Vector3 mousePosition)
        {
            if (WeaponRotationStopped)
                return;

            Vector2 direction = (mousePosition - transform.position).normalized;
            transform.right = direction;

            RotationHandler(direction);
            SpriteSortOrderHandler();
        }

        private void SpriteSortOrderHandler()
        {
            if (transform.localEulerAngles.z is > 180f and < 360f)
            {
                _weaponRenderer.sortingOrder = 1;
            }
            else
            {
                _weaponRenderer.sortingOrder = -1;
            }
        }

        private void RotationHandler(Vector2 direction)
        {
            if (direction.x < 0)
            {
                transform.Rotate(180f, 0f, 0f);
            }
            if (Mathf.Approximately(direction.x, -1))
            {
                transform.Rotate(-180f, 0f, 0f);
            }
            else
            {
                transform.Rotate(0f, 0f, 0f);
            }
        }

        #endregion
    }
}