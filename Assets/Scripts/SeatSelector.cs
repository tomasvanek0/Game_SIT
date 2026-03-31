using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatSelector : MonoBehaviour
{
    public bool WinAlo;
    public bool BackAlo;
    public bool FrontAlo;
    public bool AlleyAlo;


    public CustomerSelectorT customerSelectorT;
    public Seat seat;

    private void Awake()
    {
        if (customerSelectorT == null)
            customerSelectorT = FindObjectOfType<CustomerSelectorT>();

        seat = GetComponent<Seat>();
    }

    private void OnMouseDown()
    {
        if (customerSelectorT.currentCustomer == null)
            return;

        Customer customer = customerSelectorT.currentCustomer.GetComponent<Customer>();

        if (seat.CanSit(customer))
        {
            customer.transform.position = transform.position;

            seat.isSeatOccupied = true;
            customerSelectorT.isOccupied = false;
            customerSelectorT.currentCustomer = null;

            Debug.Log("Zákazník si sedl");
            GameManager.Instance.AddScore(200);
        }
        else
        {
            customer.transform.position = transform.position;

            seat.isSeatOccupied = true;
            customerSelectorT.isOccupied = false;
            customerSelectorT.currentCustomer = null;

            Debug.Log("Sedl si, ale špatnì");
            GameManager.Instance.AddScore(-500);
        }
    }
}
