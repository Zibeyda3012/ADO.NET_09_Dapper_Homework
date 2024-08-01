using ADO.NET_09_Dapper_Homework;
using System.Data.SqlClient;

IAuthorRepository repo = new AuthorRepository(new SqlConnection(),
    @"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=SSPI;");

