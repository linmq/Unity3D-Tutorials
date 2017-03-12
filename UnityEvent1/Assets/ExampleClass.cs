using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class MyIntEvent : UnityEvent<int>
{
}

public class ExampleClass : MonoBehaviour
{
	public MyIntEvent m_MyEvent;

	void Start ()
	{
		if (m_MyEvent == null)
			m_MyEvent = new MyIntEvent();

		m_MyEvent.AddListener (Ping);
	}

	void Update () 
	{
		if (Input.anyKeyDown && m_MyEvent != null)
		{
			m_MyEvent.Invoke (5);
		}
	}

	void Ping (int i)
	{
		Debug.Log ("Ping" + i);
	}
}