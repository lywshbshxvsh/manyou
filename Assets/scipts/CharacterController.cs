using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.SocialPlatforms;


public class CharacterController : MonoBehaviour
{
    private CharacterController character;
    private Animator animator;
    bool isMove = true;
    //public float m_speed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(x: Horizontal, y: 0, z: Vertical);
        if (isMove)
        {
            if (dir != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(dir);
                animator.SetBool(name: "IsRun", value: true);
                transform.Translate(translation: Vector3.forward * 2 * Time.deltaTime);


            }
            else
            {
                animator.SetBool(name: "IsRun", value: false);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                animator.SetTrigger("isjump");

            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            animator.SetTrigger("isjump");

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("isvictory");
            isMove = false;
        }

    }
}
