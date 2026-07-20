using UnityEngine;
using UnityEngine.UIElements;

public class Oscillator : MonoBehaviour
{

    public float speed = 1f; 
    public float range = 1f;
    public GameObject Gobject;
    private Random.Range(float min, float max)

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,rand,0)* Time.deltaTime);
    }
}
