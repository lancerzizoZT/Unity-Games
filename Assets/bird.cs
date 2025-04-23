using Unity.Hierarchy;
using UnityEngine;

public class bird : MonoBehaviour
{
    public Rigidbody2D myrigid;
    public float jumpstrength = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space ) == true)
        {
            myrigid.linearVelocity = (Vector2.up * jumpstrength);
;
        }
    }
}
