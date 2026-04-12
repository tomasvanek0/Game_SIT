using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seat : MonoBehaviour
{
    public bool back;
    public bool front;
    public bool window;
    public bool alley;

    public bool isSeatOccupied;

    public float neighbourDistance = 0.8f;   
    public List<Seat> neighbours = new List<Seat>();


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

        return true;
    }

    void Start()
    {
        FindNeighbours();
    }

    void FindNeighbours()
    {
        Seat[] allSeats = FindObjectsOfType<Seat>();

        foreach (Seat seat in allSeats)
        {
            if (seat == this)
                continue;

            float distance = Vector3.Distance(transform.position, seat.transform.position);

            if (distance <= neighbourDistance)
            {
                neighbours.Add(seat);
            }
        }
    }
}


    



