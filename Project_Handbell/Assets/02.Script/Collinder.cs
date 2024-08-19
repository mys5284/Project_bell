using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Collinder : MonoBehaviour
{
    Note note;
    Transform tr;
    float Verdict = 0;
    float dist = 0;

    ScoreManager scoreManager;


    private void Start()
    {
        tr = GetComponent<Transform>();
        scoreManager = GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NOTE"))
        {
            dist = this.tr.position.y - other.transform.position.y;

            if (dist >= 1 || dist <= -1)
            {
                print("미스");
                other.gameObject.tag = "NOTNOTE";
            }
            else if ((dist < 1 && dist >= 0.5f) || (dist > -1 && dist <= -0.5f)) //NICE의 거리값
            {
                print("나이스");
                
                Destroy(other.gameObject);
            }
            else if ((dist < 0.5f && dist >= 0.2f) || (dist > -0.5f && dist <= -0.2f)) //GOOD의 거리값
            {
                print("굿");
                Destroy(other.gameObject);
            }
            else if ((dist < 0.2f && dist >= 0f) || (dist > -0.2f && dist <= -0f)) //PERFECT의 거리값
            {
                print("퍼펙트");
                Destroy(other.gameObject);
            }



        }
    }



}
