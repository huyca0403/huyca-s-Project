using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Control : MonoBehaviour
{
    public int huong;
    public int toc_do=10;
    public GameObject main;
    public bool nhay;
    public int chieu_cao;
    public Rigidbody2D rb;

    // duoc goi o frame dau tien
    void Start()
    {
        
    }
    // duoc goi o moi frame
    void Update()
    {
        DiChuyenNhanVat();
    }
    void DiChuyenNhanVat()
    {
        //huong cua nhan di chuyen
        if (Input.GetKey(KeyCode.LeftArrow)) this.huong = -1;
        else if (Input.GetKey(KeyCode.RightArrow)) this.huong = 1;
        else this.huong = 0;
        //di chuyen nhan vat
        main.transform.Translate(Vector3.right*toc_do*huong*Time.deltaTime);
        //nhay
    }
}
