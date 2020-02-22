
using UnityEngine;

public class Food : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(gameObject);
        PlayerPrefs.SetInt("IsRifleSold", 0);

    }





}

