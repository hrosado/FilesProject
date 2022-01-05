using System;
using System.Data;
using System.Data.SqlClient;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Getting connection ... ");

// Database connection
//var datasource = @"DESKTOP-9JFUPPD\SQLEXPRESS";//your server
//var database = "AplDb"; //your database name
//var username = "sa"; //username of server to connect
//var password = "password"; //password

////your connection string 
//string connString = @"Data Source=" + datasource + ";Initial Catalog="
//            + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

string connString = @"Data Source=DESKTOP-9JFUPPD\\SQLEXPRESS;Initial Catalog=tb_AplFiles;Integrated Security=True;";

//create instanace of database connection
SqlConnection conn = new SqlConnection(connString);


try
{
    Console.WriteLine("Opening Connection ... ");

    // Open connection
    conn.Open();
    Console.WriteLine("Success!");
    Console.ReadKey();
}
catch (Exception ex)
{

    Console.WriteLine("Error: " + ex.Message);
}

Console.ReadKey();

