using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public  class UiController : MonoBehaviour
{
   
    private UIDocument _document => GetComponent<UIDocument>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var listElements = new VisualElement[]
        {
           new Label("Hello"),
           new Label("hello"),
           new Button() {text = "hello world"}
        };

        ListView listView = _document.rootVisualElement.Q<ListView>("List1");
        listView.SetListContent(listElements);
        listView.fixedItemHeight = 50;


    }



   
}


