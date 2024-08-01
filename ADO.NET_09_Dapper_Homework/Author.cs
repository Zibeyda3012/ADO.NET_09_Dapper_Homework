﻿namespace ADO.NET_09_Dapper_Homework;

public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"{Id} {FirstName} {LastName}";
    }
}
