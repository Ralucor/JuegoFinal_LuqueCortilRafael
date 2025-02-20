
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    [SerializeField] Transform player;
    // [SerializeField] float DetectionRadius=2f;
    [SerializeField] float EnemySpeed;
    private Vector3 originalPosition;
    private bool PlayerDetected = false;
    [SerializeField] SpriteRenderer sprite;
    float PreviousPos;
    void Start()
    {
        originalPosition =transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition=
        PlayerDetected? player.position:
        originalPosition;
        MoveToPosition(targetPosition);

        if(transform.position.x > PreviousPos){
            sprite.flipX=true;
        }
        if(transform.position.x < PreviousPos){
            sprite.flipX=false;
        }

        PreviousPos=transform.position.x;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform==player){
            PlayerDetected=true;
        }
    }
      private void OnTriggerExit2D(Collider2D other)
    {
        if(other.transform==player){
            PlayerDetected=false;
        }
    }
    private void MoveToPosition(Vector3 targetPosition){
        Vector3 direction =(targetPosition - transform.position). normalized;
        float step=EnemySpeed*Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,targetPosition,step);
    }

    // private void OnDrawGizmos(){
    //     Gizmos.color = Color.red;
    //     Gizmos.DrawWireSphere(transform.position,DetectionRadius);
    // }

}
