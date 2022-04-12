using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class LightComponents : MonoBehaviour
{
	private Material _baseMaterial;
	public Material changeMaterial;

	public GameObject leftFrame;
	public GameObject rightFrame;
	private void Start()
    {
		_baseMaterial = gameObject.GetComponent<Renderer>().material;
    }


    public void ChangeColor()
	{
		ShowAll();
		gameObject.GetComponent<Renderer>().material = changeMaterial;
	}

	public void ReturnColor()
	{
		ShowAll();
		gameObject.GetComponent<Renderer>().material = _baseMaterial;
	}

	public void ShowAll()
	{
		leftFrame.SetActive(true);
		rightFrame.SetActive(true);
	}

}
