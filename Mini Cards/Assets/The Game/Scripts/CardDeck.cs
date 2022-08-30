using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardDeck : MonoBehaviour
{
    //shows carddeck and contains rules for interaction
    public List<CardDescription> cards;
    public GameObject cardPrefab;
    public GameObject cardContainer;

    public bool isEmpty()
    {
        return cards.Count == 0;
    }

    public CardDescription pickRandomCard()
    {

        int randomStackPosition = Random.Range(0, cards.Count);

        CardDescription pickedCard = cards[randomStackPosition];

        Debug.Log("picked card =" + pickedCard.cardpicture + "of position=" + randomStackPosition);

        cards.Remove(pickedCard);

        return pickedCard;

    }

    public Card createCardInScene()
    {
       return Instantiate(cardPrefab, cardContainer.transform).GetComponent<Card>();
    }

    internal object createCardInSecene()
    {
        throw new System.NotImplementedException();
    }
}
