using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatSelector : MonoBehaviour
{
    public bool WinAlo;
    public bool BackAlo;
    public bool FrontAlo;
    public bool AlleyAlo;


    public CustomerSelector customerSelector;
    public Seat seat;

    private void Awake()
    {
        if (customerSelector == null)
            customerSelector = FindObjectOfType<CustomerSelector>();

        seat = GetComponent<Seat>();
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
            Debug.Log("Tady sedìt nemùže");
            GameManager.Instance.AddScore(-500);
        }
    }
}
