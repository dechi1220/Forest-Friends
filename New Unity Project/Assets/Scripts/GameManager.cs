using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("目前好感度")]
    public int score;

    [Header("好感度分數介面")]
    public Text textScore;




    /// <summary>
    /// 定義加分
    /// </summary>
    public void AddScore()
    {
        print("++~!");
        score++;
        //分數介面.文字內容 = 分數.轉為字串()
        // ToString() 可以將任何類型轉為字串
        textScore.text = score.ToString();

    }



}
