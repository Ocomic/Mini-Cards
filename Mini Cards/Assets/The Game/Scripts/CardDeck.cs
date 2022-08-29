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
    public int remainingTurns = 4;
    public Text help;

    private void actualizeHelpText()
    {
        if (remainingTurns == 0)
        {
            help.text = "Sieh dir die Karten an, die du gezogen hast.";
        }
        else
        {
            help.text = "Ziehe " + remainingTurns + " Karten!";
        }
        
    }

    private void Start()
    {
        actualizeHelpText();
    }

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
        remainingTurns -= 1; // is the same like remainingTurns = remainingTurns - 1; 

                GameObject cardInScene = Instantiate(cardPrefab, cardContainer.transform);
        cardInScene.GetComponent<Card>().setDescription(pickedCard, true);
        
        actualizeHelpText();


        if (cards.Count == 0 || remainingTurns == 0) gameObject.SetActive(false);
    }

}
