using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Scripting;
using UnityEngine;
using UnityEngine.UI;

public class DamgeCuaKeThuTruyenKieps : MonoBehaviour
{
    public int EnermyDamgeCuaManaCuaBan = 1000000;
    public int hell = 100000;
    public int TienDongXu = 0;
    public TextMeshProUGUI SoTienCuaBanHienTaiLaKhong;
    public Slider Mana;
    // Start is called before the first frame update
    void Start()
    {
        SoTienCuaBanHienTaiLaKhong.text = TienDongXu.ToString();
        Mana.maxValue = EnermyDamgeCuaManaCuaBan;
        Mana.value = EnermyDamgeCuaManaCuaBan;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coinlysnes")
        {
            TienDongXu += 1;
            SoTienCuaBanHienTaiLaKhong.text = TienDongXu.ToString();
            Destroy(other.gameObject);
        }
    }
}
