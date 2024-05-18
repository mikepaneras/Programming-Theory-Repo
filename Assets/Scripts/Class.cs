using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Class : MonoBehaviour
{
    public TextMeshProUGUI chatBox;

<<<<<<< Updated upstream
    protected int hp {  get; set; }
    protected int mana {  get; set; }
    protected string ability {  get; set; }
    protected string className {  get; set; }
=======
    // ENCAPSULATION
    public int hp { get; protected set; }
    public int mana { get; protected set; }
    public string ability { get; protected set; }
    public string className { get; protected set; }
>>>>>>> Stashed changes

    // ABSTRACTION
    public void MyHealth()
    {
        chatBox.text = $"My health is {hp} points";
    }
<<<<<<< Updated upstream
=======

    // ABSTRACTION
>>>>>>> Stashed changes
    public void MyMana()
    {
        chatBox.text = $"My mana is {mana} points";
    }
<<<<<<< Updated upstream
=======

    // ABSTRACTION
>>>>>>> Stashed changes
    public void MyClass()
    {
        chatBox.text = $"I'm a {className}!";
    }
<<<<<<< Updated upstream
=======

    // ABSTRACTION
>>>>>>> Stashed changes
    public void MyAbility()
    {
        chatBox.text = $"My ability is {ability}";
    }
<<<<<<< Updated upstream
=======

    // POLYMORPHISM
    public virtual void MyWeapon()
    {
        // Nothing needed here.
    }
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======

    // POLYMORPHISM
    public override void MyWeapon()
    {
        chatBox.text = "With my bow I shoot arrows from afar.";
    }
>>>>>>> Stashed changes
}
