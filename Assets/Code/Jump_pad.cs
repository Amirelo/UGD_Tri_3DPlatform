using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_pad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.GetComponent<Jump>().jumpStrength *= 30;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.GetComponent<Jump>().jumpStrength /= 30;
        }
    }
}
