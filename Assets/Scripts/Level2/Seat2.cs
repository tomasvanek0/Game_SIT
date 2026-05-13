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

    public Customer2 seatedCustomer;

    public bool CanSit(Customer2 customer)
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

        // Diamond chce mít souseda
        if (customer.Diamond && !neighbours.Any(n => n.isSeatOccupied))
            return false;

        return true;
    }

    void Start()
    {
        FindNeighbours();
        Collider2D hit = Physics2D.OverlapCircle(transform.position, 0.1f);
        if (hit != null)
        {
            isSeatOccupied = true;
        }
        else
        {
            isSeatOccupied = false;
        }
    }

    private void Update()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, 0.1f);
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


    



