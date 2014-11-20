﻿using UnityEngine;
using System.Collections;
using UnityEditor;

namespace SimpleNodeEditor
{
    [CustomEditor(typeof(NodeGraph))]
    public class NodeGraphInspector : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            NodeGraph myTarget = (NodeGraph)target;

            if( GUILayout.Button("Show Graph") )
            {
                NodeEditor nodeEditor = (NodeEditor)EditorWindow.GetWindow(typeof(NodeEditor));
                nodeEditor.ConnectionColor = myTarget.ConnectionColor;
                nodeEditor.Root = myTarget.gameObject;
                nodeEditor.Show();
            }
        }
    }
}