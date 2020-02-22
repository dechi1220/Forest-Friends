
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopControlScript : MonoBehaviour {

	int moneyAmount;
	int isRifleSold;

	public Text moneyAmountText;
	public Text riflePrice;

	public Button buyButton;

	// Use this for initialization
	void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
	}
	
	// Update is called once per frame
	void Update () {
		
		moneyAmountText.text = "Money: " + moneyAmount.ToString() + "$";

		isRifleSold = PlayerPrefs.GetInt ("IsRifleSold");


	}

	public void buyRifle()
	{
        if (moneyAmount >=5)
        {
            moneyAmount -= 5;
            PlayerPrefs.SetInt("IsRifleSold", 1);
        }

	

	}

	public void exitShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		SceneManager.LoadScene ("scene01");
	}

	public void resetPlayerPrefs()
	{
		moneyAmount = 0;
		buyButton.gameObject.SetActive (true);
		riflePrice.text = "Price: 5$";
		PlayerPrefs.DeleteAll ();
	}

}
