using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idiodic_banana : MonoBehaviour
{
    public Rigidbody2D Dipshit;
    public LayerMask grodn;
    public LayerMask wall;
    private float walljumpactive;
    private float walljumpdur;
    private bool alive = true;
    Vector3 HOME = new Vector3(-8, -31, 0);
    private bool gonk;
    private float jumpcd;
    public BoxCollider2D freem;
    public BoxCollider2D sidesd;
    private bool delayer = true;
    private float dashx;
    private string howdash;
    private float dashy;
    private bool candash;
    private bool isdash = false;
    private float dashcd;
    private float xboi;
    public GameObject moron;
    public GameObject CAMAMAMA;
    public bool trnamslate;

    // Start is called before the first frame update
    void Start()
    {

        Invoke("Delay", 0);
        Invoke("DelayCancel", 1);
        
    }

    // Update is called once per frame
    void Update()
    {

        //wiper stuff
    
        if(!delayer){
            if(jumpcd > 0.2f){
                if(iswla() || iswlaother() && !isgonk() && !isdash){
                    if(Dipshit.velocity.y < 1){
                        Dipshit.gravityScale = 0.5f;
                    
                    }

                }
                else{
                    Dipshit.gravityScale = 4f;
                }
                if(Input.GetKey(KeyCode.Z)){

                    BOINGBOING();
                } 
            }                
            
            else{
                jumpcd += Time.deltaTime;
            }
            if(isgonk()){
                
                candash = true;
            }
            if(alive){
                moron.transform.position = new Vector2(Dipshit.transform.position.x -7, Dipshit.transform.position.y - 50f);
            }
            moron.transform.position = new Vector2(Dipshit.transform.position.x - 7, moron.transform.position.y);
            

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
                        Dipshit.velocity = new Vector2(0, 15);
                    }
                    if(howdash == "D"){
                        Dipshit.velocity = new Vector2(0, -15);
                    }
                }
            //horizontal movement/movement parameters
            xboi = Dipshit.velocity.x;
            if(Input.GetKey(KeyCode.LeftArrow) && Dipshit.velocity.x < 15){

                Dipshit.transform.localEulerAngles = new Vector3(0, 180, 0);
                Dipshit.velocity = new Vector2(xboi -= 2, Dipshit.velocity.y);
                if(Dipshit.velocity.x > -1){
                    Dipshit.velocity = new Vector2(0, Dipshit.velocity.y);
                }
            }
            if(Dipshit.velocity.x < -15){
                Dipshit.velocity = new Vector2(xboi +=2, Dipshit.velocity.y);
        
            }
            if(Input.GetKey(KeyCode.RightArrow) && Dipshit.velocity.x > -15){

                Dipshit.velocity = new Vector2(xboi += 2, Dipshit.velocity.y);
                if(Dipshit.velocity.x < 1){
                    Dipshit.velocity = new Vector2(0, Dipshit.velocity.y);
                }
            if(Dipshit.velocity.x > 15){
                Dipshit.velocity = new Vector2(xboi -= 2, Dipshit.velocity.y);
            
            }


            }
            //this stops the player if they aint tryin to move
            if(Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.LeftArrow) == false && isdash == false){

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
                if(!isgonk() && Dipshit.velocity.x > 0){
                    Dipshit.velocity = new Vector2(Dipshit.velocity.x - 0.5f, Dipshit.velocity.y);

                }
                if(!isgonk() && Dipshit.velocity.x < 0){
                    Dipshit.velocity = new Vector2(Dipshit.velocity.x + 0.5f, Dipshit.velocity.y);

                }
        }

    }
    //jump velo set
    private void BOINGBOING(){
        if(isgonk()){
            Dipshit.velocity = new Vector2(Dipshit.velocity.x, 15);
        }
        else if(iswlaother() && !isgonk()){
            jumpcd = 0;
            Dipshit.velocity = new Vector2(-3.6f, 6);
        }
        else if(iswla() && !isgonk()){
            jumpcd = 0;
            Dipshit.velocity = new Vector2(3.6f, 6);
        }
        
        

    }
    //makes u not fall through floor?

    private bool isgonk(){
        RaycastHit2D raycastHit = Physics2D.BoxCast(freem.bounds.center, freem.bounds.size, 0, Vector2.down, 0.1f, grodn);
        return raycastHit.collider != null;

        Debug.Log("grounded");
    }
    
    private bool iswla(){
        RaycastHit2D raycastHit = Physics2D.BoxCast(sidesd.bounds.center, sidesd.bounds.size, 0, new Vector3(0, transform.localScale.y, 0), 0.1f, grodn);
        return raycastHit.collider != null;

        Debug.Log("wlad");
        
    }
    private bool iswlaother(){
        RaycastHit2D raycastHit = Physics2D.BoxCast(sidesd.bounds.center, sidesd.bounds.size, 0, new Vector3(0, 0, 90), 0.1f, grodn);
        return raycastHit.collider != null;

        Debug.Log("wlasdde");
    }

    //makes you die
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "die bitch"){
            dedboi();
        }
    }
    public void dedboi(){
        alive = false;
        Invoke("ogo", 0.0f);
        Invoke("DIE", 0.4f);
        Invoke("RISE_MY_CREATION", 1f);        
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
    //not sure
    public void DIE(){
        Debug.Log("dead");
        transform.position = new Vector2(-8, -2.3f);
        moron.transform.position = new Vector2(-14, moron.transform.position.y);
    }
    //death wiper
    private void ogo(){
        Invoke("boi", 0);

    }
    private void boi(){
        if(alive == false){
            moron.transform.position += new Vector3(0, 1f, 0);
            Debug.Log("Step");
            Invoke("ogo", 0.01f);

        }   
    }
    private void RISE_MY_CREATION(){
        alive = true;
        moron.transform.position = new Vector2(-14, -31);
        Debug.Log("realived");
    }
    private void Delay(){
        if(delayer){
            moron.transform.position += new Vector3(0, 1, 0);
            Invoke("Delayer2", 0.01f);
        }
    }
    private void Delayer2(){
        Invoke("Delay", 0);
    }
    private void DelayCancel(){
        delayer = false;
        moron.transform.position = new Vector2(-14, -31);
    }
}

