using UnityEngine;

namespace Vega.Common.Orientation
{
    public class ParentOrientationHandler : MonoBehaviour
    {
        #region FIELDS

        [Header("References")]
        [SerializeField]
        private SpriteRenderer _weaponRenderer;

        [Header("Weapon Rotation Settings")]
        public bool WeaponRotationStopped = false;
        private Transform _transform;

        #endregion

        #region UNITY METHODS

        private void Awake()
        {
            _transform = transform;
        }

        #endregion

        #region METHODS

        public void MotionHandler(Vector2 direction)
        {
            if (WeaponRotationStopped)
                return;

            _transform.right = direction;
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
            _weaponRenderer.flipY = direction.x < 0;
        }

        #endregion
    }
}