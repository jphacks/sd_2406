using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class addfood : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //
    public void adddood()
    {
        SceneManager.LoadScene("addfood");
    }
    public void addmenu()
    {
        SceneManager.LoadScene("addmenu");
    }
    public void foodlist()
    {
        SceneManager.LoadScene("foodlist");
    }
    public void title()
    {
        SceneManager.LoadScene("Title");
    }
}
