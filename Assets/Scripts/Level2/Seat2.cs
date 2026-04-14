using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Seat2 : MonoBehaviour
{
    public bool back;
    public bool front;
    public bool window;
    public bool alley;

    public bool isSeatOccupied;

    public float neighbourDistance = 0.8f;   
    public List<Seat2> neighbours = new List<Seat2>();


    public bool CanSit(Customer customer)
    {
        //pokud volno nebo neni zakaznik
        if (isSeatOccupied)
        {
            return false;
        }
        if (customer == null)
        {
            return false;
        }
        //pokud modry
        if (customer.Blue && !window)
        {
            return false;
        }
        if (customer.Blue && window)
        { 
            return true;
        }
        //pokud cerveny
        if (customer.Red && !back)
        {
            return false;
        }
        if (customer.Red && back)
        {
            return true;
        }
        //pokud zluty
        if (customer.Yellow && !alley)
        {
            return false;
        }
        if (customer.Yellow && alley)
        {
            return true;
        }
        //pokud zeleny
        if (customer.Green && !front)
        {
            return false;
        }
        if (customer.Green && front)
        {
            return true;
        }
        if (customer.Triangle && neighbours.Any(n => n.isSeatOccupied))
        {
            return false;
        }
        
        
            return true;
    }

    void Start()
    {
        FindNeighbours();
    }

    void FindNeighbours()
    {
        neighbours.Clear();

        Seat2[] allSeats = FindObjectsOfType<Seat2>();

        foreach (Seat2 seat2 in allSeats)
        {
            if (seat2 == this)
                continue;

            float distance = Vector3.Distance(transform.position, seat2.transform.position);

            if (distance <= neighbourDistance)
            {
                neighbours.Add(seat2);
            }
        }
    }
}


    



