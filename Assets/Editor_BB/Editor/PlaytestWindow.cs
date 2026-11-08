using UnityEngine;
using UnityEditor;
using Unity.VisualScripting;
public class PlaytestWindow : EditorWindow
{
    [MenuItem("Tools/Playtest Controls")]
    public static void OpenWindow()
    {
        GetWindow<PlaytestWindow>();
    }
     void OnGUI()    
    { 
    
         if (GUILayout.Button("Start Playtest"))
         {
            EditorApplication.isPlaying = true; 
         }
         
        if (GUILayout.Button("End Playtest"))
        {
            EditorApplication.isPlaying = false;
        }

    }
    

}