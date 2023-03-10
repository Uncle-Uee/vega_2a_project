using System;
using UnityEngine;

namespace Vega.Examples
{
    public class PlayerController2D_Example : MonoBehaviour
    {
        #region FIELDS

        [Header("References")]
        public Rigidbody2D Rigidbody2D;
        public Animator Animator;

        [Header("Movement Properties")]
        [SerializeField]
        private float _speed = 5f;
        [SerializeField]
        private bool _isFacingRight = true;

        private float _horizontal;
        private Vector2 _velocity = Vector2.zero;

        #endregion

        #region UNITY METHODS

        private void Awake()
        {
        }

        private void Update()
        {
            _velocity.x = Input.GetAxis("Horizontal");
            Animator.SetFloat("Speed", Mathf.Abs(_velocity.x));

            if (_velocity.x > 0f && !_isFacingRight)
            {
                _isFacingRight = true;
                transform.Rotate(0f, 180f, 0f);
            }
            else if (_velocity.x < 0f && _isFacingRight)
            {
                _isFacingRight = false;
                transform.Rotate(0f, 180f, 0f);
            }
        }

        private void FixedUpdate()
        {
            _velocity.x *= _speed;
            _velocity.y = Rigidbody2D.velocity.y;
            Rigidbody2D.velocity = _velocity;
        }

        #endregion

        #region METHODS

        #endregion
    }
}