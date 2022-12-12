using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed, timer;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
   {
		if(collision.collider.CompareTag("Enemy"))
		{
            GameObject clone = Instantiate (explosion, transform.position, transform.rotation);
			Destroy (clone, 1f);
			Destroy(collision.gameObject);
            Destroy(gameObject);
		}
		
   }
}
