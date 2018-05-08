using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// Execute the code as required for different menu item options

public class MenuItems : MonoBehaviour {

	[ MenuItem ( "Tools/New Option" ) ] // Specify Menu Item under New Menu Tools, leads to creating a new menu named Tools and specified sub options under it.
	private static void NewOptionNewMenuClicked ( ) {

		Debug.Log ( "'New Option' in new menu 'Tools' Clicked" );

	}

	[ MenuItem ( "Window/New Option" ) ] // You can also add new option to the existing Menus
	private static void NewOptionExistingMenuClicked ( ) {

		Debug.Log ( "'New Option' in existing menu 'Window' Clicked" );

	}

	// You can also specify shortcuts to your menu options as :
	// % is for Ctrl on Windows / CMD on OSX
	// # is for Shift
	// & is for Alt
	// _ is added as prefix to a character if you want that character to be the shortcut
	// LEFT,RIGHT,UP,DOWN for arrow keys
	// F1,...,F12 Used with an underscore preifx
	[ MenuItem ( "Tools/Clear PlayerPrefs _F5" ) ]
	private static void ClearPlayerPrefsClicked ( ) {

		Debug.Log ( "Clearing All Player Prefs" );

		PlayerPrefs.DeleteAll ( );

	}

	[ MenuItem ( "Tools/SubMenu/New Nested Option" ) ] // Set Paths of nested options
	private static void NewNestedOptionClicked ( ) {
	
		Debug.Log ( "'New Nested Option' in new menu 'Tools' Clicked" );

	}

	[ MenuItem ( "NewMenu/Option1" , false , 1 ) ]	// Setting priority for this option to appear in the menu
	private static void NewMenuOption1Clicked ( ) {

		Debug.Log ( "New 'Option1' in new menu 'New Menu' Clicked" );

	}

	[ MenuItem ( "NewMenu/Option2" , false , 2 ) ]
	private static void NewMenuOption2Clicked ( ) {

		Debug.Log ( "New 'Option2' in new menu 'New Menu' Clicked" );

	}

	// Menu items are also automatically grouped according to their assigned priority in increments of 50

	[ MenuItem ( "NewMenu/Option3" , false , 51 ) ]
	private static void NewMenuOption3Clicked ( ) {

		Debug.Log ( "New 'Option3' in new menu 'New Menu' Clicked" );

	}

	[ MenuItem ( "NewMenu/Option4" , false , 52 ) ]
	private static void NewMenuOption4Clicked ( ) {

		Debug.Log ( "New 'Option4' in new menu 'New Menu' Clicked" );

	}

	[ MenuItem ( "Assets/New Option" ) ] // Creating a new option directly under Assets Menu
	private static void NewOptionInAssetsMenuClicked ( ) {
		
		Debug.Log ( "'NewOption' in existing menu 'Assets' Clicked" );

	}

	[ MenuItem ( "Assets/Create/New Option" ) ] // Creating a new option in the Create Menu of Assets
	private static void NewOptionInCreateMenuClicked ( ) {

		Debug.Log ( "'NewOption' in existing menu 'Assets/Create' Clicked" );
		
	}

	// Add a new menu item that is accessed by right-clicking inside the RigidBody component
	[ MenuItem ( "CONTEXT/Rigidbody/New Option" ) ]
	private static void NewOpenForRigidBody ( MenuCommand menuCommand ) {

		Debug.Log ( "'NewOption' in existing menu of Rigidbody Clicked" );
	
		Rigidbody rigidbodyReference = menuCommand.context as Rigidbody;

		Debug.Log ( "Mass of the rigidbody is : " + rigidbodyReference.mass );

	}

	[ ContextMenu ( "Reset Variable1" ) ]
	private void ResetVariable1Clicked ( ) {
		
		variable1 = "";

	}

	[ ContextMenuItem ( "Randomize Value", "Randomize" ) ] // Assign a script function to run in the Context Menu
	public string variable1;

	private void Randomize ( ) {

		List < string > randomNames = new List < string > ( ) { "Gagan" , "Rahul" , "Ritesh" , "Sanjiv" , "Navneeth" , "Paras" , "Prasanth" , "Kasi" };

		variable1 = randomNames [ Random.Range ( 0 , randomNames.Count ) ];

	}

}