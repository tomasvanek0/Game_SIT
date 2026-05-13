using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerParrent : MonoBehaviour
{
    public static CustomerParrent Instance;
    void Awake()
    {
        if (FindObjectsOfType<CustomerParrent>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }
}
