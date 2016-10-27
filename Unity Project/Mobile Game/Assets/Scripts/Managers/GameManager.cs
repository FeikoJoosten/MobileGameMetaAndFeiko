using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	LayerManager layerManager;

	[SerializeField]
	UnityEngine.UI.Image[] tempImages;

	void Awake()
	{
		layerManager = new GameObject().AddComponent<LayerManager>();
		layerManager.name = "Layer manager";
	}

	void Start()
	{
		for(int i = 0; i < 5; i++)
		{
			layerManager.AddLayerObject();

			layerManager.AddObjectToLayer(i, Instantiate(tempImages[i]));
		}
	}
}
