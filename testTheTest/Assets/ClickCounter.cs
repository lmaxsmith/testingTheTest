using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    private int current = 0;

    public TextMeshProUGUI textMesh;
    
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<BoxController>().ColorChangedEvent.AddListener(CountUp);
    }
    
    private void CountUp()
    {
        current++;
        textMesh.text = $"You've clicked the clicks {current} times.";

    }
}
