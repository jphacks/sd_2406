using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class menulist : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject Panel1;
    [SerializeField] GameObject Panel2;
    [SerializeField] GameObject Panel3;
    public InputField food;
    public Text food_text;
    public static List<string> need_food = new List<string>();
    public static List<string> food_List = new List<string>();
    private int need_food_Count;
    private int food_List_Count;
    private int OK_count = 0;
    public Text Bad_bar;
    public static List<string> Ok_food = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        food = food.GetComponent<InputField>();
        food_text = food_text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void InputText()
    {
        food_text.text = food.text;
        need_food.Add(food_text.text);
    }
    public void Btn()
    {
        Panel.SetActive(true);
    }
    public void Find()
    {
        food_List = addfoodtext.list_food;
        need_food_Count = need_food.Count;
        food_List_Count = foodlist.list_count;

        Debug.Log(need_food_Count);
        Debug.Log(food_List_Count);
        for (int i=0;i<need_food_Count;i++)
        {
            for(int j=0;j< food_List_Count; j++)
            {
                if (need_food[i] == food_List[j])
                {
                    Ok_food.Add(need_food[i]);
                    OK_count++;
                    Debug.Log(need_food[i] + "はある");
                }
            }
        }
        if(need_food_Count == OK_count)
        {
            Debug.Log("作れるよー");
            Debug.Log(OK_count);
            Panel2.SetActive(true);
            Panel1.SetActive(false);
        }
        else
        {
            Panel1.SetActive(false);
            Panel3.SetActive(true);
            for (int i=0;i<Ok_food.Count;i++)
            {
                Bad_bar.text = Ok_food[i] + "\n";
            }
            Bad_bar.text = "は自宅にあるよー！！";
            Debug.Log("無理―");
        }
    }
}