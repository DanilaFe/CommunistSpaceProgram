using UnityEngine;
using System.Collections;

/**
 * Static utility functions go here
 **/
public class Utilities {

	/**
	 * Sets an object's collider's size to be its sprite size.
	 **/
	public static void MatchBoxColliderSize(GameObject obj){
		SpriteRenderer spriteRenderer = obj.GetComponent<SpriteRenderer> ();
		BoxCollider2D collider = obj.GetComponent<BoxCollider2D> ();
		if (spriteRenderer != null && collider != null) {
			collider.size = spriteRenderer.bounds.size;
		}
	}

}
