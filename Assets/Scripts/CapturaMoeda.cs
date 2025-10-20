using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturaMoeda : MonoBehaviour
{
    public static int pontos=0;
    public AudioClip somMoeda;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, Time.deltaTime * 100);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bolinha")
        {
            pontos++;
            AudioSource.PlayClipAtPoint(somMoeda, GameObject.Find("Main Camera").transform.position);
            Destroy(gameObject);
        }
    }
}
