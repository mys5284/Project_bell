using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //현재스코어, 최대스코어, 완성도로 나뉨

    //1곡 스코어
    public int song1_score = 0;
    public int song1_curr_score = 168;
    public float song1_total_score = 0;

    //2곡 스코어
    public int song2_score = 0;
    public int song2_curr_score = 192;
    public float song2_total_score = 0;

    //3곡 스코어
    public int song3_score = 0;
    public int song3_curr_score = 651;
    public float song3_total_score = 0;

    private void Update()
    {
        //스코어 백분률로 나뉘어 완성도를 나타냄
        song1_total_score = ((float)song1_score / (float)song1_curr_score) * 100;
        song2_total_score = ((float)song2_score / (float)song2_curr_score) * 100;
        song3_total_score = ((float)song3_score / (float)song3_curr_score) * 100;

    }
}
