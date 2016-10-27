using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LayerManager : MonoBehaviour
{
	Dictionary<int, LayerObject> allLayers = new Dictionary<int, LayerObject>();

	public void AddLayerObject()
	{
		LayerObject newObject = new GameObject().AddComponent<LayerObject>();

		newObject.name = "Layer " + allLayers.Count;
		newObject.AssignBaseLayer(allLayers.Count);

		allLayers.Add(allLayers.Count, newObject);
	}

	public void AddObjectToLayer(int layer, Image objectToAdd)
	{
		if(allLayers.Count < layer)
		{
			return;
		}

		allLayers[layer].AddObjectToLayer(objectToAdd);
	}
}
