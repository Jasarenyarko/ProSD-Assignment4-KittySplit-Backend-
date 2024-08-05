# ProSD-Assignment_4
KittySplit Backend Simulation

Overview

This project is a simplified backend implementation of the KittySplit web application, designed to demonstrate proficiency in LINQ and C#’s Entity Framework. The project consists of two primary tasks:

Analysis of the KittySplit Web Application
Implementation of a Console Application Backend
Task 1: Analysis
The web application analyzed is KittySplit, an expense and bill tracking app. The primary use-cases identified are:

Creating a New Kitty: This allows users to start a new expense tracking group easily without registration. It sets up the foundation for tracking group expenses and makes the process quick and user-friendly.
Adding Participants to Kitty: Users can add the names of individuals who will be sharing expenses. Identifying participants is crucial for accurately tracking who owes what in the group.
Recording Expenses: Users can input detailed information about each expense, including the amount, payer, and participants sharing the cost. This is the core functionality of the app, enabling precise tracking of all shared expenses.
Viewing and Editing Expenses: Users can review all recorded expenses and make necessary edits or deletions. Ensures accuracy and allows for corrections, maintaining the integrity of the expense records.
Settling Balances: Provides a summary of final balances and suggests ways to settle debts among participants. Facilitates the resolution of financial discrepancies.
The detailed analysis is provided in the accompanying PDF file.

Task 2: Console Application
The console application is structured into three layers:

Console Application:
Main Class and Method: The entry point of the application.
Use-Case Functions: Functions implementing the identified use-cases, including:
Creating a New Kitty
Adding Participants to Kitty
Recording Expenses
Viewing and Editing Expenses
Settling Balances
Domain/Business Logic:
Classes and Interfaces: Define the business rules and logic for handling data related to Kitties, Participants, Expenses, and Settlements.
Database Abstraction:
Context and Config: Entity Framework context and configuration for managing database operations related to Kitties, Participants, and Expenses.