Here’s a step-by-step guide in Markdown format for setting up an ASP.NET web front-end with a Node.js Azure Function backend, orchestrated using .NET Aspire. This includes a test project, Aspire host, and Service Defaults Projects.

---

The projects all live in the src folder, but docker and other files are in the root

---

# 🛠️ Full Stack Setup with .NET Aspire, ASP.NET Frontend, and Node.js Azure Function Backend

## 📁 Project Structure

```
/AspireSolution
│
├── /src/frontend               # ASP.NET Core Web App
├── /src/backend                # Node.js Azure Function
├── /src/tests                  # Aspire NUnit Test project
├── /src/AspireHost             # Aspire orchestration project
├── /src/AspireServiceDefaults  # Aspire Service Defaults
└── AspireSolution.sln      # Solution file
```

---

## 1. 🧱 Create the Aspire Solution

---

## 2. 🌐 Add ASP.NET Core Frontend

Update `frontend` to call the backend API (e.g., update env variable to point to API endpoint).

---

## 3. ⚙️ Add Node.js Azure Function Backend

Update `GetData/index.js` to return sample JSON data.

---

## 4. 🧪 Add Test Project

Add a sample test in `tests/UnitTest1.cs`.

---

## 5. 🚀 Add Aspire Host and Wire Up Services

In `AspireHost/Program.cs`, register the frontend and backend:

> Note: `AddNpmApp` is a custom extension method you may define to run `func start` via `npm` or `child_process`.

---

## 6. 🧩 Configure Service Defaults

In `AspireHost/ServiceDefaults.cs`:

---

## 7. 🧪 Run and Test

- Navigate to `http://localhost:<frontend-port>` to see the frontend.
- It should call the backend Azure Function and display the response.

---

## 🧼 Optional: Add Docker Support

You can containerize the backend and frontend and orchestrate them via Aspire using `builder.AddContainer()`.

---
