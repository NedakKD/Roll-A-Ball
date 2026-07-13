using UnityEngine;
using UnityEngine.InputSystem;

public class Ballmovement : MonoBehaviour
{
    float inputX;
    float inputY;
    public int Speed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove (InputValue moveValue)
    {
        Vector2 moveVector = moveValue.Get<Vector2>();

        inputX = moveVector.x;
        inputY = moveVector.y;

    }

}

