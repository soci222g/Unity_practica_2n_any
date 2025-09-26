using UnityEngine;

public class characterControler : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up*100, ForceMode2D.Impulse);
        }
    }
/*
    private void FixedUpdate()
    {
        Vector2 forceDirection = Vector2.right;
        float forceStrenth = 10.0f;
        GetComponent<Rigidbody2D>().AddForce(forceDirection * forceStrenth);
    }*/
}
