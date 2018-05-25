// =========================
// MAKAKA GAMES - MAKAKA.ORG
// =========================

using UnityEngine;
using UnityEngine.Events;

[HelpURL("https://makaka.org/category/docs")]
[AddComponentMenu ("AR/GyroCameraControl")]
public class GyroCameraControl : MonoBehaviour 
{
	private Gyroscope gyro;
	private bool gyroSupported;
	private Quaternion rotationFix = new Quaternion(0f, 0f, 1f, 0f);

	public Transform gyroCamera;

	void Start () 
	{
		gyroSupported = SystemInfo.supportsGyroscope;

		gyroCamera.parent.transform.rotation = Quaternion.Euler(90f, 180f, 0f);

		if (gyroSupported) 
		{
			gyro = Input.gyro;
			gyro.enabled = true;
		}
	}

	void Update () 
	{
		if (gyroSupported)
		{
			gyroCamera.localRotation = gyro.attitude * rotationFix;
		}
	}
}
