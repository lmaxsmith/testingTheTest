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
			ColorButton button = Instantiate(buttonPrefab, transform).GetComponent<ColorButton>();
			button.transform.localPosition += new Vector3(0, buttonHeight, 0);
			button.colorSO = color;
			
			TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();
			buttonText.faceColor = color.color;
			
			buttonHeight += 30;
		}
	}
}
