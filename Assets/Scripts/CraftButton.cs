using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftButton : MonoBehaviour
{
    public Button openCraftMenu;
    public Button fizzyrocket;
    public Button weapon2;
    public Button weapon3;
    // Start is called before the first frame update
    void Start()
    {
        openCraftMenu.onClick.AddListener(EnableButtons);

        DisableButtons();

        fizzyrocket.onClick.AddListener(createFizzyRocket);
        weapon2.onClick.AddListener(createWeapon2);
        weapon3.onClick.AddListener(createWeapon3);
    }

    private void EnableButtons() {
        fizzyrocket.gameObject.SetActive(true);
        weapon2.gameObject.SetActive(true);
        weapon3.gameObject.SetActive(true);

        openCraftMenu.onClick.RemoveListener(EnableButtons);
        openCraftMenu.onClick.AddListener(DisableButtons);

    }

    private void DisableButtons() {
        openCraftMenu.onClick.AddListener(EnableButtons);

        fizzyrocket.gameObject.SetActive(false);
        weapon2.gameObject.SetActive(false);
        weapon3.gameObject.SetActive(false);
    }

    private void createFizzyRocket() {

    }

    private void createWeapon2() {

    }
    private void createWeapon3() {
        
    }
}
