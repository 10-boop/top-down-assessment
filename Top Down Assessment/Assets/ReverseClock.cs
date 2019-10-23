using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReverseClock : MonoBehaviour
{
    public float timer = 0;
    public float ontime = 20;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > ontime)

        {
            GetComponent<Canvas>().enabled = true;
        }
    }
}
