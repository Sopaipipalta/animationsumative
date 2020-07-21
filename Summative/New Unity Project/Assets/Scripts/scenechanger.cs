using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{
    public void Load2d()
    {
        SceneManager.LoadScene(1);
    }
    public void Load3d()
    {
        SceneManager.LoadScene(0);
    }
 

    // Update is called once per frame
    void Update()
    {
      
    }
}
