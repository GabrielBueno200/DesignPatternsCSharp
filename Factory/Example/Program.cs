﻿/*
Factory Coding Exercise
You are given a class called Person . The person has two fields: Id , and Name .

Please implement a non-static PersonFactory  that has a CreatePerson()  method that takes a person's name.

The Id of the person should be set as a 0-based index of the object created. So, the first person the factory makes should have Id=0, second Id=1 and so on.

*/

using Example;

var firstPerson = new PersonFactory().CreatePerson("Ashley");
var secondPerson = new PersonFactory().CreatePerson("Josh");
var thirdPerson = new PersonFactory().CreatePerson("Joe");

Console.Write($"{firstPerson.Id} {secondPerson.Id} {thirdPerson.Id}");
