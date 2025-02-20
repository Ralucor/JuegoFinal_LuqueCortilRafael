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
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag=="Enemy"){
            health--;
        }
        if(health <=0){
            SceneManager.LoadScene("TestScene");
        }
    }
}
