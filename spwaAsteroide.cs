using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwaAsteroide : MonoBehaviour
{

    private float randomX;
    private int updateSoma =0;
    public int veloSpaw;
    public GameObject AsteroidPrefab;
    //public GameObject objspaw;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        updateSoma= updateSoma+1;
        if (updateSoma >= veloSpaw)
        {
            updateSoma = 0;
            aleatorio();
        }
         //
        //UnityEngine.Random.value=(8.2,8.2)
    }
    void aleatorio()
    {
       // Debug.Log("aleatorio");
        randomX=Random.Range(-8,8);
        transform.position = new Vector3(randomX,transform.position.y);
        //Debug.Log("aleatoriospaw");
        Instantiate(AsteroidPrefab,transform.position,Quaternion.identity);
        //Debug.Log("paswouuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
    }
}
