using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController gameController;
    public GameObject gameOverText;
    public bool gameOver;
    public float scrollSpeed = -1.5f;

    public TMPro.TMP_Text scoreText;
    public int score = 0;

    private void Awake()
    {
        if(gameController == null)
        {
            gameController = this;
        }
        else if(gameController != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == true && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void birdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score:"+ score.ToString();
    }
}
