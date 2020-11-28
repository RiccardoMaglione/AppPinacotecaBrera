SCE, com.Grayson1509.Localization,
A. Manna, Copyright(C), 2020
all rights reserved
vs.1.0

===================================================================================
                HOW TO IMPLEMENT THE LOCALIZATION FRAMEWORK
===================================================================================
1. In your GAME_MANAGER create the class "LOCALIZATIION MANAGER" and type 
LocalizationManager.Initialize(localization_settings)
2. Inherit your GUI class from the "namespace Localization.UI"
3. At this point you can override inside your class 3 Callbacks
	#OnLocalizationChanged: 	Called when the localization settings changes
	#OnItalianLocalizationSelected: Called when the italian localization sets
	#OnEnglishLocalizationSelected: Called when the italian localization sets
4. From these callbacks you can access the SENDER; here call the method as below:
	#sender.GetLocalizationDocument<DOCUMENT-TYPE>()
5. Access the document to get localization infos

===================================================================================
                         HOW TO CREATE LOCALIZATION FILES
===================================================================================
1. Inherit from "Localization Document" interface 
2. Create your data infos here
3. Create an .xml file inside the folder "Localization/Resources/ITA/ENG/FILE_NAME.xml"
4. Write the same architecture of the Localization document just created
5. End

NB: IF YOU INHERIT FROM UI CALLING AND/OR on-enable/on-disbale from UI Interface without inherit the base behaviour 
    THE LOCALIZATION FRAMEWORK WILL NOT WORKS ANYMORE

===================================================================================
                     NOTES FOR UPCOMING VERSION _1.1.0
===================================================================================
# Localization tool for creating localization documents in editor
# Localization Window for building your localization documents whitout using visual studio

Feel free to contact me if you noted a bug;

>Discord: Grayson#0424

Cheers;
Grayson1509