using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int speed = 5;
    [SerializeField] SpriteRenderer sprite;
    public int jump = 5;
    Rigidbody2D rb;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float entradaX = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(entradaX * speed, rb.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space)&&touchGround()==true){
            rb.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
        if (entradaX>0){
            sprite.flipX=false;
        }
        else if(entradaX<0){
            sprite.flipX=true;
        }
    }
    private bool touchGround(){
        RaycastHit2D touches = Physics2D.Raycast(
            transform.position, Vector2.down,0.2f);

        if(touches.collider == null)
        {
            return false;
        } else{
            return true;
        }
        
    }
}
