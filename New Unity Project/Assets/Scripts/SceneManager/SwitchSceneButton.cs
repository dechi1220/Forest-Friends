using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwitchSceneButton : MonoBehaviour
{
    int moneyAmount;


    [HideInInspector]
    public string SceneName;

    public void exit()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
    }


    void Awake()
    {

        var btn = GetComponent<Button>();
        if (btn != null)
        {
            btn.onClick.AddListener(OnMouseDown);
        }
    }

    void OnMouseDown()
    {
        Application.LoadLevel(SceneName);

    }
}