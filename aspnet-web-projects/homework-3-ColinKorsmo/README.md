[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/WpNg16sv)
## Your Name:

# CIDM 3312 Homework 3 - Frontend: Checkout Page
For this homework, you are being tasked with creating a Checkout page for ThoughtTronix. A user will enter all their billing information and submit the checkout. You must validate all user input and show a confirmation page at the end.

## Requirements
Create a Razor Page called `Checkout.cshtml` and a corresponding Page Model called `Checkout.cshtml.cs`.

The Checkout razor page should look like this image (https://i.imgur.com/d0jIgYv.png):

![Checkout](https://i.imgur.com/d0jIgYv.png)

Follow the design practices you've learned in our Advanced Bootstrap lesson, lab 5, and lab 6. In particular pay attention to -
* Create an entity class to represent the `Order`. Place all data validation in the entity class.
* Use an enum class to represent the Country and State. Add at least 3 countries and 3 states. You don't need all.
* Use a regular expression to validate the zip code as being 5 numbers. We have not learned regular expressions yet.
    - The code is this `[RegularExpression(@"\d{5}$", ErrorMessage = "Invalid Zip Code")]`
    - Regular Expressions are a programming tool to match any sort of text or numbers and are very powerful and complex.
    - This regular expression uses `\d` to represent decimal numbers and then `{5}` to indicate that there must be 5 numbers.
    - This is a simple zipcode validation that is a good introduction to regular expressions.
* Add `additional-methods.min.js` script to **_ValidationScriptsPartial.cshtml** to validate the Credit Card.
* Add Bootstrap validation script code to the same **_ValidationScriptsPartial.cshtml** to enable the custom Bootstrap validation styles.
* Place a link to your Checkout page in the navbar in **_Layout.cshtml**.

Entity Class properties -

| Property Name | Data Validation Rules |
|---------------|-----------------------|
| FirstName     | Display as "First Name" |
| LastName      | Display as "Last Name" |
| Email         | Validate as [EmailAddress] |
| Address       | No specific validation |
| Country       | Data Type = Country?, Required |
| State         | Data Type = State?, Required |
| Zip           | string, validate as 5 numbers regular expression (see above) |
| SameShippingInfo | bool, Display as "Shipping address is the same as my billing address" |
| SaveInformation | bool, Display as "Save this information for next time" |
| PaymentType   | int |
| NameOnCard    | Display as "Name on card" |
| CreditCardNumber | Display as "Credit card number", validate as [CreditCard] |

* UI for Checkout.cshtml razor page should match the screenshot as best as possible.
      - Use nested rows and columns to display Billing address and Cart in a column next to it.
      - Billing Address should be `col-7` and Cart should be `col-3`.
      - Displaying the cart uses a table with a border. The cart and costs are hard-coded in the razor page.
      - Checkout Button should have the classes `w-100 btn btn-lg btn-primary` to appear the same as in my screenshot.

Create a Confirmation Razor Page called `Confirmation.cshtml` and a corresponding Page Model called `Confirmation.cshtml.cs`.

The Confirmation page should look like this image (https://i.imgur.com/DoGN7Gb.png):

![Confirmation](https://i.imgur.com/DoGN7Gb.png)

Data Validation should look like these images (https://i.imgur.com/oTnCHqI.png AND https://i.imgur.com/p26mHfN.png):

![Success](https://i.imgur.com/oTnCHqI.png)

![Failure](https://i.imgur.com/p26mHfN.png)

