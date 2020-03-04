using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // opens Gallery when "Gallery" button is hit
    public void LoadScene()
    {
        SceneManager.LoadScene("Gallery");
    }
}
