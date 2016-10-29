using UnityEngine;
using System.Collections;

[RequireComponent(typeof(RectTransform))]
public class ImageObject : OverridableMonoBehaviour
{
	int sortLayer;
	float startTime;
	float journeyLength;
	Vector3 endPosition;

	public int SortLayer
	{
		get { return sortLayer; }
		set { sortLayer = value; }
	}
	public float StartTime
	{
		get { return startTime; }
		set { startTime = value; }
	}
	public float JourneyLength
	{
		get { return journeyLength; }
		set { journeyLength = value; }
	}
	public Vector3 EndPosition
	{
		get { return endPosition; }
		set { endPosition = value; }
	}

	public override void UpdateMe()
	{
		float distCovered = (Time.time - startTime) * (sortLayer + 1);
		float fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp(transform.position, endPosition, fracJourney);
	}
}
