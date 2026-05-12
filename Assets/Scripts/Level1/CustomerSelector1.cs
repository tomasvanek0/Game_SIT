using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustomerSelector1 : MonoBehaviour
{
    public GameObject[] Customers;
    public bool isOccupied = false;
    public Transform CustomerPoint;
    public Transform CustomerParrent1;
    public CustomerParrent customerParrent;
    public GameObject currentCustomer;
    public int numberOfCustomers;
    public Customer customer;
    public Level1 level1;
    public LoadLogic loadLogic;
    public Transform Seats;
    public Seats seats;


    public static CustomerSelector1 Instance;
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
        seats = FindObjectOfType<Seats>();
        GameObject obj = GameObject.FindWithTag("Parrent");
        CustomerParrent1 = obj.transform;
        level1 = FindObjectOfType<Level1>();
        loadLogic = FindObjectOfType<LoadLogic>();
        int MaxDeleteCustomer = Random.Range(0, CustomerParrent1.childCount);

        for (int i = 0; i < MaxDeleteCustomer; i++)
        {
            int index = Random.Range(0, CustomerParrent1.childCount);
            GameObject DelCust = CustomerParrent1.GetChild(index).gameObject;
            Destroy( DelCust );
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
        level1.SceneCounter++;
        LoadLogic.Instance.LoadLogicGame();

    }





    public int GetRandomCustomerNumber()
    {
        GameObject seatsParrent = GameObject.FindWithTag("Seats");
        Seats = seatsParrent.transform;
        List<Transform> freeSeats = new List<Transform>();

        int maxNumber = Seats.childCount;
        Debug.Log("Pocet deti: " + maxNumber);

        foreach (Transform seat in Seats)
        {
            Seat1 seatScript = seat.GetComponent<Seat1>();

            if (seatScript != null && !seatScript.isSeatOccupied)
            {
                Debug.Log("Occupied: " + seatScript.isSeatOccupied);
                freeSeats.Add(seat);
            }
        }


        maxNumber = freeSeats.Count;
        Debug.Log(maxNumber);
        return (Random.Range(1, maxNumber));
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
