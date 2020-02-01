using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前好感度")]
    public int score;

    [Header("好感度分數介面")]
    public Text textScore;


    
    private void UpdateScore()
    {

        if (score > 0)
        {
            //玩家資料.設定整數("最佳分數"，目前分數)
            PlayerPrefs.SetInt("目前好感度", score);
        }
    }




    /// <summary>
    /// 定義加分
    /// </summary>
    public void AddScore()
    {
        print("+1~!");
        score++;
        //分數介面.文字內容 = 分數.轉為字串()
        // ToString() 可以將任何類型轉為字串
        textScore.text = score.ToString();
        UpdateScore();

    }

    private void Start()
    {
        //螢幕.設定解析度(寬,高,是否全螢幕)
        Screen.SetResolution(450, 800, false);
       textScore.text = PlayerPrefs.GetInt("好感度分數介面").ToString();
        score = PlayerPrefs.GetInt("目前好感度", score);
    }
}



