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
    public Customer seatedCustomer;
    public float neighbourDistance = 0.8f;   
    public List<Seat1> neighbours = new List<Seat1>();


    public bool CanSit(Customer customer)
    {
        // Obsazené místo nebo neexistující zákazník
        if (customer == null || isSeatOccupied)
            return false;

        // BARVY
        if (customer.Blue && !window)
            return false;

        if (customer.Red && !back)
            return false;

        if (customer.Yellow && !alley)
            return false;

        if (customer.Green && !front)
            return false;

        // TVARY

        // Triangle chce být sám
        if (customer.Triangle && neighbours.Any(n => n.isSeatOccupied))
            return false;

        if (neighbours.Any(n => n.isSeatOccupied && n.seatedCustomer != null && n.seatedCustomer.Triangle))
            return false;

        return true;
    }

    void Start()
    {
        FindNeighbours();
        Collider2D hit = Physics2D.OverlapCircle(transform.position, 1);
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


    



