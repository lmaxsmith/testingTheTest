using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomButtonController : MonoBehaviour
{
    public ColorSO colorSO;
    private BoxController _boxController;

    public VoidEventChannel buttonClickedChannel;

    public void ButtonPushedHandler()
    {
        if (_boxController == null)
            _boxController = FindObjectOfType<BoxController>();
        _boxController.SetColor(colorSO);

        buttonClickedChannel.Raise();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _boxController = FindObjectOfType<BoxController>();
    }

}
