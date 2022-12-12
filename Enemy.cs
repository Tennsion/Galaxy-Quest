using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
	Transform[] waypoints;

	[SerializeField]
	float moveSpeed = 2f;
	int waypointIndex = 0;
    

	void Start () {
	}

	void Update () {
       
		Move ();
	}

	void Move()
	{
		transform.position = Vector2.MoveTowards (transform.position,
												waypoints[waypointIndex].transform.position,
												moveSpeed * Time.deltaTime);

		if (transform.position == waypoints [waypointIndex].transform.position) {
			waypointIndex += 1;
		}
				
		if (waypointIndex == waypoints.Length)
			waypointIndex = 0;
	}
   

   private void OnCollisionEnter2D(Collision2D collision)
   {
		if(collision.collider.CompareTag("Player"))
		{
			Destroy(collision.gameObject);
		}
		
   }

}
