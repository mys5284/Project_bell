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
    double currcntTime2 = 0d;
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
        Chapter1_Start = true;

    }



    int a = 0;
    int b = 0;
    bool Chapter1_Start = false;

    float Wait_MR_Count = 0.2f; //18.45f(������) //0.2f
    private void FixedUpdate()
    {


        if (Chapter1_Start) //é�� ���۽� �� ����
        {
            currcntTime2 += Time.deltaTime;
            if (currcntTime2 >= 60d / bpm)
            {
                b++;
                print(b);
                currcntTime2 -= 60d / bpm;
            }


            Wait_MR_Count -= Time.deltaTime;

            switch (chapter1)
            {
                case Chapter1.song1:
                    audioManager.Song_MR_Obj[0].SetActive(true);
                    bpm = 120;
                    if (n_count == json.data1.notes1.Length)
                    {
                        n_count = 0;
                        Wait_MR_Count = 0f; //25.45f
                        chapter1 = Chapter1.song2;
                    }
                    break;
                case Chapter1.song2:
                    audioManager.Song_MR_Obj[0].SetActive(false);
                    audioManager.Song_MR_Obj[1].SetActive(true);
                    bpm = 120;
                    if (n_count == json.data2.notes2.Length)
                    {
                        n_count = 0;
                        Wait_MR_Count = 0.17f;; //12.09f
                        chapter1 = Chapter1.song3;
                    }
                    break;
                case Chapter1.song3:
                    audioManager.Song_MR_Obj[1].SetActive(false);
                    audioManager.Song_MR_Obj[2].SetActive(true);
                    bpm = 240;
                    if (n_count == json.data2.notes2.Length)
                    {
                        print("��");
                    }
                    break;
            }

            if (Wait_MR_Count <= 0) //���� ��ũ�ð� ���߱�
            {
                currcntTime += Time.deltaTime;
                if (currcntTime >= 60d / bpm)
                {

                    StartCoroutine(test(n_count++));

                    a++;
                    print(a);
                    currcntTime -= 60d / bpm;
                }

            }

        }
    }






    private void Update()
    {
        #region Ű�Է�
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
        #endregion

    }

    IEnumerator Wait_MR()
    {
        new WaitForSeconds(20f);
        yield return null;
    }

    public IEnumerator test(int _n_count) //é�� 1 (song1, song2, song3) ��ƾ ����
    {
        switch (chapter1) //�� �뷡�� 3�� �����ϸ� 1�� -> 2�� -> 3������ ����
        {
            case Chapter1.song1: //song1�� �� ��Ʈ ����
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
            case Chapter1.song2: //song2 �� �� ��Ʈ ����
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
            case Chapter1.song3: //song3 �� �� ��Ʈ ����
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



}
