
# ToDoApp 🎯

A Blazor WebAssembly application designed to manage events efficiently. It allows users to create, edit, view, and delete events with a modern, responsive interface. The application integrates with a backend API to store and retrieve event data.

---

## Features

- **Event Creation**: Add new events with details like title, description, start and end dates, and all-day status.
- **Event Editing**: Modify existing events with a user-friendly form.
- **Event Listing**: View a list of all events in a structured format.
- **Responsive Design**: Built with Bootstrap for a clean and responsive UI.
- **Blazor WebAssembly**: Runs entirely in the browser for a fast and modern experience.

---

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) installed on your machine.

## Running the Application

1. **Clone the repository**:
   ```bash
   git clone https://github.com/sid-rahman/TodoApp.git
   cd TodoApp
   
2. **Build and run the backend API**:
   ```bash
    cd TodoApp
    dotnet run

3. **Build and run the Blazor WebAssembly project**:
   ```bash
    cd TodoApp.Blazor
    dotnet run
   
4. Open your browser and navigate to http://localhost:5000 (or the port specified in your launch settings).

---

## Screenshots

<div align="center">
  
  ### Event List
  <img src="https://github.com/user-attachments/assets/68718e35-2057-4f95-8fa5-17ba7fb5ecbd" alt="Event List" width="800">
  
  ### Create Event
  <img src="https://github.com/user-attachments/assets/3f9c7dd9-baad-4723-abbe-7b8287e80c48" alt="Create Event" width="800">
  
  ### Edit Event
  <img src="https://github.com/user-attachments/assets/868aaae1-7608-4750-ba55-9486fcdbd90b" alt="Edit Event" width="800">
  
  ### Delete Event
  <img src="https://github.com/user-attachments/assets/2e0670f4-6e9a-4218-9d27-97a320609600" alt="Delete Event" width="800">
</div>

---

## Technologies Used
- **Frontend**: Blazor WebAssembly
- **Backend**: ASP.NET Core Web API
- **Styling**: Bootstrap
- **Data Handling**: HttpClient for API communication
- **Language**: C# 13.0
- **Framework**: .NET 9
  
---

## Project Structure
- **TodoApp.Blazor**: The Blazor WebAssembly frontend.
- **TodoApp**: The backend API for managing events.
- **TodoApp.Data**: Shared data models and entities.
- **TodoApp.Business**: Business logics and services.
