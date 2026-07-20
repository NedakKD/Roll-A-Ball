using UnityEngine;
using UnityEngine.UIElements;

public class Oscillator : MonoBehaviour
{

    public float speed = 1f; 
    public float range = 1f;

    private Vector3 startPosition;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        startPosition = transform.position;
        
        
    }

    // Update is called once per frame
    void Update()
    {

        
        transform.position = new Vector3(transform.position.x,(Random.Range(0f, 1f)* Time.time * speed)* range, transform.position.z);

        //float newY = startPosition.y + Mathf.Sin(Time.time * speed) * range;
        //transform.position = new Vector3(transform.position.x, newY, transform.position.z);
       
    }
}
