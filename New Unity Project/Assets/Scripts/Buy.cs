using UnityEngine;

public class Buy : MonoBehaviour
{
    private StoreManager StoreManager;  // 關卡管理器

    public void BuyClick()
    {
        StoreManager.OpenBuyPanel();
    }
}
