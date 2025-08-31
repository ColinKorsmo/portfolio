[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/fjZfWWKr)
## Your Name: Zachary Colin Korsmo


# CIDM 3312 Lab 3: Middleware, Razor Pages, and Logging

## Task 0: Setting up your ASP.NET Core project
1. Open up VS Code. Create a new ASP.NET Core project using the `webapp` template with the following terminal command: `dotnet new webapp`
  
2. ASP.NET Core projects run in a web server, not the console. Type `dotnet run` and go to the web site.
  
3. Browse the web site in your browser. The web site URL will be listed in the VS Code terminal. The web site may have an invalid security certificate. Allow an exception for it.
   
4. Press Ctrl+C at the terminal to shut down your app. Open `Program.cs` and look at lines 8-23. That code is the HTTP request pipeline. It should look like this -
  ```
  // Configure the HTTP request pipeline.
  if (!app.Environment.IsDevelopment())
  {
      app.UseExceptionHandler("/Error");
      // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
      app.UseHsts();
  }
  
  app.UseHttpsRedirection();
  app.UseStaticFiles();
  
  app.UseRouting();
  
  app.UseAuthorization();
  
  app.MapRazorPages();
  ```

5. **Delete** those lines of code and save your changes. Run your project again.
   
6. Visit the website. What do you see? Why?
   
   I see a broken site that displays the following message. This localhost page can’t be found No webpage was found for the web address: http://localhost:5121/
HTTP ERROR 404
   
## Task 1: Add Some Middleware
1. In `Program.cs` where you deleted the HTTP request pipeline, add the following piece of middleware (After `var app = builder.Build();` and before `app.Run()`): 
    ```
    app.UseWelcomePage();
    ```

2. Run your project and visit the site in a web browser. What happens? Why?

    A blue screen with the text Welcome
    Your ASP.NET Core application has been successfully started.
    There is also a link to learn about ASP.NET core components
     
## Task 2: Serve Some Static Files
1. Create `example.html` in the `wwwroot` folder. Write some simple html for this page.

2. Add `app.UseStaticFiles();` middleware after `app.UseWelcomePage();`

3. Run your project and navigate to the `example.html` page (http://localhost:5080/example.html) NOTE: Your HTTP Port may be different.

4. Why is the welcome page still showing?

    The static files need to be put before the welcome page
   
6. Alter your code so that the content from `example.html` displays when you navigate to it and run your project again. The Welcome Page should still display for all other requests.

## Task 3: Razor Pages
1. Put the original middleware back. Replace `app.UseStaticFiles();` and `app.UseWelcomePage();` with the original middleware shown in Task 0.
   
2. Create a new Razor Page called `Time.cshtml` in the Pages folder with the following code:
      ```
      @page
      <div class="text-center">
        <p>Time: @DateTime.Now</p>
      </div>
      ```
    
3. Your Razor Page is called `Time.cshtml` so the URL will be the URL of your web site with `/Time` at the end (e.g. https://localhost:7111/Time). Run your app and refresh the page several times. Notice how the time keeps updating. 

## Task 4: Add your page to the layout
1. Go to `_Layout.cshtml` and add a link to `Time.cshtml` within the navigation area of the web site. See where it has HTML links for Home and Privacy - put HTML code there for your page.

2. Refresh the web site again and navigate to your Time page.

## Task 5: Add a Page Model
1. Create a Page Model called `Time.cshtml.cs` with the following code (You can copy from Index.cshtml.cs) Make sure to change the class name to TimeModel and namespace to match your project.
    ```
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    namespace lab3.Pages; // Change namespace to match your project

    public class TimeModel : PageModel
    {
        private readonly ILogger<TimeModel> _logger;

        public TimeModel(ILogger<TimeModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
    ```

2. Connect the Razor Page to the Page Model. How? Remember the `@model` keyword?

3. Within the Page Model create a string Property called Message and set it equal to some text.
    ```
    public class TimeModel : PageModel
    {
      public string Message {get; set;} = string.Empty;
      
      public void OnGet()
      {
        Message = "Your Message Here";
      }
    }
    ```
 The method `OnGet()` is automatically called when there is a request for you page (specifically an HTTP GET request)

 4. Add a logging message within the `OnGet()` method. Use `_logger.LogCritical()` and enter any message you like. Next time you run your app, look for the log message in the terminal.
 
 5. Modify `Time.cshtml` so that it displays your message. Your message is a C# variable like `DateTime.Now` but it is part of the Page Model. You can access it with `@Model.Message`. Refresh the web page in your browser and take a look. Look and see if the logging message is displayed in the VS Code Terminal also.
 
 ## Task 6: A more advanced model - Using a foreach loop
 1. Create a List of integers as a Property in the Page Model of `Time.cshtml.cs` called `LuckyNumbers`.
 
 2. Within the `OnGet()` method, initialize the list to a new list with a few lucky numbers.
 
 3. Razor Pages can really run most C# code. Write C# code in `Time.cshtml` to loop through every element of the list and display them with HTML. Use the `@` symbol to start your C# code. Good luck!
 
 4. Submit your assignment to GitHub.
  
  
