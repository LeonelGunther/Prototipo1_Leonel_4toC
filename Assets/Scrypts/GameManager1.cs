using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager1 : MonoBehaviour
{
    public TextMeshProUGUI txtTiempo;
    public float tiempo =30f;
    // Start is called before the first frame update
    void Start()
    {
        txtTiempo.text = "Tiempo: " + tiempo;
    }

    void Update()
    {
        tiempo -= Time.deltaTime;

        txtTiempo.text = "Tiempo: " + tiempo.ToString("F2");

        if(tiempo <= 0)
        {
            Debug.Log ("Perdiste");
        }
    }
}

