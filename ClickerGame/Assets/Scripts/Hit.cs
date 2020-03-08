using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        GetComponent<Animator>().SetTrigger("Hit");

        GetComponent<Health>().GetHit(10);
    }
}
