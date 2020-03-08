using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject Bee;
    public int _MaxHealth = 100;
    public int _Health = 100;

    GameSc _gameSc;
    // Start is called before the first frame update
    void Start()
    {
        _gameSc = GameObject.FindObjectOfType<GameSc>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetHit(int damage)
    {
        int health = _Health - damage;
        _gameSc.PlayerScore += 1;
        if (health <= 0)
        {
            //Destroy(gameObject);
            //Instantiate(gameObject);
        }
        _Health = health;
        Debug.Log("Health =" + _Health);
    }
}
