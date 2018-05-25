using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
	public static GameManager Instance;

	#region public-variable
	public Text txtgyroMessage;
	#endregion

	#region private-variable
	#endregion

	#region unity-callback
	void Awake()
	{
		Instance = this;

		if(SystemInfo.supportsGyroscope)
		{
			// gyro supported
			txtgyroMessage.text = "Look around via smartphone";
		}
		else
		{
			// accelerometer
			txtgyroMessage.text = "Device doesn't support gyro";
		}
	}

	void Start () 
	{
		
	}
	#endregion

	#region Delagates
	#endregion

	#region private-function
	#endregion

	#region public-function
	#endregion

	#region coroutine
	#endregion
}
