using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clock : MonoBehaviour
{
    public float timer = 0;
    public float ontime = 20;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

         if (timer > ontime)
                
        {
            GetComponent<Canvas>().enabled = false;
        }
    }
}
