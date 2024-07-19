using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //AudioManager.instance.scoreSFX();
            Debug.Log("POINT++");
            scoremanager.instance.UpdateScore();
        }
    }
}
