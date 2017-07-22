using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoalCoin : MonoBehaviour
{
    GameData ga;
    public Text coinText;

    // Use this for initialization
    void Start()
    {
        ga = GameObject.Find("GameData").GetComponent<GameData>();
        coinText.text = "Coin : " + ga.coinNum.ToString();
    }
}
