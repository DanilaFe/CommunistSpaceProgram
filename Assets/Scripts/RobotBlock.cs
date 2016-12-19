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
		
}
