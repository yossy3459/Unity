using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    void OnTriggerEnter()
    {
        Debug.Log("Goal!");
        SceneManager.LoadScene("Goal");
    }


}
