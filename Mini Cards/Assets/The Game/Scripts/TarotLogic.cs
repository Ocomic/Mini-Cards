using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TarotLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public int remainingTurns
    {
        get { return container.Count; }
    }
    public Text help;
    public List<GameObject> container;

    private void Start()
    {
        actualizeHelpText();
    }
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
            
            

        deck.cardContainer = container[0];
        container.RemoveAt(0);

            deck.createCardInScene().setDescription(pickedCard, true);

            actualizeHelpText();


            if (deck.cards.Count == 0 || remainingTurns == 0) gameObject.SetActive(false);
    }


}
