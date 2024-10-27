using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class addfoodtext : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Panel2;
    public InputField food;
    public InputField Due_Date;
    public Text food_text;
    public Text Due_Date_text;
    private int food1=-1;
    private int Date1=-1;
    public static List<string> list_food = new List<string>();
    public static List<string> list_Due = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        food = food.GetComponent<InputField>();
        Due_Date = Due_Date.GetComponent<InputField>();
        food_text = food_text.GetComponent<Text>();
        Due_Date_text = Due_Date_text.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void InputText()
    {
        food1++;
        Date1++;
        food_text.text = food.text;
        Due_Date_text.text = Due_Date.text;
        list_food.Add(food_text.text);
        list_Due.Add(Due_Date_text.text);
        Debug.Log(list_food[food1]);
        Debug.Log(list_Due[Date1]);
    }
    public void Btn()
    {
        Panel.SetActive(true);
        Panel2.SetActive(false);
    }
    public void foodList()
    {
        SceneManager.LoadScene("foodlist");
    }

}
