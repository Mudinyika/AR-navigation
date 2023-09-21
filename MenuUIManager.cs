using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIManager : MonoBehaviour
{
    [SerializeField] private GameObject eventPanelUserInRange;
    [SerializeField] private GameObject attractionsPanel;
    [SerializeField] private GameObject restuarantPanel;
    [SerializeField] private GameObject toiletsPanel;
    [SerializeField] private GameObject parkingPanel;
    bool isUIPanelActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenButtonClick()
    {
        if(isUIPanelActive == false)
        {
            attractionsPanel.SetActive(true);
            isUIPanelActive = true;
        }
       
    }

    public void OpenRestuarantClick()
    {
        if (isUIPanelActive == false)
        {
            restuarantPanel.SetActive(true);
            isUIPanelActive = true;
        }

    }

    public void OpenToiletClick()
    {
        if (isUIPanelActive == false)
        {
            toiletsPanel.SetActive(true);
            isUIPanelActive = true;
        }

    }

    public void OpenParkingClick()
    {
        if (isUIPanelActive == false)
        {
            parkingPanel.SetActive(true);
            isUIPanelActive = true;
        }

    }
    public void DisplayStartEventPanel()
    {
        eventPanelUserInRange.SetActive(true);
      
    }

    public void CloseButtonClick()
    {
        eventPanelUserInRange.SetActive(false);
       
    }

    public void CloseButton()
    {
        attractionsPanel.SetActive(false);
        isUIPanelActive = false;
    }

    public void CloseRestuarantButton()
    {
        restuarantPanel.SetActive(false);
        isUIPanelActive = false;
    }

    public void CloseToiletButton()
    {
        toiletsPanel.SetActive(false);
        isUIPanelActive = false;
    }

    public void CloseParkingButton()
    {
        parkingPanel.SetActive(false);
        isUIPanelActive = false;
    }
}
