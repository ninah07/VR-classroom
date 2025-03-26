using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpScript : MonoBehaviour
{

    public GameObject CameraOnPlayer;
    
    void Start()
    {
        CameraOnPlayer.SetActive(false); 
    }

    private void OnTriggerStay (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.C))
            {
                this.gameObject.SetActive(false);
                CameraOnPlayer.SetActive(true);
            }
        }
    }
}

