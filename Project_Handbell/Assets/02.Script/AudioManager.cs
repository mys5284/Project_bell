using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public GameObject[] Song_MR_Obj;

    public AudioSource[] mr_audioSource;
    public AudioClip[] song_MRs;
    public AudioSource[] effect_sound_Line;
    public AudioClip[] effect_sound_Clips;

    GameManager gameManager;


    private void Awake()
    {
         for (int i = 0; i < mr_audioSource.Length; i++)
        {
            mr_audioSource[i].clip = song_MRs[i];
            Song_MR_Obj[i].SetActive(false);
        }

        for (int i = 0; i < effect_sound_Line.Length; i++)
        {
            effect_sound_Line[i].clip = effect_sound_Clips[i];
        }
    }

    void Start()
    {
        //오디오매니저의 각 개체별로 각 클립을 넣어줌

        //this.mr_audioSource.clip = song_MRs[0];
        //mr_audioSource.Play();
    
    }

    private void OnEnable()
    {

    }

  

    #region 트랙라인별 효과음
    public void Line_1_sfx()
    {
        effect_sound_Line[0].Play();
    }
    public void Line_2_sfx()
    {
        effect_sound_Line[1].Play();
    }
    public void Line_3_sfx()
    {
        effect_sound_Line[2].Play();
    }
    public void Line_4_sfx()
    {
        effect_sound_Line[3].Play();
    }
    public void Line_5_sfx()
    {
        effect_sound_Line[4].Play();
    }
    public void Line_6_sfx()
    {
        effect_sound_Line[5].Play();
    }
    public void Line_7_sfx()
    {
        effect_sound_Line[6].Play();
    }
    public void Line_8_sfx()
    {
        effect_sound_Line[7].Play();
    }
    #endregion
}
