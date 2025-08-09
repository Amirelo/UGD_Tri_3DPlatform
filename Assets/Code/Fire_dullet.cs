using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_dullet : MonoBehaviour
{
    public GameObject DanLuaDuocPhuPhepSieuManh;
    public Transform ViTriCuaDan;
    public DamgeCuaKeThuTruyenKieps damge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && damge.EnermyDamgeCuaManaCuaBan > 100000)
        {
            damge.EnermyDamgeCuaManaCuaBan -= 100000;
            damge.Mana.value = damge.EnermyDamgeCuaManaCuaBan;
            Instantiate(DanLuaDuocPhuPhepSieuManh, ViTriCuaDan.position, ViTriCuaDan.rotation);
        }
    }
}
