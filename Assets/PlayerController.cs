using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D rb;
    private float speed;
    public float positionx;
    public float positiony;
    void Start () {
	rb=GetComponent<Rigidbody2D>();
        speed=8.0f;
        positionx=transform.position.x;
        positiony=transform.position.y;
        

	}
	
	 void FixedUpdate(){
Movement();
 
    
    } 

    
    
    
    
void Movement(){
	
    
    
    
    
    
    
    
    
    
    float moveHorizontal=Input.GetAxis("Horizontal");
	float moveVertical=Input.GetAxis("Vertical");
        Vector2 movement=new Vector2(moveHorizontal,moveVertical)*speed;;
        
        rb.AddForce(movement);    
    
}
    
    
    
    

  
}
