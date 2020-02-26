using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanelMovement : MonoBehaviour
{

    public GameObject MenuOrigPos; //Menu Position
    public GameObject MenuActivePos; //Menu Active Position
    public GameObject MenuPanel; //Menu
    public GameObject ThreeDotsOrigPos; //Three Vertical Dots Original Position
    public Button Three_dots; //Three Vertical Dots Button
    public Button Back_arrow; //Back Arrow of the Menu

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.transform.position = MenuOrigPos.transform.position; //Menu moves to position 1 (outside of screen view) from wherever it is
        Three_dots.transform.position = ThreeDotsOrigPos.transform.position; //Three Vertical Dots to Original Position
    }

    // Update is called once per frame
    void Update()
    {
        Three_dots.onClick.AddListener(Moveposition2); //Adds listener for when 3 dots button is clicked
        Back_arrow.onClick.AddListener(Moveposition1); //Adds listener for when back arrow is clicked
    }

    void Moveposition2()
    {
        MenuPanel.transform.position = MenuActivePos.transform.position; //Moves the menu to position 2
        Three_dots.transform.position = MenuOrigPos.transform.position; //Moves the Three Dots button offscreen
    }

    void Moveposition1()
    {
        MenuPanel.transform.position = MenuOrigPos.transform.position; //Moves the menu to position 1
        Three_dots.transform.position = ThreeDotsOrigPos.transform.position; //Moves the Three Dots to Original Position
    }
}
