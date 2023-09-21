using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine;

public class start : MonoBehaviour
{


    [SerializeField] private ARSessionOrigin sessionOrigin;
    [SerializeField] private ARSession session;
    [SerializeField] private GameObject RajivHall;
    [SerializeField] private GameObject HallOfCommerce;
    [SerializeField] private GameObject Zesa;
    [SerializeField] private GameObject RobbieM;
    [SerializeField] private GameObject Convergence;
    [SerializeField] private GameObject Gate2;
    [SerializeField] private GameObject HomeIndustries;
    [SerializeField] private GameObject NelsonMandela;
    bool isUIPanelActive;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    

    public void SessionResetClick()
    {
        {
            session.Reset();
        }
      
       

       

    }

    public void RobbieMClick()
    {
  
       
         {

            this.transform.position = new Vector3(32.74f, 0f, -5.869995f);
         }
        

    }

    public void RajivClick()//Rajiv
    {


        {

            this.transform.position = new Vector3(25.35f, 0f, 59.03f);
        }


    }

    public void ZesaClick()
    {


        {

            this.transform.position = new Vector3(-32.78f, 0f, 80.79f);
        }


    }

    public void HallOfCommerceClick()//Rajiv
    {


        {

            this.transform.position = new Vector3(-173.55f, 0f, -14.46f);
        }


    }

    public void Gate2Click()
    {


        {

            this.transform.position = new Vector3(-13.66f, 0f, 87.89f);
        }


    }

    public void ConvergenceClick()
    {


        {

            this.transform.position = new Vector3(-194.67f, 0f, -17.8f);
        }


    }

    public void HomeIndustriesClick()
    {


        {

            this.transform.position = new Vector3(0.23f, 0f, 3.46f);
        }


    }

    public void NelsonMandelaClick()
    {


        {

            this.transform.position = new Vector3(-187.27f, 0f, 35.11f);
        }


    }






}
