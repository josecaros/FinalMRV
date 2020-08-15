using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject cubeBoxText;
    // Start is called before the first frame update
    void Start()
    {     
    }
    private void OnTriggerEnter(Collider other)
    {
        if (cubeBoxText == null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
