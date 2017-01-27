#pragma strict
import UnityEngine.SceneManagement;

var Level : int;

function OnCollisionEnter (col : Collision)
{
    if(col.gameObject.name == "Platform")
    {
        SceneManager.LoadScene("Level"+Level);
    }
}