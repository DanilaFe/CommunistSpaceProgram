using UnityEngine;
using System.Collections;

public class RobotBuilderBox : MonoBehaviour {

	/**
	 * The sprite renderer of this RobotBuilderBox
	 **/
	SpriteRenderer spriteRenderer;
	/**
	 * The type of the block that this RobotBuilderBox is currently.
	 **/
	RobotBlock.BlockType type;
	/**
	 * The script node attached to this box.
	 **/
	ScriptNode root;

	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
		spriteRenderer.sprite = RobotBlock.GetSpriteForBlockType (type);
		UpdateSprite ();
	}

	void Update () {

	}

	/**
	 * gets the block type of this Assembly Box
	 **/
	public RobotBlock.BlockType GetBlockType(){
		return type;
	}

	/**
	 * Sets the block type of this Assembly Box
	 **/
	public void SetBlockType(RobotBlock.BlockType type){
		this.type = type;
		UpdateSprite ();
	}

	/**
	 * Sets the root ScriptNode attached to this box.
	 **/
	public ScriptNode GetRoot(){
		return root;
	}

	/**
	 * Gets the root ScriptNode attached to this box.
	 **/
	public void SetRoot(ScriptNode root){
		this.root = root;
	}

	/**
	 * Updates the sprite of the Box to the one
	 * dictated by its block type.
	 **/
	public void UpdateSprite(){
		spriteRenderer.sprite = RobotBlock.GetSpriteForBlockType (type);
		Utilities.MatchBoxColliderSize (gameObject);
	}
}
