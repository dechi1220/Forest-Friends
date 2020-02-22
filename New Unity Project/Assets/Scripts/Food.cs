
using UnityEngine;

public class Food : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D col)
    {

            Destroy(gameObject,1f);
        PlayerPrefs.SetInt("IsRifleSold", 0);

    }


}

