using UnityEngine;
using System.Collections.Generic;

/**
 *  A script node.
 *  Represents nodes being placed by the user
 *  to script a robot component.
 **/
public class ScriptNode {

	/**
	 *  Enum representing different node types.
	 **/
	public enum ScriptNodeType {
		ROOT,
		TURN_ON,
		TURN_OFF
	}
		
	/**
	 * The child nodes of the node.
	 **/
	List<ScriptNode> children;
	/**
	 * The type of the node.
	 **/
	ScriptNodeType type;
	/**
	 * The data associated specifically with this node.
	 **/
	Dictionary<string, object> data;

	/**
	 * Creates a new ScriptNode of the given type.
	 **/
	public ScriptNode(ScriptNodeType nodeType){
		children = new List<ScriptNode> ();
		data = new Dictionary<string, object> ();
		type = nodeType;
	}

	/**
	 * Adds a child node to the node.
	 **/
	public void addNode(ScriptNode newNode){
		children.Add (newNode);
	}

	/**
	 *  Removes a child node from the node.
	 **/
	public void removeNode(ScriptNode toRemove){
		children.Remove (toRemove);
	}

	/**
	 * Gets the node type.
	 **/
	public ScriptNodeType GetNodeType(){
		return this.type;
	}

	/**
	 * Sets the type of the node.
	 **/
	public void SetNodeType(ScriptNodeType type){
		this.type = type;
	}

	/**
	 * Set the data under the given string.
	 **/
	public void SetData(string s, object o){
		data.Add(s, o);
	}

	/**
	 * Get the data under the given string
	 **/
	public object GetData(string s){
		object _data;
		data.TryGetValue (s, out _data);
		return _data;
	}

	/**
	 * Removes the data under the given string.
	 **/
	public void RemoveData(string s){
		data.Remove (s);
	}
}
