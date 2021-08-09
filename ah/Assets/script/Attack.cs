using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

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
            Invoke("StartAttack", 0.1f);                       
        }
    }

    void StartAttack()
    {
        sword.SetActive(true);

        Invoke("StopAttack", 1.5f);
        
    }

    void StopAttack()
    {
        sword.SetActive(false);
    }
}
