using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using UnityEngine;

[Serializable]

public class Notes1
{
    public int C1, D, E, F, G, A, B, C2;
}
[Serializable]
public class Data1
{
    public Notes1[] notes1;
}
[Serializable]
public class Notes2
{
    public int C1, D, E, F, G, A, B, C2;
}
[Serializable]
public class Data2
{
    public Notes2[] notes2;
}
[Serializable]
public class Notes3
{
    public int C1, D, E, F, G, A, B, C2;
}
[Serializable]
public class Data3
{
    public Notes3[] notes3;
}

public class JsonData : MonoBehaviour
{
    public Data1 data1;
    public Data2 data2;
    public Data3 data3;

    void Awake()
    {
        LoadJson();


    }

    public void SaveJson()
    {
        string jsondata = JsonUtility.ToJson(data1, true);
        string path = Application.dataPath + "/Resources/Data1.json";
        File.WriteAllText(path, jsondata);
    }

    public void LoadJson()
    {
        string path1 = Application.dataPath + "/Resources/Data1.json";
        string jdata1 = File.ReadAllText(path1);
        data1 = JsonUtility.FromJson<Data1>(jdata1);

        string path2 = Application.dataPath + "/Resources/Data2.json";
        string jdata2 = File.ReadAllText(path2);
        data2 = JsonUtility.FromJson<Data2>(jdata2);

        string path3 = Application.dataPath + "/Resources/Data3.json";
        string jdata3 = File.ReadAllText(path3);
        data3 = JsonUtility.FromJson<Data3>(jdata3);
    }

    public void song1_LoadJson()
    {

    }

    public void Update()
    {
       
    }


}
