using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GrabPickups : MonoBehaviour {

	private AudioSource pickupSoundSource;

	void Awake() {
		pickupSoundSource = DontDestroy.instance.GetComponents<AudioSource>()[1];
	}

	void OnControllerColliderHit(ControllerColliderHit hit) {
		if (hit.gameObject.tag == "Pickup") {
			//transform to be sure no double pickups
			if (!LevelGenerator.levelLock){
				LevelGenerator.level += 1;
				LevelGenerator.levelLock = true;
			}
			pickupSoundSource.Play();
			SceneManager.LoadScene("Play");
		}
	}
}
