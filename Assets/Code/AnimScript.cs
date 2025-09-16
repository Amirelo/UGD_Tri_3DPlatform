using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimScript : MonoBehaviour
{
    public Animator skibitihoathinh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.W))
        // {
        //     if (Input.GetKey(KeyCode.LeftShift))
        //     {
        //         skibitihoathinh.SetBool("LACHAY", true);
        //         skibitihoathinh.SetBool("LADIBO", false);
        //     }
        //     else
        //     {
        //         skibitihoathinh.SetBool("LADIBO", true);
        //         skibitihoathinh.SetBool("LACHAY", false);
        //     }
        // }
        // else
        // {
        //     skibitihoathinh.SetBool("LADIBO", false);
        //     skibitihoathinh.SetBool("LACHAY", false);
        // }

        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        skibitihoathinh.SetFloat("veolocityX", hor);
        skibitihoathinh.SetFloat("veolocityY", ver);
        print(hor);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            skibitihoathinh.SetBool("LADIBO", false);
        }
        else
        {
            skibitihoathinh.SetBool("LADIBO", true);
        }
        
    }
}
