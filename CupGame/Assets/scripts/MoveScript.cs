using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    float count = 0;
    int cupControl=0;
    public PermissionScript PermissionScript;
    public GameObject closeCupRot,openCupRot;
    bool leftt=false,rightt=false,backk = false,forwardd = false;
    Vector3 startPos;
    Vector3 endPos;
    Vector3 midPos;
    float rotControl;
    CupActive cupActive;
    
    void Start()
    {
        
        
    }

    
    void Update()
    {


        if (!PermissionScript.ground)
        {
            if (cupControl % 2 == 0)
            {
                transform.position = transform.position + -transform.up * 0.04f;
            }
            if (cupControl % 2 != 0)
            {
                transform.position = transform.position + transform.up * 0.04f;
            }

        }





        if (forwardd)
        {

            

            if (count < 5)
            {
                transform.position = Vector3.Lerp(Vector3.Lerp(startPos, midPos, count), Vector3.Lerp(midPos, endPos, count), count);
                transform.rotation = Quaternion.Lerp(transform.rotation, openCupRot.transform.rotation,4*Time.deltaTime);
                count = count + Time.deltaTime;
                
            }
            else
            {
                forwardd = false;
            }
        }
        if (backk)
        {

            

            if (count < 5)
            {
                transform.position = Vector3.Lerp(Vector3.Lerp(startPos, midPos, count), Vector3.Lerp(midPos, endPos, count), count);
                transform.rotation = Quaternion.Lerp(transform.rotation, openCupRot.transform.rotation, 4 * Time.deltaTime);
                count = count + Time.deltaTime;
            }
            else
            {
                backk = false;
            }
        }
        if (rightt)
        {



            if (count < 5)
            {
                transform.position = Vector3.Lerp(Vector3.Lerp(startPos, midPos, count), Vector3.Lerp(midPos, endPos, count), count);
                transform.rotation = Quaternion.Lerp(transform.rotation, openCupRot.transform.rotation, 4 * Time.deltaTime);
                count = count + Time.deltaTime;
            }
            else
            {
                rightt = false;
            }
        }
        if (leftt)
        {



            if (count < 5)
            {
                transform.position = Vector3.Lerp(Vector3.Lerp(startPos, midPos, count), Vector3.Lerp(midPos, endPos, count), count);
                transform.rotation = Quaternion.Lerp(transform.rotation, openCupRot.transform.rotation, 4 * Time.deltaTime);
                count = count + Time.deltaTime;
            }
            else
            {
                leftt = false;
            }
        }



       










        if (Input.GetKeyDown(KeyCode.W)&&PermissionScript.fwrd)
            { 
            cupControl++;
            startPos = transform.position;
            openCupRot.transform.Rotate(180, 0, 0);
            if (cupControl % 2 == 0)
            {

                endPos = transform.position + -transform.forward * 2.2f;
                midPos = transform.position + transform.forward * 1.1f +- transform.up * 5;
            }
            if (cupControl % 2 != 0)
            {

                endPos = transform.position + transform.forward * 2.2f;
                midPos = transform.position + transform.forward * 1.1f + transform.up * 5;
            }
            count = 0;

            
            
            forwardd = true;

            rotControl = 0;






        }


        if (Input.GetKeyDown(KeyCode.S)&& PermissionScript.bck)
            {
            cupControl++;
            startPos = transform.position;
            openCupRot.transform.Rotate(180, 0, 0);
            if (cupControl%2==0)
            {
                endPos = transform.position + transform.forward * 2.2f;
                midPos = transform.position + -transform.forward * 1.1f + -transform.up * 5;
            }
            if (cupControl % 2 != 0)
            {
                endPos = transform.position + -transform.forward * 2.2f;
                midPos = transform.position + transform.forward * 1.1f + transform.up * 5;
            }
            count = 0;
          
            

            backk = true;

            rotControl = 0;

        }

      
        if (Input.GetKeyDown(KeyCode.A)&& PermissionScript.lt)
            {
            cupControl++;
            startPos = transform.position;
            openCupRot.transform.Rotate(180, 0, 0);

            if (cupControl % 2 == 0)
            {
            endPos = transform.position + -transform.right * 2.2f;
            midPos = transform.position + -transform.right * 1.1f +- transform.up * 5;
            }
            if (cupControl % 2 != 0)
            {
                endPos = transform.position + -transform.right * 2.2f;
                midPos = transform.position + -transform.right * 1.1f + transform.up * 5;
            }

            count = 0;
            

         
            
            leftt = true;

            rotControl = 0;
        }
        
        
        if (Input.GetKeyDown(KeyCode.D)&& PermissionScript.rt )
            {
            cupControl++;
            startPos = transform.position;
            openCupRot.transform.Rotate(180, 0, 0);
            if(cupControl % 2 == 0)
            {
                endPos = transform.position + transform.right * 2.2f;
                midPos = transform.position + transform.right * 1.1f + -transform.up * 5;
            }
            if (cupControl % 2 != 0)
            {
                endPos = transform.position + transform.right * 2.2f;
                midPos = transform.position + transform.right * 1.1f + transform.up * 5;
            }

            count = 0;
            rightt = true;

            rotControl = 0;
            
        }
    

            
            
          


    }
    
}
