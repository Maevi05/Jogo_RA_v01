using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Areia_reinicio : MonoBehaviour
{
    private Vector3 posInicial;
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.localPosition;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Bolinha")
        {
            other.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
            GameObject.Find("Campo").transform.localRotation = new Quaternion(0f, 0f, 0f, 0f);
            other.transform.localPosition = posInicial;
        }
    }
}
