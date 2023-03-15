using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectScript : MonoBehaviour
{
    private bool _stop = false;
    private int _laps = 0;
    private int _timer = 0;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Finish") {
            _laps++;
            _stop = _laps == 3;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        
        if (col.tag == "Finish") {
            Debug.Log("Гонка началась!");
        }
    }

    void GameEnd() {
        Debug.Log("End of game!");
        SceneManager.LoadScene("MainMenu");
    }

    void Update()
    {
        if (!_stop)
            transform.localPosition += new Vector3(.002f, 0, 0);
        else _timer++;

        if (_timer > 120) {
            GameEnd();
        }
    }
}
