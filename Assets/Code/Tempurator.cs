using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tempurator : MonoBehaviour
{
    public float bodyCuaBanThanGetSkiling = 50;
    public DamgeCuaKeThuTruyenKieps damgeCuaKeThuTruyenKieps;
    public bool touching_Camp;
    public TextMeshProUGUI nhietDoCuaAnhSangVaAmThanh;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (touching_Camp == true)
        {
            if (bodyCuaBanThanGetSkiling <= 50)
            {
                bodyCuaBanThanGetSkiling += 1;
            }
        }
        else
        {
            bodyCuaBanThanGetSkiling -= Time.deltaTime;
        }
        if (bodyCuaBanThanGetSkiling <= 0)
        {
            damgeCuaKeThuTruyenKieps.hell -= 25;
        }
        nhietDoCuaAnhSangVaAmThanh.text = bodyCuaBanThanGetSkiling.ToString("F1");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "LuaChuas")
        {
            touching_Camp = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "LuaChuas")
        {
            touching_Camp = false;
        }
    }
}

