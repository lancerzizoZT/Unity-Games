using UnityEngine;

public class pipe : MonoBehaviour
{
    public float deadzone = -45;
    public float movespeed = 8;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * movespeed) * Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);

        }

    }
}
