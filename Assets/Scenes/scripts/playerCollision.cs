using UnityEngine;

public class playerCollision : MonoBehaviour {

    public movement goditje;

	void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle") {
            goditje.enabled = false;
            FindObjectOfType<gamemanager>().GameOver();
        }
    }
}
