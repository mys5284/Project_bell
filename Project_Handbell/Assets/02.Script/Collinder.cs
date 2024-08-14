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

    private void Start()
    {
        tr = GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NOTE"))
        {
            print(this.tr.position.y);
            print(other.transform.position.y);
            dist = this.tr.position.y - other.transform.position.y;
          print(dist);

            if (dist >= 1)
            {
              //  note.score = Note.Score.Miss;
                print("¹Ì½º");
            }
            else if ((dist < 1 && dist >= 0.5f) || (dist > -1 && dist <= -0.5f))
            {
               // note.score = Note.Score.Nice;
                print("³ªÀÌ½º");
            }
            else if ((dist < 0.5f && dist >= 0.2f) || (dist > -0.5f && dist <= -0.2f))
            {
              //  note.score = Note.Score.Good;
                print("±Â");
            }
            else if ((dist < 0.2f && dist >= 0f) || (dist > -0.2f && dist <= -0f))
            {
              //  note.score = Note.Score.Perfect;
                print("ÆÛÆåÆ®");
            }

            Destroy(other.gameObject);

        }
    }


}
