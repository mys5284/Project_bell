using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Note : MonoBehaviour
{
 
    // Update is called once per frame
    void Update() 
    {
        //��Ʈ�� �̵� �� ȸ��
        Vector3 move = new Vector3(0, -10, 0);
        this.transform.position += move * Time.deltaTime;
        transform.Rotate(0f, 180f * Time.deltaTime, 0f);
    }

    private void OnDestroy()
    {
        
    }

}
