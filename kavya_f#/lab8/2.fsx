
#r "nuget: Microsoft.Data.Sqlite"

open Microsoft.Data.Sqlite

let connection = new SqliteConnection("Data Source=students.db")
connection.Open()

// Create Table
let createTable = connection.CreateCommand()
createTable.CommandText <- "CREATE TABLE IF NOT EXISTS Students (Id INTEGER PRIMARY KEY, Name TEXT, Age INTEGER)"
createTable.ExecuteNonQuery() |> ignore

// Clear old records
let clear = connection.CreateCommand()
clear.CommandText <- "DELETE FROM Students"
clear.ExecuteNonQuery() |> ignore

// Function to display Students
let showStudents (message: string) =
    printfn "\n%s" message

    let read = connection.CreateCommand()
    read.CommandText <- "SELECT * FROM Students"

    use reader = read.ExecuteReader()

    while reader.Read() do
        printfn "Id: %d Name: %s Age: %d"
            (reader.GetInt32(0))
            (reader.GetString(1))
            (reader.GetInt32(2))

// CREATE
let insert = connection.CreateCommand()
insert.CommandText <- "INSERT INTO Students (Name, Age) VALUES ('John', 20)"
insert.ExecuteNonQuery() |> ignore

showStudents "After Create:"

// READ
showStudents "After Read:"

// UPDATE
let update = connection.CreateCommand()
update.CommandText <- "UPDATE Students SET Age = 21 WHERE Name = 'John'"
update.ExecuteNonQuery() |> ignore

showStudents "After Update:"

// DELETE
let delete = connection.CreateCommand()
delete.CommandText <- "DELETE FROM Students WHERE Name = 'John'"
delete.ExecuteNonQuery() |> ignore

showStudents "After Delete:"

connection.Close()
