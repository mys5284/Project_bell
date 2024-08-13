using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paten_test : MonoBehaviour
{
    public Transform tr1;
    public Transform tr2;
    public Transform tr3;
    public Transform tr4;
    public Transform tr5;
    public Transform tr6;
    public Transform tr7;
    public Transform tr8;

    public Data1 load;
    public List_test list;

    void Start()
    {

    }


    void Update()
    {

    }

    IEnumerator Start_Note()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(0.5f);

            //switch (load.C1)
            //{
            //    case 0:

            //        break;
            //    case 1:
            //        Instantiate(list.note1, tr1.transform.position, Quaternion.identity);
            //        break;
            //    default:
            //        break;
            //}
        }

    }
}
