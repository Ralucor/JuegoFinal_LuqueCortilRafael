using UnityEngine;
using UnityEngine.Animations;

public class FlyingEnemyControl : MonoBehaviour
{
    [SerializeField] public float EnemySpeed;
    bool PlayerDetected = false;
    [SerializeField] Transform Player;



    // Update is called once per frame
    void Update()
    {
        if(PlayerDetected){
            MoveToPosition();
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.transform==Player){
            PlayerDetected=true;
        }

    }


    private void MoveToPosition(){
        float step=EnemySpeed*Time.deltaTime;
        transform.parent.Translate(Vector3.down*step);
    }
}
