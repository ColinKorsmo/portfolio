[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/p7l5DvwY)
## Your Name: Zachary Colin Korsmo

# CIDM 3312 Lab 8: ASP.NET Core + EF Core Simple Modeling

In this lab exercise you will create an ASP.NET Core + EF Core Web App that keeps track of patients being admitted to your hospital. Patients are being admitted with unsettling symptoms after using the MindSync neural implant. 

This lab will follow the 8 steps to combine ASP.NET and EF Core. It will very closely resemble the Week 9 Lesson on ASP.NET Core + EF Core Simple Modeling that built a web app displaying students. If you copy and paste any code, make sure to doublecheck namespace names and ensure they match the project hierarchy of this lab. Follow these requirements to complete this lab exercise:

## Task 1: Combine ASP.NET Core + EF Core by following the 8 steps

1. Follow the 8 steps to combine ASP.NET Core and EF Core. Start with step 1, `dotnet new webapp`.
2. Your Entity Class will model patients and should look like this:

  | Property Name | Data Validation Rules |
  | ------------- | --------------------- |
  | FirstName     | string, Display as "First Name", String Length Max of 20, Min of 3 |
  | LastName      | string, Display as "Last Name", String Length Max of 20, Min of 3 |
  | AdmitDate     | DateTime, Display as "Admittance Date", [DataType(DataType.Date)] |
  | SymptomDescription | string, Display as "Description of Symptoms" |

3. Seed the database with these five initial patients:

 | FirstName | LastName | AdmitDate  | SymptomDescription |
 | --------- | -------- | ---------- | ------------------ |
 | Samantha  | Carter   | 10/01/2024 | Severe migraines, Erratic behavior |
 | Jack      | O'Neill  | 10/02/2024 | Hallucinations, Memory loss |
 | Daniel    | Jackson  | 10/04/2024 | Seizures, Extreme mood swings |
 | George    | Hammond  | 10/14/2024 | Loss of motor control, Speech difficulties |
 | Janet     | Fraiser  | 10/20/2024 | Persistent dizziness, Glows in the dark |

4. In this lab, I'd like you to explore the DateTime data type. This data type stores Dates and Times.
     - Use the data validation rule [DataType(DataType.Date)] in the entity class to display it as just a Date.
     - Use `DateTime.Parse("10/01/2024")` to convert a string into a DateTime object. Use this when seeding initial data.
     - When you add and edit patients, confirm that the AdmitDate input field brings up a calendar that lets you select the date.

## Task 2: List all Patients

1. List all patients on the Index razor page. Your page should look like this screenshot:

![Listing](https://i.imgur.com/cIZQI5g.png)

## Task 3: Add a new patient

1. Make a Create razor page and page model to add a new patient. Your page should look like this screenshot:

![Create](https://i.imgur.com/Ipn4da0.png)

## Task 4: View a single patient

1. Make a Details razor page and page model to view the details of a single patient. Your page should look like this screenshot:

![Details](https://i.imgur.com/84YrNv2.png)

## Task 5: Edit an existing patient

1. Make an Edit razor page and page model. Your page should look like this:

![Edit](https://i.imgur.com/0UuMGXj.png)

## Task 6: Delete an existing patient

1. Make a Delete razor page and page model. Your page should look like this:

![Delete](https://i.imgur.com/xZVA66B.png)

## Submit your assignment. You are now finished with Lab 8
