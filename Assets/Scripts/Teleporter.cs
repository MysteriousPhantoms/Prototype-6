using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public Transform newPos;

    private GameObject cyanM;
    private GameObject darkredM;
    private GameObject greenM;
    private GameObject orangeM;
    private GameObject blueM;
    private GameObject redM;
    private GameObject purpleM;
    private GameObject whiteM;
    private GameObject pinkM;
    private GameObject yellowM;



    private void Start() {

        cyanM = GameObject.FindWithTag("cyanM");
        darkredM = GameObject.FindWithTag("darkredM");
        greenM = GameObject.FindWithTag("greenM");
        orangeM = GameObject.FindWithTag("orangeM");
        blueM = GameObject.FindWithTag("blueM");
        redM = GameObject.FindWithTag("redM");
        purpleM = GameObject.FindWithTag("purpleM");
        whiteM = GameObject.FindWithTag("whiteM");
        pinkM = GameObject.FindWithTag("pinkM");
        yellowM = GameObject.FindWithTag("yellowM");


    }


    private void OnTriggerEnter2D(Collider2D other) 
    {

             if (other.gameObject.tag == "cyanM")
            {
            cyanM.transform.position = newPos.transform.position;
            }

             if (other.gameObject.tag == "darkredM")
            {
            darkredM.transform.position = newPos.transform.position;
            }

             if (other.gameObject.tag == "greenM")
            {
            greenM.transform.position = newPos.transform.position;
            }
             
             if (other.gameObject.tag == "orangeM")
            {
            orangeM.transform.position = newPos.transform.position;
            }

             if (other.gameObject.tag == "blueM")
            {
            blueM.transform.position = newPos.transform.position;
            }

             if (other.gameObject.tag == "redM")
            {
            redM.transform.position = newPos.transform.position;
            }

             if (other.gameObject.tag == "purpleM")
            {
            purpleM.transform.position = newPos.transform.position;
            }

             if (other.gameObject.tag == "whiteM")
            {
            whiteM.transform.position = newPos.transform.position;
            }

             if (other.gameObject.tag == "pinkM")
            {
            pinkM.transform.position = newPos.transform.position;
            }

             if (other.gameObject.tag == "yellowM")
            {
            yellowM.transform.position = newPos.transform.position;
            }

   
    }
   
    
    

}