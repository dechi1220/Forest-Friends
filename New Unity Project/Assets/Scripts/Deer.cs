using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : MonoBehaviour
{
    //[Header("好感度"), Range(0, 100)]
    //public int friendship = 0;
    [Header("遊戲管理器")]
    public GameManager gm;

    public GameObject goScore, goGM;



    //事件 : 觸發離開 - 物件離開觸發區域執行一次
    private void OnTriggerExit2D(Collider2D hit)
    {
        // dead ==true 簡寫 dead
        // dead != true 簡寫 !dead
        if (hit.name == "飼料")
        {
            print("加好感!");
            gm.AddScore();
            // aud.PlayOneShot(sounfAdd, 1);
        }

   
    }


    

}
