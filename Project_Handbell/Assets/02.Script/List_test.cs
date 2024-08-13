using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class List_test : MonoBehaviour
{
    // List<float> note_line_0 = new List<float>();
    //List<float> note_line_1 = null;
    //List<float> note_line_2 = null;
    //List<float> note_line_3 = null;
    //List<float> note_line_4 = null;
    //List<float> note_line_5 = null;
    //List<float> note_line_6 = null;
    //List<float> note_line_7 = null;


    public GameObject null_note;

    public GameObject note1;
    public GameObject note2;
    public GameObject note3;
    public GameObject note4;
    public GameObject note5;
    public GameObject note6;
    public GameObject note7;
    public GameObject note8;

    public List<GameObject> note_line_1 = new List<GameObject>();
    public List<GameObject> note_line_2 = new List<GameObject>();
    public List<GameObject> note_line_3 = new List<GameObject>();
    public List<GameObject> note_line_4 = new List<GameObject>();
    public List<GameObject> note_line_5 = new List<GameObject>();
    public List<GameObject> note_line_6 = new List<GameObject>();
    public List<GameObject> note_line_7 = new List<GameObject>();
    public List<GameObject> note_line_8 = new List<GameObject>();
  



    // Start is called before the first frame update
    void Start()
    {
        //라인1번
        note_line_1.Add(note1);
        note_line_1.Add(null_note);
        note_line_1.Add(null_note);
        note_line_1.Add(null_note);
        note_line_1.Add(null_note);
        note_line_1.Add(null_note);
        note_line_1.Add(null_note);
        note_line_1.Add(null_note);
        note_line_1.Add(null_note);

        note_line_1.Add(null_note);
        note_line_1.Add(null_note);
        note_line_1.Add(null_note);
        note_line_1.Add(null_note);
        note_line_1.Add(null_note);
        note_line_1.Add(null_note);


        //라인2번
        note_line_2.Add(note2);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);

        note_line_2.Add(null_note);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);
        note_line_2.Add(null_note);

        //라인3번
        note_line_3.Add(note3);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);

        note_line_3.Add(null_note);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);
        note_line_3.Add(null_note);

        //라인4번
        note_line_4.Add(note4);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);

        note_line_4.Add(null_note);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);
        note_line_4.Add(null_note);

        //라인5번
        note_line_5.Add(note5);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);

        note_line_5.Add(note5);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);
        note_line_5.Add(null_note);

        //라인6번
        note_line_6.Add(note6);
        note_line_6.Add(null_note);
        note_line_6.Add(null_note);
        note_line_6.Add(null_note);
        note_line_6.Add(null_note);
        note_line_6.Add(null_note);
        note_line_6.Add(null_note);
        note_line_6.Add(null_note);
        note_line_6.Add(null_note);
        note_line_6.Add(null_note);

        note_line_6.Add(null_note);
        note_line_6.Add(note6);
        note_line_6.Add(null_note);
        note_line_6.Add(null_note);
        note_line_6.Add(null_note);
        note_line_6.Add(null_note);

        //라인7번
        note_line_7.Add(note7);
        note_line_7.Add(null_note);
        note_line_7.Add(null_note);
        note_line_7.Add(null_note);
        note_line_7.Add(null_note);
        note_line_7.Add(null_note);
        note_line_7.Add(null_note);
        note_line_7.Add(null_note);
        note_line_7.Add(note7);
        note_line_7.Add(null_note);

        note_line_7.Add(null_note);
        note_line_7.Add(null_note);
        note_line_7.Add(note7);
        note_line_7.Add(null_note);
        note_line_7.Add(null_note);
        note_line_7.Add(null_note);


        //라인8번
        note_line_8.Add(note8);
        note_line_8.Add(null_note);
        note_line_8.Add(null_note);
        note_line_8.Add(null_note);
        note_line_8.Add(note8);
        note_line_8.Add(null_note);
        note_line_8.Add(null_note);
        note_line_8.Add(null_note);
        note_line_8.Add(null_note);
        note_line_8.Add(null_note);

        note_line_8.Add(null_note);
        note_line_8.Add(null_note);
        note_line_8.Add(null_note);
        note_line_8.Add(null_note);
        note_line_8.Add(note8);
        note_line_8.Add(null_note);


        //리스트 코루틴 시작
        StartCoroutine(note_spawn_1());
        StartCoroutine(note_spawn_2());
        StartCoroutine(note_spawn_3());
        StartCoroutine(note_spawn_4());
        StartCoroutine(note_spawn_5());
        StartCoroutine(note_spawn_6());
        StartCoroutine(note_spawn_7());
        StartCoroutine(note_spawn_8());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator note_spawn_1()
    {
        for (int i = 0; i < note_line_1.Count; i++)
        {
            yield return new WaitForSeconds(0.5f);

            Instantiate(note_line_1[i], new Vector3(-8.62f, 4.5f, 0), Quaternion.identity);

            

        }
    }

    IEnumerator note_spawn_2()
    {
        for (int i = 0; i < note_line_2.Count; i++)
        {
            yield return new WaitForSeconds(0.5f);

            Instantiate(note_line_2[i], new Vector3(-6.32f, 4.5f, 0), Quaternion.identity);
           
           
        }
    }

    IEnumerator note_spawn_3()
    {
        for (int i = 0; i < note_line_3.Count; i++)
        {
            yield return new WaitForSeconds(0.5f);

            Instantiate(note_line_3[i], new Vector3(-3.89f, 4.5f, 0), Quaternion.identity);
        }
    }

    IEnumerator note_spawn_4()
    {
        for (int i = 0; i < note_line_4.Count; i++)
        {
            yield return new WaitForSeconds(0.5f);

            Instantiate(note_line_4[i], new Vector3(-1.22f, 4.5f, 0), Quaternion.identity);
        }
    }

    IEnumerator note_spawn_5()
    {
        for (int i = 0; i < note_line_5.Count; i++)
        {
            yield return new WaitForSeconds(0.5f);

            Instantiate(note_line_5[i], new Vector3(1.45f, 4.5f, 0), Quaternion.identity);
        }
    }

    IEnumerator note_spawn_6()
    {
        for (int i = 0; i < note_line_6.Count; i++)
        {
            yield return new WaitForSeconds(0.5f);

            Instantiate(note_line_6[i], new Vector3(4.01f, 4.5f, 0), Quaternion.identity);
        }
    }

    IEnumerator note_spawn_7()
    {
        for (int i = 0; i < note_line_7.Count; i++)
        {
            yield return new WaitForSeconds(0.5f);

            Instantiate(note_line_7[i], new Vector3(6.19f, 4.5f, 0), Quaternion.identity);
        }
    }

    IEnumerator note_spawn_8()
    {
        for (int i = 0; i < note_line_8.Count; i++)
        {
            yield return new WaitForSeconds(0.5f);

            Instantiate(note_line_8[i], new Vector3(9.12f, 4.5f, 0), Quaternion.identity);
        }
    }
}

