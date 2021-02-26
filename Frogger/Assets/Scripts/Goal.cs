using UnityEngine;
using UnityEngine.SceneManagement;

class Goal : MonoBehaviour {

    void OnTriggerEnter2D()
    {
        Debug.Log("YOU WON!");
        Score.CurrentScore += 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
