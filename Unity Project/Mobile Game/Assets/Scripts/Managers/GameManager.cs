using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	[SerializeField]
	LayerManager layerManagerPrefab;

	LayerManager layerManager;

	[SerializeField]
	ImageObject[] tempImages;

	void Awake()
	{
		layerManager = Instantiate(layerManagerPrefab);
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
