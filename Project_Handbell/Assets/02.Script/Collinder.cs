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
                print("�̽�");
                other.gameObject.tag = "NOTNOTE";
            }
            else if ((dist < 1 && dist >= 0.5f) || (dist > -1 && dist <= -0.5f)) //NICE�� �Ÿ���
            {
                print("���̽�");
                
                Destroy(other.gameObject);
            }
            else if ((dist < 0.5f && dist >= 0.2f) || (dist > -0.5f && dist <= -0.2f)) //GOOD�� �Ÿ���
            {
                print("��");
                Destroy(other.gameObject);
            }
            else if ((dist < 0.2f && dist >= 0f) || (dist > -0.2f && dist <= -0f)) //PERFECT�� �Ÿ���
            {
                print("����Ʈ");
                Destroy(other.gameObject);
            }



        }
    }



}
