using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Canvas))]
public class LayerObject : MonoBehaviour
{ 
	List<ImageObject> allObjects = new List<ImageObject>();
	Canvas canvas;

	public void AssignBaseLayer(int layer)
	{
		canvas = GetComponent<Canvas>();
		canvas.sortingOrder = layer;
	}

	public void AddObjectToLayer(ImageObject objectToAdd)
	{
		allObjects.Add(objectToAdd);

		if(objectToAdd.GetComponent<RectTransform>() == null)
		{
			objectToAdd.gameObject.AddComponent<RectTransform>();
		}

		objectToAdd.transform.SetParent(transform);

		Vector3 localPos = objectToAdd.transform.localPosition;
		objectToAdd.transform.localPosition = new Vector3(Screen.width + (objectToAdd.GetComponent<RectTransform>().sizeDelta.x * 2) + localPos.x, 0, localPos.z);

		objectToAdd.gameObject.name = "Image " + allObjects.Count;

		objectToAdd.SortLayer = canvas.sortingOrder;
		objectToAdd.EndPosition = new Vector3(0 - objectToAdd.GetComponent<RectTransform>().sizeDelta.x * 2, objectToAdd.transform.position.y);
		objectToAdd.StartTime = Time.time;
		objectToAdd.JourneyLength = Vector3.Distance(transform.position, objectToAdd.EndPosition);

	}
}
