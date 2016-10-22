using UnityEngine;
using System.Collections;

//reference to UI namespace
using UnityEngine.UI;

//reference to manage my scenes
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public int tankCount;
	public GameObject tank;

	[Header("UI Objects")]
	public Text LivesLabel;
	public Text ScoreLabel;
	public Text GameOverLabel;
	public Button RestartButton;

	//	private Instance variables
	private int _scoreValue;
	private int _livesValue;

	// Use this for initialization
	void Start () {
		this._GenerateTanks ();
		this.ScoreValue = 0;
		this.LivesValue = 5;
		this.GameOverLabel.gameObject.SetActive (false);
		this.RestartButton.gameObject.SetActive (false);
	}

	//public properties
	public int LivesValue
	{
		get{
			return this._livesValue;

		}

		set{
			this._livesValue = value;
			if (this._livesValue <= 0) {
			
				this._endGame ();
			} else {
				this.LivesLabel.text = "Lives: " + this._livesValue;
			}
		}
	
	}
	public int ScoreValue{
		get{
			return this._scoreValue;
		}

		set{
			this._scoreValue = value;
			this.ScoreLabel.text = "Score :" + this._scoreValue;
		}


	}

	
	// Update is called once per frame
	void Update () {
	
	}
	private void _endGame()
	{
		
		this.GameOverLabel.gameObject.SetActive (true);
		this.RestartButton.gameObject.SetActive (true);
	}

	// generate Clouds
	private void _GenerateTanks() {
		for (int count=0; count < this.tankCount; count++) {
			Instantiate(tank);
		}
	}

	//PUBLIC METHODS+++++++++++++++++++
	public void RestartButton_Click()
	{
		SceneManager.LoadScene ("Main");

	}
}
