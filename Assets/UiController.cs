using UnityEngine;
using UnityEngine.UIElements;

public class UiController : MonoBehaviour
{
    [SerializeField] GameObject _ui;
    
    private UIDocument _document;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var a = Instantiate(_ui);

        _document = a.GetComponent<UIDocument>();

        var element = _document.rootVisualElement.Q<Button>("Buttun");

        element.clicked += () =>
        {
            Debug.Log("click");
            var labelelement = _document.rootVisualElement.Q<Label>("Label");
            labelelement.text = "click";
            
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
