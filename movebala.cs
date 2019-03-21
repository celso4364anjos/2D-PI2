using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebala : MonoBehaviour
{
    public float velocidade_da_bala; 
    //public GameObject layser;
      
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
       	transform.Translate(Vector3.up*velocidade_da_bala*Time.deltaTime);
           if (transform.position.y >=5.3)
           {
               Destroy(this.gameObject);
           }

 
    }
}
