using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
	public int time;
	public GUIText timer;

	void Start()
	{
		StartCoroutine(countdown());
	}

	IEnumerator countdown()
	{
		while (time > 0)
		{
			yield return new WaitForSeconds(1);

			timer.text = time.ToString();

			time -= 1;
		}

		timer.text = "Out of Time!";
		//SceneManager.LoadScene(3);
	}


	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log ("Found trash");
		if (collider.gameObject.CompareTag("trash"))
		{
			
			time += 5;
			timer.text = time.ToString();
			//SceneManager.LoadScene(3);
			
		}
	}



}