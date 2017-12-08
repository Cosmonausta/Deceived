using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerAudioManager : MonoBehaviour {
	public AudioSource sfxAudioS;

	public AudioClip[] hardSteps;

	public float distToGround = 1.3f;
	RaycastHit hitInfo;

	bool Grounded()
	{
		return Physics.Raycast (transform.position + Vector3.up * 0.5f, -Vector3.up, out hitInfo, distToGround);
	}

	public void Footsteps()
	{
		if (Grounded ()) 
		{
			int r = Random.Range (0, hardSteps.Length);
			switch (hitInfo.transform.GetComponent<Collider> ().tag) 
			{
				case "HardFloor":
					sfxAudioS.PlayOneShot(hardSteps[r]);
					break;
				default:
					sfxAudioS.PlayOneShot(hardSteps[r]);
					break;
			}
		}
	}

}
