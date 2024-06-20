using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Open : MonoBehaviour
{
    public  GameObject text;

    public void Show(GameObject text)
    {
        text.SetActive(true);
    }
    public void Hide(GameObject text)
    {
        text.SetActive(false);
    }
    void OnTriggerEnter(Collider other)//接触时触发
    {
        Debug.Log(Time.time + ":进入该触发器的对象是：" + other.gameObject.name);
        Show(text);
    }
    void OnTriggerStay(Collider other)    //每帧调用一次OnTriggerStay()函数
    {
        Debug.Log(Time.time + "留在触发器的对象是：" + other.gameObject.name);
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log(Time.time + "离开触发器的对象是：" + other.gameObject.name);
        Hide(text);
    }

    // Start is called before the first frame update
    void Start()
    {
        Hide(text);
    }

    // Update is called once per frame
    void Update()
    {
       // animator.SetBool(name: "DoorOpen", IsOpen);
       // animator.SetBool(name: "DoorOpen2", IsOpen);
    }
}
