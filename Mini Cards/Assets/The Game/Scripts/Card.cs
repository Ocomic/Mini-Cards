using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class Card : MonoBehaviour
{
    //image of turned card
    private CardDescription description;

    //sets a new value to card display
    //card is visible immediately
    //param newDescription = new value of card
    //param canBeClicked = when true -> play animation of turning card
    public void setDescription(CardDescription newDescription, bool canBeClicked)
    {
        description = newDescription; 
        if (!canBeClicked)
        {
            GetComponent<Image>().sprite = newDescription.cardpicture;
        }
         
        GetComponent<Button>().enabled = canBeClicked;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private bool CardTurned()
    {
        return GetComponent<Image>().sprite == description.cardpicture;
    }

    private bool StartTurning()
    {
        return GetComponent<PlayableDirector>().state == PlayState.Playing;
    }
    public void OnClick()
    {
        if (CardTurned() || StartTurning()) { return; }

        Debug.Log("OnClick works");

        GetComponent<PlayableDirector>().Play();
                
    }

    public void ChangePicture()
    {
        if (Application.isPlaying)
        {
            Debug.Log("change picture");
            GetComponent<Image>().sprite = description.cardpicture;
        }
    }
}
