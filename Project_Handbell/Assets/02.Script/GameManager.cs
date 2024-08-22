using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager = null;

    public float spawn_Speed = 0.1f;
    public float wait_time = 1f;

    public int bpm = 60;
    double currcntTime = 0d;
    int n_count = 0;

    JsonData json;
    UIManager uiManager;
    ScoreManager scoreManager;
    AudioManager audioManager;

    public GameObject[] note_List;

    public GameObject[] verdit_List;

    public GameObject[] track_List;


    public enum Chapter1
    {
        song1,
        song2,
        song3,
        legth
    }
    public Chapter1 chapter1 = Chapter1.song1;
    private void Awake()
    {
        gameManager = GetComponent<GameManager>();

        if (this != gameManager)
        {
            gameManager = this;
        }
        else if (gameManager != this) //���� ���� �Ŵ��� ����
        {
            Destroy(this.gameObject);
        }

        //�� ���� �ǵ� ���� ������Ʈ �ı�x
        //������ ����� �� ���� �� ����
        DontDestroyOnLoad(this.gameObject);

        json = GetComponent<JsonData>();
        uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        chapter1 = Chapter1.song1;

    }
    void Start()
    {
        // StartCoroutine(SongStart());
        audioManager.Song1_Start();
    }

    float prevtime = 0f;
    float t_currtime = 0f;

    void Sum(float _prevtime, float _t_currtime)
    {
        print(_t_currtime - _prevtime);
        _prevtime = _t_currtime;
    }

    public IEnumerator test(int _n_count)
    {
        switch (chapter1)
        {
            case Chapter1.song1:
                if (json.data1.notes1[_n_count].C1 == 1)
                {
                    Instantiate(note_List[0], new Vector3(-7, 5.5f, 0), Quaternion.identity);
                }
                if (json.data1.notes1[_n_count].D == 1)
                {
                    Instantiate(note_List[1], new Vector3(-5, 5.5f, 0), Quaternion.identity);
                }
                if (json.data1.notes1[_n_count].E == 1)
                {
                    Instantiate(note_List[2], new Vector3(-3, 5.5f, 0), Quaternion.identity);
                }
                if (json.data1.notes1[_n_count].F == 1)
                {
                    Instantiate(note_List[3], new Vector3(-1, 5.5f, 0), Quaternion.identity);
                }
                if (json.data1.notes1[_n_count].G == 1)
                {
                    Instantiate(note_List[4], new Vector3(1, 5.5f, 0), Quaternion.identity);
                }
                if (json.data1.notes1[_n_count].A == 1)
                {
                    Instantiate(note_List[5], new Vector3(3, 5.5f, 0), Quaternion.identity);
                }
                if (json.data1.notes1[_n_count].B == 1)
                {
                    Instantiate(note_List[6], new Vector3(5, 5.5f, 0), Quaternion.identity);
                }
                if (json.data1.notes1[_n_count].C2 == 1)
                {
                    Instantiate(note_List[7], new Vector3(7, 5.5f, 0), Quaternion.identity);
                }
                break;
            case Chapter1.song2:
                if (json.data2.notes2[_n_count].C1 == 1)
                {
                    Instantiate(note_List[0], new Vector3(-7, 5.5f, 0), Quaternion.identity);
                }
                if (json.data2.notes2[_n_count].D == 1)
                {
                    Instantiate(note_List[1], new Vector3(-5, 5.5f, 0), Quaternion.identity);
                }
                if (json.data2.notes2[_n_count].E == 1)
                {
                    Instantiate(note_List[2], new Vector3(-3, 5.5f, 0), Quaternion.identity);
                }
                if (json.data2.notes2[_n_count].F == 1)
                {
                    Instantiate(note_List[3], new Vector3(-1, 5.5f, 0), Quaternion.identity);
                }
                if (json.data2.notes2[_n_count].G == 1)
                {
                    Instantiate(note_List[4], new Vector3(1, 5.5f, 0), Quaternion.identity);
                }
                if (json.data2.notes2[_n_count].A == 1)
                {
                    Instantiate(note_List[5], new Vector3(3, 5.5f, 0), Quaternion.identity);
                }
                if (json.data2.notes2[_n_count].B == 1)
                {
                    Instantiate(note_List[6], new Vector3(5, 5.5f, 0), Quaternion.identity);
                }
                if (json.data2.notes2[_n_count].C2 == 1)
                {
                    Instantiate(note_List[7], new Vector3(7, 5.5f, 0), Quaternion.identity);
                }
                break;
            case Chapter1.song3:
                if (json.data3.notes3[_n_count].C1 == 1)
                {
                    Instantiate(note_List[0], new Vector3(-7, 5.5f, 0), Quaternion.identity);
                }
                if (json.data3.notes3[_n_count].D == 1)
                {
                    Instantiate(note_List[1], new Vector3(-5, 5.5f, 0), Quaternion.identity);
                }
                if (json.data3.notes3[_n_count].E == 1)
                {
                    Instantiate(note_List[2], new Vector3(-3, 5.5f, 0), Quaternion.identity);
                }
                if (json.data3.notes3[_n_count].F == 1)
                {
                    Instantiate(note_List[3], new Vector3(-1, 5.5f, 0), Quaternion.identity);
                }
                if (json.data3.notes3[_n_count].G == 1)
                {
                    Instantiate(note_List[4], new Vector3(1, 5.5f, 0), Quaternion.identity);
                }
                if (json.data3.notes3[_n_count].A == 1)
                {
                    Instantiate(note_List[5], new Vector3(3, 5.5f, 0), Quaternion.identity);
                }
                if (json.data3.notes3[_n_count].B == 1)
                {
                    Instantiate(note_List[6], new Vector3(5, 5.5f, 0), Quaternion.identity);
                }
                if (json.data3.notes3[_n_count].C2 == 1)
                {
                    Instantiate(note_List[7], new Vector3(7, 5.5f, 0), Quaternion.identity);
                }
                break;
        }

        yield return null;

    }
    int a = 0;
    private void FixedUpdate()
    {
       // chapter1 = Chapter1.song3;
        currcntTime += Time.deltaTime;

        if (currcntTime >= 60d / bpm)
        {

            StartCoroutine(test(n_count++));

            t_currtime = Time.time;
            Sum(prevtime, t_currtime);

            if (n_count == json.data1.notes1.Length)
            {
                n_count = 0;
                chapter1 = Chapter1.song2;
            }
            a++;
            print(a);
            currcntTime -= 60d / bpm;
        }
    }




    private void Update()
    {

        //Ű�Է� �� ��Ʈĭ collider Ȱ��
        if (Input.GetKey(KeyCode.A))
        {
            verdit_List[0].gameObject.GetComponent<BoxCollider>().enabled = true; //��Ʈĭ Box Coiilinder Ȱ��
            track_List[0].SetActive(true); //Ʈ�� ���� �÷�ȿ�� Ȱ��
            if (Input.GetKeyDown(KeyCode.A)) //�ѹ��� �Ҹ�(Update ������ �Ҹ����°� ����)
            {
                audioManager.Line_1_sfx();  //������Ŵ������� �޼��� ����
            }
        }
        else
        {
            verdit_List[0].gameObject.GetComponent<BoxCollider>().enabled = false; //��Ʈĭ Box Coiilinder ��Ȱ��
            track_List[0].SetActive(false); //Ʈ�� ���� �÷�ȿ�� ��Ȱ��
        }

        if (Input.GetKey(KeyCode.S))
        {
            verdit_List[1].gameObject.GetComponent<BoxCollider>().enabled = true;
            track_List[1].SetActive(true);
            if (Input.GetKeyDown(KeyCode.S))
            {
                audioManager.Line_2_sfx();
            }
        }
        else
        {
            verdit_List[1].gameObject.GetComponent<BoxCollider>().enabled = false;
            track_List[1].SetActive(false);
        }

        if (Input.GetKey(KeyCode.D))
        {
            verdit_List[2].gameObject.GetComponent<BoxCollider>().enabled = true;
            track_List[2].SetActive(true);
            if (Input.GetKeyDown(KeyCode.D))
            {
                audioManager.Line_3_sfx();
            }
        }
        else
        {
            verdit_List[2].gameObject.GetComponent<BoxCollider>().enabled = false;
            track_List[2].SetActive(false);
        }

        if (Input.GetKey(KeyCode.F))
        {
            verdit_List[3].gameObject.GetComponent<BoxCollider>().enabled = true;
            track_List[3].SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                audioManager.Line_4_sfx();
            }
        }
        else
        {
            verdit_List[3].gameObject.GetComponent<BoxCollider>().enabled = false;
            track_List[3].SetActive(false);
        }

        if (Input.GetKey(KeyCode.J))
        {
            verdit_List[4].gameObject.GetComponent<BoxCollider>().enabled = true;
            track_List[4].SetActive(true);
            if (Input.GetKeyDown(KeyCode.J))
            {
                audioManager.Line_5_sfx();
            }
        }
        else
        {
            verdit_List[4].gameObject.GetComponent<BoxCollider>().enabled = false;
            track_List[4].SetActive(false);
        }

        if (Input.GetKey(KeyCode.K))
        {
            verdit_List[5].gameObject.GetComponent<BoxCollider>().enabled = true;
            track_List[5].SetActive(true);
            if (Input.GetKeyDown(KeyCode.K))
            {
                audioManager.Line_6_sfx();
            }
        }
        else
        {
            verdit_List[5].gameObject.GetComponent<BoxCollider>().enabled = false;
            track_List[5].SetActive(false);
        }

        if (Input.GetKey(KeyCode.L))
        {
            verdit_List[6].gameObject.GetComponent<BoxCollider>().enabled = true;
            track_List[6].SetActive(true);
            if (Input.GetKeyDown(KeyCode.L))
            {
                audioManager.Line_7_sfx();
            }
        }
        else
        {
            verdit_List[6].gameObject.GetComponent<BoxCollider>().enabled = false;
            track_List[6].SetActive(false);
        }

        if (Input.GetKey(KeyCode.Semicolon))
        {
            verdit_List[7].gameObject.GetComponent<BoxCollider>().enabled = true;
            track_List[7].SetActive(true);
            if (Input.GetKeyDown(KeyCode.Semicolon))
            {
                audioManager.Line_8_sfx();
            }
        }
        else
        {
            verdit_List[7].gameObject.GetComponent<BoxCollider>().enabled = false;
            track_List[7].SetActive(false);
        }


    

}


    public IEnumerator SongStart() //é�� 1 (song1, song2, song3) ��ƾ ����
    {

        for (int c = 0; c < (int)Chapter1.legth; c++) //�� �뷡�� 3�� �����ϸ� 1�� -> 2�� -> 3������ ����
        {
            switch (chapter1)
            {
                case Chapter1.song1: //song1�� �� ��Ʈ ����

                    for (int i = 0; i < json.data1.notes1.Length; i++)
                    {
                        if (json.data1.notes1[i].C1 == 1)
                        {
                            Instantiate(note_List[0], new Vector3(-7, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data1.notes1[i].D == 1)
                        {
                            Instantiate(note_List[1], new Vector3(-5, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data1.notes1[i].E == 1)
                        {
                            Instantiate(note_List[2], new Vector3(-3, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data1.notes1[i].F == 1)
                        {
                            Instantiate(note_List[3], new Vector3(-1, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data1.notes1[i].G == 1)
                        {
                            Instantiate(note_List[4], new Vector3(1, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data1.notes1[i].A == 1)
                        {
                            Instantiate(note_List[5], new Vector3(3, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data1.notes1[i].B == 1)
                        {
                            Instantiate(note_List[6], new Vector3(5, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data1.notes1[i].C2 == 1)
                        {
                            Instantiate(note_List[7], new Vector3(7, 5.5f, 0), Quaternion.identity);
                        }

                        yield return new WaitForSeconds(0.5f);
                    }

                    yield return new WaitForSeconds(wait_time);
                    chapter1 = Chapter1.song2;
                    break;

                case Chapter1.song2: //song2 �� �� ��Ʈ ����
                    for (int i = 0; i < json.data2.notes2.Length; i++)
                    {
                        if (json.data2.notes2[i].C1 == 1)
                        {
                            Instantiate(note_List[0], new Vector3(-7, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data2.notes2[i].D == 1)
                        {
                            Instantiate(note_List[1], new Vector3(-5, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data2.notes2[i].E == 1)
                        {
                            Instantiate(note_List[2], new Vector3(-3, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data2.notes2[i].F == 1)
                        {
                            Instantiate(note_List[3], new Vector3(-1, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data2.notes2[i].G == 1)
                        {
                            Instantiate(note_List[4], new Vector3(1, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data2.notes2[i].A == 1)
                        {
                            Instantiate(note_List[5], new Vector3(3, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data2.notes2[i].B == 1)
                        {
                            Instantiate(note_List[6], new Vector3(5, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data2.notes2[i].C2 == 1)
                        {
                            Instantiate(note_List[7], new Vector3(7, 5.5f, 0), Quaternion.identity);
                        }

                        yield return new WaitForSeconds(spawn_Speed);

                    }

                    yield return new WaitForSeconds(wait_time);
                    chapter1 = Chapter1.song3;
                    break;

                case Chapter1.song3: //song3 �� �� ��Ʈ ����
                    for (int i = 0; i < json.data3.notes3.Length; i++)
                    {
                        if (json.data3.notes3[i].C1 == 1)
                        {
                            Instantiate(note_List[0], new Vector3(-7, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data3.notes3[i].D == 1)
                        {
                            Instantiate(note_List[1], new Vector3(-5, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data3.notes3[i].E == 1)
                        {
                            Instantiate(note_List[2], new Vector3(-3, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data3.notes3[i].F == 1)
                        {
                            Instantiate(note_List[3], new Vector3(-1, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data3.notes3[i].G == 1)
                        {
                            Instantiate(note_List[4], new Vector3(1, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data3.notes3[i].A == 1)
                        {
                            Instantiate(note_List[5], new Vector3(3, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data3.notes3[i].B == 1)
                        {
                            Instantiate(note_List[6], new Vector3(5, 5.5f, 0), Quaternion.identity);
                        }
                        if (json.data3.notes3[i].C2 == 1)
                        {
                            Instantiate(note_List[7], new Vector3(7, 5.5f, 0), Quaternion.identity);
                        }

                        yield return new WaitForSeconds(0.175f);

                    }

                    yield return new WaitForSeconds(wait_time);

                    uiManager.Color_note_Spawn(); //���â ����
                    break;
                default:

                    break;

            }
        }

        yield break;
    }



}
