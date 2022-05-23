using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    [SerializeField] private GameObject Pipe;
    [SerializeField] private float timeDuration;
    private float coutdown;
    public bool enableGeneratePipe; // cho phep sinh ra ong

    // Start is called before the first frame update
    void Awake()
    {
        coutdown = 1f;
        enableGeneratePipe = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (enableGeneratePipe)
        {
            coutdown -= Time.deltaTime;
            if (coutdown <= 0)
            {
                Instantiate(Pipe, new Vector3(10, Random.Range(-1.2f, 2.1f), 0), Quaternion.identity);
                coutdown = timeDuration;
            }
        }           
    }
}
