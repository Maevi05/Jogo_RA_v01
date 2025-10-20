using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilador : MonoBehaviour
{
    Barreira par;
    public float velocidade=0;
    private Vector3 posInicial;

    void Start()
    {
        posInicial = transform.localPosition;
        par = GameObject.Find("Barreira").GetComponent<Barreira>();
    }
    void OnTriggerStay(Collider collision)
    {
        Debug.Log("Entrou no trigger");
        if (collision.gameObject.name == "Bolinha")
        {
            if (par.barreira == false)
            {
                collision.GetComponent<Rigidbody>().velocity += new Vector3(0f, 0f, velocidade);
            }
            else
            {
                Debug.Log("Deu certo!");
            }
        }
    }
}
