using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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
        transform.Rotate(0f, 180f * Time.deltaTime, 0f);
        //if(trans
    }

}
