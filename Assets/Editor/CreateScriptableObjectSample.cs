using UnityEngine;
using UnityEditor;
using System.Collections;

public class CreateScriptableObjectSample : MonoBehaviour
{
    [MenuItem("Assets/Create/ScriptableObjectSample")]
    public static void CreateAsset()
    {
        CreateAsset<CardData>();
       
    }

    public static void CreateAsset<Type>() where Type : ScriptableObject
    {
        Type item = ScriptableObject.CreateInstance<Type>();

        string path = AssetDatabase.GenerateUniqueAssetPath("Assets/Create/ScriptableObjectSample" + typeof(Type) + ".asset");

        AssetDatabase.CreateAsset(item, path);
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();
        Selection.activeObject = item;
    }
}