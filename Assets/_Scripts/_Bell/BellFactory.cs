using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Reflection;
using System;
using TMPro;

public class BellFactory : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefeb3;

    public GameObject buttonPanel;
    public GameObject buttonPrefab;

    List<Bell> bells;
    // Start is called before the first frame update
    void Start()
    {
        var bellTypes = Assembly.GetAssembly(typeof(Bell)).GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Bell)));
        
        bells = new List<Bell>();

        foreach(var type in bellTypes)
        {
            var tempType = Activator.CreateInstance(type) as Bell;
            bells.Add(tempType);
            Debug.Log(tempType.Name);
        }

        ButtonPanel();
    }

    public Bell GetBell(string bellType)
    {
        foreach(Bell bell in bells)
        {
            if(bell.Name == bellType)
            {
                var target = Activator.CreateInstance(bell.GetType()) as Bell;

                return target;
            }
        }
        return null;
    }
    void ButtonPanel()
    {
        foreach(Bell bell in bells)
        {
            var button = Instantiate(buttonPrefab);
            button.transform.SetParent(buttonPanel.transform);
            button.gameObject.name = bell.Name + "Button";
            button.GetComponentInChildren<TextMeshProUGUI>().text = bell.Name;
        }
    }
}
