using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupActive : MonoBehaviour
{
    
    public GameObject cup1, cup2, cup3,finish;
    public int sayac = 0;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="standCup")
        {
            if(sayac == 0)
            {
            cup1.SetActive(true);
            }
            if (sayac == 1)
            {
                cup2.SetActive(true);
            }
            if (sayac == 2)
            {
                cup3.SetActive(true);
                
            }
           
            Destroy(other.gameObject); 
            sayac++;
        }
    }
}
