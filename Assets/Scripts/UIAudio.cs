using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAudio : MonoBehaviour
{
    public void ClickButton()
    {
        AudioManager.instance.PlaySFX("ButtonClick");
    }
}
