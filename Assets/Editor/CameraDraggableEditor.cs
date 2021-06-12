using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CameraDraggable))]
public class CameraDraggableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CameraDraggable script = (CameraDraggable)target;
        if(GUILayout.Button("TestMove"))
        {
            script.testMove();
        }
    }
}
