using UnityEngine;

public class ScoreAreaChecker : MonoBehaviour {

    public Collider ScoreArea;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == ScoreArea.gameObject) {
            Debug.Log("Triggered by score area");
        }
    }
}
