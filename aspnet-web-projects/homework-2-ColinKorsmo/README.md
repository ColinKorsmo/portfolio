[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/jrxFyM70)
## Your Name: Zachary Colin Korsmo

# CIDM 3312 Homework 2 - Razor Pages
ThoughtTronix has become inundated with complaints about their AI products and they are tired of hearing about them. The company has tasked you, their intern, with creating an ASP.NET Core Razor Page containing a complaint form. You will read in the users' complaints and confirm their submission according to the following requirements.

## Requirements
Create a Razor Page called `Complaint.cshtml` and a corresponding Page Model called `Complaint.cshtml.cs`.

Match the layout of the Razor Page to the picture in Figure 1 below:
  - Use an &lt;h3&gt; tag with the text "ThoughtTronix Complaint Form". Use a &lt;p&gt; tag for the sentence below.
  - Use a &lt;form&gt; tag that will perform an HTTP Post request.
  - Create a form with Bootstrap classes.
  - Use an &lt;h5&gt; tag with Bootstrap class "mb-3" for the "Select a product..." text.
  - Use radio buttons with values of 1, 2, 3, and 4 for each respective product.
  - Use an &lt;hr class="my-4"&gt; for the horizontal lines.
  - The Message should use the &lt;textarea&gt;&lt;/textarea&gt; HTML tags.
  - Ensure all HTML tags use the proper Bootstrap classes.
  - Add a link to your razor page in the navigation menu of the web site by adding the correct HTML code to Pages\Shared\_Layout.cshtml.

Create the Page Model to read in the contents of the form when the user clicks Submit:
  - Use Model Binding to input the selected product, Name, Email, and Message.
  - Use logging to display the selected product, Name, Email, and Message to the console when the user clicks submit. You should log at the LogWarning level.
  - Use the proper tag helpers on the &lt;label&gt; and &lt;input&gt; tags on the Razor Page.
  - Perform Data Validation:
      - The Name field should be required with a maximum string length of 30 and minimum of 3.
      - The Email field should be required and validated as an Email Address.
      - The Message should be required and limited to 500 characters.
      - The SelectedProduct field should be required and display a custom error message of "Please select a product."
  - Place the proper HTML tags, tag helpers, and code on the Razor Page to perform the validation and display errors as shown in Figure 2.

When the user clicks Submit, display a message at the bottom of the page saying "Thank you for your complaint about {ProductName} - {Name} ({Email}) / {Message}." as shown in Figure 3. This message should display the actual product name and not the number of the radio box. You need to convert the number into a product name. This message should NOT display until the user successfully clicks Submit.

**Don't forget to comment your code.**


**Push all your changes to GitHub when you are finished with the commit message "Ready for Grading".**

![Figure 1](https://i.imgur.com/mg7WAPp.png)
Figure 1: Web page when user first visits

![Figure 2](https://i.imgur.com/nPeZa4u.png)
Figure 2: Data Validation Errors

![Figure 3](https://i.imgur.com/C9lUgqL.png)
Figure 3: Web Page after user clicks Submit. Page should reload and display the message.
