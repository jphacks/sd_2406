using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class addmenu : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    public InputField menu;
    public Text menu_text;
    private int menu1 = -1;
    [SerializeField] GameObject Panel2;
    public static List<string> list_menu = new List<string>();
    public static bool R=false;
    // Start is called before the first frame update
    void Start()
    {
        menu = menu.GetComponent<InputField>();
        menu_text = menu_text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void InputText()
    {
        menu1++;
        menu_text.text = menu.text;
        list_menu.Add(menu_text.text);
        Debug.Log(list_menu[menu1]);
    }
    public void Btn()
    {
        R = true;
        Panel.SetActive(true);
        Panel2.SetActive(false);
    }


}
