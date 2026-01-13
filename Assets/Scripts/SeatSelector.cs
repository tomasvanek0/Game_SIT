using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatSelector : MonoBehaviour
{

    public CustomerSelector customerSelector;

    private void OnMouseDown()
    {

        if (customerSelector.currentCustomer != null && customerSelector.isOccupied && customerSelector.currentCustomer.gameObject.tag == "Customer" )
        {
            if (gameObject.tag == "Plno")
            {

            }
            else
            {
                customerSelector.currentCustomer.transform.position = transform.position;

                customerSelector.isOccupied = false;

                customerSelector.currentCustomer.gameObject.tag = "Untagged";
                customerSelector.currentCustomer = null;
                Debug.Log("Zákazník pøesazen");
                gameObject.tag = "Plno";
            }
        }
    }
}
