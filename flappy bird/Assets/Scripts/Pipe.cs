using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        // Vector3.left = new vector 3 (-1,0,0)
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
