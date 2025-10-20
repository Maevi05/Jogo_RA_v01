using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturaFlag : MonoBehaviour
{
    public static int pontos=0;
    public AudioClip somFlag;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 100,0);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bolinha")
        {
            pontos++;
            AudioSource.PlayClipAtPoint(somFlag, GameObject.Find("Main Camera").transform.position);
            Destroy(gameObject);
        }
    }
}
