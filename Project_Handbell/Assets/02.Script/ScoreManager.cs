using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //���罺�ھ�, �ִ뽺�ھ�, �ϼ����� ����

    //1�� ���ھ�
    public int song1_score = 0;
    public int song1_curr_score = 168;
    public float song1_total_score = 0;

    //2�� ���ھ�
    public int song2_score = 0;
    public int song2_curr_score = 192;
    public float song2_total_score = 0;

    //3�� ���ھ�
    public int song3_score = 0;
    public int song3_curr_score = 651;
    public float song3_total_score = 0;

    private void Update()
    {
        //���ھ� ��з��� ������ �ϼ����� ��Ÿ��
        song1_total_score = ((float)song1_score / (float)song1_curr_score) * 100;
        song2_total_score = ((float)song2_score / (float)song2_curr_score) * 100;
        song3_total_score = ((float)song3_score / (float)song3_curr_score) * 100;

    }
}
