using UnityEngine;
using System.Collections;

public class MulticastScript : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;

    void Start()
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if(myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    void PowerUp()
    {
        print ("Orb is powering up!");
    }

    void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}