using UnityEditor;

public class BuildScript 
{
    [MenuItem("Custom Utilities/Build StandaloneLinux64")]
    static void PerformBuild()
    {
        string[] defaultScene = { "Assets/Scenes/MainScene.unity" };
        BuildPipeline.BuildPlayer(defaultScene, "./builds/game.x86_64",
            BuildTarget.StandaloneLinux64, BuildOptions.None);
    }

    [MenuItem("Custom Utilities/Build Asset Bundle StandaloneLinux64")]
    static void PerformAssetBundleBuild()
    {
        BuildPipeline.BuildAssetBundles("../AssetBundles/", BuildAssetBundleOptions.ChunkBasedCompression,
            BuildTarget.StandaloneLinux64);
    }
}
