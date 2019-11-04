using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {

    public GameObject telaPause;
    public void pausar()
    {
        Time.timeScale = 0f;
        telaPause.SetActive(true);
    }

    public void despausar()
    {
        Time.timeScale = 1f;
        telaPause.SetActive(false);
    }
}
