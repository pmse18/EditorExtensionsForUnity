using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// For More Information, you can visit :
// 1. https://docs.unity3d.com/ScriptReference/HelpURLAttribute.html to read about all the other default attributes
// 2. https://docs.unity3d.com/Manual/editor-PropertyDrawers.html to read about how to creat your own Property Attributes and Property Drawers

[ ExecuteInEditMode ] // Helps to execute the script in the edit mode also
[ RequireComponent ( typeof ( TextMesh ) ) ] // Stops us by removing the specified component, so that we will not remove it accidently
[ DisallowMultipleComponent ] // Disallows to add any component multiple times
[ HelpURL ( "http://www.str8bat.com/" ) ] // Allows us to write our own docs on web for our custom scripts
public class BasicAttributesScript : MonoBehaviour {

	[ Space ( 10 ) ] // Used to give space in the inspector

	[ Header ( "Some Heading For Following Variables" ) ] // Speficies some heading for the continuing variables

	[ Space ( 10 ) ]

	[ Multiline ] // Makes this string field to accept multiline string
	public string variable1;

	[ HideInInspector ] // Stops editor to render this variable in the inspector window
	public bool variable2;

	[ Range ( -10 , 10 ) ] // Draws a slider with the specified range for this variable's value to be set accordingly 
	public float variable3;

	[ Range ( -10 , 10 ) ] // Also works for int variable
	public int variable4;

	[ TextArea ] // Makes this string field to accept big strings in a text area layout
	public string variable5;

	[ Tooltip ( "This is a bool varibale named variable6 of BasicAttributesScript." ) ] // Try hovering over this variable, you can read this text. This is to give extra information.
	public bool variable6;

	[ SerializeField ] // This is to edit a private variable from the inspector
	private int variable7;

	public void Update ( ) {

		GetComponent < TextMesh > ( ).text = variable1;

	}

}