using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(RabbitBehavior))]
public class RabbitEditor : Editor
{
	void OnSceneGUI()
	{
		//FOV fow = (FOV)target;
		RabbitBehavior rab = (RabbitBehavior)target;
		Handles.color = Color.red;
		Handles.DrawWireArc(rab.transform.position, Vector3.forward, Vector3.right, 360, rab.hearingRadius);
		Handles.color = Color.green;
		Handles.DrawLine(rab.transform.position, rab.waypoint);
	}
}