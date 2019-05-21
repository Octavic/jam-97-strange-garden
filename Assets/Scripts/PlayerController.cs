using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float MovementSpeed;

	private BaseInteractable hovering = null;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		#region Handles clicks
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		var interactable = Physics.Raycast(ray, out hit)
			? hit.transform.GetComponent<BaseInteractable>()
			: null;

		// Only need to call hover/unhover if things changed
		if (this.hovering != interactable)
		{
			if (this.hovering != null)
			{
				this.hovering.OnUnhover();
			}
			if (interactable != null)
			{
				interactable.OnHover();
			}
			this.hovering = interactable;
		}

		if (this.hovering != null && Input.GetMouseButtonDown(0))
		{
			this.hovering.OnClick();
		}
		#endregion

		#region Handles movement
		var x = 0;
		var z = 0;
		if (Input.GetKey(KeyCode.A))
		{
			x--;
		}
		if (Input.GetKey(KeyCode.D))
		{
			x++;
		}
		if (Input.GetKey(KeyCode.W))
		{
			z++;
		}
		if (Input.GetKey(KeyCode.S))
		{
			z--;
		}

		var movement = new Vector3(x, 0, z).normalized;
		this.transform.position += movement * this.MovementSpeed * Time.deltaTime;
		#endregion
	}
}
