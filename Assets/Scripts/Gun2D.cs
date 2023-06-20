using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Gun2D : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject FizzyRocketPrefab;
    public float bulletSpeed = 10;
    private PlayerMovement player;

    void Start() {
        player = GetComponent<PlayerMovement>();

    }
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            string selectedWeapon = "FizzyRocket";
            GameObject selectedPrefab = FizzyRocketPrefab;
            // make sure selectedWeapon is available in gadgets
            Dictionary<string, int> available_gadgets = player.getGadgets();
            if (available_gadgets.ContainsKey(selectedWeapon)) { 
                int num_available = available_gadgets[selectedWeapon];
                if (num_available > 0) {
                    // remove one ammo
                    player.setGadgetItem(selectedWeapon, num_available - 1);
                    // shoot ammo
                    var bullet = Instantiate(selectedPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                    bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.right * bulletSpeed;
                }
            }
        }
    }
}