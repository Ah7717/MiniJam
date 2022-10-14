using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class rotate : MonoBehaviour
{
    [SerializeField]GameObject Player;
    [SerializeField]bool ani;
    bool dec;
    void FixedUpdate()
    {
        if(!GetComponentInChildren<shoot>().isShot){
        Vector3 diff=Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue())-transform.position;
        float rot=Mathf.Atan2(diff.y,diff.x)*Mathf.Rad2Deg;
        if(rot>40){rot=40;}
        if(rot<-40){rot=-40;}
        transform.rotation=Quaternion.Euler(0,0,rot);}}
       
}
