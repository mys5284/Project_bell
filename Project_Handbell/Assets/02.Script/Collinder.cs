using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Collinder : MonoBehaviour
{
    Note note;
    Transform tr;
    float dist = 0;

    GameManager gameManager;
    ScoreManager scoreManager;


    private void Start()
    {
        tr = GetComponent<Transform>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NOTE"))
        {
            dist = this.tr.position.y - other.transform.position.y;

            if (dist >= 1 || dist <= -1)
            {
                print("¹Ì½º");
                other.gameObject.tag = "NOTNOTE";
            }
            else if ((dist < 1 && dist >= 0.5f) || (dist > -1 && dist <= -0.5f)) //GOODÀÇ °Å¸®°ª
            {
                print("±Â");
                //Ã©ÅÍ1 °î º°·Î +1Á¡
                if (gameManager.chapter1 == GameManager.Chapter1.song1) 
                {
                    scoreManager.song1_score++;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song2)  
                {
                    scoreManager.song2_score++;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song3)  
                {
                    scoreManager.song3_score++;
                }


                Destroy(other.gameObject);
            }
            else if ((dist < 0.5f && dist >= 0.2f) || (dist > -0.5f && dist <= -0.2f)) //COOLÀÇ °Å¸®°ª
            {
                print("Äð");
                //Ã©ÅÍ1 °î º°·Î +2Á¡
                if (gameManager.chapter1 == GameManager.Chapter1.song1)
                {
                    scoreManager.song1_score += 2;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song2)
                {
                    scoreManager.song2_score += 2;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song3)
                {
                    scoreManager.song3_score += 2;
                }

                Destroy(other.gameObject);
            }
            else if ((dist < 0.2f && dist >= 0f) || (dist > -0.2f && dist <= -0f)) //PERFECTÀÇ °Å¸®°ª
            {
                print("ÆÛÆåÆ®");
                //Ã©ÅÍ1 °î º°·Î +3Á¡
                if (gameManager.chapter1 == GameManager.Chapter1.song1)
                {
                    scoreManager.song1_score += 3;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song2)
                {
                    scoreManager.song2_score += 3;
                }
                else if (gameManager.chapter1 == GameManager.Chapter1.song3)
                {
                    scoreManager.song3_score += 3;
                }

                Destroy(other.gameObject);
            }



        }
    }



}
