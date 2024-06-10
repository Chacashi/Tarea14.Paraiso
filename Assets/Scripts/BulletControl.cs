using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{    
    Rigidbody2D _compRigidbody2D;
    public float speed;
    public float DirectionY;
   
    
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(0,speed*DirectionY);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag != "Player"){
          Destroy(this.gameObject);
        }
	
    }
}
