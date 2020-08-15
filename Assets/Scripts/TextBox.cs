using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextBox : MonoBehaviour
{
    
    public GameObject UIText;
    public GameObject cube;
    public GameObject Mensaje;

    // Start is called before the first frame update
    void Start()
    {
        Mensaje.SetActive(false);
        UIText.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            UIText.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        UIText.SetActive(false);
        Mensaje.SetActive(true);
        
        Destroy(cube);
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
