using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    
    [SerializeField] float steerSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmout = Input.GetAxisRaw("Horizontal");
        transform.Translate(steerAmout * steerSpeed,0,0);
        
    }
}
