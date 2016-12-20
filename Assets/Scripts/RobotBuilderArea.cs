using UnityEngine;
using System.Collections;

public class RobotBuilderArea : MonoBehaviour {

	RobotBuilderBox[,] robotBuilderBoxes;
	public RobotBuilderBox builderBoxPrefab;
	public int widthBoxes = 5;
	public int heightBoxes = 5;

	void Start () {
		robotBuilderBoxes = new RobotBuilderBox[widthBoxes, heightBoxes];
		for (int w = 0; w < widthBoxes; w++) {
			for (int h = 0; h < heightBoxes; h++) {
				RobotBuilderBox newBox = Instantiate (builderBoxPrefab);
				robotBuilderBoxes [w, h] = newBox;
			}
		}
	}

	void Update () {
	
	}
}
