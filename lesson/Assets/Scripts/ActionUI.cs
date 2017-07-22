using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActionUI : MonoBehaviour
{
    GameData ga;
    public Text coinText;

	// Use this for initialization
	void Start ()
    {
        ga = GameObject.Find("GameData").GetComponent<GameData>();
        ga.coinNum = 0;
    }

    // Update is called once per frame
    void Update ()
    {
        coinText.text = "Coin : " + ga.coinNum.ToString();
    }
}
