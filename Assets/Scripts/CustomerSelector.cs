using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomerSelector : MonoBehaviour
{
    public GameObject[] Customers;
    public bool isOccupied = false;
    public Transform CustomerPoint;
    public Transform CustomerParrent;
    public GameObject currentCustomer;
    public float numberOfCustomers;





    private void Update()
    {
        
            if (!isOccupied)
            {
                SpawnCustomer();
            }

        

    }




    public GameObject GetRandomCustomer()
    {
        return Customers[UnityEngine.Random.Range(0, Customers.Length)];
        
    }

    public void SpawnCustomer()
    {
        
        
            isOccupied = true;
            GameObject Customer = GetRandomCustomer();
            if (Customer != null)
            {
                currentCustomer = Instantiate(Customer, CustomerPoint);
                currentCustomer.transform.SetParent(CustomerParrent);
                currentCustomer.tag = "Customer";

            }
        
    }
}
