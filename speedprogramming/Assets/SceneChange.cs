using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject ErrorText;
    // Start is called before the first frame update
    void Start()
    {
        ErrorText.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToScene2 ()
    {
        SceneManager.LoadScene("Scene2");
         
    }
    public void ActivateGameObject()
    {
        ErrorText.SetActive(true);
    }


}
