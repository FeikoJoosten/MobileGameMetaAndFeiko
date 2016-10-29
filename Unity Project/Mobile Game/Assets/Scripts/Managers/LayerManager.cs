using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LayerManager : MonoBehaviour
{
	[SerializeField]
	LayerObject layerPrefab;

	Dictionary<int, LayerObject> allLayers = new Dictionary<int, LayerObject>();

	public void AddLayerObject()
	{
		LayerObject newObject = Instantiate(layerPrefab);

		newObject.name = "Layer " + allLayers.Count;
		newObject.AssignBaseLayer(allLayers.Count);

		allLayers.Add(allLayers.Count, newObject);
	}

	public void AddObjectToLayer(int layer, ImageObject objectToAdd)
	{
		if(allLayers.Count < layer)
		{
			return;
		}

		allLayers[layer].AddObjectToLayer(objectToAdd);
	}
}
