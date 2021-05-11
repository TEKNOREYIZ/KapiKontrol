using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KapiKontrol : MonoBehaviour
{
    public Animator animator;
    public bool Acik;
    Vector3 ileri;
    RaycastHit hit;
    public float Mesafe;
    public GameObject Kapi;

    private void Awake()
    {
        animator.enabled = false;
        
        Mesafe = 3;

        
    }

    public void AcikKapali()
    {
        if (Kapi.gameObject.transform.rotation.y < 90)
        {
            Acik = false;
        }

        if (Kapi.gameObject.transform.rotation.y == 90)
        {
            Acik = true;
        }
    }
   

     void Update()
     {


        ileri = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, ileri, out hit, Mesafe))
        {

            if (Input.GetKeyDown(KeyCode.E) && hit.collider.tag == "Kapi")
            {
                animator.enabled = true;
            }


            if (hit.collider.tag == "Kapi" && Input.GetKeyDown(KeyCode.E))
            {
                Acik = !Acik;

            }
        }



        if (Acik == false && Input.GetKeyDown(KeyCode.E))
                {

            animator.SetBool("Acik", true);
           
        }
                if (Acik == true && Input.GetKeyDown(KeyCode.E))
                {
                 
                    animator.SetBool("Acik",false);
                }
            
            

            

        
        
     }
}

