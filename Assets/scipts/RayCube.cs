using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCube : MonoBehaviour
{
    public GameObject Door01;
    public GameObject Door02;
    public GameObject Door03;
    public GameObject Door04;
    public GameObject Door05;
    public GameObject Door06;
    public GameObject Door07;
    public GameObject Door08;
    public GameObject Door09;
    public GameObject Door00l;
    public GameObject Door00r;


    bool IsOpen = false;
  
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }
    /*public void Open()
    {
        Door01.GetComponent<Animator>().SetTrigger("IsOpenDoor");
    }
    public void Close()
    {

        Door01.GetComponent<Animator>().SetTrigger("IsCloseDoor");
    }*/
    // Update is called once per frame

    void Update()
    {
        ani.SetBool("DoorOpen", IsOpen);
       
    }
    private void OnTriggerEnter(Collider other)
    {
        IsOpen = true;
     

    }
    private void OnTriggerExit(Collider other)
    {
        IsOpen = false;
      
    }
}
