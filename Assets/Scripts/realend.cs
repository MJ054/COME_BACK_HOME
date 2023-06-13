using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class realend : MonoBehaviour
{
    GameObject BackgroundMusic;
    AudioSource backmusic;

    void Awake()
    {
        BackgroundMusic = GameObject.Find("Bgm");
        backmusic = BackgroundMusic.GetComponent<AudioSource>(); //배경음악 저장해둠
        if (backmusic.isPlaying) backmusic.Pause(); //배경음악이 재생되고 있다면 패스
      
    }
}