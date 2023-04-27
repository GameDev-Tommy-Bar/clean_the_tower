using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;


public class collision_logger : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;

    int score;
    int life;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("basket is "+this.tag+" and this is a "+other.tag);
        Destroy(other.gameObject);
            if(other.tag == this.tag){
                Debug.Log("youre awsome");
                score = Int32.Parse(scoreText.text);
                score += 1;
                scoreText.text = ""+score;
            }
            else
            {
                Debug.Log("shit");
                life = Int32.Parse(livesText.text);
                life --;
                livesText.text = ""+life;
                if(life == 0){
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
    }

}
