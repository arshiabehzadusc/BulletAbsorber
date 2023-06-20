using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Gun2D : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject FizzyRocketPrefab;
    public float bulletSpeed = 10;
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            var bullet = Instantiate(FizzyRocketPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * bulletSpeed;
        }
    }
}