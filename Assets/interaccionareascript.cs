using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interaccionareascript : MonoBehaviour
{
    public Text puntostxt;   
    public int puntosactuales = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void puntos(int puntosalimentos)
    {
        puntosactuales += puntosalimentos;
    }
    private void OnTriggerEnter(Collider other)
    {
        pickupscript pikup;
        pikup = GetComponent<pickupscript>();
        if(pikup.escomida == true)
        {
            puntos(pikup.puntosalimento);
            Destroy(other.gameObject);
            
        }
        else
        {
            puntos(pikup.puntosalimento);
        }
        Debug.Log(other);

    }
}
