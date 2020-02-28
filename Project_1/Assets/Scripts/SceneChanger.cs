using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
 

    public void Load_Scene1()
    {
        SceneManager.LoadScene(1);
    }

    public void Load_Scene2()
    {
        SceneManager.LoadScene(2);
    }

    public void Load_Scene3()
    {
        SceneManager.LoadScene(3);
    }

    public void Load_MasterScene()
    {
        SceneManager.LoadScene(0);
    }
}
