using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BellButton : MonoBehaviour
{
    private BellFactory factory;

    private EditorManager editor;

    TextMeshProUGUI btnText;

    // Start is called before the first frame update
    void Start()
    {
        factory = GameObject.Find("Game Manager").GetComponent<BellFactory>();

        editor = EditorManager.instance;

        btnText = GetComponentInChildren<TextMeshProUGUI>();
    }

    public void OnClickSpawn()
    { 
        switch(btnText.text)
        {
            case "green bell":
                editor.item = factory.GetBell("green bell").Create(factory.prefab1);
                break;
            case "yellow bell":
                editor.item = factory.GetBell("yellow bell").Create(factory.prefab2);
                break;
            case "white bell":
                editor.item = factory.GetBell("white bell").Create(factory.prefeb3);
                break;
            default:
                break;
        }
        editor.instantiated = true;
    }
}
