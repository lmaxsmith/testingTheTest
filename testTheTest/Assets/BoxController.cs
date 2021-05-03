using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class BoxController : MonoBehaviour
{
    public MeshRenderer _boxRenderer;
    public TextMeshProUGUI _textRenderer;
    public ColorSO startingColor;

    public UnityEvent ColorChangedEvent = new UnityEvent();
    
    public void Start()
    {
        SetColor(startingColor);
    }

    public void SetColor(ColorSO colorSo)
    {
        _boxRenderer.material.color = colorSo.color;
        _textRenderer.faceColor = colorSo.color;

        _textRenderer.text = $"The color is {colorSo.colorName}!";
        
        ColorChangedEvent.Invoke();
    }
    
}
