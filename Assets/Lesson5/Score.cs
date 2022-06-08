using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //変数の宣言
    private int score;

    //スコアを表示するテキスト
    public GameObject ScoreText;


    // Start is called before the first frame update
    void Start()
    {

        //シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update()

    {

    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {


        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 10;

        }

        else if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 20;
        }

        else if (other.gameObject.tag == "LargeStarTag")
        {

           score += 30;
        }

        else if (other.gameObject.tag == "SmallStarTag")
        {
            score += 40;
        }

        ScoreText.GetComponent<Text>().text = "Score:" + score;

    }

}
