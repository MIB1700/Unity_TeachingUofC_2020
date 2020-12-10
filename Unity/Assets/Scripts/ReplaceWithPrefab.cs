using UnityEngine;
using UnityEditor;

public class ReplaceWithPrefab : EditorWindow
{
    [SerializeField] private GameObject prefab;

    [SerializeField] private bool useNewPrefabSize = true;
    [SerializeField] private bool useNewPrefabLocation = true;
    [SerializeField] private bool useNewPrefabRotation = true;

    [MenuItem("Tools/Replace With Prefab")]
    static void CreateReplaceWithPrefab()
    {
        ReplaceWithPrefab window = EditorWindow.GetWindow<ReplaceWithPrefab>();

    }

    private void OnGUI()
    {
        prefab = (GameObject)EditorGUILayout.ObjectField("Prefab", prefab, typeof(GameObject), false);

        useNewPrefabSize = EditorGUILayout.Toggle("use orig. SIZE", useNewPrefabSize);
        useNewPrefabLocation = EditorGUILayout.Toggle("use orig. LOCATION", useNewPrefabLocation);
        useNewPrefabRotation = EditorGUILayout.Toggle("use orig. ROTATION", useNewPrefabRotation);


        if (GUILayout.Button("Replace"))
        {
            var selection = Selection.gameObjects;

            for (var i = selection.Length - 1; i >= 0; --i)
            {
                var selected = selection[i];
                // var prefabType = PrefabUtility.GetPrefabType(prefab);
                GameObject newObject;

                if (PrefabUtility.IsPartOfPrefabAsset(prefab))
                {
                    newObject = (GameObject)PrefabUtility.InstantiatePrefab(prefab);
                }
                else
                {
                    newObject = Instantiate(prefab);
                    newObject.name = prefab.name;
                }

                if (newObject == null)
                {
                    Debug.LogError("Error instantiating prefab");
                    break;
                }

                Undo.RegisterCreatedObjectUndo(newObject, "Replace With Prefabs");

                newObject.transform.parent = selected.transform.parent;
                if (useNewPrefabLocation)   {

                    newObject.transform.localPosition = selected.transform.localPosition;
                }
                if (useNewPrefabRotation)   {

                    newObject.transform.localRotation = selected.transform.localRotation;
                }
                if (useNewPrefabSize) {

                    newObject.transform.localScale = selected.transform.localScale;
                }

                newObject.transform.SetSiblingIndex(selected.transform.GetSiblingIndex());

                Undo.DestroyObjectImmediate(selected);
            }
        }

        GUI.enabled = false;
        EditorGUILayout.LabelField("Selection count: " + Selection.objects.Length);
    }
}