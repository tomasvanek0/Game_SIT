using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seats : MonoBehaviour
{
    public static Seats Instance;
    void Awake()
    {
        if (FindObjectsOfType<Seats>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
