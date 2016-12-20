using UnityEngine;
using System.Collections;

/**
 * Script to highlight objects that are being hovered over.
 **/
public class HoverHighlight : MonoBehaviour {

	/**
	 * The color this object should have when it's not being hovered over. 
	 **/
	public Color normalColor;
	/**
	 * The color this object should have when it is being hovered over. 
	 **/
	public Color hoverColor;
	/**
	 *  The SpriteRenderer that draws this object's sprite.
	 **/
	SpriteRenderer spriteRenderer;

	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
		spriteRenderer.color = normalColor;
	}

	void OnMouseEnter() {
		spriteRenderer.color = hoverColor;
	}

	void OnMouseExit(){
		spriteRenderer.color = normalColor;
	}
}
