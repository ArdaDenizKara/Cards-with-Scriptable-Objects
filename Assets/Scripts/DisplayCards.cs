using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayCards : MonoBehaviour
{
    public GameObject emptyCard;
    public Button button1;
    public Button button2;
    public Card card;
    public Text  cardNameText;
    public Text cardEnergyText;
    public Text cardDamageText;
    public Text cardHealthText;
    public Image character;
    public void Start()
    {
        cardNameText.text = card.cardName;
        cardEnergyText.text = card.energyCost.ToString();
        cardDamageText.text = card.damageValue.ToString();
        cardHealthText.text = card.healthValue.ToString();
        character.sprite = card.character;
        //GameObject.Find("EmptyCard").SetActive(true);
        emptyCard.SetActive(true);


    }
    public void setactiveCardButton()
    {
        //GameObject.Find("EmptyCard").SetActive(false);
        emptyCard.SetActive(false);

        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(true);
    }
    public void setactiveFalseCardButton()
    {
        emptyCard.SetActive(true);
        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(false);
        //GameObject.Find("EmptyCard").SetActive(true);
        
        
    }
    
}
