using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Progression : MonoBehaviour
{
    void Update()
    {
        if (ScoreScript.ScoreValue >= 300)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
