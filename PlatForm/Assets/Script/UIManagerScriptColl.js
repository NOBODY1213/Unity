import UnityEngine.SceneManagement;

var pickup : AudioClip;

function OnCollisionEnter2D(col : Collision2D)
{
    if(col.collider.name == "Guy")
    {
    	GetComponent.<AudioSource>().Play();
    	yield WaitForSeconds (2);
        SceneManager.LoadScene("Level0");
    }

}