using UnityEngine;
using UnityEngine.UIElements;

public class Oscillator : MonoBehaviour
{

    public float speed; 
    public float range;

    private Vector3 startPosition;
    private Vector3 Movement;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        startPosition = transform.position;// + Random.Range(0f,1f) * Vector3.up;
        transform.position += Vector3.up * Random.Range( range - 1, range);
        Movement = Vector3.up * speed;

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= startPosition.y + range)
        {
            Movement = Vector3.down * speed;
        }
        else if (transform.position.y <= startPosition.y - range)
        {
            Movement = Vector3.up * speed;
        }

        transform.position += Movement * Time.deltaTime;
        
        

        //float newY = startPosition.y + Mathf.Sin(Time.time * speed) * range;
        //transform.position = new Vector3(transform.position.x, newY, transform.position.z);
       
    }
}
