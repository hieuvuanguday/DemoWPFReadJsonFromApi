#DemoWPFReadJsonFromApi
A WPF application that demonstrates fetching JSON data from a public API and displaying it in a DataGrid.

Overview
This project uses a WPF application to load and display data from the https://jsonplaceholder.typicode.com/posts API. The JSON data is deserialized and presented to the user within a DataGrid, providing a simple and effective UI for viewing data fetched from an external source.

Features
Fetch Data: Retrieves JSON data from a sample API using HttpClient.
Display in DataGrid: Renders the fetched data in a WPF DataGrid for easy viewing.
Async Programming: Uses asynchronous programming to fetch data without blocking the UI thread.
Project Structure
MainWindow.xaml.cs: Handles UI logic, including fetching and displaying data in the DataGrid.
ApiServices.cs: Contains the logic for making the API call and deserializing JSON data.
User.cs: Represents the model used to store data for each entry fetched from the API.
Getting Started
Prerequisites
.NET Framework or .NET Core installed.
NuGet packages:
Newtonsoft.Json for JSON parsing.
Running the Application
Clone the repository:
git clone https://github.com/hieuvuanguday/DemoWPFReadJsonFromApi.git
cd DemoWPFReadJsonFromApi
Open the project in Visual Studio.

Restore NuGet packages if necessary.

Build and run the application.

Usage
When the application starts, it will automatically fetch data from the API.
The data will populate the DataGrid, where each row corresponds to a JSON post entry.
Code Explanation
MainWindow.xaml.cs
Initializes and loads data into the DataGrid when the window loads.
Uses an instance of ApiServices to fetch the JSON data.
ApiServices.cs
Handles HTTP requests to the JSONPlaceholder API.
Deserializes the JSON response into a list of User objects.
User.cs
A data model that maps to each post object in the JSON response.
Properties include userId, id, title, and body.
Troubleshooting
If the application cannot fetch data, ensure you have a stable internet connection.
Check for updates or compatibility issues with Newtonsoft.Json if serialization errors occur.
License
This project is licensed under the MIT License.

