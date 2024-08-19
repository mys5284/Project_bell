using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public enum Color_note //��ǥ ���� ����
    {
        Color_note_1,
        Color_note_2,
        Color_note_3
    }

    Color_note enum_Color_note;

    GameManager gameManager;
    ScoreManager scoreManager;

    //��ǥ��ư ������Ʈ
    public GameObject Color_note_button1;
    public GameObject Color_note_button2;
    public GameObject Color_note_button3;

    //�ϼ��� �ؽ�Ʈ
    public Text Comple_song1;
    public Text Comple_song2;
    public Text Comple_song3;

    Color Alpha_color;

    //��ǥ��ĭ ä������ ������Ʈ
    public Image Color_note1;
    public Image Color_note2;
    public Image Color_note3;

    public GameObject Result_UI; //���â UI

    private void Start()
    {

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    public void Get_Color_note_1() //��ǥ��ư1 ��������
    {
        enum_Color_note = Color_note.Color_note_1;
        Color_note_button1.SetActive(false);
        StartCoroutine(Get_Color());
    }

    public void Get_Color_note_2() //��ǥ��ư2 ��������
    {
        enum_Color_note = Color_note.Color_note_2;
        Color_note_button2.SetActive(false);
        StartCoroutine(Get_Color());
    }

    public void Get_Color_note_3() //��ǥ��ư3 ��������
    {
        enum_Color_note = Color_note.Color_note_3;
        Color_note_button3.SetActive(false);
        StartCoroutine(Get_Color());
    }
    public void Result_UI_Close() //���â ������ ��������
    {
        Result_UI.SetActive(false);
    }
    IEnumerator Get_Color() //��ǥ��ĭ ���� �� �ø�
    {
        switch (enum_Color_note)
        {
            case Color_note.Color_note_1:
                for (float i = 0; i > -1; i += 0.02f)
                {
                    Alpha_color = new Color(1, 1, 1, i);
                    Color_note1.color += Alpha_color;
                    yield return new WaitForSeconds(0.05f);
                }
                break;
            case Color_note.Color_note_2:
                for (float i = 0; i > -1; i += 0.02f)
                {
                    Alpha_color = new Color(1, 1, 1, i);
                    Color_note2.color += Alpha_color;
                    yield return new WaitForSeconds(0.05f);
                }
                break;
            case Color_note.Color_note_3:
                for (float i = 0; i > -1; i += 0.02f)
                {
                    Alpha_color = new Color(1, 1, 1, i);
                    Color_note3.color += Alpha_color;
                    yield return new WaitForSeconds(0.05f);
                }
                break;
        }
        yield break;
    }

    public void Color_note_Spawn() //�뷡�� ������ �� ��ǥ ��ư�� �����Ǵ� ���ǽ�
    {
        Result_UI.SetActive(true); //���âUI Ȱ��

        //�ϼ��� ǥ��
        Comple_song1.text = (int)scoreManager.song1_total_score + "%".ToString();
        Comple_song2.text = (int)scoreManager.song2_total_score + "%".ToString();
        Comple_song3.text = (int)scoreManager.song3_total_score + "%".ToString();

        if (scoreManager.song1_total_score >= 50) //��1 �ϼ����� 50% �̻��� ��
        {
            Color_note_button1.SetActive(true);
        }
        else
        {
            Color_note_button1.SetActive(false);
        }

        if (scoreManager.song2_total_score >= 50) //��2 �ϼ����� 50% �̻��� ��
        {
            Color_note_button2.SetActive(true);
        }
        else
        {
            Color_note_button2.SetActive(false);
        }

        if (scoreManager.song3_total_score >= 50) //��3 �ϼ����� 50% �̻��� ��
        {
            Color_note_button3.SetActive(true);
        }
        else
        {
            Color_note_button3.SetActive(false);
        }

    }

}
