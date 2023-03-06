using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vega.LU3
{
    public class CircleInstantiation : MonoBehaviour
    {
        #region FIELDS

        public GameObject CirclePrefab;
        public Vector3 Position;
        [SerializeField]
        private Vector3 _rotation;
        public Transform Parent;

        #endregion

        #region PROPERTIES

        public Vector3 Rotation
        {
            get => _rotation;

            set => _rotation = value;
        }

        #endregion

        #region UNITY METHODS

        private void Start()
        {
            GameObject parent = new GameObject("Parent");
            Instantiate(CirclePrefab, Position, Quaternion.Euler(_rotation), parent.transform);
        }

        #endregion

        #region METHODS

        #endregion
    }
}