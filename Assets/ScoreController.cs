using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	//得点を表示するテキスト
	private GameObject scoreText;
	//スコアを管理する変数
	private int score;

	// Use this for initialization
	void Start (){

		//シーン中のScoreTextオブジェクトを取得
		this.scoreText = GameObject.Find("ScoreText");
	}
	
	// Update is called once per frame
	void Update ()
	{
		//ScoreTextにスコアを表示
		this.scoreText.GetComponent<Text>().text = "Score: " + score;


	}

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
		//衝突したターゲットの種類によって取得出来る点数を決める
		if (collision.gameObject.tag == "SmallStarTag")
		{
			this.score = score + 1;
		}
		else if (collision.gameObject.tag == "LargeStarTag")
		{
			this.score = score + 3;
		}
		else if (collision.gameObject.tag == "SmallCloudTag")
		{
			this.score = score + 5;
		}
		else if (collision.gameObject.tag == "LargeCloudTag")
		{
			this.score = score + 10;
		}
	}
}
