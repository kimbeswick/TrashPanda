using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Earned : MonoBehaviour {

	private int moneyMade;
	public GUIText earned;

	[SerializeField]
	public int gems;

	// Use this for initialization
	void Start () {
		moneyMade = 0;
		UpdateCounter();
		//earned.text = moneyMade.ToString ();
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.CompareTag ("diamond")) 
		{
			//Debug.Log ("Found diamond");

			moneyMade += 100;
			UpdateCounter ();
			if (moneyMade == gems) 
			{
				//SceneManager.LoadScene (4);
			}
		}
	}


	void UpdateCounter()
	{
		earned.text = "$" + moneyMade.ToString();
		//SceneManager.LoadScene(3);
	}
}
