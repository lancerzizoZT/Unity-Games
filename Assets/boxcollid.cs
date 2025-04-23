using UnityEngine;

public class boxcollid : MonoBehaviour
{
    public logic logicc;
    
    void Start()
    {
        logicc = GameObject.FindGameObjectsWithTag("logic").GetComponent<logic>();


    }

   
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
}
