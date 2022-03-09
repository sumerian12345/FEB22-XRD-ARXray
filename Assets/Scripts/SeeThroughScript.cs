using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeeThroughScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.renderQueue = 3002; // gets the mesh renderer component > material queue > changes the queue to 3002
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
