using UnityEngine;

public class ShootingControl : MonoBehaviour
{
    public Vector2 DragStart;
    public Vector2 DragEnd;
    public Vector2 Launch;
    [SerializeField] GameObject bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            DragStart =Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if(Input.GetMouseButton(0)){

        }
        if(Input.GetMouseButtonUp(0)){
            DragEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Launch=(DragStart-DragEnd);
            Instantiate(bullet,
             new Vector3(transform.position.x, 
             transform.position.y, 0),
             Quaternion.identity);
        }
    }
}
