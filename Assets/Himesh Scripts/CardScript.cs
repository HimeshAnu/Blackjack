using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public int value = 0; 

    public int GetValueOfCard()
    {
        return value; 
    }

    public void SetValue(int newvalue)
    {
        value = newvalue; 
    }

    public string GetSpriteName()
    {
        return gameObject.name; 
    }

   

    public void ResetCard()
    {
        // Find the DeckController GameObject
        GameObject deckController = GameObject.Find("DeckController");

        // Retrieve the back GameObject from the DeckScript
        GameObject back = deckController.GetComponent<DeckScript>().GetCardBack();

       
        back.transform.SetParent(this.transform);
        value = 0; 
    }
}
