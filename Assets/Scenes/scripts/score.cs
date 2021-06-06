using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour {

    public Transform cube;
    public Text scoreText;
	// Update is called once per frame
	void Update () {
        scoreText.text = cube.position.z.ToString("0");
	}
}
