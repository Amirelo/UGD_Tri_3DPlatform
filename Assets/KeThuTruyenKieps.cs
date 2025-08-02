using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeThuTruyenKieps : MonoBehaviour
{
    public GameObject keThuTruyenKieps;
    public int speed;
    public int hell = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(keThuTruyenKieps.transform);
        Vector3 targetpos =  (keThuTruyenKieps.transform.position - transform.position).normalized;
        transform.position += targetpos * speed * Time.deltaTime;
    }
}
