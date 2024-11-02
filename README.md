# Demo WPF - Display JSON from API

A WPF application demonstrating how to fetch JSON data from a public API and display it in a DataGrid.

## Introduction

This application retrieves data from the API `https://jsonplaceholder.typicode.com/posts` and displays it in a DataGrid. This project helps you learn how to integrate JSON data from an API into a WPF application, utilizing asynchronous techniques in C#.

## Features

- **Fetch Data from API**: Sends an HTTP request to fetch JSON data.
- **Display Data**: Displays the data in a DataGrid for easy reading and management.
- **Asynchronous Handling**: Uses `async` and `await` to ensure the UI remains responsive.

## Project Structure

- **MainWindow.xaml.cs**: Handles the UI logic, including loading and displaying data in the DataGrid when the application starts.
- **ApiServices.cs**: Contains the function to fetch data from the API and convert JSON data into C# objects.
- **User.cs**: Data model to store the information of each post (userId, id, title, body).

## Setup Instructions

1. **Clone** the repository:
   ```bash
   git clone https://github.com/hieuvuanguday/DemoWPFReadJsonFromApi.git
   cd DemoWPFReadJsonFromApi
2. **Setup Instructions**
3. **Open the project in Visual Studio.**
4. **Install necessary packages from NuGet** (such as **Newtonsoft.Json** for JSON handling).
5. **Run the application.**
