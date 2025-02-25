using UnityEngine;

public class ExplosionControl : MonoBehaviour
{  
     [SerializeField] GameObject Explosion;
     private bool Exploded;
     [SerializeField] FlyingEnemyControl script;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Explosion.SetActive(false);
        Exploded=false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Exploded){
            Explosion.SetActive(true);
            script.EnemySpeed=0.25f;
            Invoke("destruction",2f);
        }
    }
    void destruction(){
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            Exploded=true;
            print("parate;");
        }
    }
}
