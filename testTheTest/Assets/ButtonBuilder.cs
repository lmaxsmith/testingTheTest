using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonBuilder : MonoBehaviour
{
	[SerializeField]
	private List<ColorSO> colorsToButton;

	[SerializeField]
	private GameObject buttonPrefab;
	
	private void Start()
	{
		float buttonHeight = 0;
		
		foreach (var color in colorsToButton)
		{
			CustomButtonController buttonController = Instantiate(buttonPrefab, transform).GetComponent<CustomButtonController>();
			buttonController.transform.localPosition += new Vector3(0, buttonHeight, 0);
			buttonController.colorSO = color;
			
			TextMeshProUGUI buttonText = buttonController.GetComponentInChildren<TextMeshProUGUI>();
			buttonText.faceColor = color.color;
			
			buttonHeight += 30;
		}
	}
}
