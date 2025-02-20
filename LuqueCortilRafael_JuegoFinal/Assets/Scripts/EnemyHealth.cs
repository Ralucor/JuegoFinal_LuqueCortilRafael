using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyHealth : MonoBehaviour
{
   [SerializeField] float Health;
   [SerializeField] GameObject player;
   Rigidbody2D rb;
   [SerializeField] float Knockback=15f;
   
    void Start()
    {
        Health = 20f;
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Health <=0){
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Projectile"){
            Health = Health -2;
        }
        if(other.gameObject.tag =="melee"){
            Health--;
            rb.AddForce((transform.position - player.transform.position)*Knockback, ForceMode2D.Impulse);
        }
    }
}
