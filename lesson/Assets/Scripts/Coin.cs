using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    void OnTriggerEnter()
    {
        Debug.Log("GetCoin");
        GameObject.Find("GameData").GetComponent<GameData>().coinNum++;
        Destroy(gameObject);
    }
}
