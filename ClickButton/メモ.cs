// アクティブ/非アクティブ化
	gameObject.SetActive(true);

// テキストを変える
	timeText.text = "変更後のテキスト";

// シーンの移動
	using UnityEngine.SceneManagement;
	SceneManager.LoadScene("SampleScene");