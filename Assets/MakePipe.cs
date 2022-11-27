using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Pipe;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newpipe = Instantiate(Pipe);
            newpipe.transform.position = new Vector3(6, Random.Range(-0.65f, 4.5f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
    }
}
