using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collinder : MonoBehaviour
{
 
    void Start()
    {

    }


    void Update()
    {


    }
    int note_idx = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NOTE"))
        {
            Destroy(other.gameObject);
          
      

            

        }
    }


}
