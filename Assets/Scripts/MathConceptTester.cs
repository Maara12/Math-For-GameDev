using System;
using Unity.Mathematics;
using UnityEngine;

public class MathConceptTester : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            RoundNumber();
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            CeilNumber();
        }
        if(Input.GetKeyDown(KeyCode.Y))
        {
            FloorNumber();
        }
    }

    #region CHAPTER 1 ADDITION AND SUBTRACTION
        
    
      
    public int a = 2147483640;

    public void CheckINtValueOverFlowInConsole()
    {
        a = a + 1;
        Debug.Log(a);
    }

    #endregion 

    #region CHAPTER 2 ROUNDING, CEILING AND FLOOR
        
    public float numberToApproximate = 6.283f;

    public void RoundNumber()
    {
        Debug.Log("Rounded number: " + Math.Round(numberToApproximate,2)); // general use
        Debug.Log("Rounded number: " + Mathf.Round(numberToApproximate * 100) / 100); // used for and floats, good for performance
    }

    public void FloorNumber()
    {
        Debug.Log("Floored number: " + Mathf.Floor(numberToApproximate));
    }

    public void CeilNumber()
    {
        Debug.Log("Ceiled number: " + Mathf.Ceil(numberToApproximate));
    }

    #endregion
    
    
}
