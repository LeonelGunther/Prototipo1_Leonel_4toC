using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtScore;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScore (0);
    }

    // Update is called once per frame
 public void UpdateScore(int Score)
 {
    txtScore.text = "Score = " + Score.ToString();

    if(Score >= 3)
    {
        Debug.Log("gane");
    }
 }
}
