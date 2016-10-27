using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Canvas))]
public class LayerObject : MonoBehaviour
{
	List<Image> allObjects = new List<Image>();
	Canvas canvas;

	public void AssignBaseLayer(int layer)
	{
		canvas = GetComponent<Canvas>();
		canvas.sortingOrder = layer;
		canvas.renderMode = RenderMode.ScreenSpaceOverlay;
		
	}


	public void AddObjectToLayer(Image objectToAdd)
	{
		allObjects.Add(objectToAdd);

		if(objectToAdd.GetComponent<RectTransform>() == null)
		{
			objectToAdd.gameObject.AddComponent<RectTransform>();
		}

		objectToAdd.transform.SetParent(transform);

		Vector3 localPos = objectToAdd.transform.localPosition;
		objectToAdd.transform.localPosition = new Vector3(320 + localPos.x, 0, localPos.z);

		objectToAdd.gameObject.name = "Image " + allObjects.Count;
	}
}
