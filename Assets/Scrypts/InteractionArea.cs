using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public int score = 0;
    public UIManager uiMaragerScript;


void Awake(){
    uiMaragerScript = GameObject.FindObjectOfType<UIManager>() ;
}

    void OnTriggerEnter(Collider other){
        Debug.Log(other.gameObject.name);
            if (other.gameObject.CompareTag("Collectible")){
                Destroy(other.gameObject);
                score ++;
                uiMaragerScript.UpdateScore(score);
            }
    }
}
