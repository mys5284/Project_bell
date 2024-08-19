using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public enum Color_note //음표 종류 정리
    {
        Color_note_1,
        Color_note_2,
        Color_note_3
    }

    Color_note enum_Color_note;

    GameManager gameManager;
    ScoreManager scoreManager;

    //음표버튼 오브젝트
    public GameObject Color_note_button1;
    public GameObject Color_note_button2;
    public GameObject Color_note_button3;

    //완성도 텍스트
    public Text Comple_song1;
    public Text Comple_song2;
    public Text Comple_song3;

    Color Alpha_color;

    //음표빈칸 채워지는 오브젝트
    public Image Color_note1;
    public Image Color_note2;
    public Image Color_note3;

    public GameObject Result_UI; //결과창 UI

    private void Start()
    {

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    public void Get_Color_note_1() //음표버튼1 눌렀을때
    {
        enum_Color_note = Color_note.Color_note_1;
        Color_note_button1.SetActive(false);
        StartCoroutine(Get_Color());
    }

    public void Get_Color_note_2() //음표버튼2 눌렀을때
    {
        enum_Color_note = Color_note.Color_note_2;
        Color_note_button2.SetActive(false);
        StartCoroutine(Get_Color());
    }

    public void Get_Color_note_3() //음표버튼3 눌렀을때
    {
        enum_Color_note = Color_note.Color_note_3;
        Color_note_button3.SetActive(false);
        StartCoroutine(Get_Color());
    }
    public void Result_UI_Close() //결과창 나가기 눌렀을때
    {
        Result_UI.SetActive(false);
    }
    IEnumerator Get_Color() //음표빈칸 투명도 값 올림
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

    public void Color_note_Spawn() //노래가 끝났을 때 음표 버튼이 생성되는 조건식
    {
        Result_UI.SetActive(true); //결과창UI 활성

        //완성도 표시
        Comple_song1.text = (int)scoreManager.song1_total_score + "%".ToString();
        Comple_song2.text = (int)scoreManager.song2_total_score + "%".ToString();
        Comple_song3.text = (int)scoreManager.song3_total_score + "%".ToString();

        if (scoreManager.song1_total_score >= 50) //곡1 완성도가 50% 이상일 때
        {
            Color_note_button1.SetActive(true);
        }
        else
        {
            Color_note_button1.SetActive(false);
        }

        if (scoreManager.song2_total_score >= 50) //곡2 완성도가 50% 이상일 때
        {
            Color_note_button2.SetActive(true);
        }
        else
        {
            Color_note_button2.SetActive(false);
        }

        if (scoreManager.song3_total_score >= 50) //곡3 완성도가 50% 이상일 때
        {
            Color_note_button3.SetActive(true);
        }
        else
        {
            Color_note_button3.SetActive(false);
        }

    }

}
