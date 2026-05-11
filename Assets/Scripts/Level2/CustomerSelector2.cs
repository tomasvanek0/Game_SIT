using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomerSelector2 : MonoBehaviour
{
    public GameObject[] Customers;
    public bool isOccupied = false;
    public Transform CustomerPoint;
    public Transform CustomerParrent1;
    public CustomerParrent customerParrent;
    public GameObject currentCustomer;
    public int numberOfCustomers;
    public Customer2 customer;
    public Level2 level2;
    public LoadLogic2 loadLogic2;



    public static CustomerSelector2 Instance;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        customerParrent = CustomerParrent.Instance;
    }


    private void Start()
    {
        GameObject obj = GameObject.FindWithTag("Parrent");
        CustomerParrent1 = obj.transform;
        level2 = FindObjectOfType<Level2>();
        loadLogic2 = FindObjectOfType<LoadLogic2>();
        int MaxDeleteCustomer = Random.Range(0, CustomerParrent1.childCount);

        for (int i = 0; i < MaxDeleteCustomer; i++)
        {
            int index = Random.Range(0, CustomerParrent1.childCount);
            GameObject DelCust = CustomerParrent1.GetChild(index).gameObject;
            Destroy(DelCust);
        }



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
        level2.SceneCounter++;
        LoadLogic2.Instance.LoadLogicGame();

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
            currentCustomer.transform.SetParent(CustomerParrent1);
            currentCustomer.tag = "Customer";

        }
        
    }
}
