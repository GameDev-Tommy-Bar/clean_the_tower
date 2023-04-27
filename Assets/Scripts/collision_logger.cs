using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionLogger : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;

    private int score;
    private int life;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Basket is " + gameObject.tag + " and this is a " + other.tag);
        Destroy(other.gameObject);

        if (other.CompareTag(gameObject.tag))
        {
            Debug.Log("Awesome!");
            score = Int32.Parse(scoreText.text);
            score += 1;
            scoreText.text = score.ToString();
        }
        else
        {
            Debug.Log("Oh no!");
            life = Int32.Parse(livesText.text);
            life--;
            livesText.text = life.ToString();

            if (life == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
