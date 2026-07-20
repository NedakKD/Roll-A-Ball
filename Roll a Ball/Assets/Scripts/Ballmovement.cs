using UnityEngine;
using UnityEngine.InputSystem;

public class Ballmovement : MonoBehaviour
{
    Rigidbody rb;

    float inputX;
    float inputY;

    float Speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(inputX, 0f, inputY);
        
        rb.AddForce(movement * Speed);

    }

    void OnMove (InputValue moveValue)
    {
        Vector2 moveVector = moveValue.Get<Vector2>();

        inputX = moveVector.x;
        inputY = moveVector.y;

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collectible") 
        {
            other.gameObject.SetActive(false);
        }
    }
}

