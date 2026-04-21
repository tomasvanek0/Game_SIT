using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomerSelector1 : MonoBehaviour
{
    public GameObject[] Customers;
    public CustomerParrent customerParrent;
    public Transform CustomerParrent;
    public bool isOccupied = false;
    public Transform CustomerPoint;
    public GameObject currentCustomer;
    public int numberOfCustomers;
    public Customer customer;
    public Level1 level1;
    public LoadLogic loadLogic;

    public static CustomerSelector1 Instance;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        CustomerParrent = CustomerParrent.Instance;
    }


private void Start()
    {
        StartCoroutine(SpawnCustomers());
        
    }

    IEnumerator SpawnCustomers()
    {
        int targetCustomers = GetRandomCustomerNumber();
        int i = 0;

        while (i <= targetCustomers)
        {
            if (!isOccupied)
            {
                SpawnCustomer();
                i++;
            }

            yield return new WaitForSeconds(1); // èekání mezi pokusy
        }
        yield return new WaitUntil(() => isOccupied == false);
        yield return new WaitForSeconds(1);
        Debug.LogWarning("Spawn dokonèen");
        LoadLogic.Instance.LoadLogicGame();

    }





    public int GetRandomCustomerNumber()
    {
             return (Random.Range(1, 12));
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
