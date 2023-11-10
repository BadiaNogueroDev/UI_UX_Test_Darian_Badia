using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public Audio[] music;
    public Audio[] sfx;
    public AudioSource musicSource;
    public AudioSource sfxSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("MainMusic");
    }

    public void PlayMusic(string name)
    {
        Audio audio = null;

        for (int i = 0; i < music.Length; i++)
        {
            if (music[i].name == name) audio = music[i];
        }

        if (audio == null) Debug.Log("Audio not found");
        else
        {
            musicSource.clip = audio.audio;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name)
    {
        Audio audio = null;

        for (int i = 0; i < sfx.Length; i++)
        {
            if (sfx[i].name == name) audio = sfx[i];
        }

        if (audio == null) Debug.Log("Audio not found");
        else sfxSource.PlayOneShot(audio.audio);
    }
}
