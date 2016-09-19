using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    
    
    
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
	
    float moveHorizontal=Input.GetAxis("Horizontal1");
	float moveVertical=Input.GetAxis("Vertical1");
        Vector2 movement=new Vector2(moveHorizontal,moveVertical)*speed;;
        
        rb.AddForce(movement);    
    
}
    
    
    
    
    
    }
