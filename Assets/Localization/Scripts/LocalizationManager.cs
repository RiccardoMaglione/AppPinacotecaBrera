

namespace Localization
{ 
    /// <summary>
    /// This class manage and load localizatio resources for UI
    /// </summary>
    public sealed class LocalizationManager
    {
        public enum ELanguage { ENG, ITA }

        ELanguage _localization;
        /// <summary>
        /// Current language selected 
        /// </summary>
        public ELanguage localization
        {
            get { return _localization; }
            private set
            {
                if (value != _localization)
                {
                    _localization = value;
                    OnLocalizationChanged?.Invoke(this, value);

                    switch (value)
                    {
                        case ELanguage.ENG:
                            OnEngSelected?.Invoke(this, value);
                            break;
                        case ELanguage.ITA:
                            OnItaSelected?.Invoke(this, value);
                            break;
                    }
                }
            }
        }                   

        #region Events
        public delegate void LocalizationEvent(LocalizationManager sender, ELanguage localization);
        public static event LocalizationEvent OnLocalizationChanged;
        public static event LocalizationEvent OnItaSelected;
        public static event LocalizationEvent OnEngSelected;
        #endregion

        /// <summary>
        /// Initalize localization resources
        /// </summary>
        public void Initialize(ELanguage language)
        {
            _localization = language;
        }
        /// <summary>
        /// Return a localization document
        /// </summary>
        /// <typeparam name="T">document type to get</typeparam>
        public T GetLocalizationDocument<T>() where T : LocalizationDocument, new()
        {
            T doc = new T();
            string filePath = string.Empty;

            /* CHECK LOCALIZATION SETTINGS */
            switch (localization)
            {
                case ELanguage.ENG:
                    if (doc is Localization.Documents.Dog) filePath = "/Localization/Resources/ENG/God.xml";
                    break;
                case ELanguage.ITA:
                    if (doc is Localization.Documents.Dog) filePath = "/Localization/Resources/ITA/Dio.xml";
                    break;
            }

            /* LOAD LOCALIZATION DATA FROM DOCUMENT */
            System.Xml.Serialization.XmlSerializer binaryFormatter = new System.Xml.Serialization.XmlSerializer(typeof(T));
            System.IO.Stream stream = new System.IO.FileStream(UnityEngine.Application.dataPath + filePath, System.IO.FileMode.Open);
            doc = binaryFormatter.Deserialize(stream) as T;
            stream.Close();

            return doc;
        }
        /// <summary>
        /// Change localization settings
        /// </summary>
        /// <param name="_newLocalization"></param>
        public void ChangeLocalization(ELanguage _newLocalization) => localization = _newLocalization;
        
    }
}
