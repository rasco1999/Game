
using UnityEditor;
using System.IO;

public class BuildScript
{
    public static void BuildAndroid()
    {
        string path = "Builds/Android";
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        BuildPipeline.BuildPlayer(
            new[] { "Assets/Scenes/Main.unity" },
            path + "/PizzaGame.apk",
            BuildTarget.Android,
            BuildOptions.None
        );
    }
}
