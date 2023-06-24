using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    void Update()
    {

    }

    public void OnRetry()
    {
        SceneManager.LoadScene("GameScenes");
    }
}
