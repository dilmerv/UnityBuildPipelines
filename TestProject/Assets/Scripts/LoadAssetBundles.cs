using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundles : MonoBehaviour
{
    private AssetBundle assetBundle;
    public string assetBundlePath;
    public string cubeName = "Cube_sm";
    void Start()
    {
        assetBundle = AssetBundle.LoadFromFile(assetBundlePath);
        if (assetBundle == null)
        {
            Debug.Log("Could not load asset bundle");
        }
        else {
            Debug.Log("Asset bundle was loaded");
            InstantiateCube();
        }
    }

    void InstantiateCube()
    {
        var cube = assetBundle.LoadAsset(cubeName);
        Instantiate(cube);
    }
}
