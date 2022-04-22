using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball instance;

    public Rigidbody rb;
    public float jumpForce;

    [SerializeField] private FloatValue lifeValue;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckHealth(float damageTaken) 
    {
        lifeValue.runtimeValue -= damageTaken;
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * jumpForce);
    }
}
