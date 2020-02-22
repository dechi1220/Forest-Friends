
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour {

	public Text moneyText;
	public static int moneyAmount;
	int isRifleSold;
	public GameObject Food;

	// Use this for initialization
	void Start () {
		moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
		isRifleSold = PlayerPrefs.GetInt ("IsRifleSold");

		if (isRifleSold == 1)
			Food.SetActive (true);
		else
			Food.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		moneyText.text = "Money: " + moneyAmount.ToString() + "$";
	}

	public void gotoShop()
	{
		PlayerPrefs.SetInt ("MoneyAmount", moneyAmount);
		SceneManager.LoadScene ("scene01");
	}
}
