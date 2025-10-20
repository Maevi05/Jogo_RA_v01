using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PasseFase : MonoBehaviour
{
    private bool fim;
    public string proximaFase;

    // Start is called before the first frame update
    void Start()
    {
        fim = false;   
    }

    private void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.name == "Bolinha")
        {
            fim = false;
            GameObject bolinha = other.gameObject;
            Destroy(bolinha.GetComponent<Rigidbody>());
            bolinha.transform.parent = GameObject.Find("Caixa").GetComponent<Transform>();
            GameObject.Find("TextoProximaFase").GetComponent<Text>().enabled = true;
            CapturaMoeda.pontos += 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(fim && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(proximaFase);
        }
    }
}
