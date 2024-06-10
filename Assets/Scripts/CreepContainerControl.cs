using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepContainerControl : MonoBehaviour
{
    public GameObject creepPrefab;
    public float timeForCreation=2;
    public float currentTime=0;	
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void CreateCreep()
    {
        Instantiate(creepPrefab, new Vector2(Random.Range(-7.8f,7.97f),Random.Range(3.9f,0.83f)), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
 	currentTime = currentTime + Time.deltaTime;
        if(currentTime>= timeForCreation){
	currentTime= 0;
	CreateCreep();
	}
    }
}
