import UnityEngine.SceneManagement;

var Level : int;

on start {
	SceneManager.LoadScene("Level"+Level);
}