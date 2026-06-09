using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
        Time.timeScale = 1f;
        UpdateScore(0);

        perdiste.gameObject.SetActive(false);
        ganaste.gameObject.SetActive(false);
    }

    void Update()
    {
        updatetime();


        if (!vivo && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void UpdateScore(int Score)
    {
        txtScore.text = "Score = " + Score.ToString();

        if (Score >= 3)
        {
            Debug.Log("gane");
            vivo = false;
            ganaste.gameObject.SetActive(true);

            Time.timeScale = 0f; 
        }
    }

    public void updatetime()
    {
        if (vivo)
        {
            TXT_Time.text = "Tiempo = " + tiempo.ToString("F2");
            tiempo -= Time.deltaTime;
        }

        if (tiempo < 0)
        {
            vivo = false;
            perdiste.gameObject.SetActive(true);

            Time.timeScale = 0f; 
        }
    }
}