using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float speed = 3f;
	private GameObject Player;


	public GameObject enemy;

	void Start()
	{
		Player = GameObject.Find("Player");
	}

	void Update()
	{
		transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);

	}

}
