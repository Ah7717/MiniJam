using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class shoot : MonoBehaviour
{
    public bool isShot=false;
    [SerializeField]float force;
    [SerializeField]GameObject hand;
    [SerializeField]float gravity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnFire(){
        Debug.Log("Fired");
        if(!isShot){
        Vector3 diff=Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue())-transform.position;
        this.gameObject.GetComponent<Rigidbody2D>().AddForce( new Vector2(diff.x,diff.y)*force,ForceMode2D.Impulse);
        this.gameObject.GetComponent<Rigidbody2D>().gravityScale=gravity;
        isShot=true;}
    }
}
