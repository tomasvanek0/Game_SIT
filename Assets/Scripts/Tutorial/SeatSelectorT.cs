using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatSelectorT : MonoBehaviour
{
    public bool WinAlo;
    public bool BackAlo;
    public bool FrontAlo;
    public bool AlleyAlo;


    public CustomerSelectorT customerSelector1;
    public SeatT seat;

    private void Awake()
    {
        if (customerSelector1 == null)
            customerSelector1 = FindObjectOfType<CustomerSelectorT>();

        seat = GetComponent<SeatT>();
    }

    private void OnMouseDown()
    {
        if (customerSelector1.currentCustomer == null)
            return;

        CustomerT customer = customerSelector1.currentCustomer.GetComponent<CustomerT>();

        if (seat.CanSit(customer))
        {
            customer.transform.position = transform.position;

            seat.isSeatOccupied = true;
            customerSelector1.isOccupied = false;
            customerSelector1.currentCustomer = null;

            Debug.Log("Zákazník si sedl");
            GameManager.Instance.AddScore(200);
        }
        else
        {
            customer.transform.position = transform.position;

            seat.isSeatOccupied = true;
            customerSelector1.isOccupied = false;
            customerSelector1.currentCustomer = null;

            Debug.Log("Sedl si, ale špatnì");
            GameManager.Instance.AddScore(-500);
        }
    }
}
