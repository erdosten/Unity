using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public int health;
    public float time;
    void Start()
    {
        
    }
    void Update()
    {
        time -= Time.deltaTime;
        Debug.Log("Time" + time);
        if (health > 0 && time > 0)
        {
            transform.localScale += new Vector3(0.4f, 0.4f, 0.4f) * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        health--;
    }
}
