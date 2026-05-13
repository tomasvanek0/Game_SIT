using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetScore : MonoBehaviour
{
    public TMP_Text max1;
    public TMP_Text max2;

    private void Start()
    {
            max1.text = JsonScore.Instance.LoadGame1().ToString();
            max2.text = JsonScore.Instance.LoadGame2().ToString();
    }
}
