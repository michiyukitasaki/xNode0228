using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEditor;
using XNodeEditor;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    [CustomNodeEditor(typeof(AIDecisionLineOfSightToTargetNode))]
    public class AIDecisionLineOfSightToTargetNodeEditor : AIDecisionNodeEditor
    {
        private SerializedProperty _obstacleLayerMask;
        private SerializedProperty _lineOfSightOffset;
        
        protected override void SerializeAdditionalProperties()
        {
            _obstacleLayerMask = serializedObject.FindProperty("obstacleLayerMask");
            _lineOfSightOffset = serializedObject.FindProperty("lineOfSightOffset");

            serializedObject.Update();
            EditorGUIUtility.labelWidth = 140;
            NodeEditorGUILayout.PropertyField(_obstacleLayerMask);
            NodeEditorGUILayout.PropertyField(_lineOfSightOffset);
            serializedObject.ApplyModifiedProperties();
        }
    }
}