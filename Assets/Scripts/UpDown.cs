using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[DisallowMultipleComponent]
[RequireComponent(typeof(SpriteRenderer))]

public class UpDown : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField]Direction dir;

    public int upclick;
    public int downclick;
    public int leftclick;
    public int rightclick;
    // Start is called before the first frame update
    void Start()
    {
        upclick = 0;
        downclick = 0;
        leftclick = 0;
        rightclick = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 
    //    void OnMouseDown()
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(gameObject.name);
        switch(dir)
        {
            case Direction.DOWN:
                downclick = 1;
                break;
            case Direction.UP:
                upclick = 1;
                break;
            case Direction.LEFT:
                leftclick = 1;
                break;
            case Direction.RIGHT:
                rightclick = 1;
                break;
            default:
                break;
        }
    }

//    void OnMouseUp()
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log(gameObject.name);
        switch (dir)
        {
            case Direction.DOWN:
                downclick = 0;
                break;
            case Direction.UP:
                upclick = 0;
                break;
            case Direction.LEFT:
                leftclick = 0;
                break;
            case Direction.RIGHT:
                rightclick = 0;
                break;
            default:
                break;
        }
    }
}

public enum Direction
{
    UP,
    DOWN,
    LEFT,
    RIGHT
}