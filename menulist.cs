using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menulist : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Panel1;
    public InputField food;
    public InputField food1;
    public InputField food2;
    public InputField food3;
    public Text food_text;
    public Text food_text1;
    public Text food_text2;
    public Text food_text3;
    public static List<string> list_food = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        food = food.GetComponent<InputField>();
        food1 = food1.GetComponent<InputField>();
        food2 = food2.GetComponent<InputField>();
        food3 = food3.GetComponent<InputField>();
        food_text = food_text.GetComponent<Text>();
        food_text1 = food_text1.GetComponent<Text>();
        food_text2 = food_text2.GetComponent<Text>();
        food_text3 = food_text3.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void InputText()
    {
        food_text.text = food.text;
        food_text1.text = food1.text;
        food_text2.text = food2.text;
        food_text3.text = food3.text;
        list_food.Add(food_text.text);
        list_food.Add(food_text1.text);
        list_food.Add(food_text2.text);
        list_food.Add(food_text3.text);
        Debug.Log(list_food[0]);
        Debug.Log(list_food[1]);
        Debug.Log(list_food[2]);
        Debug.Log(list_food[3]);
    }
    public void Btn()
    {
        Panel.SetActive(true);
    }
}