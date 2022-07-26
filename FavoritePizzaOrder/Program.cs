// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Marvish Chandra
// This program is designed to help the user craft their favorite pizza based on chosen crust, sauce, toppings,and additions.
// This program utilized polymorphism specifically with the function crust since it is the only thing required to order a pizza. 
// Written in C#

class favoritePizza
{
    public virtual void crust()
    {
        myCrusts = {"Crunchy Thin Crust": {0}, "Hand Tossed": {1}, "Handmade Pan": {2}, "Brooklyn Style":{3}, "Gluten Free Crust": {4}}
        foreach(var c in myCrusts)
            Console.WriteLine("Key: {0}", Value: {1}", c.Key, c.Value);
            selectedCrust = Console.ReadLine("Which pizza crust would you like to select for today?");
        print(selectedCrust);
    }

    class Sauce : favoritePizza
    {
        public override void crust();
        
    public void sauces()
    {
        mySauces = {"Robust Inspired Tomato Sauce": {0}, "Honey BBQ Sauce" : {1},"Garlic Parmesan Sauce": {2}, "Alfredo Sauce": {3}, "Ranch": {4}}
        foreach(var s in mySauces)
            Console.WriteLine("Key: {0}",Value: {1}, s.Key, s.Value);
        chosen_sauce = Console.ReadLine("What pizza sauce would you like to select for your pizza today?")
            Console.WriteLine(chosen_sauce);
    }

    class Toppings : favoritePizza
    {
        public override void crust();
    }
public void toppings()
    {
        myToppings = {"Beef": {0}, "Salami": {1}, "Pepperoni": {2}, "Italian Sausage": {3}, "Premium Chicken": {4}, "Bacon:": {5},"Philly Steak": {6}}
        foreach(var t in myToppings)
            Console.WriteLine("Key: {0}",Value: {1}, s.Key, s.Value);
        chosen_topping = Console.ReadLine("What pizza topping would you like to select for your pizza today?")
            Console.WriteLine(chosen_topping);
    }

class Additions : favoritePizza
{
    public override void crust()
}
    {
        public void additions()
        { 
            mybeverages = {"Coke": {0}, "Diet Coke": {1},"Sprite": {2}, "Fanta Orange": {3}} 
            myAppetizers = {"Parmesan Bread Bites": {0},"Parmesan Bread Twists": {1}, "Garlic Bread Twists": {2}} 
            myDesserts = {"Baked Apple Dip & Cinnamon Bread Twists": {0},"Cinnamon Bread Twists"; {1}, "Domino's Marbled Cookie Brownie": {2}, "Chocolate Lava Crunch Cakes": {3}}
        // Nested for loop to iterate through 3 dictionaries 
        foreach(var b in mybeverages):
            Console.WriteLine("Key: {0)",Value: {1}, b.Key, b.Value);
            chosen_beverage = Console.ReadLine("What beverage(s) would you like to enjoy with your pizza?");
            Console.WriteLine(chosenBeverage);
            foreach(var a in myAppetizers):
                Console.WriteLine("Key: {0}",Value: {1},a.Key,a.Value);
                chosen_appetizer = Console.ReadLine("What appetizer(s) would you like to enjoy with your pizza?");
                Console.WriteLine(chosen_appetizer);
                foreach(var d in myDesserts):
                    Console.WriteLine("Key : {0}",Value: {1},d.Key,d.Value);
                    chosen_dessert = Console.ReadLine("What dessert(s) would you like to enjoy with your pizza? ");
                    Console.WriteLine(chosen_dessert);
                    
    }

        static void Main(string[] args)
        {
            favoritePizza myfavoritePizza = new favoritePizza();
            favoritePizza sauces = new Sauce();
            favoritePizza toppings = new Toppings();
            favoritePizza additions = new Additions();
            
            myfavoritePizza.crust();
            sauces.crust();
            toppings.crust();
            additions.crust();
        }
