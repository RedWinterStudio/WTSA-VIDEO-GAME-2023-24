using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smart_banana : MonoBehaviour
{

    public Rigidbody2D Dipshit;
    public LayerMask grodn;
    public LayerMask wall;
    private bool walljumpactive;
    private int walljumpdir;
    private float walljumpdur;
    private Vector2 Spawnpoint;
    private bool alive = true;
    Vector3 HOME = new Vector3(-8, -31, 0);
    private bool gonk;

    public BoxCollider2D freem;
    public BoxCollider2D Sides;
    private bool delayer = true;
    private float dashx;
    private float dashcd;
    private string howdash;
    private float jumpcd;
    private float dashy;
    private bool candash;
    private bool isdash = false;
    private float xboi;

    public bool trnamslate;

    // Start is called before the first frame update
    void Start()
    {

        gameObject.SetActive(false);
        Invoke("ACTIVATE", 1);
    }

    // Update is called once per frame
    void Update()
    {

        //wiper stuff
        if(jumpcd > 40){
            walljumpactive = false;
            if(iswla() || iswlaother() && !isgonk() && !isdash && Input.GetKey(KeyCode.Z)){
                if(Dipshit.velocity.y < 1){
                    Dipshit.gravityScale = 0.5f;
                   
                }

            }
            else{
                Dipshit.gravityScale = 4f;
            }
           
                  
        }
        else{
            jumpcd += 1;
        }
            if(Input.GetKeyDown(KeyCode.Z)){

                BOINGBOING();
            }         
        
        if(walljumpactive){
            Dipshit.gravityScale = 4f;
        }
        if(isgonk()){
            candash = true;
        }


            

            //dash shit that sets velocity
                if(isdash == true){
                    Dipshit.gravityScale = 4;
                    if(howdash == "L"){
                        Dipshit.velocity = new Vector2(-30, 0);
                    }
                    if(howdash == "R"){
                        Dipshit.velocity = new Vector2(30, 0);
                    }
                    if(howdash == "U"){
                        Dipshit.velocity = new Vector2(0, 20);
                    }
                    if(howdash == "D"){
                        Dipshit.velocity = new Vector2(0, -15);
                    }
                }
            //horizontal movement/movement parameters
            xboi = Dipshit.velocity.x;
            if(Input.GetKey(KeyCode.LeftArrow) && Dipshit.velocity.x < 12 && walljumpactive == false){

                Dipshit.velocity = new Vector2(xboi -= 2, Dipshit.velocity.y);
                if(Dipshit.velocity.x > -1 && !walljumpactive){
                    Dipshit.velocity = new Vector2(0, Dipshit.velocity.y);
                }
            }
            if(Dipshit.velocity.x < -12){
                Dipshit.velocity = new Vector2(xboi +=2, Dipshit.velocity.y);
        
            }
            if(Input.GetKey(KeyCode.RightArrow) && Dipshit.velocity.x > -12 && walljumpactive == false){

                Dipshit.velocity = new Vector2(xboi += 2, Dipshit.velocity.y);
                if(Dipshit.velocity.x < 1 && !walljumpactive){
                    Dipshit.velocity = new Vector2(0, Dipshit.velocity.y);
                }
            if(Dipshit.velocity.x > 12){
                Dipshit.velocity = new Vector2(xboi -= 2, Dipshit.velocity.y);
            
            }


            }
            //this stops the player if they aint tryin to move
            if(Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.LeftArrow) == false && !isdash && walljumpactive == false){

                if(Dipshit.velocity.x > 0){
                    Dipshit.velocity = new Vector2(Dipshit.velocity.x - 2, Dipshit.velocity.y);
                }
                if(Dipshit.velocity.x > -2 && Dipshit.velocity.x < 2){
                    Dipshit.velocity = new Vector2(0, Dipshit.velocity.y);

                    
                }
                if(Dipshit.velocity.x < 0){
                    Dipshit.velocity = new Vector2(Dipshit.velocity.x + 2, Dipshit.velocity.y);
                }
            }
            //jump

            //makes not jump if not jump key touching
            if(Input.GetKey(KeyCode.Z) == false && Dipshit.velocity.y > 1 && isdash == false){

                Dipshit.velocity = new Vector2(Dipshit.velocity.x, 0);
            }



            //dash shit that finds if you are inputting
            if(Input.GetKey(KeyCode.C) && candash){
                if(Input.GetKey(KeyCode.LeftArrow)){
                    howdash = "L";
                    candash = false;
                    isdash = true;
                    Invoke("stahp", 0.15f);
                }
                if(Input.GetKey(KeyCode.RightArrow)){
                    howdash = "R";
                    candash = false;
                    isdash = true;
                    Invoke("stahp", 0.15f);                               
                }
                if(Input.GetKey(KeyCode.UpArrow)){
                    howdash = "U";
                    candash = false;
                    isdash = true;
                    Invoke("stahp", 0.2f);                
                }
                if(Input.GetKey(KeyCode.DownArrow)){
                    howdash = "D";
                    candash = false;
                    isdash = true;
                    Invoke("stahp", 0.2f);                
                }
                

            }
            //some sort of parameter idk what
                if(gonk == false && Dipshit.velocity.x > 0 && walljumpactive == false){
                    Dipshit.velocity = new Vector2(Dipshit.velocity.x - 0.5f, Dipshit.velocity.y);

                }
                if(gonk == false && Dipshit.velocity.x < 0 && walljumpactive == false){
                    Dipshit.velocity = new Vector2(Dipshit.velocity.x + 0.5f, Dipshit.velocity.y);

                }

                


    }
    //jump velo set
    private void BOINGBOING(){
        if(isgonk()){
            Dipshit.velocity = new Vector2(Dipshit.velocity.x, 15);
        }
        else if(iswlaother() && !isgonk() && Input.GetKey(KeyCode.RightArrow)){
            jumpcd = 0;
            Dipshit.velocity = new Vector2(-1, 13);
            walljumpactive = true;
        }
        else if(iswla() && !isgonk() && Input.GetKey(KeyCode.LeftArrow)){
            jumpcd = 0;
            Dipshit.velocity = new Vector2(1, 13);
            walljumpactive = true;
        }
        else if(iswla() && !isgonk() && Input.GetKey(KeyCode.RightArrow)){
            jumpcd = 0;
            Dipshit.velocity = new Vector2(10, 5);
            walljumpactive = true;
        }
        else if(iswlaother() && !isgonk() && Input.GetKey(KeyCode.LeftArrow)){
            jumpcd = 0;
            Dipshit.velocity = new Vector2(-10, 5);
            walljumpactive = true;
        }

        

    }
    //makes u not fall through floor?

    private bool isgonk(){
        RaycastHit2D raycastHit = Physics2D.BoxCast(freem.bounds.center, freem.bounds.size, 0, Vector2.down, 0.1f, grodn);
        return raycastHit.collider != null;
        Debug.Log("33fer");

    }
    
    private bool iswla(){
        RaycastHit2D raycastHit = Physics2D.BoxCast(Sides.bounds.center, Sides.bounds.size, 0, Vector2.left, 0.1f, grodn);
        return raycastHit.collider != null;

    }
    private bool iswlaother(){
        RaycastHit2D raycastHit = Physics2D.BoxCast(Sides.bounds.center, Sides.bounds.size, 0, Vector2.right, 0.1f, grodn);

        return raycastHit.collider != null;
       
    }
    //makes you die
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "die bitch"){
            dedboi();
        }
    }
    public void dedboi(){
        transform.position = Spawnpoint;
    }
    //stops the dash counter
    private void stahp(){
        isdash = false;
        if(Input.GetKey(KeyCode.LeftArrow)){
            Dipshit.velocity = new Vector2(-12, 0);
        }
         else if(Input.GetKey(KeyCode.RightArrow)){
            Dipshit.velocity = new Vector2(12, 0);
        }
        else{
            Dipshit.velocity = new Vector2(0, 0);
        }
        
    }
    private void RISE_MY_CREATION(){
        alive = true;

        Debug.Log("realived");
    }
    private void ACTIVATE(){
        gameObject.SetActive(true);
        Spawnpoint = transform.position;
    }


}
