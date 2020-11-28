using UnityEngine;
using UnityEngine.UI;
using Localization;
using Localization.Documents;
using Localization.Utilities;

public class ExampleMenu : UI               // Ereditare dall'interfaccia UI permette di avere accesso alle callbacks di localizzazione
{
    [Header("Settings"), Space(10)]
    public Text exampleName;
    public Text exampleSurname;
    public Text exampleAge;
    public Text exampleID;

    protected override void OnLocalizationChanged(LocalizationManager sender, LocalizationManager.ELanguage localization)
    {
        ExampleDocument document = sender.GetLocalizationDocument<ExampleDocument>();      // Restituisce il documento selezionato basandosi su quello <TIPO-DOCUMENTO-CERCATO>
        
        /* LOADING LOCALIZATION SETTINGS */
        exampleName.text =          document.exampleName;                 // valore del documento di localizzazione
        exampleSurname.text =       document.exampleSurname;              // valori del documento di localizzazione
        exampleAge.text =           document.exampleAge;                  // valore del documento di localizzazione
        exampleID.text =            document.exampleID;                   // valori del documento di localizzazione
    }

    protected override void OnEnglishLocalizationSelected(LocalizationManager sender, LocalizationManager.ELanguage current_localization)
    {
        exampleName.color =         Color.red;
        exampleSurname.color =      Color.red;
        exampleAge.color =          Color.red;
        exampleID.color =           Color.red;
    }
    protected override void OnItalianLocalizationSelected(LocalizationManager sender, LocalizationManager.ELanguage current_localization)
    {
        exampleName.color =         Color.green;
        exampleSurname.color =      Color.green;
        exampleAge.color =          Color.green;
        exampleID.color =           Color.green;
    }

    /* THIS METHOD ALLOW TO SWITCH BETWEEN LOCAZATION SETTINGS - FOR DEMO IS HERE*/
    public void SwitchLocalizationSettings()
    {
        var manager = FakeGameManager.singleton.localizationManager;

        if (manager.localization == LocalizationManager.ELanguage.ENG) manager.ChangeLocalization(LocalizationManager.ELanguage.ITA);
        else manager.ChangeLocalization(LocalizationManager.ELanguage.ENG);
    }
}
