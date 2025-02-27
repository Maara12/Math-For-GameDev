using UnityEngine;

public class MathConceptTester : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            CheckINtValueOverFlowInConsole();
        }
    }

    //CHAPTER 1 ADDITION AND SUBTRACTION
      
    public int a = 2147483640;

    public void CheckINtValueOverFlowInConsole()
    {
        a = a + 1;
        Debug.Log(a);
    }
}
