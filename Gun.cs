using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float cooldowntimer = .05f;
    float timerlength;
    public GameObject Bullet;
    public Transform gun;
    // Start is called before the first frame update
    void Start()
    {
        timerlength = cooldowntimer;
        cooldowntimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cooldowntimer <= 0)
        {
            GameObject.Instantiate(Bullet,gun);
            cooldowntimer = timerlength;
        }
        if (cooldowntimer >= 0)
        {
            cooldowntimer -= Time.deltaTime;
        }
    }
}
