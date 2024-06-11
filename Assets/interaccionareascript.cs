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
        puntostxt.text =  puntosactuales.ToString();

    }
    public void puntos(int puntosalimentos)
    {
        puntosactuales += puntosalimentos;
    }
    public void OnTriggerEnter(Collider other)
    {
           Debug.Log("OnTriggerEnter llamado con " + other.gameObject.name);
            pickupscript pikup;
            pikup = other.GetComponent<pickupscript>();
           puntos(pikup.puntosalimento);
            if (pikup.escomida == true)
            {
                Destroy(other.gameObject);

            }
          
        
    }
}
