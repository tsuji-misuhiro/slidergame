using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private Rigidbody rb;
    [Header("ˆÚ“®‘¬“x")]
    public float moveSpeed;

    [Header("‰Á‘¬‘¬“x")]
    public float accelerationSpeed;

    [SerializeField]
    private PhysicMaterial pmNoFriction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();

        Accelerate();
    }
    
    private void Move()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(x * moveSpeed, rb.velocity.y, rb.velocity.z);
        Debug.Log(rb.velocity);

    }

    void Update()
    {
        Brake();
    }

    private void Brake()
    {
        float vertical = Input.GetAxis("Vertical");
        if (vertical < 0)
        {
            pmNoFriction.dynamicFriction += Time.deltaTime;
            if(pmNoFriction.dynamicFriction > 1.0f)
            {
                pmNoFriction.dynamicFriction = 1.0f;
            }
        }
        else
        {
            pmNoFriction.dynamicFriction = 0;
        }
    }

    private void Accelerate()
    {
        float vertical = Input.GetAxis("Vertical");
        if(vertical > 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, accelerationSpeed);
        }
    }
}















