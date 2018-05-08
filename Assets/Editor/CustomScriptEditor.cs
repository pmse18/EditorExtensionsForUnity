using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[ CustomEditor ( typeof ( CustomScript ) ) ]
[ CanEditMultipleObjects ]
public class CustomScriptEditor : Editor {

	SerializedProperty comparingPosition;

	void OnEnable ( ) {
		
		comparingPosition = serializedObject.FindProperty("comparingPosition");
	}

	public override void OnInspectorGUI ( ) {
		
		serializedObject.Update ( );

		EditorGUILayout.PropertyField ( comparingPosition );

		serializedObject.ApplyModifiedProperties ( );

		if ( comparingPosition.vector3Value.x > ( target as CustomScript ).transform.position.x ) {

			EditorGUILayout.LabelField ( "( X Axis : Right of this object )" );

		} else if ( comparingPosition.vector3Value.x < ( target as CustomScript ).transform.position.x ) {

			EditorGUILayout.LabelField ( "( X Axis : Left of this object )" );

		} else {

			EditorGUILayout.LabelField ( "( X Axis : Same as this object )" );

		}

		if ( comparingPosition.vector3Value.y > ( target as CustomScript ).transform.position.y ) {
			
			EditorGUILayout.LabelField ( "( Y Axis : Above this object )" );

		} else if ( comparingPosition.vector3Value.y < ( target as CustomScript ).transform.position.y ) {

			EditorGUILayout.LabelField ( "( Y Axis : Below this object )" );

		} else {
		
			EditorGUILayout.LabelField ( "( Y Axis : Same as this object )" );
		
		}

		if ( comparingPosition.vector3Value.z > ( target as CustomScript ).transform.position.z ) {

			EditorGUILayout.LabelField ( "( Z Axis : Behind this object )" );

		} else if ( comparingPosition.vector3Value.z < ( target as CustomScript ).transform.position.z ) {

			EditorGUILayout.LabelField ( "( Z Axis : In Front of this object )" );

		} else {

			EditorGUILayout.LabelField ( "( Z Axis : Same as this object )" );

		}

	}

}