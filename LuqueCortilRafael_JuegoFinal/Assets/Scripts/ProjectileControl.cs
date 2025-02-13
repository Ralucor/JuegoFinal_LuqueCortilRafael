using UnityEngine;

public class ProjectileControl : MonoBehaviour
{
    public float power= 5f;
    Rigidbody2D rb;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Limit"){
        Destroy(gameObject);}

    }
}
