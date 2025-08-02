using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MauBanLaKhongChamMot : MonoBehaviour
{
    public DamgeCuaKeThuTruyenKieps player;
    public Slider DepTraiSildefrg;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<DamgeCuaKeThuTruyenKieps>();

        DepTraiSildefrg = transform.GetComponent<Slider>();
        DepTraiSildefrg.maxValue = player.hell;
    }

    // Update is called once per frame
    void Update()
    {
        DepTraiSildefrg.value = player.hell;
    }
}
