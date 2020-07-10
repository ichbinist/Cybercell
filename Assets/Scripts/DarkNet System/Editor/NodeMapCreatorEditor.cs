using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(NodeMapCreator))]

public class NodeMapCreatorEditor : Editor
{
  public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        NodeMapCreator mapcreator = (NodeMapCreator)target;
        if(GUILayout.Button("Create Map"))
        {
            mapcreator.AddMap();
        }
    }
}
