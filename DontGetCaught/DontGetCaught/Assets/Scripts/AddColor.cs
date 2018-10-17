
using UnityEngine;
using UnityEngine.Events;


public class AddColor : MonoBehaviour
{

	public UnityEvent Paint;

	// Use this for initialization
	void Start()
	{

		Paint.Invoke();

	}

}
