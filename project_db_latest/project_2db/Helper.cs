using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace project_2db;
public class Helper
{
    private readonly string connectionString;

    public Helper(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void InsertStudent(Student student)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO Students (StudentID, Password, PhoneNumber, StudentName) " +
                                 "VALUES (@StudentID, @Password, @PhoneNumber, @StudentName)";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@StudentID", student.StudentID);
                command.Parameters.AddWithValue("@Password", student.Password);
                command.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                command.Parameters.AddWithValue("@StudentName", student.StudentName);

                command.ExecuteNonQuery();
            }
        }
    }


    public bool VerifyStudentLogin(string username, string password)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT COUNT(*) FROM Students WHERE StudentID = @Username AND Password = @Password";

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();

                // If count is greater than 0, the login is successful
                return count > 0;
            }
        }
    }

    public bool VerifyManagerLogin(string username, string password)
    {
        using (SqlConnection connection = new SqlConnection("Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True"))
        {
            connection.Open();

            string selectQuery = "SELECT COUNT(*) FROM Management WHERE Username = @Username AND Password = @Password";

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();

                // If count is greater than 0, the login is successful
                return count > 0;
            }
        }
    }


    // In your Helper class
    public bool VerifyCashierLogin(string cashierID, string password)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM Cashiers WHERE ID = @CashierID AND Password = @Password";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CashierID", cashierID);
                command.Parameters.AddWithValue("@Password", password);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows; // If there are rows, the login is successful
                }
            }
        }
    }



    public List<MenuItem> GetMenuItems()
    {
        List<MenuItem> menuItems = new List<MenuItem>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM MenuItems";

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MenuItem menuItem = new MenuItem
                        {
                            MenuItemID = Convert.ToInt32(reader["MenuItemID"]),
                            ItemName = reader["ItemName"].ToString(),
                            Description = reader["Description"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Category = reader["Category"].ToString()
                            // Add other properties as needed
                        };

                        menuItems.Add(menuItem);
                    }
                }
            }
        }

        return menuItems;
    }




    public void AddToCart(string studentID, int menuItemID, int quantity)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO Cart (StudentID, MenuItemID, Quantity) " +
                                 "VALUES (@StudentID, @MenuItemID, @Quantity)";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@MenuItemID", menuItemID);
                command.Parameters.AddWithValue("@Quantity", quantity);

                command.ExecuteNonQuery();
            }
        }
    }
    public void InsertCartItem(string studentID, int menuItemID, int quantity)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO Cart (StudentID, MenuItemID, Quantity) " +
                                 "VALUES (@StudentID, @MenuItemID, @Quantity)";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@MenuItemID", menuItemID);
                command.Parameters.AddWithValue("@Quantity", quantity);

                command.ExecuteNonQuery();
            }
        }
    }

    public void InsertPayment(string studentID, decimal totalAmount, string cardHolderName, string cardNumber, string billingAddress)
    {
        // Verify card using Luhn algorithm
        if (IsCardNumberValid(cardNumber))
        {
            // Get the current date and time for PaymentDate
            string paymentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string maskedCardNumber = new string('*', cardNumber.Length - 4) + cardNumber.Substring(cardNumber.Length - 4);

            // Get the selected payment method (e.g., "Card")
            string paymentMethod = "Card";

            using (SqlConnection connection = new SqlConnection("Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Payments (StudentID, Amount, PaymentDate, PaymentMethod, CardHolderName, CardNumber, BillingAddress) VALUES (@StudentID, @Amount, @PaymentDate, @PaymentMethod, @CardHolderName, @CardNumber, @BillingAddress)", connection))
                {
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@Amount", totalAmount);
                    command.Parameters.AddWithValue("@PaymentDate", paymentDate);
                    command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    command.Parameters.AddWithValue("@CardHolderName", cardHolderName);
                    command.Parameters.AddWithValue("@CardNumber", maskedCardNumber);
                    //  command.Parameters.AddWithValue("@CVV", cvv);
                    command.Parameters.AddWithValue("@BillingAddress", billingAddress);

                    command.ExecuteNonQuery();
                }
            }

            // Optionally, update the UI or perform other actions
            MessageBox.Show("Payment successful!");
        }
        else
        {
            // Show an error message for invalid card
            MessageBox.Show("Invalid card number. Please check and try again.");
        }
    }

    public void InsertPayment_2(string studentID, decimal totalAmount, string cardHolderName, string cardNumber, string billingAddress)
    {
        // Verify card using Luhn algorithm
        //   if (IsCardNumberValid(cardNumber))
        // {
        // Get the current date and time for PaymentDate
        string paymentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string maskedCardNumber = new string('*', cardNumber.Length - 4) + cardNumber.Substring(cardNumber.Length - 4);

        // Get the selected payment method (e.g., "Card")
        string paymentMethod = "MobileBanking";

        using (SqlConnection connection = new SqlConnection("Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True"))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("INSERT INTO Payments (StudentID, Amount, PaymentDate, PaymentMethod, CardHolderName, CardNumber, BillingAddress) VALUES (@StudentID, @Amount, @PaymentDate, @PaymentMethod, @CardHolderName, @CardNumber, @BillingAddress)", connection))
            {
                command.Parameters.AddWithValue("@StudentID", studentID);
                command.Parameters.AddWithValue("@Amount", totalAmount);
                command.Parameters.AddWithValue("@PaymentDate", paymentDate);
                command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                command.Parameters.AddWithValue("@CardHolderName", cardHolderName);
                command.Parameters.AddWithValue("@CardNumber", maskedCardNumber);
                //  command.Parameters.AddWithValue("@CVV", cvv);
                command.Parameters.AddWithValue("@BillingAddress", billingAddress);

                command.ExecuteNonQuery();
            }
        }

        // Optionally, update the UI or perform other actions
        MessageBox.Show("Payment successful!");
        //   }

    }





    private bool IsCardNumberValid(string cardNumber)
    {
        int sum = 0;
        bool alternate = false;

        foreach (char digit in cardNumber.Reverse())
        {
            if (char.IsDigit(digit))
            {
                int num = (digit - '0') * (alternate ? 2 : 1);
                sum += num > 9 ? num - 9 : num;
                alternate = !alternate;
            }
            else
            {
                // Handle non-digit characters if needed
                return false;
            }
        }

        return sum % 10 == 0;
    }

    public MenuItem GetMenuItemByID(int menuItemID)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT * FROM MenuItems WHERE MenuItemID = @MenuItemID";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MenuItemID", menuItemID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming MenuItem class has appropriate properties; adjust as needed
                        MenuItem menuItem = new MenuItem
                        {
                            MenuItemID = Convert.ToInt32(reader["MenuItemID"]),
                            ItemName = reader["ItemName"].ToString(),
                            Description = reader["Description"].ToString(),
                            Price = Convert.ToDecimal(reader["Price"]),
                            Category = reader["Category"].ToString()
                            // Add other properties as needed
                        };

                        return menuItem;
                    }
                }
            }
        }

        // Return null if the MenuItem with the given ID is not found
        return null;
    }


    public Cart GetCartByStudentID(string studentID)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Assuming there is a Students table with a StudentID column
            string studentQuery = "SELECT * FROM Students WHERE StudentID = @StudentID";
            using (SqlCommand studentCommand = new SqlCommand(studentQuery, connection))
            {
                studentCommand.Parameters.AddWithValue("@StudentID", studentID);

                using (SqlDataReader studentReader = studentCommand.ExecuteReader())
                {
                    if (studentReader.Read())
                    {
                        // Assuming there is a Cart table with a StudentID column
                        string cartQuery = "SELECT * FROM Cart WHERE StudentID = @StudentID";
                        using (SqlCommand cartCommand = new SqlCommand(cartQuery, connection))
                        {
                            cartCommand.Parameters.AddWithValue("@StudentID", studentID);

                            using (SqlDataReader cartReader = cartCommand.ExecuteReader())
                            {
                                Cart cart = new Cart();

                                while (cartReader.Read())
                                {
                                    // Assuming there is a CartItem class and a method to get MenuItem by ID
                                    int menuItemID = Convert.ToInt32(cartReader["MenuItemID"]);
                                    MenuItem menuItem = GetMenuItemByID(menuItemID); // You need to implement this method

                                    int quantity = Convert.ToInt32(cartReader["Quantity"]);

                                    cart.AddItem(menuItem, quantity);
                                }

                                return cart;
                            }
                        }
                    }
                }
            }
        }

        // Return an empty cart if the student is not found or has no cart
        return new Cart();
    }


    public static void RemoveMenuItem(string itemName)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection("Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();

                // Assuming you have a table named MenuItems with a column ItemName
                string deleteQuery = "DELETE FROM MenuItems WHERE ItemName = @ItemName";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", itemName);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error removing menu item: {ex.Message}");
        }
    }



    public static void UpdateMenuItem(string itemName, string updatedItemName, string updatedDescription, decimal updatedPrice, string updatedCategory)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection("Data Source=Cactus\\SQLEXPRESS;Initial Catalog=CafeBistro;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();

                // Assuming you have a table named MenuItems with a column ItemName
                string updateQuery = "UPDATE MenuItems SET ItemName = @UpdatedItemName, Description = @UpdatedDescription, Price = @UpdatedPrice, Category = @UpdatedCategory WHERE ItemName = @ItemName";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@UpdatedItemName", updatedItemName);
                    command.Parameters.AddWithValue("@UpdatedDescription", updatedDescription);
                    command.Parameters.AddWithValue("@UpdatedPrice", updatedPrice);
                    command.Parameters.AddWithValue("@UpdatedCategory", updatedCategory);
                    command.Parameters.AddWithValue("@ItemName", itemName);

                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Error updating menu item: {ex.Message}");
        }
    }



    ///////////////////////////inevntory////////////////

    public bool VerifyInventManagerLogin(string username, string password)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT COUNT(*) FROM InventoryManagement WHERE Username = @Username AND Password = @Password";

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();

                // If count is greater than 0, the login is successful
                return count > 0;
            }
        }
    }



    public List<InventoryItem> GetInventoryItems()
    {
        List<InventoryItem> inventoryItems = new List<InventoryItem>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * FROM Inventory";

            using (SqlCommand command = new SqlCommand(selectQuery, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        InventoryItem inventoryItem = new InventoryItem
                        {
                            InventoryID = Convert.ToInt32(reader["InventoryID"]),
                            MenuItemID = Convert.ToInt32(reader["MenuItemID"]),
                            IngredientName = reader["IngredientName"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            Threshold = Convert.ToInt32(reader["Threshold"]),
                            LastUpdated = Convert.ToDateTime(reader["LastUpdated"])
                            // Add other properties as needed
                        };

                        inventoryItems.Add(inventoryItem);
                    }
                }
            }
        }

        return inventoryItems;
    }
    public void UpdateInventoryItemQuantity(int inventoryID, int newQuantity)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string updateQuery = "UPDATE Inventory SET Quantity = @NewQuantity WHERE InventoryID = @InventoryID";

            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                command.Parameters.AddWithValue("@NewQuantity", newQuantity);
                command.Parameters.AddWithValue("@InventoryID", inventoryID);

                command.ExecuteNonQuery();
            }
        }
    }

    public void InsertInventoryItem(InventoryItem inventoryItem)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO Inventory (MenuItemID, IngredientName, Quantity, Threshold, LastUpdated) " +
                                 "VALUES (@MenuItemID, @IngredientName, @Quantity, @Threshold, @LastUpdated)";

            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@MenuItemID", inventoryItem.MenuItemID);
                command.Parameters.AddWithValue("@IngredientName", inventoryItem.IngredientName);
                command.Parameters.AddWithValue("@Quantity", inventoryItem.Quantity);
                command.Parameters.AddWithValue("@Threshold", inventoryItem.Threshold);
                command.Parameters.AddWithValue("@LastUpdated", inventoryItem.LastUpdated);

                command.ExecuteNonQuery();
            }
        }
    }

    public void DeleteInventoryItem(int inventoryID)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string deleteQuery = "DELETE FROM Inventory WHERE InventoryID = @InventoryID";

            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
            {
                command.Parameters.AddWithValue("@InventoryID", inventoryID);

                command.ExecuteNonQuery();
            }
        }
    }

    public void DecrementInventoryQuantity(int menuItemID, int quantity)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Construct the SQL command to update the Quantity in the Inventory table
            string sql = "UPDATE Inventory SET Quantity = Quantity - @Quantity WHERE MenuItemID = @MenuItemID";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@MenuItemID", menuItemID);
                command.Parameters.AddWithValue("@Quantity", quantity);

                // Execute the SQL command
                command.ExecuteNonQuery();
            }
        }
    }
    /////////staff management//////////////
    public DataTable GetStaff()
    {
        DataTable staffTable = new DataTable();

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Staff";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(staffTable);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Handle the exception as needed
            throw new Exception($"Error retrieving staff data: {ex.Message}");
        }

        return staffTable;
    }
    public void FireStaffMember(int staffID)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Staff WHERE StaffID = @StaffID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffID", staffID);

                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            // Handle the exception as needed
            throw new Exception($"Error firing staff member: {ex.Message}");
        }

    }

    public void AddStaffMember(string username, string password, string firstName, string lastName, decimal salary, DateTime dateJoined)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO Staff (Username, Password, FirstName, LastName, Salary, DateJoined)
                                VALUES (@Username, @Password, @FirstName, @LastName, @Salary, @DateJoined)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@DateJoined", dateJoined);

                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            // Handle the exception as needed
            throw new Exception($"Error adding staff member: {ex.Message}");
        }
    }
    public void UpdateStaffMember(int staffID, string username, string password, string firstName, string lastName, decimal salary, DateTime dateJoined)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"UPDATE Staff
                            SET Username = @Username,
                                Password = @Password,
                                FirstName = @FirstName,
                                LastName = @LastName,
                                Salary = @Salary,
                                DateJoined = @DateJoined
                            WHERE StaffID = @StaffID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@DateJoined", dateJoined);
                    command.Parameters.AddWithValue("@StaffID", staffID);

                    command.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            // Handle the exception as needed
            throw new Exception($"Error updating staff member: {ex.Message}");
        }
    }
    public DataRow GetStaffDetails(int staffID)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"SELECT * FROM Staff WHERE StaffID = @StaffID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StaffID", staffID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Check if any rows were returned
                        if (dataTable.Rows.Count > 0)
                        {
                            DataRow row = dataTable.Rows[0];
                            if (row["DateJoined"] != DBNull.Value)
                            {
                                DateTime dateJoined = Convert.ToDateTime(row["DateJoined"]);
                                // Use the dateJoined as needed
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Handle the exception as needed
            throw new Exception($"Error getting staff details: {ex.Message}");
        }
        
        


        // Return null if no data or an error occurred
        return null;
    }

    // Other database-related methods can be added here
}
