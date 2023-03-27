using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject cookingMenu;
    public GameObject fridgeMenu;

    public TextMeshProUGUI eggsText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateIngredient()
    {
        
    }

    public void UpdateIngredientText(int count)
    {
        eggsText.text = "Eggs: " + count;
    }

    public void ToggleCookingMenu()
    {
        cookingMenu.SetActive(!cookingMenu.activeSelf);
    }

    public void ToggleFridgeMenu()
    {
        fridgeMenu.SetActive(!fridgeMenu.activeSelf);
    }
}
