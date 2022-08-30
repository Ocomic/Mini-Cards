using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickCard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickOnDeck()
    {

        CardDeck deck = GetComponent<CardDeck>();

        Debug.Log("deck clicked");

        if (deck.isEmpty())
        {
            Debug.Log("stack empty");
            return;
        }

        CardDescription pickedCard = deck.pickRandomCard();

        deck.createCardInScene().setDescription(pickedCard, true);

        


        if (deck.cards.Count == 0) gameObject.SetActive(false);
    }
}
