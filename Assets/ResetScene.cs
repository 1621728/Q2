using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Gun")
        {
            Debug.Log("You touched the Green Square...now what?...");
            Debug.Log("Switch Scenes");
            SceneManager.LoadScene("PlateformerScene");
        }
    }
}