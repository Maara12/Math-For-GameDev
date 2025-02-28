using System;
using Unity.Mathematics;
using UnityEngine;

public class MathConceptTester : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
           PowerOfNumber();
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
    
    #region CHAPTER 5 REMAINDER AND MODULO


    public void FindPlayerTurn()
    {
        int randomNUm = UnityEngine.Random.Range(1, 100);

        if(randomNUm % 4 == 0)
        {
            Debug.Log("Player 1 turn");
        }
        else if(randomNUm % 4 == 1)
        {
            Debug.Log("Player 2 turn");
        }
        else if(randomNUm % 4 == 2)
        {
            Debug.Log("Player 3 turn");
        }
        else if(randomNUm % 4 == 3)
        {
            Debug.Log("Player 4 turn");
        }
    }

    #endregion

    #region CHAPTER 6 POWER AND EXPONENTIATION


    public void PowerOfNumber()
    {
        Debug.Log("2^24: " + Mathf.Pow(2,24));
    }

    #endregion

}
