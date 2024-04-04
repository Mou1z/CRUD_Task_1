# Description
A grocery store's business is expanding and they need an efficient way for keeping track of their products. They hire you to make an application for them which is based on a MySQL database where they can store and monitor all the products which they have in stock.

Your task is to write the C# code for:
1. Connecting to your local MySQL database;
2. Creating a new table called `products` with the following columns:
- id: A column of type integer;
- name: A string value up to 100 characters;
- category: A string representing the category of the product. Can be up to 100 characters;
- price: A float value representing the price;
- stock_quantity: An integer representing the quantity of the product available in stock;

You can either create and connect to a new database or use an existing one.

### Hints
> **Hint 1:** Use `MySqlConnector` to establish a connection to the local database;

> **Hint 2:** You also need to close the connection using the `Close()` method or by utilizing the `using` statement;

> **Hint 3:** Creating objects is a non-query operation this command will be executed using the `ExecuteNonQuery()` method;
