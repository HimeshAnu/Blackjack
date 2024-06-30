using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Button dealBtn;
    public Button hitBtn;
    public Button standBtn;
    public Button betBtn; 
    void Start()
    {
        //add on click listener
        dealBtn.onClick.AddListener(() => DealClicked());
        hitBtn.onClick.AddListener(() => HitClicked());
        standBtn.onClick.AddListener(() => StandClicked());
    }

    // Update is called once per frame
    private void StandClicked()
    {
        
    }
    private void HitClicked()
    {
     
    }
    private void DealClicked()
    {
        
    }
}
