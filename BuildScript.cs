
using UnityEditor;
using System.IO;
using UnityEditor.Build.Reporting;

public class BuildScript
{
    public static void BuildAndroid()
    {
        string buildPath = "Builds/Android";
        string apkName = "PizzaGame.apk";

        if (!Directory.Exists(buildPath))
        {
            Directory.CreateDirectory(buildPath);
        }

        string[] scenes = new string[]
        {
            "Assets/Scenes/Main.unity"
        };

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = Path.Combine(buildPath, apkName),
            target = BuildTarget.Android,
            options = BuildOptions.None
        };

        BuildReport report = BuildPipeline.BuildPlayer(buildPlayerOptions);

        if (report.summary.result == BuildResult.Succeeded)
        {
            UnityEngine.Debug.Log("Build succeeded: " + report.summary.totalSize + " bytes");
        }
        else
        {
            UnityEngine.Debug.LogError("Build failed");
        }
    }
}
