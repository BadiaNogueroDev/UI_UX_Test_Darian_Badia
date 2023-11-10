using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    [Header("Sprites")]
    [SerializeField] private Sprite musicUnmute;
    [SerializeField] private Sprite sfxUnmute;
    [SerializeField] private Sprite musicMute;
    [SerializeField] private Sprite sfxMute;

    [Header("Images")]
    [SerializeField] private Image musicImage;
    [SerializeField] private Image sfxImage;

    public void ToggleMusic(bool value)
    {
        //true == muted
        //false == unmuted
        AudioManager.instance.musicSource.mute = value;
        if (value) musicImage.sprite = musicMute;
        else musicImage.sprite = musicUnmute;
    }

    public void ToggleSFX(bool value)
    {
        AudioManager.instance.sfxSource.mute = value;
        if (value) sfxImage.sprite = sfxMute;
        else sfxImage.sprite = sfxUnmute;
    }

    public void MusicVolume (float value)
    {
        AudioManager.instance.musicSource.volume = value;
        Debug.Log(value);
    }

    public void SFXVolume (float value)
    {
        AudioManager.instance.sfxSource.volume = value;
        Debug.Log(value);
    }
}
