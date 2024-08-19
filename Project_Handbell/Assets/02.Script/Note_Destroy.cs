using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note_Destroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NOTE"))
        {
            print("¹Ì½º");
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("NOTNOTE"))
        {
            Destroy(other.gameObject);
        }
    }

}
