using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PermissionScript : MonoBehaviour
{
   public bool lt, rt, fwrd, bck,ground=false;

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "dontL"|| other.tag == "dontR" || other.tag == "dontF" || other.tag == "dontB" || other.tag == "dontLR" || other.tag == "dontFB" || other.tag == "dontLF" || other.tag == "dontBL" || other.tag == "dontRB" || other.tag == "dontRF" || other.tag == "cube")
        {
            lt = false;
            rt = false;
            fwrd = false;
            bck = false; 
            ground = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "dontL")
        {
            lt = false;
            rt = true;
            fwrd = true;
            bck = true;
            ground = true;
        }
        if (other.tag == "dontR")
        {
            lt = true;
            rt = false;
            fwrd = true;
            bck = true;
            ground = true;
        }
        if (other.tag == "dontF")
        {
            lt = true;
            rt = true;
            fwrd = false;
            bck = true;
            ground = true;
        }
        if (other.tag == "dontB")
        {
            lt = true;
            rt = true;
            fwrd = true;
            bck = false;
            ground = true;
        }
        if (other.tag == "dontLR")
        {
            lt = false;
            rt = false;
            fwrd = true;
            bck = true;
            ground = true;
        }
        if (other.tag == "dontFB")
        {
            lt = true;
            rt = true;
            fwrd = false;
            bck = false;
            ground = true;
        }
        if (other.tag == "dontLF")
        {
            lt = false;
            rt = true;
            fwrd = false;
            bck = true;
            ground = true;
        }
        if (other.tag == "dontBL")
        {
            lt = false;
            rt = true;
            fwrd = true;
            bck = false;
            ground = true;
        }
        if (other.tag == "dontRB")
        {
            lt = true;
            rt = false;
            fwrd = true;
            bck = false;
            ground = true;
        }
        if (other.tag == "dontRF")
        {
            lt = true;
            rt = false;
            fwrd = false;
            bck = true;
            ground = true;

        }
        if (other.tag == "dontRLB")
        {
            lt = false;
            rt = false;
            fwrd = true;
            bck = false;
            ground = true;

        }
        if (other.tag == "dontRLF")
        {
            lt = false;
            rt = false;
            fwrd = false;
            bck = true;
            ground = true;

        }
        if (other.tag == "cube")
        {
            lt = true;
            rt = true;
            fwrd = true;
            bck = true;
            ground = true;

        }
        
    }
}
    
        

