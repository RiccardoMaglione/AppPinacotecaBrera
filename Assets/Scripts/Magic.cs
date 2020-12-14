using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Localization;
using Localization.Documents;
using Localization.Utilities;

public class Magic : UI               // Ereditare dall'interfaccia UI permette di avere accesso alle callbacks di localizzazione
{
    [Header("Settings"), Space(10)]
    public Text HomeTitle;
    public TextMeshProUGUI HomeText;
    public Text exampleAge;
    public Text exampleID;

    protected override void OnLocalizationChanged(LocalizationManager sender, LocalizationManager.ELanguage localization)
    {
        Dog document = sender.GetLocalizationDocument<Dog>();      // Restituisce il documento selezionato basandosi su quello <TIPO-DOCUMENTO-CERCATO>

        /* LOADING LOCALIZATION SETTINGS */
        HomeText.text = document.HomeText;                 // valore del documento di localizzazione
        HomeTitle.text = document.HomeTitle;              // valori del documento di localizzazione
        exampleID.text = document.exampleID;                   // valori del documento di localizzazione
    }

    /*protected override void OnEnglishLocalizationSelected(LocalizationManager sender, LocalizationManager.ELanguage current_localization)
    {
        exampleName.color = Color.red;
        exampleSurname.color = Color.red;
        exampleAge.color = Color.red;
        exampleID.color = Color.red;
    }
    protected override void OnItalianLocalizationSelected(LocalizationManager sender, LocalizationManager.ELanguage current_localization)
    {
        exampleName.color = Color.green;
        exampleSurname.color = Color.green;
        exampleAge.color = Color.green;
        exampleID.color = Color.green;
    }

    /* THIS METHOD ALLOW TO SWITCH BETWEEN LOCAZATION SETTINGS - FOR DEMO IS HERE*/
    public void SwitchLocalizationSettings()
    {
        var manager = FakeGameManager.singleton.localizationManager;

        if (manager.localization == LocalizationManager.ELanguage.ENG) manager.ChangeLocalization(LocalizationManager.ELanguage.ITA);
        else manager.ChangeLocalization(LocalizationManager.ELanguage.ENG);
    }
}
