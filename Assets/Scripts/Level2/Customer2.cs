using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Customer2 : MonoBehaviour
{
    public bool Red;
    public bool Green;
    public bool Blue;
    public bool Yellow;

    public bool Round;
    public bool Square;
    public bool Triangle;
    public bool Diamond;



    public SeatSelector2 seatSelector;
    public void TypeCustomer()
    {
        if (Red)
        {
            if (Round)
            {

            }
            else if (Square)
            {

            }
            else if (Triangle)
            {
                seatSelector.BackAlo = true;
            }
            else if (Diamond)
            {

            }
        }
        else if (Green)
        {
            if (Round)
            {

            }
            else if (Square)
            {

            }
            else if (Triangle)
            {
                seatSelector.FrontAlo = true;
            }
            else if (Diamond)
            {

            }
        }
        else if (Blue)
        {
            if (Round)
            {

            }
            else if (Square)
            {

            }
            else if (Triangle)
            {
                seatSelector.WinAlo = true;
            }
            else if (Diamond)
            {

            }
        }
        else if (Yellow)
        {
            if (Round)
            {

            }
            else if (Square)
            {

            }
            else if (Triangle)
            {
                seatSelector.AlleyAlo = true;
            }
            else if (Diamond)
            {

            }
        }
        else { }
    }
}
