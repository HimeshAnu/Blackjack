using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DeckScript : MonoBehaviour
{
    public GameObject[] cardSprites;
    int[] cardValues = new int[53];
    int currentIndex = 0; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void GetCardValues()
    {
        int num = 0;
        //loop to assign values; 
        for (int i = 0; i < cardSprites.Length; i++)
        {
            num = i;
            //count up to the amount of cards; 
            num %= 13;

            if (num > 10 || num == 0)
            {
                num = 10;
            }
            cardValues[i] = num++; 
        }
        currentIndex = 1; 
    }

    public void Shuffle()
    {
        for(int i = cardSprites.Length - 1; i>0; --i)
        {
            int j = Mathf.FloorToInt(Random.Range(0.0f, 1.0f) * cardSprites.Length - 1) + 1;
            GameObject face = cardSprites[i];
            cardSprites[i] = cardSprites[j];
            cardSprites[j] = face;

            int value = cardValues[i];
            cardValues[i] = cardValues[j];
            cardValues[j] = value; 
        }
        
    }

    

    public GameObject GetCardBack()
    {
        return cardSprites[0]; 
    }
}
