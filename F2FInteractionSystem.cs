using UnityEngine;
using UnityEngine.UI;

public class F2FInteractionSystem : MonoBehaviour
{


    public GameObject BSTake;

    public GameObject BSHeld;

    public GameObject BSPlaced;

    bool CanDoJob = true;

    public Text InteractionText;

    // inventory 

    bool HaveBlueSphere = false;

    // inventory 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {




        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(CanDoJob == true)
        {


            Ray ray1 = new Ray(transform.position, transform.forward);
            RaycastHit hit1;

            if(Physics.Raycast(ray1, out hit1, 5f))
            {


                if (hit1.collider.CompareTag("BlueSphere") && HaveBlueSphere == false)
                {

                    InteractionText.text = "Take Blue Sphere";

                    if(Input.GetMouseButtonDown(0))
                    {


                        BSTake.SetActive(false);
                        BSHeld.SetActive(true);

                        HaveBlueSphere = true;


                    }


                }
                else if (hit1.collider.CompareTag("PlaceBlueSphere") && HaveBlueSphere == true)
                {

                    InteractionText.text = "Place Blue Sphere";

                    if(Input.GetMouseButtonDown(0))
                    {


                        BSHeld.SetActive(false);
                        BSPlaced.SetActive(true);

                        HaveBlueSphere = false;



                    }



                }
                else
                {

                    InteractionText.text = "";



                }





            }
            else
            {


                InteractionText.text = "";


            }




        }



    }
}
