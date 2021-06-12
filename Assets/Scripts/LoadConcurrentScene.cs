using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadConcurrentScene : MonoBehaviour
{

    public string TargetScene;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadSceneAsync(TargetScene, LoadSceneMode.Additive);
    }
}
