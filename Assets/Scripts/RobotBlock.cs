using UnityEngine;
using System.Collections.Generic;

/** A Robot Block object.
 * Contains data about the block,
 * such as its type and the script that it has to run.
 **/
public class RobotBlock {

	/**
	 * Block type enum.
	 * Used to represent the type of a block.
	 **/
	public enum BlockType {
		NONE,
		CORE,
		STRUCTURE,
		ENGINE,
		BATTERY,
		SOLAR,
		DRILL,
		LIGHT,
		TRACTOR
	}

	/**
	 * The type of this specific block.
	 **/
	BlockType type;
	/**
	 * The root script node of this block.
	 * */
	ScriptNode root;
	/**
	 * The properties of this block.
	 **/
	Dictionary<string, object> properties;

	/**
	 * Creates a new RobotBlock of the given type.
	 **/
	public RobotBlock(BlockType blockType) {
		properties = new Dictionary<string, object> ();
		type = blockType;
		root = null;
	}

	/**
	 * Sets the property for this block.
	 **/
	public void SetProperty(string s, object o){
		properties.Add (s, o);
	}

	/**
	 * Gets the property for this block.
	 **/
	public object GetProperty(string s){
		object _data;
		properties.TryGetValue (s, out _data);
		return _data;
	}

	/**
	 * Removes the property from this block.
	 **/
	public void RemoveProperty(string s){
		properties.Remove (s);
	}

	/**
	 * Gets the block type.
	 **/
	public BlockType GetBlockType(){
		return type;
	}

	/**
	 * Sets the block type.
	 **/
	public void SetBlockType(BlockType type){
		this.type = type;
	}

	/**
	 *  Sets the root node of this block.
	 **/
	public void SetRoot(ScriptNode newRoot){
		this.root = newRoot;
	}

	/**
	 * Gets the root node of this block.
	 **/
	public ScriptNode GetRoot(){
		return root;
	}
		
	/**
	 * Static dictionary used to load sprites for block based on their type.
	 **/
	static Dictionary<BlockType, Sprite> blockSprites = new Dictionary<BlockType, Sprite>();

	/**
	 * Gets the path of the sprite to load for the given block type.
	 **/
	static string GetSpritePathForBlockType(BlockType type){
		string _data;
		switch (type) {
		default:
			_data = "blockA";
			break;
		}
		return "Blocks/" + _data;
	}

	/**
	 * Loads the sprite for the given block type from disk.
	 **/
	public static Sprite LoadSpriteForBlockType(BlockType type){
		string _path = "Graphics/" + GetSpritePathForBlockType (type);
		Sprite _data = Resources.Load<Sprite> (_path);
		blockSprites.Add (type, _data);
		return _data;
	}

	/**
	 * Searches cache for already loaded sprite. If one is not found, loads
	 * it from disk.
	 **/
	public static Sprite GetSpriteForBlockType(BlockType type){
		Sprite _data = null;
		if (blockSprites.ContainsKey (type)) {
			blockSprites.TryGetValue (type, out _data);
		} else {
			_data = LoadSpriteForBlockType (type);
		}
		return _data;
	}
		
}
