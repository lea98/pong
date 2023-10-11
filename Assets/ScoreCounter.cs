using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public Text PlayerScore;
    public int score;
    public GameObject Ball;
    public GameObject gameOver;
    public Text gameOverText;


    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Debug.Log("jesam li tu");
    //    if (collision.gameObject.layer == LayerMask.NameToLayer("wall1")) {
    //        Debug.Log(int.Parse(PlayerOneScore.GetComponent<Text>().text));

    //    }
    //}

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.layer == LayerMask.NameToLayer("bally"))
        {
            score = int.Parse(PlayerScore.GetComponent<Text>().text);
            PlayerScore.GetComponent<Text>().text = (score+1).ToString();
            if (score == 2)
            {
                if (gameObject.name == "Border")
                {
                    gameOverText.text = "Player #2 wins!";
                }
                if (gameObject.name == "BorderSecond")
                {
                    gameOverText.text = "Player #1 wins!";
                }

                gameOver.SetActive(true);

            }
            else
            {
                Ball.GetComponent<BallMovement>().RestartBall();
            }
        }
    }
}
