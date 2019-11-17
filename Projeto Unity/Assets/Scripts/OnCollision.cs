using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DitzeGames.Effects;
public class OnCollision : MonoBehaviour
{
    public static bool alive = true;
    public GameObject explosion;
    public GameObject spaceShip;

    private void OnTriggerEnter(Collider other)
    {
        
        if(alive == true && other.gameObject.tag == "enemy")
        {
            Camera.main.GetComponent<CameraEffects>().Shake();
            explosion.SetActive(true);
            spaceShip.SetActive(false);
            alive = false;
        }
        



        
    }


}