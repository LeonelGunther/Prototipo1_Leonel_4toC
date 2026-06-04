using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    public TextMeshProUGUI TXT_Time;
    public float tiempo = 15f;
    public bool vivo = true;
    public Canvas perdiste;
    public Canvas ganaste;

    void Start()
    {
        UpdateScore(0);
    }

    void Update()
    {
        updatetime();
    }

    public void UpdateScore(int Score)
    {
        txtScore.text = "Score = " + Score.ToString();

        if (Score >= 3)
        {
            Debug.Log("gane");
            vivo = false; 
            ganaste.gameObject.SetActive(true);
        }
    }

    public void updatetime()
    {
        if ( vivo == true) {
        TXT_Time.text = "Tiempo = " + tiempo.ToString("F2");
        tiempo -= Time.deltaTime;
        }

        if (tiempo < 0){

        perdiste.gameObject.SetActive(true);


        }

        
        
    }
}