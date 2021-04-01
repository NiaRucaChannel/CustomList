using UnityEditor;
using System.Collections.Generic;

[CustomEditor(typeof(CustomList))]
public class CustomListEditor : Editor
{

    SerializedProperty sampleList;
    SerializedProperty num;
    void OnEnable()
    {
        sampleList = serializedObject.FindProperty("sampleList");
        sampleList.isExpanded = true;
        num = serializedObject.FindProperty("num");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.PropertyField(num);
        sampleList.arraySize = num.intValue;
        EditorGUILayout.PropertyField(sampleList);
        serializedObject.ApplyModifiedProperties();
    }
}