using UnityEngine;
using System.Collections;

public class RobotBuilderArea : MonoBehaviour {

	RobotBuilderBox[,] robotBuilderBoxes;
	public RobotBuilderBox builderBoxPrefab;
	public int widthBoxes = 5;
	public int heightBoxes = 5;
	public float boxMarginWidth = 0.25f;
	public float boxMarginHeight = 0.25f;

	void Start () {
		robotBuilderBoxes = new RobotBuilderBox[widthBoxes, heightBoxes];
		float boxWidth =  builderBoxPrefab.GetComponent<BoxCollider2D> ().size.x;
		float boxHeight = builderBoxPrefab.GetComponent<BoxCollider2D> ().size.y;
		float fullWidth = boxWidth * widthBoxes + boxMarginWidth * (widthBoxes - 1);
		float fullHeight = boxHeight * heightBoxes + boxMarginHeight * (heightBoxes - 1);
		for (int w = 0; w < widthBoxes; w++) {
			for (int h = 0; h < heightBoxes; h++) {
				RobotBuilderBox newBox = Instantiate (builderBoxPrefab);
				robotBuilderBoxes [w, h] = newBox;
				Transform transform = newBox.GetComponent<Transform> ();
				transform.position = new Vector3(
					-fullWidth / 2 + boxWidth * (w + .5f) + boxMarginWidth * w + this.transform.position.x,
					-fullHeight / 2 + boxHeight * (h + .5f) + boxMarginHeight * h + this.transform.position.y,
					this.transform.position.z);
			}
		}
	}

	void Update () {
	
	}
}
