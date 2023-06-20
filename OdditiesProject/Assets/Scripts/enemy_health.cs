using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_health : MonoBehaviour
{
    // Start is called before the first frame update
    
    private int health = 100;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) {
            DestroySelf();
        }
    }

    void TakeDamage(int damage) {
        health -= damage;
    }

    void DestroySelf() {
        Debug.Log("destroyed self");
        Destroy(gameObject);
    }
}
