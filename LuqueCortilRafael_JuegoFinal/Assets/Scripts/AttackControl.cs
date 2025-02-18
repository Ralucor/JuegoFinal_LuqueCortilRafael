using UnityEngine;

public class AttackControl : MonoBehaviour
{
    [SerializeField] GameObject Melee;
    void Start()
    {
        Melee.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Melee.SetActive(true);
            Invoke("FinDeAtaque", 0.75f);
        }
    }
    private void FinDeAtaque(){
        Melee.SetActive(false);
    }
}
