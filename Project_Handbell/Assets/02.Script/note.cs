using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public enum Score
    {
        Miss,
        Nice,
        Good,
        Perfect
    }

    public Score score;


    private void Start()
    {
        score = Score.Miss;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, -7, 0);
        this.transform.position += move * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("VERDICT"))
        {

        }
    }

}
