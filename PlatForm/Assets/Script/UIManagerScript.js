import UnityEngine.SceneManagement;

var Level : int;

function OnClick () {

	SceneManager.LoadScene("Level" + Level);

}