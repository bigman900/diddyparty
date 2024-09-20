using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coolButton4 : MonoBehaviour
{
    public void Freakoff ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
// Start is called before the first frame update
void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void Credits ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void Exit ()
    {
        Application.Quit();
    }
}
