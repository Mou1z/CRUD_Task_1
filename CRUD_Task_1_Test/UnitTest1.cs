using System.Data;
using MySql.Data.MySqlClient;

[TestClass]
public class CRUD_Task_1_Test
{
    private readonly string connectionString = CRUD_Task_1.connectionString;

    [TestMethod]
    public void TestTableCreation()
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            // Query the information schema to get column details
            string cmdText = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'products'";
            MySqlCommand cmd = new MySqlCommand(cmdText, connection);
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());

            // Check if all columns with correct data types exist
            Assert.IsTrue(table.Rows.Count == 5, "Number of columns does not match expected.");
            AssertColumnExistsWithDataType(table, "id", "INT");
            AssertColumnExistsWithDataType(table, "name", "VARCHAR");
            AssertColumnExistsWithDataType(table, "category", "VARCHAR");
            AssertColumnExistsWithDataType(table, "price", "FLOAT");
            AssertColumnExistsWithDataType(table, "stock_quantity", "INT");
        }
    }

    private void AssertColumnExistsWithDataType(DataTable table, string columnName, string expectedDataType)
    {
        DataRow[] rows = table.Select($"COLUMN_NAME = '{columnName}' AND DATA_TYPE = '{expectedDataType}'");
        Assert.IsTrue(rows.Length == 1, $"Column '{columnName}' with data type '{expectedDataType}' not found.");
    }
}
