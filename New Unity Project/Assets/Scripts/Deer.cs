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

    public Transform Transform;   //還沒確定，想抓動物的座標 翻轉X軸


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

    Rigidbody2D rig;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    public IEnumerator EatFood()
    {
        // 往左走
        while (transform.position.x > -1f)
        {
            //速度
            rig.AddForce(transform.right * -2);

            yield return new WaitForSeconds(0.1f);
        }
        //剛體睡著
        rig.Sleep();

        yield return new WaitForSeconds(1f);
        //醒來
        rig.WakeUp();

        while (transform.position.x < 1f)
        {    



            rig.AddForce(transform.right * 2);
        
            yield return new WaitForSeconds(0.1f);
        }

        rig.Sleep();
    }
}
