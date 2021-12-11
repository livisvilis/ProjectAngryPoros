using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private static int _nextLevelIndex = 1;

    public void Next()
    {
        _nextLevelIndex++;
        string nextLevelName = "Level" + _nextLevelIndex;
        SceneManager.LoadScene(nextLevelName);
    }
    public void PlayAgain()
    {
        _nextLevelIndex = 1;
        SceneManager.LoadScene("Level1");
    }
}
