using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CardDeck deck = GetComponent<CardDeck>();
        doubleCardsIn(deck);

        while(!deck.isEmpty())
        {
            CardDescription pickedCard = deck.pickRandomCard();
            deck.createCardInScene().setDescription(pickedCard, true);
        }
        

        gameObject.SetActive(false);
    }

    private void doubleCardsIn(CardDeck deck)
    {
        for(int i=deck.cards.Count-1; i>=0; i--)
        {
            CardDescription card = deck.cards[i];
            deck.cards.Add(card);
        }
    }

    
}
