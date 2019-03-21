using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyasteroide : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject asteroid;
    public GameObject explosao;

    private float  tempo;
    public float  tempo_anim;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D asteroid) {
		
        tempo = Time.time;
        Instantiate(explosao,transform.position,Quaternion.identity);
        Destroy(asteroid.gameObject);
        distroy();

        
        
        
	}
    void distroy (){
        Destroy(this.gameObject);
        if (tempo + tempo_anim == Time.time)
        {
            Destroy(explosao.gameObject);
        }
    }
}
