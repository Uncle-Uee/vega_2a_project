using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Vega.LU4
{
    public class SimpleUIInteractions : MonoBehaviour
    {
        #region FIELDS

        [Header("UI Elements")]
        public Button PlayButton;
        public Button QuitButton;

        [Header("Unity Events")]
        public UnityEvent OnQuitButtonClicked = new UnityEvent();

        #endregion

        #region UNITY METHODS

        private void OnEnable()
        {
            OnQuitButtonClicked.AddListener(OnQuitButton);
            PlayButton.onClick.AddListener(OnPlayButton_Clicked);
        }

        private void OnDisable()
        {
            OnQuitButtonClicked.RemoveListener(OnQuitButton);
            PlayButton.onClick.RemoveListener(OnPlayButton_Clicked);
        }

        #endregion

        #region METHODS

        private void OnQuitButton()
        {
            Camera.main.enabled = false;
        }

        private void OnPlayButton_Clicked()
        {
            SoundManager.Instance.PlayChoirBase();
        }

        public void OnQuitButton_Clicked()
        {
            print("Quit button clicked!");
            OnQuitButtonClicked.Invoke();
            Application.Quit();
        }

        #endregion
    }
}