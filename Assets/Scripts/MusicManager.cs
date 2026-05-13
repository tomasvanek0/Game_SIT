using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    public Toggle musicToggle;

    void Start()
    {
        musicToggle.isOn = !AudioListener.pause;

        musicToggle.onValueChanged.AddListener(SetMusic);
    }

    public void SetMusic(bool isOn)
    {
        AudioListener.pause = !isOn;
    }
}
