using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Vega.LU4
{
    [System.Serializable]
    public class UnityEventTransform : UnityEvent<Transform>
    {
    }

    public class UnityEventsExample : MonoBehaviour
    {
        #region FIELDS

        [Header("EVENTS")]
        public UnityEvent StandardUnityEvent = new UnityEvent();
        
        public UnityEventTransform TransformUnityEvent = new UnityEventTransform();

        [Header("Data")]
        public int Score;

        #endregion

        #region UNITY METHODS

        #endregion

        #region METHODS

        public void AddToScore(int value)
        {
            Score += value;
        }

        public void PrintTransformName(Transform other)
        {
            print(other.name);
        }

        #endregion
    }
}