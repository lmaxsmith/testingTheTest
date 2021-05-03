using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
	public class VoidEventListener : MonoBehaviour
	{
		public VoidEventChannel EventChannel;

		public UnityEvent Event = new UnityEvent();

		private void OnEnable()
		{
			EventChannel.voidEvent.AddListener(TriggerEvent);
		}

		public void TriggerEvent()
		{
			Event.Invoke();
		}
	}
}