using UnityEngine;
using Vega.Common.Orientation;

namespace Vega.Examples
{
    public class MousePosition2D_Example : MonoBehaviour
    {
        #region FIELDS

        [Header("References")]
        [SerializeField]
        private ParentOrientationHandler _orientationHandler;

        private Camera _camera;

        #endregion

        #region UNITY METHODS

        private void Awake()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            Vector2 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mousePosition - (Vector2)transform.position;

            _orientationHandler.MotionHandler(direction);
        }

        #endregion

        #region METHODS

        #endregion
    }
}