using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "voidEventChannelData", menuName = "UnityTest/VoidEventChannel")]
public class VoidEventChannel : ScriptableObject
{
	public UnityEvent voidEvent = new UnityEvent();

	public void Raise()
	{
		voidEvent.Invoke();
		
	}
	
}
