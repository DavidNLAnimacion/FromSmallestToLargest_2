using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //Y pues aqui es donde indicamos nuestrxs variables 
    public int NumberA; 
    public int NumberB;
    public int NumberC;

    // Start is called before the first frame update
    void Start()
    {
        ascendingNumbers(); 
    }

    private void ascendingNumbers()
    {
        if (NumberA > NumberB)
        {
            if (NumberB > NumberC)
            {
                Debug.Log("El orden de los numeros es: " + NumberC +"\t" + NumberB + "\t" + NumberA);
            }
            if (NumberB < NumberC)
            {
                Debug.Log("El orden de los numeros es: " + NumberB + "\t" + NumberC + "\t" + NumberA);
            }

        }
        if (NumberB > NumberA)
        {
            if (NumberA > NumberC)
            {
                Debug.Log("El orden de los numeros es: " + NumberC + "\t" + NumberA + "\t" + NumberB);
            }
            if (NumberA < NumberC)
            {
                Debug.Log("El orden de los numeros es: " + NumberA + "\t" + NumberC + "\t" + NumberB);
            }

        }
        if (NumberC > NumberB)
        {
            if (NumberB > NumberA)
            {
                Debug.Log("El orden de los numeros es: " + NumberA + "\t" + NumberB + "\t" + NumberC);
            }
            if (NumberB < NumberA)
            {
                Debug.Log("El orden de los numeros es: " + NumberB + "\t" + NumberA + "\t" + NumberC);
            }

        }
    }
}
