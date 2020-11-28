namespace Localization.Utilities
{
    /// <summary>
    /// This class provides some callback for localize texts
    /// </summary>
    public abstract class UI : UnityEngine.MonoBehaviour
    {
        #region UnityCallbacks
        protected void OnEnable()
        {
            LocalizationManager.OnLocalizationChanged       += OnLocalizationChanged;
            LocalizationManager.OnEngSelected               += OnEnglishLocalizationSelected;
            LocalizationManager.OnItaSelected               += OnItalianLocalizationSelected;
        }
        protected void OnDisable()
        {
            LocalizationManager.OnLocalizationChanged       -= OnLocalizationChanged;
            LocalizationManager.OnEngSelected               -= OnEnglishLocalizationSelected;
            LocalizationManager.OnItaSelected               -= OnItalianLocalizationSelected;
        }
        #endregion

        /// <summary>
        /// Visualize this object in viewport
        /// </summary>
        public void Enable() => gameObject.SetActive(true);
        /// <summary>
        /// Hide this object from viewport
        /// </summary>
        public void Disable() => gameObject.SetActive(false);

        /// <summary>
        /// Called when the localization settings changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="localization"></param>
        protected virtual void OnLocalizationChanged(LocalizationManager sender, LocalizationManager.ELanguage localization) { }
        /// <summary>
        /// Called when the italian localization is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="current_localization"></param>
        protected virtual void OnItalianLocalizationSelected(LocalizationManager sender, LocalizationManager.ELanguage current_localization) { }
        /// <summary>
        /// Called when the english localization is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="current_localization"></param>
        protected virtual void OnEnglishLocalizationSelected(LocalizationManager sender, LocalizationManager.ELanguage current_localization) { }
    }
}