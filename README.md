## BlazorServer5.0/SRC/

File Export and SQLServer sample. Half finished?

---

## BlazorServer5.0/SRC_Plane

Source code created by Blazor Server templates in Visual Studio 2019. No changes have been made.

---

## BlazorServer5.0/Src_1ColumnHeader/WebApplication1

Make headers one column in Blazor Server.

In the Blazor Server template, the headers are in two columns, which is inconvenient for business websites, so I made the headers in one column.

[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e3%83%98%e3%83%83%e3%83%80%e3%83%bc%e3%82%921%e5%88%97%e3%81%ab%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_Appsettings/WebApplication1

Displaying Preference File Values on Screen in Blazor Server.

Implemented a process to read the user setting value in the appsettings.json environment setting file when the web application is started and display it as the title of the application.

[YouTube](https://youtu.be/HrY-goiIGPs)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e7%92%b0%e5%a2%83%e8%a8%ad%e5%ae%9a%e3%83%95%e3%82%a1%e3%82%a4%e3%83%ab%e3%81%ae%e5%80%a4%e3%82%92%e7%94%bb%e9%9d%a2%e3%81%ab%e8%a1%a8%e7%a4%ba%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_Asynch1/WebApplication1

The simplest implementation of asynchronous processing realized by Blazor Server.

I made the simplest asynchronous processing sample that can be realized with Blazor Server, so please refer to it.

[YouTube](https://youtu.be/yFDaNTpmvoY)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e5%ae%9f%e7%8f%be%e3%81%99%e3%82%8b%e6%9c%80%e3%82%82%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab%e3%81%aa%e9%9d%9e%e5%90%8c%e6%9c%9f%e5%87%a6%e7%90%86%e3%81%ae%e5%ae%9f%e8%a3%85/)

---

## BlazorServer5.0/Src_Button/WebApplication1

Blazor Server don't let submit on button click.

The sample button provided in the initial project of Blazor Server is a submit button, so if you add buttons to the screen based on that, all the added buttons will submit, and the submit button/submit It tends to be addictive when you want to provide both buttons on the screen.
I made a sample so that you can compare the implementation of submit button, normal button and link button.

[YouTube](https://youtu.be/jAIFhuXp6gQ)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7submit%e3%81%97%e3%81%aa%e3%81%84%e3%83%9c%e3%82%bf%e3%83%b3/)

---

## BlazorServer5.0/Src_CoreHtmlToImage/WebApplication1

Create and download images in Blazor Server (on Windows).

When implementing a function to convert web screens and documents to image data and download them in Blazor Server, it is better to prepare an HTML template file and convert it to image data with wkhtmltoimage before downloading.

[YouTube](https://youtu.be/Eau90KGIVvU)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e7%94%bb%e5%83%8f%e3%82%92%e4%bd%9c%e6%88%90%e3%81%97%e3%83%80%e3%82%a6%e3%83%b3%e3%83%ad%e3%83%bc%e3%83%89%e3%81%99%e3%82%8bon-windows/)

---

## BlazorServer5.0/Src_Dapper_Oracle/WebApplication1

Incomplete.

---

## BlazorServer5.0/Src_Disabled/WebApplication1

Simple implementation of Html tag disabled in Blazor Server.

Implemented a text box that links the checkbox check state and the "enabled/disabled" state.
I implemented it by using the bound variable as it is and returning the value corresponding to disabled from the bool type extension method, but this implementation method can simplify the source code the most.

[YouTube](https://youtu.be/WsQl9VsHJKc)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7html%e3%82%bf%e3%82%b0%e3%81%aedisabled%e3%82%92%e3%82%b7%e3%83%b3%e3%83%97%e3%83%ab%e3%81%ab%e5%ae%9f%e8%a3%85%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_DownloadCsvFile/WebApplication1

Download CSV file in Blazor Server.

In Blazor Server, I implemented a CSV file download process using the "BlazorDownloadFile, CsvHelper" Nuget package. I think this implementation is the shortest.

[YouTube](https://youtu.be/zQVsVsYMWqM)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7csv%e3%83%95%e3%82%a1%e3%82%a4%e3%83%ab%e3%82%92%e3%83%80%e3%82%a6%e3%83%b3%e3%83%ad%e3%83%bc%e3%83%89/)

---

## BlazorServer5.0/Src_DownloadFile/WebApplication1

Download files in Blazor Server.

File download for text data and file download for image data.

[YouTube](https://youtu.be/4fSVO6MKClY)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e3%83%95%e3%82%a1%e3%82%a4%e3%83%ab%e3%82%92%e3%83%80%e3%82%a6%e3%83%b3%e3%83%ad%e3%83%bc%e3%83%89%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_EFCoreCodeFirst/WebApplication1

Log SQL issued by EFCore Code First.

I made a sample that leaves SQL issued from EFCore Code First in a log file. I think it is essential to improve code-first DB performance by adding indexes.
This time, I'm creating it based on the popular Blazor Server, but it's the same for anything other than Blazor Server.

SQL issued from EFCore Code-First is printed with Microsoft's log level set to debug, but you can also print it by overriding the DbContext's OnConfiguring method.
If you set Microsoft's log level to debug and output the SQL issued by Code First, a large amount of logs other than the issued SQL will be output. is recommended.

If you override the DbContext's OnConfiguring method to log the SQL issued by Code First. Log file size is 2KB.
When the Microsoft log level is set to debug and the SQL issued by CodeFirst is logged. The log file size is 31KB.

[YouTube](https://youtu.be/xPougKDav5w)
[Source code explanation page](https://blog.unikktle.com/efcore%e3%82%b3%e3%83%bc%e3%83%89%e3%83%95%e3%82%a1%e3%83%bc%e3%82%b9%e3%83%88%e3%81%8c%e7%99%ba%e8%a1%8c%e3%81%97%e3%81%9fsql%e3%82%92%e3%83%ad%e3%82%b0%e5%87%ba%e5%8a%9b%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_ExcelFileDownload/WebApplication1

Download the Blazor Server Excel file.

I created a sample that places an Excel file on Blazor Server, outputs the values entered from the screen to the Excel file, and downloads the output Excel file.

[YouTube](https://youtu.be/0cNJvDfl0C0)
[Source code explanation page](https://blog.unikktle.com/blazor-server-excel%e3%83%95%e3%82%a1%e3%82%a4%e3%83%ab%e3%82%92%e3%83%80%e3%82%a6%e3%83%b3%e3%83%ad%e3%83%bc%e3%83%89%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_ExcelFileUpload/WebApplication1

Upload Blazor Server Excel file.

I created a sample that uploads an Excel file with the Blazor Server \<InputFile> built-in component, reads the uploaded Excel file, and displays the data in the Excel file on the screen.
I'm using the ClosedXML nuget package for reading excel files.

[YouTube](https://youtu.be/fU8HGOrXJY8)
[Source code explanation page](https://blog.unikktle.com/blazor-server-excel%e3%83%95%e3%82%a1%e3%82%a4%e3%83%ab%e3%82%92%e3%82%a2%e3%83%83%e3%83%97%e3%83%ad%e3%83%bc%e3%83%89%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_ExceptionMessageBox/WebApplication1

Handling Exceptions in Blazor Server.

Log output and screen output are performed when an Exception occurs.
By displaying only a message to the user and making it impossible to check the source code without looking at the log, it prevents the leakage of the source code and also notifies the user of an unexpected processing failure due to a bug. I'm here.

[YouTube](https://youtu.be/vvzVs3Eo3UE)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%E3%81%A7-exception-%E3%82%92%E5%87%A6%E7%90%86%E3%81%99%E3%82%8B/)

---

## BlazorServer5.0/Src_HamburgerMenu/WebApplication1

Turn your sidebar into a hamburger menu in Blazor Server.

Turned the sidebar into a hamburger menu in Blazor Server.
I think this method is the most convenient for the side menu.

[YouTube](https://youtu.be/edcJmaCQmUs)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e3%82%b5%e3%82%a4%e3%83%89%e3%83%90%e3%83%bc%e3%82%92%e3%83%8f%e3%83%b3%e3%83%90%e3%83%bc%e3%82%ac%e3%83%bc%e3%83%a1%e3%83%8b%e3%83%a5%e3%83%bc%e3%81%ab%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_HtmlTable/BlazorApp1

Incomplete.

---

## BlazorServer5.0/Src_InputFile/WebApplication1

Customize Blazor Server file upload button.

I implemented file upload processing using Blazor Server's \<InputFile> built-in component. It also implements a pattern example that changed the layout and design of \<InputFile>.

[YouTube](https://youtu.be/zWP2AWRjaiE)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%83%95%e3%82%a1%e3%82%a4%e3%83%ab%e3%82%a2%e3%83%83%e3%83%97%e3%83%ad%e3%83%bc%e3%83%89/)

---

## BlazorServer5.0/Src_Log/WebApplication1

Output logs in Blazor Server.

Output logs in Blazor Server. Deployable on both Windows and Linux.

[YouTube](https://youtu.be/Lh2e5tGzEwk)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e3%83%ad%e3%82%b0%e3%82%92%e5%87%ba%e5%8a%9b%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_MessageBox/WebApplication1

Easy-to-use MessageBox for Blazor Server.

We have created a user-friendly MessageBox that is as easy to use as the Windows Form application MessageBox, so please use it in Blazor Server.

[YouTube](https://youtu.be/lsUYVG4WQ3g)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e4%bd%bf%e3%81%88%e3%82%8b%e3%80%81%e4%bd%bf%e3%81%84%e5%8b%9d%e6%89%8b%e3%81%ae%e8%89%af%e3%81%84-messagebox/)

---

## BlazorServer5.0/Src_MessageBox_v2/WebApplication1

Blazor Server Usable MessageBox v2.

[YouTube](https://youtu.be/lsUYVG4WQ3g)
[Easy-to-use MessageBox for Blazor Server](https://blog.unikktle.com/blazor-server-%e3%81%a7%e4%bd%bf%e3%81%88%e3%82%8b%e3%80%81%e4%bd%bf%e3%81%84%e5%8b%9d%e6%89%8b%e3%81%ae%e8%89%af%e3%81%84-messagebox/) Corrected the button of the message box implemented in , to right alignment.

[YouTube](https://youtu.be/-BtiuyKg2HU)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e4%bd%bf%e3%81%84%e5%8b%9d%e6%89%8b%e3%81%ae%e8%89%af%e3%81%84-messagebox-v2/)

---

## BlazorServer5.0/Src_OnInputEvent/WebApplication1

Use @oninput when handling input events in Blazor Server.

I tried to implement the timing event processing with @onchange when the value of the input field is changed. It feels good to use.

[YouTube](https://youtu.be/jW2FMTdK9Vk)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e5%85%a5%e5%8a%9b%e3%82%a4%e3%83%99%e3%83%b3%e3%83%88%e5%87%a6%e7%90%86%e3%82%92%e8%a1%8c%e3%81%86/)

---

## BlazorServer5.0/Src_PageBase/WebApplication1

Centralizing Inject in Blazor Server.

Blazor Server by default allows usings to be aggregated in _Imports.razor, but not where Injects can be aggregated by default.

You can aggregate Inject by creating a base class for aggregating Inject and having each page inherit the base class from @inherits .

[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7inject%e3%82%92%e4%b8%80%e7%ae%87%e6%89%80%e3%81%ab%e7%ba%8f%e3%82%81%e3%82%8b/)

---

## BlazorServer5.0/Src_SessionID/WebApplication1

Get session id in Blazor Server.

I made a sample to get session variables with Blazor Server, so please refer to it.

[YouTube](https://youtu.be/1hViv1YVtCs)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e3%82%bb%e3%83%83%e3%82%b7%e3%83%a7%e3%83%b3id%e3%82%92%e5%8f%96%e5%be%97%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_SessionVariable/WebApplication1

Implementation with session variables in Blazor Server.

I made a sample of processing using session variables in Blazor Server, so please refer to it.

[YouTube](https://youtu.be/oYjp82e8QI0)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e3%82%bb%e3%83%83%e3%82%b7%e3%83%a7%e3%83%b3%e5%a4%89%e6%95%b0%e3%82%92%e4%bd%bf%e3%81%a3%e3%81%9f%e5%ae%9f%e8%a3%85/)

---

## BlazorServer5.0/Src_SidebarInputFocus/WebApplication1

Event manipulation of individual components from Blazor Server razor pages.

Implemented a process to focus on the input field of the sidebar when the top page is displayed.
Since Sidebar is a component, it is not possible to focus the Sidebar input field from an event in the razor page.
You can't handle events on individual components from the razor page, but you can use JavaScript to handle events across components.
The concept that what cannot be implemented on the server side should be implemented on the client side (web browser side) instead of the server side.

[YouTube](https://youtu.be/14LHHErrS8k)
[Source code explanation page](https://blog.unikktle.com/blazor-server-razor%e3%83%9a%e3%83%bc%e3%82%b8%e3%81%8b%e3%82%89%e5%80%8b%e5%88%a5%e3%82%b3%e3%83%b3%e3%83%9d%e3%83%bc%e3%83%8d%e3%83%b3%e3%83%88%e3%82%92%e3%82%a4%e3%83%99%e3%83%b3%e3%83%88%e6%93%8d/)

---

## BlazorServer5.0/Src_SidebarInputValue/WebApplication1

Link input values of Blazor Server razor pages and components.

In the razor page event, I implemented a process to enter a value in the input field of the sidebar component.
Since the sidebar is a component, it is not possible to enter values in the input fields of the sidebar from C# processing in the razor page, but you can implement functions across components using JavaScript.
The concept that functions that cannot be realized by server-side processing are realized on the client side (web browser side).

[YouTube](https://youtu.be/K0Xy4zIHRPg)
[Source code explanation page](https://blog.unikktle.com/blazor-server-razor%e3%83%9a%e3%83%bc%e3%82%b8%e3%81%a8%e3%82%b3%e3%83%b3%e3%83%9d%e3%83%bc%e3%83%8d%e3%83%b3%e3%83%88%e3%81%ae%e5%85%a5%e5%8a%9b%e5%80%a4%e3%82%92%e9%80%a3%e5%8b%95%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_SlackNotification/WebApplication1

Notify Slack with Blazor Server.

Using Slack's Webhook function, Blazor Server implemented the process of posting to the Slack workspace channel.
* Any application that can connect to the Internet can send Slack notifications from Webhooks.

The flow from obtaining the Slack Webhook URL, implementation using that URL, and notification.

[YouTube](https://youtu.be/ZWjiTCEXGMo)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7slack%e3%81%b8%e9%80%9a%e7%9f%a5%e3%81%99%e3%82%8b/)

---

## BlazorServer5.0/Src_Static/WebApplication1

Common methods used between Blazor Server screens.

Common methods used between Blazor Server screens are basically implemented as static classes and static methods, and put together in folders for common parts.

I made a sample that uses common processing implemented by static classes and static methods from two screens.

[Source code explanation page](https://blog.unikktle.com/blazor-server-%e7%94%bb%e9%9d%a2%e9%96%93%e3%81%a7%e4%bd%bf%e3%81%86%e5%85%b1%e9%80%9a%e3%83%a1%e3%82%bd%e3%83%83%e3%83%89/)

---

## BlazorServer5.0/Src_TextboxEnterkey/WebApplication1

After entering a value in the input field in Blazor Server, perform event processing at the timing when the Enter key is pressed.

I created a sample for processing when the Enter key is pressed after a value is entered in the \<input> tag.
This input field can also be used as a barcode input field.

This sample implements the following movements:
・ If "1" is entered in \<input> and the Enter key is pressed, the Index page is displayed.
・ If "2" is entered in \<input> and the Enter key is pressed, the Counter page is displayed.
・ If "3" is entered in \<input> and the Enter key is pressed, the FetchData page is displayed.

[YouTube](https://youtu.be/5nyliC_g7c4)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e5%85%a5%e5%8a%9b%e6%ac%84%e3%81%ab%e5%80%a4%e3%82%92%e5%85%a5%e5%8a%9b%e3%81%97%e3%81%9f%e5%be%8c%e3%80%81enter%e3%82%ad%e3%83%bc%e3%81%8c%e6%8a%bc%e3%81%95%e3%82%8c%e3%81%9f/)

---

## BlazorServer5.0/Src_WkHtmlToImage/WebApplication1

Create and download images in Blazor Server (on Linux).

When implementing a function to convert web screens and documents to image data and download them in Blazor Server, it is better to prepare an HTML template file and convert it to image data with wkhtmltoimage before downloading.

[YouTube](https://youtu.be/Eau90KGIVvU)
[Source code explanation page](https://blog.unikktle.com/blazor-server-%e3%81%a7%e7%94%bb%e5%83%8f%e3%82%92%e4%bd%9c%e6%88%90%e3%81%97%e3%83%80%e3%82%a6%e3%83%b3%e3%83%ad%e3%83%bc%e3%83%89%e3%81%99%e3%82%8bon-linux/)

---


