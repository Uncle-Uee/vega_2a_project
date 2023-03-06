using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vega.LU3
{
    public class FindingObjects : MonoBehaviour
    {
        #region FIELDS

        #endregion

        #region UNITY METHODS

        private void Start()
        {
            // THIS IS NOT THE RECOMMENDED WAY TO FIND OBJECTS WITHIN YOUR SCENE!
            
            // Find a reference to the GameObject with the name "[MANAGERS]"
            GameObject manager = GameObject.Find("[MANAGERS]");
            manager.name = "Vega Manager";
            SpriteRenderer spriteRenderer = manager.AddComponent<SpriteRenderer>();
            spriteRenderer.color = Color.red;
            print(manager == null);

            // Find a reference to the GameObject with the tag "Managers"
            GameObject managerTaggedObject = GameObject.FindWithTag("Managers");
            print(managerTaggedObject == null);

            // Find a reference to the CircleInstantiation script
            CircleInstantiation circleInstantiation = GameObject.FindObjectOfType<CircleInstantiation>();
        }

        #endregion

        #region METHODS

        #endregion
    }
}