using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseInteractable : MonoBehaviour
{
	// Interactions
	public virtual void OnClick()
	{
		Debug.Log("Clicked");
	}
	public virtual void OnHover()
	{
		Debug.Log("Hover");
	}
	public virtual void OnUnhover()
	{
		Debug.Log("Unhover");
	}

	// Unity hooks
	protected void Start()
	{

	}
	protected void Update()
	{

	}
}
