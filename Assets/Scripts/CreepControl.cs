using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepControl : MonoBehaviour
{
    public float speed;
    public float directionY;
    Animator _compAnimator;
    Rigidbody2D _compRigidbody2D;
     void Awake()
    {
	_compRigidbody2D = GetComponent<Rigidbody2D>();
        _compAnimator= GetComponent<Animator>();
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
        _compRigidbody2D.velocity = new Vector2(0,speed*directionY);
    } 

    void OnTriggerEnter2D(Collider2D collider){
	if(collider.gameObject.tag == "Bullet"){
	  _compAnimator.SetTrigger("isDestroying");
	  Destroy(this.gameObject,1);
	}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "Player" || collision.gameObject.tag==  "Wall"){
        _compAnimator.SetTrigger("isDestroying");
        Destroy(this.gameObject,1);
	}
    }
    

}
