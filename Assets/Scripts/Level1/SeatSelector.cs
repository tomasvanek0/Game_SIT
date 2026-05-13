using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatSelector1 : MonoBehaviour
{
    public bool WinAlo;
    public bool BackAlo;
    public bool FrontAlo;
    public bool AlleyAlo;


    public CustomerSelector1 customerSelector1;
    public Seat1 seat;
    
    private void Awake()
    {
        if (customerSelector1 == null)
            customerSelector1 = FindObjectOfType<CustomerSelector1>();

        seat = GetComponent<Seat1>();
    }

    private void OnMouseDown()
    {
        if (CustomerSelector1.Instance.currentCustomer == null)
            return;

        Customer customer = CustomerSelector1.Instance.currentCustomer.GetComponent<Customer>();

        if (seat.CanSit(customer))
        {
            if (seat.isSeatOccupied)
            {
                Debug.Log("již obsazeno");
            }

            else
            {
                customer.transform.position = transform.position;

                seat.isSeatOccupied = true;
                seat.seatedCustomer = customer;
                CustomerSelector1.Instance.isOccupied = false;
                CustomerSelector1.Instance.currentCustomer = null;

                Debug.Log("Zákazník si sedl");
                GameManager.Instance.AddScore(200);
            }
            
        }
        else
        {
            if (seat.isSeatOccupied)
            {
                Debug.Log("již obsazeno");
            }

            else
            {
                customer.transform.position = transform.position;

                seat.isSeatOccupied = true;
                CustomerSelector1.Instance.isOccupied = false;
                CustomerSelector1.Instance.currentCustomer = null;

                Debug.Log("Sedl si, ale špatnì");
                GameManager.Instance.AddScore(-500);
            }
            
        }
    }
}
