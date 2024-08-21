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
        else if (gameManager != this) //새로 들어온 매니저 날림
        {
            Destroy(this.gameObject);
        }

        //씬 변경 되도 게임 오브젝트 파괴x
        //게임이 종료될 때 까지 쭉 유지
        DontDestroyOnLoad(this.gameObject);

        json = GetComponent<JsonData>();
        uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        chapter1 = Chapter1.song1;

    }
    void Start()
    {
        StartCoroutine(SongStart());
    }

    public int bpm = 120;
    double currcntTime = 0d;

    public IEnumerator test()
    {
        for (int i = 0; i < 200; i++)
        {

            Instantiate(note_List[0], new Vector3(-7, 5.5f, 0), Quaternion.identity);
            yield return new WaitForSecondsRealtime(0.5f);
        }



    }
    int m = 0;
    private void Update()
    {
        currcntTime += Time.deltaTime;

        if (currcntTime >= 60d / bpm)
        {

            if (json.data1.notes1[m].C1 == 1)
            {
                Instantiate(note_List[0], new Vector3(-7, 5.5f, 0), Quaternion.identity);
            }
            if (json.data1.notes1[m].D == 1)
            {
                Instantiate(note_List[1], new Vector3(-5, 5.5f, 0), Quaternion.identity);
            }
            if (json.data1.notes1[m].E == 1)
            {
                Instantiate(note_List[2], new Vector3(-3, 5.5f, 0), Quaternion.identity);
            }
            if (json.data1.notes1[m].F == 1)
            {
                Instantiate(note_List[3], new Vector3(-1, 5.5f, 0), Quaternion.identity);
            }
            if (json.data1.notes1[m].G == 1)
            {
                Instantiate(note_List[4], new Vector3(1, 5.5f, 0), Quaternion.identity);
            }
            if (json.data1.notes1[m].A == 1)
            {
                Instantiate(note_List[5], new Vector3(3, 5.5f, 0), Quaternion.identity);
            }
            if (json.data1.notes1[m].B == 1)
            {
                Instantiate(note_List[6], new Vector3(5, 5.5f, 0), Quaternion.identity);
            }
            if (json.data1.notes1[m].C2 == 1)
            {
                Instantiate(note_List[7], new Vector3(7, 5.5f, 0), Quaternion.identity);
            }


            m++;

            currcntTime -= 60d / bpm;
        }
        print(m);







        //키입력 시 노트칸 collider 활성
        if (Input.GetKey(KeyCode.A))
        {
            verdit_List[0].gameObject.GetComponent<BoxCollider>().enabled = true; //노트칸 Box Coiilinder 활성
            track_List[0].SetActive(true); //트랙 라인 컬러효과 활성
            if (Input.GetKeyDown(KeyCode.A)) //한번만 소리(Update 여러번 소리나는걸 방지)
            {
                audioManager.Line_1_sfx();  //오디오매니저에서 메서드 실행
            }
        }
        else
        {
            verdit_List[0].gameObject.GetComponent<BoxCollider>().enabled = false; //노트칸 Box Coiilinder 비활성
            track_List[0].SetActive(false); //트랙 라인 컬러효과 비활성
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


    public IEnumerator SongStart() //챕터 1 (song1, song2, song3) 루틴 시작
    {

        for (int c = 0; c < (int)Chapter1.legth; c++) //총 노래를 3번 진행하며 1곡 -> 2곡 -> 3곡으로 진행
        {
            switch (chapter1)
            {
                case Chapter1.song1: //song1일 때 노트 패턴

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

                case Chapter1.song2: //song2 일 때 노트 패턴
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

                case Chapter1.song3: //song3 일 때 노트 패턴
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

                    uiManager.Color_note_Spawn(); //결과창 생성
                    break;
                default:

                    break;

            }
        }

        yield break;
    }



}
