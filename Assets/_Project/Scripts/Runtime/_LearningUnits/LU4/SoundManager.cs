using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Vega
{
    public class SoundManager : MonoBehaviour
    {
        #region FIELDS

        [Header("SFX")]
        public AudioSource ChoirBaseSFX;

        private static SoundManager _instance;

        #endregion

        #region PROPERTIES

        public static SoundManager Instance
        {
            get
            {
                if (_instance != null) return _instance;

                _instance = FindObjectOfType<SoundManager>();

                if (_instance != null) return _instance;

                GameObject soundManager = new GameObject("[SoundManager]");
                _instance = soundManager.AddComponent<SoundManager>();
                DontDestroyOnLoad(_instance.gameObject);
                return _instance;
            }
        }

        #endregion

        #region UNITY METHODS

        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        #endregion

        #region METHODS

        public void PlayChoirBase()
        {
            ChoirBaseSFX.Play();
        }

        #endregion
    }
}