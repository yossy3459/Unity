using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Failre : MonoBehaviour
{

    void OnTriggerEnter()
    {
        Debug.Log("Failre!");
        SceneManager.LoadScene("Failre");
    }
}
