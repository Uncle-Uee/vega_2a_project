using UnityEngine;

namespace Vega.LU2
{
    public class ScriptLifecycle : MonoBehaviour
    {
        #region FIELDS

        public string AwakeMessage = "Awake Message";
        public string OnEnableMessage = "OnEnable Message";
        public string StartMessage = "Start Message";
        public string OnDisableMessage = "OnDisable Message";
        public string OnDestroyMessage = "OnDestroy Message";

        #endregion

        #region UNITY METHODS

        private void Awake()
        {
            // Called when the GameObject is Instantiated
            Debug.Log(AwakeMessage);
        }

        private void OnEnable()
        {
            // Called everytime when the GameObject is Enabled
            Debug.Log(OnEnableMessage);
        }

        private void Start()
        {
            // Called when the GameObject is Enabled for the first time
            Debug.Log(StartMessage);
        }

        private void FixedUpdate()
        {
            // Used for Physics Calculations
        }

        private void Update()
        {
            // Used for Input, Movement, etc.
        }

        #region TRIGGERS

        private void OnTriggerEnter(Collider other)
        {
            // Used for 3D Physics Interactions where the Collider is a Trigger i.e. when a player enters a trigger area
        }

        private void OnTriggerExit(Collider other)
        {
            // Used for 3D Physics Interactions where the Collider is a Trigger i.e. when a player leaves a trigger area
        }

        private void OnTriggerStay(Collider other)
        {
            // Used for 3D Physics Interactions where the Collider is a Trigger i.e. when a player stays in a trigger area
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            // Used for 2D Physics Interactions where the Collider is a Trigger i.e. when a player enters a trigger area
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            // Used for 2D Physics Interactions where the Collider is a Trigger i.e. when a player leaves a trigger area
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            // Used for 2D Physics Interactions where the Collider is a Trigger i.e. when a player stays in a trigger area
        }

        #endregion

        #region COLLIDERS

        private void OnCollisionEnter(Collision other)
        {
            // Used for 3D Physics Interactions where the Collider is not a Trigger i.e. when a player collides with a non-trigger object
        }

        private void OnCollisionExit(Collision other)
        {
            // Used for 3D Physics Interactions where the Collider is not a Trigger i.e. when a player stops colliding with a non-trigger object
        }

        private void OnCollisionStay(Collision other)
        {
            // Used for 3D Physics Interactions where the Collider is not a Trigger i.e. when a player is colliding with a non-trigger object
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            // Used for 2D Physics Interactions where the Collider is not a Trigger i.e. when a player collides with a non-trigger object
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            // Used for 2D Physics Interactions where the Collider is not a Trigger i.e. when a player stops colliding with a non-trigger object
        }

        private void OnCollisionStay2D(Collision2D other)
        {
            // Used for 2D Physics Interactions where the Collider is not a Trigger i.e. when a player is colliding with a non-trigger object
        }

        #endregion

        private void LateUpdate()
        {
            // Used for Camera Follow, Animations, etc.
        }

        private void OnDisable()
        {
            // Called everytime when the GameObject is Disabled
            // Note: This is when the GameObject is Destroyed
            Debug.Log(OnDisableMessage);
        }

        private void OnDestroy()
        {
            // Called when the GameObject is Destroyed
            // Note: This is not called when the GameObject is Disabled
            Debug.Log(OnDestroyMessage);
        }

        #endregion
    }
}