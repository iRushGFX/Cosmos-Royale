using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnCollision : MonoBehaviour
{
    public static bool alive = true;
    private void OnTriggerEnter(Collider other)
    {
        alive = false;
    }
}