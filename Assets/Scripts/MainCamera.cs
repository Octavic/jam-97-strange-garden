using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
	public GameObject Player;
	public GameObject Ocean;

	public float LerpFactor;

	private Vector3 Diff;

	// Start is called before the first frame update
	void Start()
	{
		this.Diff = this.transform.position;
	}

	// Update is called once per frame
	void Update()
	{
		this.transform.position = Vector3.Lerp(
			this.transform.position,
			Player.transform.position + this.Diff,
			this.LerpFactor
		);

		this.Ocean.transform.position = this.transform.position.WithY(this.Ocean.transform.position.y);
	}
}
