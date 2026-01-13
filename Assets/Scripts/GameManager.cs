using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform Circle;
    public int circleCount = 6;

    void Start()
    {
        for (int i = 0; i < circleCount; i++)
        {
            CreateCircle();
        }
    }

    public void CreateCircle()
    {
        Instantiate(Circle);
    }
}
