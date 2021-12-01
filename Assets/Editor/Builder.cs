using UnityEditor;
using UnityEngine;

public class Builder : ScriptableObject
{
    [MenuItem("Build/Default")]
    public static void BuildDefault() {
        BuildPipeline.BuildPlayer(new BuildPlayerOptions{
            scenes = new[] { "Assets/Scenes/Main.unity" },
            locationPathName = "Builds/WebGL",
            target = BuildTarget.WebGL,
            options = BuildOptions.None,
        });
    }
}
