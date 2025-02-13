using UnityEngine;
using UnityEngine.WSA;

public class ProjectileControl : MonoBehaviour
{
    public float power= 5f;
    Rigidbody2D rb;
    GameObject weapon;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
       weapon=GameObject.FindGameObjectWithTag("weapon");
       
       rb.AddForce(weapon.GetComponent<ShootingControl>().Launch * power, ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Limit"){
        Destroy(gameObject);}

    }
}
