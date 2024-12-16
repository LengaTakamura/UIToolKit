using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public static class VisualElementsAdd 
{
   
        public static void SetListContent(this ListView listView, IEnumerable<VisualElement> visualElements)
        {
            var elementList = visualElements.ToList();
            listView.makeItem = () => new VisualElement(); // ���VisualElement�����܂���
            listView.itemsSource = elementList;
            listView.bindItem = (item, i) => { item.Add(elementList[i]); }; // ���VisualElement��Add����
        }
    
}
