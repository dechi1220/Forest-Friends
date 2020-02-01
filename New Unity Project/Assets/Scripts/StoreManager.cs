using UnityEngine;

public class StoreManager : MonoBehaviour
{
    private CanvasGroup panelControl;  //控制畫面

    private void Start()
    {
        panelControl = GameObject.Find("確認面板").GetComponent<CanvasGroup>();
    }

    public void OpenBuyPanel()
    {
        panelControl.alpha = 1;  //顯示復活畫面
        panelControl.interactable = true;  //可互動
        panelControl.blocksRaycasts = true;  //阻擋射線

    }
}
