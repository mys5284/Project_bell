using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public static GameManager gameManager = null;

    public float spawn_Speed = 0.1f;
    public float wait_time = 1f;

    JsonData json;
    public UIManager uiManager;

    public GameObject note1;
    public GameObject note2;
    public GameObject note3;
    public GameObject note4;
    public GameObject note5;
    public GameObject note6;
    public GameObject note7;
    public GameObject note8;

    public GameObject verdit1;
    public GameObject verdit2;
    public GameObject verdit3;
    public GameObject verdit4;
    public GameObject verdit5;
    public GameObject verdit6;
    public GameObject verdit7;
    public GameObject verdit8;



    private void Awake()
    {
        if (this != gameManager)
        {
            gameManager = this;
        }
        else if (gameManager != this) //새로 들어온 매니저 날림
        {
            Destroy(this.gameObject);
        }

        //씬 변경 되도 게임 오브젝트 파괴X
        //게임이 종료될 때 까지 쭉 유지
        DontDestroyOnLoad(this.gameObject);

        json = GetComponent<JsonData>();


    }
    void Start()
    {
        StartCoroutine(SongStart());

    }

    private void Update()
    {

        //키입력 시 노트칸 활성
        if (Input.GetKey(KeyCode.A))
        {
            verdit1.SetActive(true);
        }
        else
        {
            verdit1.SetActive(false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            verdit2.SetActive(true);
        }
        else
        {
            verdit2.SetActive(false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            verdit3.SetActive(true);
        }
        else
        {
            verdit3.SetActive(false);
        }
        if (Input.GetKey(KeyCode.F))
        {
            verdit4.SetActive(true);
        }
        else
        {
            verdit4.SetActive(false);
        }
        if (Input.GetKey(KeyCode.H))
        {
            verdit5.SetActive(true);
        }
        else
        {
            verdit5.SetActive(false);
        }
        if (Input.GetKey(KeyCode.J))
        {
            verdit6.SetActive(true);
        }
        else
        {
            verdit6.SetActive(false);
        }
        if (Input.GetKey(KeyCode.K))
        {
            verdit7.SetActive(true);
        }
        else
        {
            verdit7.SetActive(false);
        }
        if (Input.GetKey(KeyCode.L))
        {
            verdit8.SetActive(true);
        }
        else
        {
            verdit8.SetActive(false);
        }
    }

    public IEnumerator SongStart() //챕터 1 (song1, song2, song3) 루틴 시작
    {
        for (int i = 0; i < json.data1.notes1.Length; i++)
        {
            if (json.data1.notes1[i].C1 == 1)
            {
                Instantiate(note1, new Vector3(-7, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data1.notes1[i].D == 1)
            {
                Instantiate(note2, new Vector3(-5, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data1.notes1[i].E == 1)
            {
                Instantiate(note3, new Vector3(-3, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data1.notes1[i].F == 1)
            {
                Instantiate(note4, new Vector3(-1, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data1.notes1[i].G == 1)
            {
                Instantiate(note5, new Vector3(1, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data1.notes1[i].A == 1)
            {
                Instantiate(note6, new Vector3(3, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data1.notes1[i].B == 1)
            {
                Instantiate(note7, new Vector3(5, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data1.notes1[i].C2 == 1)
            {
                Instantiate(note8, new Vector3(7, 5.5f, 0), Quaternion.identity);
            }
            yield return new WaitForSeconds(spawn_Speed);
        }

        yield return new WaitForSeconds(wait_time);

        for (int i = 0; i < json.data2.notes2.Length; i++)
        {
            if (json.data2.notes2[i].C1 == 1)
            {
                Instantiate(note1, new Vector3(-7, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data2.notes2[i].D == 1)
            {
                Instantiate(note2, new Vector3(-5, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data2.notes2[i].E == 1)
            {
                Instantiate(note3, new Vector3(-3, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data2.notes2[i].F == 1)
            {
                Instantiate(note4, new Vector3(-1, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data2.notes2[i].G == 1)
            {
                Instantiate(note5, new Vector3(1, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data2.notes2[i].A == 1)
            {
                Instantiate(note6, new Vector3(3, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data2.notes2[i].B == 1)
            {
                Instantiate(note7, new Vector3(5, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data2.notes2[i].C2 == 1)
            {
                Instantiate(note8, new Vector3(7, 5.5f, 0), Quaternion.identity);
            }

            yield return new WaitForSeconds(spawn_Speed);

        }

        yield return new WaitForSeconds(wait_time);

        for (int i = 0; i < json.data3.notes3.Length; i++)
        {
            if (json.data3.notes3[i].C1 == 1)
            {
                Instantiate(note1, new Vector3(-7, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data3.notes3[i].D == 1)
            {
                Instantiate(note2, new Vector3(-5, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data3.notes3[i].E == 1)
            {
                Instantiate(note3, new Vector3(-3, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data3.notes3[i].F == 1)
            {
                Instantiate(note4, new Vector3(-1, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data3.notes3[i].G == 1)
            {
                Instantiate(note5, new Vector3(1, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data3.notes3[i].A == 1)
            {
                Instantiate(note6, new Vector3(3, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data3.notes3[i].B == 1)
            {
                Instantiate(note7, new Vector3(5, 5.5f, 0), Quaternion.identity);
            }
            else if (json.data3.notes3[i].C2 == 1)
            {
                Instantiate(note8, new Vector3(7, 5.5f, 0), Quaternion.identity);
            }

            yield return new WaitForSeconds(spawn_Speed);

        }

        yield return new WaitForSeconds(wait_time);

        uiManager.Result_UI.SetActive(true);

        yield break;
    }


}
