using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatSelector2 : MonoBehaviour
{
    public bool WinAlo;
    public bool BackAlo;
    public bool FrontAlo;
    public bool AlleyAlo;


    public CustomerSelector2 customerSelector;
    public Seat2 seat;

    private void Awake()
    {
        if (customerSelector == null)
            customerSelector = FindObjectOfType<CustomerSelector2>();

        seat = GetComponent<Seat2>();
    }

    private void OnMouseDown()
    {
        if (customerSelector.currentCustomer == null)
            return;

        Customer customer = customerSelector.currentCustomer.GetComponent<Customer>();

        if (seat.CanSit(customer))
        {
            customer.transform.position = transform.position;

            seat.isSeatOccupied = true;
            customerSelector.isOccupied = false;
            customerSelector.currentCustomer = null;

            Debug.Log("Zákazník si sedl");
            GameManager.Instance.AddScore(200);
        }
        else
        {
            customer.transform.position = transform.position;

            seat.isSeatOccupied = true;
            customerSelector.isOccupied = false;
            customerSelector.currentCustomer = null;

            Debug.Log("Sedl si, ale špatnì");
            GameManager.Instance.AddScore(-500);
        }
    }
}
