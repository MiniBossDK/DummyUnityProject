using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollCotroller : MonoBehaviour
{
    private ScrollRect scrollRect;
    private Vector3 startPos;

    private void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
        startPos = scrollRect.content.localPosition;
        scrollRect.onValueChanged.AddListener(Hello);
    }

    private void Hello(Vector2 value)
    {
        if (value.y == 1) Debug.Log("Down");
        else Debug.Log("Up");
    }
}
