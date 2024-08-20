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
    AudioSource audioSource;

    public List<GameObject> note_List = new List<GameObject>();

    public List<GameObject> verdit_List = new List<GameObject>();

    public List<GameObject> track_List = new List<GameObject>();

    public List<AudioClip> effect_sound_List = new List<AudioClip>();

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
        //gameManager = GetComponent<GameManager>();

        //if (this != gamemanager)
        //{
        //    gamemanager = this;
        //}
        //else if (gamemanager != this) //새로 들어온 매니저 날림
        //{
        //    destroy(this.gameobject);
        //}

        ////씬 변경 되도 게임 오브젝트 파괴x
        ////게임이 종료될 때 까지 쭉 유지
        //dontdestroyonload(this.gameobject);

        json = GetComponent<JsonData>();
        uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        audioSource = GetComponent<AudioSource>();
        chapter1 = Chapter1.song1;


    }
    void Start()
    {
        StartCoroutine(SongStart());

    }



    private void Update()
    {
        //키입력 시 노트칸 collider 활성
        if (Input.GetKey(KeyCode.A))
        {
            verdit_List[0].gameObject.GetComponent<BoxCollider>().enabled = true;
            track_List[0].SetActive(true);
            audioSource.PlayOneShot(effect_sound_List[0]);
        }
        else
        {
            verdit_List[0].gameObject.GetComponent<BoxCollider>().enabled = false;
            track_List[0].SetActive(false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            verdit_List[1].gameObject.GetComponent<BoxCollider>().enabled = true;
            track_List[1].SetActive(true);
            audioSource.PlayOneShot(effect_sound_List[1]);
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
            audioSource.PlayOneShot(effect_sound_List[2]);
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
            audioSource.PlayOneShot(effect_sound_List[3]);
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
            audioSource.PlayOneShot(effect_sound_List[4]);
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
            audioSource.PlayOneShot(effect_sound_List[5]);
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
            audioSource.PlayOneShot(effect_sound_List[6]);
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
            audioSource.PlayOneShot(effect_sound_List[7]);
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
                        yield return new WaitForSeconds(spawn_Speed);
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

                        yield return new WaitForSeconds(0.25f);

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
