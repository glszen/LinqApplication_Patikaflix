# LinqApplication_Patikaflix

Project Overview

This project allows users to create a list of TV series in C# by inputting details such as Series Name, Genre, and Director through the console. The goal is to filter the list by Comedy genre, sort it by Series Name and Director, and then display the sorted list.

Key Features

1. Dynamic Input:

*Users add TV series details (name, genre, director) interactively via the console.

*After adding each series, the user is asked if they want to add more.

2. Filtering Comedy Series:

*A new list is created containing only Comedy series with Name, Genre, and Director.

3. Sorting:

*The filtered list is sorted first by Series Name, and then by Director's Name if names are identical.

4. Display:

*The sorted list is printed in a readable format to the console.

Project Structure

1. TVSeries Class: Holds properties for Name, Genre, and Director.
2. Main Program: Handles user input, filtering, and sorting using LINQ.
   
Technologies Used

C#
LINQ
