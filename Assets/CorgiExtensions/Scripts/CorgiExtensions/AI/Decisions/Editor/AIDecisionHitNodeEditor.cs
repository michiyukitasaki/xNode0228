﻿using TheBitCave.MMToolsExtensions.AI;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI
{
    [CustomNodeEditorAttribute(typeof(AIDecisionHitNode))]
    public class AIDecisionHitNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _numberOfHits;
        
        public override void OnBodyGUI()
        {
            base.OnBodyGUI();
            
            _numberOfHits = serializedObject.FindProperty("numberOfHits");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 120;
            NodeEditorGUILayout.PropertyField(_numberOfHits);
            serializedObject.ApplyModifiedProperties();
        }
    }
}