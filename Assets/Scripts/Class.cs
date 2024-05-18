using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// ABSTRACTION
public abstract class Class : MonoBehaviour
{
    public TextMeshProUGUI chatBox;

    // ENCAPSULATION
    public int hp { get; protected set; }
    public int mana { get; protected set; }
    public string ability { get; protected set; }
    public string className { get; protected set; }

    // ABSTRACTION
    public void MyHealth()
    {
        chatBox.text = $"My health is {hp} points";
    }

    // ABSTRACTION
    public void MyMana()
    {
        chatBox.text = $"My mana is {mana} points";
    }

    // ABSTRACTION
    public void MyClass()
    {
        chatBox.text = $"I'm a {className}!";
    }

    // ABSTRACTION
    public void MyAbility()
    {
        chatBox.text = $"My ability is {ability}";
    }

    // POLYMORPHISM
    public virtual void MyWeapon()
    {
        // Nothing needed here.
    }
}

// INHERITANCE
public class Warrior : Class
{
    public Warrior()
    {
        hp = 150;
        mana = 50;
        ability = "Battle Cry";
        className = "Warrior";
    }

    // POLYMORPHISM
    public override void MyWeapon()
    {
        chatBox.text = "With my sword I slash my foes.";
    }
}

// INHERITANCE
public class Mage : Class
{
    public Mage()
    {
        hp = 50;
        mana = 150;
        ability = "Fireball";
        className = "Mage";
    }

    // POLYMORPHISM
    public override void MyWeapon()
    {
        chatBox.text = "With my staff I cast powerful spells.";
    }
}

// INHERITANCE
public class Ranger : Class
{
    public Ranger()
    {
        hp = 100;
        mana = 100;
        ability = "Arrow Volley";
        className = "Ranger";
    }

    // POLYMORPHISM
    public override void MyWeapon()
    {
        chatBox.text = "With my bow I shoot arrows from afar.";
    }
}
