using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    public Texture2D[] classAvatar;
    public RawImage selectedAvatar;
    public TextMeshProUGUI textBox;
    private Class selectedClass;
    private int selectedIndex;
    // Start is called before the first frame update
    void Start()
    {
        UpdateClass();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Right()
    {
        selectedIndex++;
        { 
            if(selectedIndex == classAvatar.Length)
            {
                selectedIndex = 0;
            } 
        }
        UpdateClass();
    }
    public void Left()
    {
        selectedIndex--;
        {
            if (selectedIndex < 0)
            {
                selectedIndex = classAvatar.Length - 1;
            }
        }
        UpdateClass();
    }
    void UpdateClass()
    {
        textBox.text = "What's your question?";
        if (selectedClass != null)
        {
            Destroy(selectedClass);
        }
        selectedAvatar.texture = classAvatar[selectedIndex];
        switch (selectedIndex)
        {
            case 0:
                selectedClass = gameObject.AddComponent<Mage>();
                break;
                case 1:
                selectedClass = gameObject.AddComponent<Ranger>();
                break;
                case 2:
                selectedClass = gameObject.AddComponent<Warrior>();
                break;
        }
        selectedClass.chatBox = textBox;
    }
    public void CallHp()
    {
        selectedClass.MyHealth();
    }
    public void CallMana()
    {
        selectedClass.MyMana();
    }
    public void CallClass()
    {
        selectedClass.MyClass();
    }
    public void CallAbility()
    {
        selectedClass.MyAbility();
    }
}
