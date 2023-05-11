using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{
    private Rigidbody rb;
    private SphereCollider sc;
    private TrailRenderer tr;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sc = GetComponent<SphereCollider>();
        tr = GetComponent<TrailRenderer>();
        gm = GameObject.FindObjectOfType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gm.gameIsOver == false)
        {
  
            if (Input.GetMouseButtonDown(0))
            {
                tr.enabled = true;
                sc.enabled = true;
            }

 
            if (Input.GetMouseButtonUp(0))
            {
                tr.enabled = false;
                sc.enabled = false;
            }

            BladeFollowMouse();
        }
    }

    private void BladeFollowMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 8;
        rb.position = Camera.main.ScreenToWorldPoint(mousePos);
    }
}
