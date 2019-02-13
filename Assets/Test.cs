using System.IO;
using DefaultNamespace;
using UnityEngine;

public class Test : MonoBehaviour
{
	// Use this for initialization
	private void Start ()
	{
		var caPath = Path.Combine(Application.streamingAssetsPath, "ca.crt");
		Crash.CrashFunction(caPath);
		Debug.Log("Unity did not crash");
	}
}
