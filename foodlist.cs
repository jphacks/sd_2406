using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class foodlist : MonoBehaviour
{
    public static List<string> list_foodlist = new List<string>();
    public static List<string> list_Duelist = new List<string>();
    public static int list_count = 0;
    public Text Text0;
    public Text Text1;
    public Transform parent;
    public Transform parent2;

    // Start is called before the first frame update
    void Start()
    {
        list_foodlist = addfoodtext.list_food;
        list_Duelist = addfoodtext.list_Due;
        list_count = list_foodlist.Count;
        Debug.Log(list_count);
        list_Duelist.Sort();
        for (int i = 0; i < list_count; i++)
        {
            Text Text2 = Instantiate(Text1, parent);
            Text2.text = list_foodlist[i];

            Text Text3 = Instantiate(Text0, parent2);
            Text3.text = list_Duelist[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
