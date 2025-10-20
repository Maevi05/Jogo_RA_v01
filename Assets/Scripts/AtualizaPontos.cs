using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtualizaPontos : MonoBehaviour
{

    void Update()
    {
        GetComponent<Text>().text = CapturaFlag.pontos.ToString();
    }
}
