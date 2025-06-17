# 📘 GraphQL CRUD API with ASP.NET Core

This project demonstrates how to build a simple GraphQL API with full CRUD operations using ASP.NET Core and HotChocolate. The backend uses Entity Framework Core with an in-memory database.

## 🚀 Features

- Built with ASP.NET Core and HotChocolate
- GraphQL queries and mutations
- CRUD operations on a `Book` entity
- Testable via Postman
- In-memory database for simplicity

---

## 🛠️ Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### ✅ Prerequisites

Before you begin, make sure you have the following installed:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Git](https://git-scm.com/)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

---

## ⬇️ Clone the Repository

Open your terminal and run the following command:

```bash
git clone https://github.com/rashedulalam46/graphql-crud.git
cd graphql-crud
```

## ▶️ Run the Project

Open your terminal and run the following command to restore depedencies, build & run the project:

```bash
dotnet restore
dotnet build
dotnet run
```

The API will start on http://localhost:5000 or https://localhost:5001.

## 🔍 Test the API with Postman

Open Postman and create a POST request to:

```bash
http://localhost:5000/graphql
```

In the Body, select raw and JSON, then use sample input like:

Add a Book:

```bash
{
  "query": "mutation { addBook(input: { id:1001, title: \"Fulkumari\", author: \"Pinaki Bhattacharya\" }) { id title author } }"
}
```

Get All Books:

```bash
{
  "query": "query { books { id title author } }"
}
```

Get Book By ID:

```bash
{
  "query": "query { bookById(id: 1001) { id, title author } }"
}
```

Update a Book:

```bash
{
  "query": "mutation { updateBook(id: 1001, updated: { id: 1001, title: \"Homo Deus\", author: \"Yuval Noah Harari\" }) { id title author } }"
}
```

Delete a Book:

```bash
{
  "query": "mutation { deleteBook(id: 1003) }"
}
```

## ✅ Expected Output

Request response like (for all book):

```bash
{
    "data": {
        "books": [
            {
                "id": 1001,
                "title": "Sapiens",
                "author": "Yuval Noah Harari"
            },
            {
                "id": 1002,
                "title": "Fulkumari",
                "author": "Pinaki Bhattacharya"
            },
            {
                "id": 1003,
                "title": "History Of Arob",
                "author": "Kamal Hossain"
            }
        ]
    }
}
```

If validation passes, you’ll get a 200 OK response or a confirmation message depending on your controller logic.

## 📁 Project Structure

```bash
GraphQLCrud/
│
├── Models/
│   └── Book.cs            # The data model
│
├── Data/
│   └── AppDbContext.cs    # In-memory EF Core DB context
│
├── GraphQL/
│   ├── Query.cs           # GraphQL queries
│   └── Mutation.cs        # GraphQL mutations
│
└── Program.cs             # App startup and service config

```

## 🤝 Contributing
Pull requests are welcome! If you find bugs or have suggestions, feel free to open an issue.

## 📄 License
This project is licensed under the MIT License.

## 👤 Author
[Rashedul Alam](https://github.com/rashedulalam46)

