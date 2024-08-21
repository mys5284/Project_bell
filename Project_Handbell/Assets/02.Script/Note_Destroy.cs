using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note_Destroy : MonoBehaviour
{
    Collinder collinder;

    private void Start()
    {
     collinder = GameObject.Find("Note_verdict_1").GetComponent<Collinder>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NOTE"))
        {
            collinder.StartCoroutine(collinder.DispJud(collinder.jImgList[0]));
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("NOTNOTE"))
        {
            Destroy(other.gameObject);
        }
    }

}
