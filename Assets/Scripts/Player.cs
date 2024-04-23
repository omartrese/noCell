using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public bool usingCell, gameEnd;
    
    void Start()
    {
        gameEnd = false;
        usingCell = false;
    }

    void Update()
    {

        if (gameEnd)
        {
            return;
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            usingCell = true;
            print("estas usando el movil en clase cabroooon");
        }
        else
        {
            usingCell = false;
            print("Qué buen alumno tan responsable que eres");
        }
    }
}
