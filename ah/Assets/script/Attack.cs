using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    
    public Animator anim;
    
    public GameObject sword;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            StartAttack();               
        }
    }

    void StartAttack()
    {
        anim.Play("swordTest");

        //StopAttack();
    }

    //void StopAttack()
    //{
    //    anim.Play("");
    //}
}
