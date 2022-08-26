using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardDeck : MonoBehaviour
{
    //shows carddeck and contains rules for interaction
    public List<CardDescription> cards;
    //public Image cardDisplay;
    public GameObject cardPrefab;
    public void ClickOnDeck()
    {
        Debug.Log("deck clicked");

        if (cards.Count == 0) 
        {
            Debug.Log("stack empty");
            return;
        }

        int randomStackPosition = Random.Range(0,cards.Count);

        CardDescription pickedCard = cards[randomStackPosition];

        Debug.Log("picked card =" + pickedCard.cardpicture + "of position=" + randomStackPosition);

        cards.Remove(pickedCard);

        //cardDisplay.sprite = pickedCard.cardpicture;
        //cardDisplay.gameObject.SetActive(true);
        GameObject cardInScene = Instantiate(cardPrefab, transform.parent);
        cardInScene.GetComponent<Image>().sprite = pickedCard.cardpicture;

        if (cards.Count == 0) gameObject.SetActive(false);
    }

}
