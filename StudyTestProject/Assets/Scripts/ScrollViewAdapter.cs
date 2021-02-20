using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewAdapter : MonoBehaviour
{
    public RectTransform prefab;
    public RectTransform content;
    public Text countText;

    public void UpdateItems()
    {
        int modelsCount = 0;
        int.Parse(countText.text, out modelsCount);
    }

    

    public class TestItemModel
    {
        public string title;
        public string text;

    }
    public class TestItemView
    {
        public Text title;
        public Button text;

    }
}
