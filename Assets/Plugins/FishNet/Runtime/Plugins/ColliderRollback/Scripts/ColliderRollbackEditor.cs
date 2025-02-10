#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using static Plugins.FishNet.Runtime.Plugins.ColliderRollback.Scripts.ColliderRollback;

namespace Plugins.FishNet.Runtime.Plugins.ColliderRollback.Scripts
{

    [CustomEditor(typeof(ColliderRollback), true)]
    [CanEditMultipleObjects]
    public class ColliderRollbackEditor : UnityEditor.Editor
    {
        private SerializedProperty _boundingBox;
        private SerializedProperty _physicsType;
        private SerializedProperty _boundingBoxSize;
        private SerializedProperty _colliderParents;


        protected virtual void OnEnable()
        {
            _boundingBox = serializedObject.FindProperty(nameof(_boundingBox));
            _physicsType = serializedObject.FindProperty(nameof(_physicsType));
            _boundingBoxSize = serializedObject.FindProperty(nameof(_boundingBoxSize));
            _colliderParents = serializedObject.FindProperty(nameof(_colliderParents));
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            ColliderRollback nob = (ColliderRollback)target;

            GUI.enabled = false;
            EditorGUILayout.ObjectField("Script:", MonoScript.FromMonoBehaviour(nob), typeof(ColliderRollback), false);
            GUI.enabled = true;

            EditorGUILayout.LabelField("Settings", EditorStyles.boldLabel);
            EditorGUI.indentLevel++;

            EditorGUILayout.PropertyField(_boundingBox);
            if ((BoundingBoxType)_boundingBox.intValue != BoundingBoxType.Disabled)
            {
                EditorGUI.indentLevel++;
                EditorGUILayout.PropertyField(_physicsType);
                EditorGUILayout.PropertyField(_boundingBoxSize);
                EditorGUI.indentLevel--;
            }
            EditorGUILayout.PropertyField(_colliderParents);

            EditorGUI.indentLevel--;

            serializedObject.ApplyModifiedProperties();
        }

    }

}


#endif