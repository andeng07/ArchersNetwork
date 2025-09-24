# Archers Network Video API

A CRUD (Create, Read, Update, Delete) REST API built with **ASP.NET Core Web API** and **MongoDB** for managing videos from Archers Network.

Each video contains:
- **Title** – Title of the video
- **Date** – Date and time video was uploaded
- **Description** – Description/caption attached to the video
- **Link** – Link to the video on YouTube
- **Channel** – Channel where the video comes from
- **Series** – Type of video series the video falls under

---

## 📌 Features & Endpoints

| Method | Route                | Description |
|--------|----------------------|-------------|
| `POST` | `/videos`            | Add a new video |
| `GET`  | `/videos/{id}`       | Get a specific video by ID |
| `PUT`  | `/videos/{id}`       | Update an existing video |
| `DELETE` | `/videos/{id}`     | Delete a video |
| `GET`  | `/videos/select-all?series={series}` | Get all videos from a specific series |
| `GET`  | `/videos/get-latest?channel={channel}&limit={n}` | Get the latest video(s) from a channel |

---

## 🛠️ Tech Stack
- **ASP.NET Core Web API (C#)**
- **MongoDB** (NoSQL Database)
- **Swagger / OpenAPI** for API documentation

---

## 🚀 Getting Started

### 1. Install .NET SDK
Download and install the latest **.NET SDK (>= 9.0)** from:  
👉 https://dotnet.microsoft.com/en-us/download

### 2. Clone the Repository
```bash
git clone https://github.com/andeng07/ArchersNetwork.git
cd ArchersNetwork
```

### 3. Configure MongoDB
Update your `appsettings.json` with MongoDB connection details:
```json
{
  "MongoDB": {
    "ConnectionString": "mongodb://localhost:27017",
    "DatabaseName": "ArchersNetworkDB"
  }
}
```

### 4. Run the Application
```bash
dotnet restore
dotnet build
dotnet run --project .\ArchersNetwork.Backend\
```

By default, the API runs at:
```
http://localhost:5176
```

---

## 📂 Project Structure
```
ArchersNetwork.Backend/
│── Core/Endpoint                 # Minimal API abstractions
│── Features/Video/               # DTOs, Endpoints, Models, Services
│── Program.cs                    # Entry point
│── appsettings.json              # Configurations
│──ArchersNetwork.Backend.http    # Endpoint requests
```

---
