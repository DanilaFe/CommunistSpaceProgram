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
	public List<ScriptNode> children;
	/**
	 * The type of the node.
	 **/
	public ScriptNodeType type;
	/**
	 * The data associated specifically with this node.
	 **/
	public Dictionary<string, Object> data;

	/**
	 * Creates a new ScriptNode of the given type.
	 **/
	public ScriptNode(ScriptNodeType nodeType){
		children = new List<ScriptNode> ();
		data = new Dictionary<string, Object> ();
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
}
