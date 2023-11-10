using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullScreen : MonoBehaviour
{
    [SerializeField] private Sprite expand;
    [SerializeField] private Sprite shrink;
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    public void SetFullScreen(bool value)
    {
        Screen.fullScreen = value;
        if (value) image.sprite = shrink;
        else image.sprite = expand;
    }
}
