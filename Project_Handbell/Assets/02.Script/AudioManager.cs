using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;

    public AudioClip[] song_MRs;
    public AudioSource[] effect_sound_Line;
    public AudioClip[] effect_sound_Clips;

    void Start()
    {
        //오디오매니저의 각 개체별로 각 클립을 넣어줌
        audioSource = GetComponent<AudioSource>();

        this.audioSource.clip = song_MRs[0];

        for (int i = 0; i < effect_sound_Line.Length; i++)
        {
            effect_sound_Line[i].clip = effect_sound_Clips[i];
        }
    }

    public void Song1_Start()
    {
      this.audioSource.Play();
    }

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
}
