using UnityEngine;
using Vega.Weapon;

namespace Vega.Player
{
    public class ExperimentalController : MonoBehaviour
    {
        #region FIELDS

        [Header("References")]
        [SerializeField]
        private WeaponOrientationHandler _weaponOrientationHandler;

        private bool _isFacingRight = true;
        private Vector3 _facingRotation = new Vector3(0f, 180f, 0f);
        private Camera _camera;

        #endregion

        #region UNITY METHODS

        private void Awake()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            _weaponOrientationHandler.MotionHandler(GetPointerPosition());
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            if (x > 0f && !_isFacingRight) ChangeFacingDirection();
            else if (x < 0f && _isFacingRight) ChangeFacingDirection();
        }

        #endregion

        #region METHODS

        private void ChangeFacingDirection()
        {
            _isFacingRight = !_isFacingRight;
            transform.Rotate(_facingRotation);
        }

        private Vector2 GetPointerPosition()
        {
            Vector2 mousePosition = Input.mousePosition;
            return _camera.ScreenToWorldPoint(mousePosition);
        }

        #endregion
    }
}