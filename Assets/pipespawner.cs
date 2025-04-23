using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public GameObject pipe;
    public float delay = 2;
    public float timer = 0;
    public float heightset = 10;
   
    
    void Start()
    {
        spawnpipe();
    }

   
    void Update()
    {

        

        if (timer < delay)
        {
            timer += Time.deltaTime;

        }
        else
        {
            spawnpipe();
            timer = 0;
        }
        
    }
    void spawnpipe()
    {
        float lowestpoint = transform.position.y - heightset;
        float highestpoint = transform.position.y + heightset; 
      Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }
}
