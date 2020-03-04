using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleBlock : MonoBehaviour
{
    private AudioLowPassFilter sound;
    private void Awake() 
    {
        sound = GameObject.Find("Main Camera").GetComponent<AudioLowPassFilter>();
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player1") sound.cutoffFrequency = 2000f;
    }
    private void OnTriggerStay2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player1")
        {
            other.gameObject.GetComponent<AGDDPlatformer.PlayerController>().setInZone(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player1")
        {
            sound.cutoffFrequency = 5007;
            other.gameObject.GetComponent<AGDDPlatformer.PlayerController>().setInZone(false);
        }    
    }
}
