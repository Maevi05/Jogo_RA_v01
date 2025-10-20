using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barreira : MonoBehaviour
{
    float timer = 0.0f;
    public bool barreira;
    void Start()
    {
        barreira = false;
    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        float seconds = timer % 60;
        this.transform.Translate(Mathf.Sin(timer) / 60, 0, 0);
    }
    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Bolinha")
        {
            barreira = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Bolinha")
        {
            barreira = false;
        }
    }
}
