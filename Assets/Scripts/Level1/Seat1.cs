using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Seat1 : MonoBehaviour
{
    public bool back;
    public bool front;
    public bool window;
    public bool alley;

    public bool isSeatOccupied;

    public float neighbourDistance = 0.8f;   
    public List<Seat1> neighbours = new List<Seat1>();


    public bool CanSit(Customer customer)
    {
        if (customer == null || isSeatOccupied)
            return false;

        if (customer.Blue && !window)
            return false;

        if (customer.Red && !back)
            return false;

        if (customer.Yellow && !alley)
            return false;

        if (customer.Green && !front)
            return false;

        if (customer.Triangle && neighbours.Any(n => n.isSeatOccupied))
            return false;

        return true;
    }

    void Start()
    {
        FindNeighbours();
        Collider2D hit = Physics2D.OverlapCircle(transform.position, 2);
        if (hit != null)
        {
            isSeatOccupied = true;
        }
        else
        {
            isSeatOccupied = false;
        }
    }

    

    void FindNeighbours()
    {
        neighbours.Clear();

        Seat1[] allSeats = FindObjectsOfType<Seat1>();

        foreach (Seat1 seat1 in allSeats)
        {
            if (seat1 == this)
                continue;

            float distance = Vector3.Distance(transform.position, seat1.transform.position);

            if (distance <= neighbourDistance)
            {
                neighbours.Add(seat1);
            }
        }
    }
}


    



