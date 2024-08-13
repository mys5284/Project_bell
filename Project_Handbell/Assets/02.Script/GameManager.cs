using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    JsonData json;

    public GameObject note1;
    public GameObject note2;
    public GameObject note3;
    public GameObject note4;
    public GameObject note5;
    public GameObject note6;
    public GameObject note7;
    public GameObject note8;
    //BARK RIM OF NOTE
    private void Awake()
    {
        json = GetComponent<JsonData>();
        
    }
    void Start()
    {
        StartCoroutine(SongStart());
    
    }

    public IEnumerator SongStart()
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
            yield return new WaitForSeconds(0.5f);
        }
        
        yield return new WaitForSeconds(4f);

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

            yield return new WaitForSeconds(0.5f);

        }


        yield break;
    }
}
