# Animal-Kingdom

## Description
This is a lab to test Object Oriented Principles and Interfaces in the framework of the Animal Kingdom/Zoo. It goes three levels deep of inheritance and classes, with 2 interfaces that are attached to classes on different tiers of abstractness. 

## Visual
![Alt Text](https://github.com/MinMaxed/Lab05-Animal-Kingdom/blob/master/AK%20Visual.png)

## Interfaces

Interfaces are a workaround to C#'s single-inheritance, and tells the class what it is able to do. In this lab, they ICanFly and ICanSwim are used throughout the branches. These were chosen since those two abilities are not directly tied to just fish swimming or birds flying. Swim and Fly are both used by the Ducks since they can do both, GreyWolves has Swim but not all canines can swim (I don't think), and Bats, a mammal that can fly, also has access to the ICanFly. 

## OOP Principles
An introduction to the project
Your digital drawing of your zoo
Create your own technical documentation. Breakdown and define each of the OOP principles in your own words.
Provide under each OOP definition a couple (you do not have to define all) of examples of how you are applying this into your project

Inheritance: Inheritance is when a more base class can utilize the methods and properties of parent classes. In this lab, Sound and Diet are Animal classes inherited by all sub classes, and Sweat Glands is added in for the mammals and used by its children

Abstraction: Abstract classes cannot be istantiated. Animal, Mammal, Fish, all classes that are not concrete in this lab are Abstract. 

Polymorphism: abstract methods can only live in abstract classes, virtual live in any, both can be overridden and sealed. IsNocturnal & LegCount are examples of abstract classes from Animal, Sweat Glands are an example of a virtual method from Mammals, and the Sound of the Owl has been Sealed. 

Encapsulation:  Limits access; public (all access pass) like most of the methods, private (can only be accessed within the class itself) OceanKing on GreatWhiteShark,  protected (itself and its children have access) such as Sushiable.

