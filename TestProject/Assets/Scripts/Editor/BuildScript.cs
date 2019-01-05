using UnityEditor;

public class BuildScript 
{
    static void PerformBuild()
    {
        string[] defaultScene = { "Assets/Scenes/MainScene.unity" };
        BuildPipeline.BuildPlayer(defaultScene, "./builds/game.x86_64",
            BuildTarget.StandaloneLinux64, BuildOptions.None);
    }
}
