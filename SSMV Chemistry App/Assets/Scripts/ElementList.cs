using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementList : MonoBehaviour
{ 
        public string name;
        public int AtNumber;
   
    // Start is called before the first frame update
    void Start()
    {
        //creates list and adds in elements
        List<ElementList> element = new List<ElementList>();
        element.Add(new ElementList("Hydrogen", 1));
        element.Add(new ElementList("Helium", 2));
        element.Add(new ElementList("Oxygen", 8));
        element.Add(new ElementList("Carbon", 6));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public ElementList(string name, int AtNumber)
    {

    }
}
