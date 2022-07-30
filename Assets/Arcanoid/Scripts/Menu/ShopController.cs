using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI shopText;
    [SerializeField] GameObject yesButton;

    [SerializeField] GameObject noButton;
    [SerializeField] Sprite backSprite;
    [SerializeField] Image noButtonSprite;

    private void FixedUpdate()
    {
        if(MainMenu.energyCount == 100)
        {
            shopText.text = "Your energy full!";
            yesButton.SetActive(false);

            noButton.transform.position = new Vector2 (168f, 205f);
            noButtonSprite.GetComponent<Image>().sprite = backSprite;
        }
    }
}