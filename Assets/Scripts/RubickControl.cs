using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubickControl : MonoBehaviour
{
    Rigidbody2D _compRigidbody2D;
    public float speed;
    public float horizontal;
    public float vertical;
    public GameObject bulletPrefab; 
    public AudioSource _compAudioSource;
    
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        speed = PlayerPrefs.GetFloat("RubickSpeed",3);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal  = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if(Input.GetButtonDown("Fire1") ==true){
	PlayerPrefs.SetFloat("RubickSpeed", speed);
        Instantiate(bulletPrefab, transform.position, transform.rotation);
	_compAudioSource.Play();
        }
        
        
    }
    
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(speed*horizontal, speed*vertical); 
    }

}
