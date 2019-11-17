using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public int multiplier = 2;
    private int duration = 5;
    private int random;

    private void OnTriggerEnter(Collider other)
    {

        

        if (other.CompareTag("Player"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -300);
            random = Random.Range(0, 4);

            if (random == 0)
            {
                StartCoroutine(Pickup1(other));
            }
            else if (random == 1)
            {
                StartCoroutine(Pickup2(other));
            }
            else if (random == 2)
            {
                StartCoroutine(Pickup3(other));
            }
            else if (random == 3)
            {
                StartCoroutine(Pickup4(other));
            }




        }
    }

    IEnumerator Pickup1(Collider player)
    {


        player.transform.localScale *= multiplier;
        yield return new WaitForSecondsRealtime(duration);
        player.transform.localScale /= multiplier;

        Destroy(gameObject);

    }

    IEnumerator Pickup2(Collider player)
    {

        player.transform.localScale /= multiplier;
        yield return new WaitForSecondsRealtime(duration);
        player.transform.localScale *= multiplier;

        Destroy(gameObject);

    }

    IEnumerator Pickup3(Collider player)
    {

        player.transform.GetComponent<PlayerMovement>().velocity *= multiplier;
        yield return new WaitForSecondsRealtime(duration);
        player.transform.GetComponent<PlayerMovement>().velocity /= multiplier;


        Destroy(gameObject);

    }

    IEnumerator Pickup4(Collider player)
    {

        player.transform.GetComponent<PlayerMovement>().velocity /= multiplier;
        yield return new WaitForSecondsRealtime(duration);
        player.transform.GetComponent<PlayerMovement>().velocity *= multiplier;


        Destroy(gameObject);

    }

}
