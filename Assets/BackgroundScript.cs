using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class BackgroundScript : MonoBehaviour {

	// Use this for initialization
    private int time=3;
    public Text startText;
    public Text Player1Text;
    public Text Player2Text;
    private int Player1score;
    private int Player2score;
    public GameObject Player1;
    public GameObject Player2;
    public float player1positionx;
    public float player2positionx;
    public float playerpositiony;
    
    
	void Start () {
	        StartCoroutine(Example());
startText.text=time.ToString();
        Player1score=0;
        Player2score=0;
        Player1.GetComponent<Rigidbody2D>().isKinematic=true;
        Player2.GetComponent<Rigidbody2D>().isKinematic=true;

    }
	    
    void OnTriggerExit2D(Collider2D col){
        
        if(col.gameObject.tag=="Player1"){
            Player2score++;
            Player2Text.text=Player2score.ToString();
        }
   
        if(col.gameObject.tag=="Player2"){
            Player1score++;
            Player1Text.text=Player1score.ToString();
            
        }
        resetPosition();
        
        time=3;
        startText.enabled=true;
        startText.text="3";
	    StartCoroutine(Example());
        
        
         
     }
    
    
     IEnumerator Example() {
        yield return new WaitForSeconds(1);

         if(time<=1){
             startText.text="Fight!";
        yield return new WaitForSeconds(1);

             startText.enabled=false;
               Player1.GetComponent<Rigidbody2D>().isKinematic=false;
        Player2.GetComponent<Rigidbody2D>().isKinematic=false;
         }
         
         if(time!=0){
         time--;
        print(time);
         startText.text=time.ToString();
         StartCoroutine(Example());
         }
         
     
     }
    
    void resetPosition(){
                Player1.transform.position=new Vector3(player1positionx,0,0);
                Player2.transform.position=new Vector3(player2positionx,0,0);
    Player1.GetComponent<Rigidbody2D>().isKinematic=true;
        Player2.GetComponent<Rigidbody2D>().isKinematic=true;
    }
}
    
    

