using UnityEngine;
using System.Collections;

public class GameData : MonoBehaviour
{
    public int coinNum = 0;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}