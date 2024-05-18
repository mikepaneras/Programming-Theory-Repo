using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Class : MonoBehaviour
{
    public TextMeshProUGUI chatBox;

    protected int hp {  get; set; }
    protected int mana {  get; set; }
    protected string ability {  get; set; }
    protected string className {  get; set; }

    public void MyHealth()
    {
        chatBox.text = $"My health is {hp} points";
    }
    public void MyMana()
    {
        chatBox.text = $"My mana is {mana} points";
    }
    public void MyClass()
    {
        chatBox.text = $"I'm a {className}!";
    }
    public void MyAbility()
    {
        chatBox.text = $"My ability is {ability}";
    }
}
public class Warrior : Class
{
    public Warrior()
    {
        hp = 150;
        mana = 50;
        ability = "Battle Cry";
        className = "Warrior";
    }
}
public class Mage : Class
{
    public Mage()
    {
        hp = 50;
        mana = 150;
        ability = "Fireball";
        className = "Mage";
    }
}
public class Ranger : Class
{
    public Ranger()
    {
        hp = 100;
        mana = 100;
        ability = "Arrow Volley";
        className = "Ranger";
    }
}
