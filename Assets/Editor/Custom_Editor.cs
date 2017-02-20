using UnityEngine;
using System.Collections;
using UnityEditor;
[CustomEditor (typeof (GameWorld))]
public class Custom_Editor : Editor {
public override void OnInspectorGUI(){
		DrawDefaultInspector ();
		if (GUILayout.Button ("Build World!")) {
			GameWorld Game = (GameWorld) target;
			Game.build();
		}
		if (GUILayout.Button ("Destroy World!")) {
			GameWorld Game = (GameWorld) target;
			Game.DestroyWorld();
		}
		
	}
}
