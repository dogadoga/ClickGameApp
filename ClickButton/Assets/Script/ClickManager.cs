using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Text
using UnityEngine.SceneManagement; //SceneManager
public class ClickManager : MonoBehaviour
{
    //カウント用の変数を用意
    private int count=0; 

    //テキスト型の変数を用意
    public Text countText;

    //Float型の変数を用意する
    private float time=10.0f; //初期値10

    //text型の変数を用意
    public Text timeText;

    //GameObject型の変数を用意
    public GameObject panelObject;

    //bool型の変数を用意
    private bool gameEnd=false;

    //変数を1増やす関数を作成
    public void PushButton()
    {
        count++;
        // Debug.Log(count);
        //増えた数字をテキストで表示
        countText.text="Score:"+count;
    }

    // Update is called once per frame
    void Update()
    {
        //gameEndがfalseのときに処理
        if(gameEnd==false)
        {
            //timeが0以下の時
            if(time<=0)
            {
                //テキストにカウントダウンの数値を表示する
                timeText.text="Time:0.00"; //tostringで桁数を設定
                
                //GameObjectを表示する
                panelObject.SetActive(true);

                //gameEndをtrueへ変更
                gameEnd = true;
            }
            else
            {
                //カウントダウンさせる
                time -= Time.deltaTime;
                //Debug.Log(time);
                //テキストにカウントダウンの数値を表示する
                timeText.text="Time:" + time.ToString("f2"); //tostringで桁数を設定
            }
        }  
    }

    //シーン移動
    public void ChangeScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
