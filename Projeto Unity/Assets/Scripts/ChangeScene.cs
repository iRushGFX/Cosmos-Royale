using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public void changeScene (string sceneName)
    {
        OnCollision.alive = true;
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneName);    
    }
}
