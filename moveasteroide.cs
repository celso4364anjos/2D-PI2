using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveasteroide : MonoBehaviour
{
    public float velocidade_do_asteroide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        	transform.Translate(Vector3.down*velocidade_do_asteroide*Time.deltaTime);
           if (transform.position.y <= -5.3)
           {
               Destroy(this.gameObject);
           }
    }
}
