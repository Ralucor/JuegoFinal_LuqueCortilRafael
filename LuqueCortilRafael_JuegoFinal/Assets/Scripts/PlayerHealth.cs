using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health=5f;
    }

    // Update is called once per frame
    void Update()
    {
         if(health <=0){
            SceneManager.LoadScene("TestScene");
        }
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Enemy"){
            health--;
        }
        if(other.gameObject.tag=="Explosion"){
            health=health-3;
        }
       
    }
}
