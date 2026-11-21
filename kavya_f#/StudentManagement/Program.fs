
open System
open Microsoft.Data.Sqlite

// 1. DOMAIN MODEL - Student Record
type Student = {
    Id: int
    Name: string
    Course: string
    Marks: float
}

// 2. DATABASE CONNECTION
let connectionString = "Data Source=students.db"

// 3. DATABASE INITIALIZATION
let initializeDatabase () = async {

    use connection = new SqliteConnection(connectionString)

    do! connection.OpenAsync() |> Async.AwaitTask

    use command = connection.CreateCommand()

    command.CommandText <-
        """
        CREATE TABLE IF NOT EXISTS Students (
            Id INTEGER PRIMARY KEY,
            Name TEXT NOT NULL,
            Course TEXT NOT NULL,
            Marks REAL NOT NULL
        );
        """

    let! _ =
        command.ExecuteNonQueryAsync()
        |> Async.AwaitTask

    printfn "Database initialized successfully!"
}

// 4. CREATE - ADD STUDENT
let addStudent (student: Student) = async {

    use connection = new SqliteConnection(connectionString)

    do! connection.OpenAsync() |> Async.AwaitTask

    use command = connection.CreateCommand()

    command.CommandText <-
        """
        INSERT OR REPLACE INTO Students
        (Id, Name, Course, Marks)
        VALUES (@id, @name, @course, @marks);
        """

    command.Parameters.AddWithValue("@id", student.Id) |> ignore
    command.Parameters.AddWithValue("@name", student.Name) |> ignore
    command.Parameters.AddWithValue("@course", student.Course) |> ignore
    command.Parameters.AddWithValue("@marks", student.Marks) |> ignore

    let! _ =
        command.ExecuteNonQueryAsync()
        |> Async.AwaitTask

    printfn "Student added successfully!"
}

// 5. READ - DISPLAY ALL STUDENTS
let getAllStudents () = async {

    use connection = new SqliteConnection(connectionString)

    do! connection.OpenAsync() |> Async.AwaitTask

    use command = connection.CreateCommand()

    command.CommandText <- "SELECT * FROM Students"

    use! reader =
        command.ExecuteReaderAsync()
        |> Async.AwaitTask

    let students = ResizeArray<Student>()

    let mutable reading = true

    while reading do

        let! hasRow =
            reader.ReadAsync()
            |> Async.AwaitTask

        if hasRow then

            let student = {
                Id = reader.GetInt32(0)
                Name = reader.GetString(1)
                Course = reader.GetString(2)
                Marks = reader.GetDouble(3)
            }

            students.Add(student)

        else
            reading <- false

    return students |> Seq.toList
}

// 6. UPDATE - UPDATE STUDENT
let updateStudent (id: int) (newMarks: float) = async {

    use connection = new SqliteConnection(connectionString)

    do! connection.OpenAsync() |> Async.AwaitTask

    use command = connection.CreateCommand()

    command.CommandText <-
        "UPDATE Students SET Marks = @marks WHERE Id = @id"

    command.Parameters.AddWithValue("@marks", newMarks) |> ignore
    command.Parameters.AddWithValue("@id", id) |> ignore

    let! result =
        command.ExecuteNonQueryAsync()
        |> Async.AwaitTask

    if result > 0 then
        printfn "Student updated successfully!"
    else
        printfn "Student not found!"
}

// 7. DELETE - REMOVE STUDENT
let deleteStudent (id: int) = async {

    use connection = new SqliteConnection(connectionString)

    do! connection.OpenAsync() |> Async.AwaitTask

    use command = connection.CreateCommand()

    command.CommandText <-
        "DELETE FROM Students WHERE Id = @id"

    command.Parameters.AddWithValue("@id", id) |> ignore

    let! result =
        command.ExecuteNonQueryAsync()
        |> Async.AwaitTask

    if result > 0 then
        printfn "Student deleted successfully!"
    else
        printfn "Student not found!"
}

// 8. HIGHER-ORDER FUNCTION - MAP
let calculateGrades (students: Student list) =

    students
    |> List.map (fun student ->

        let grade =
            match student.Marks with
            | marks when marks >= 90.0 -> "A"
            | marks when marks >= 75.0 -> "B"
            | marks when marks >= 60.0 -> "C"
            | marks when marks >= 40.0 -> "D"
            | _ -> "Fail"

        (student.Name, student.Marks, grade)
    )

// 9. HIGHER-ORDER FUNCTION - FILTER
let getPassedStudents (students: Student list) =

    students
    |> List.filter (fun student ->
        student.Marks >= 40.0
    )

// 10. MAIN PROGRAM
[<EntryPoint>]
let main argv =

    async {

        // Initialize database
        do! initializeDatabase()

        // Sample student records
        let student1 = {
            Id = 1
            Name = "Rahul"
            Course = "BTech CSE"
            Marks = 85.0
        }

        let student2 = {
            Id = 2
            Name = "Priya"
            Course = "BTech IT"
            Marks = 92.0
        }

        let student3 = {
            Id = 3
            Name = "Aman"
            Course = "BTech CSE"
            Marks = 35.0
        }

        // CREATE
        do! addStudent student1
        do! addStudent student2
        do! addStudent student3

        // READ
        let! students = getAllStudents()

        printfn "\nAll Students:"

        students
        |> List.iter (fun s ->
            printfn "%d | %s | %s | %.2f"
                s.Id s.Name s.Course s.Marks
        )

        // MAP - Calculate Grades
        printfn "\nStudent Grades:"

        students
        |> calculateGrades
        |> List.iter (fun (name, marks, grade) ->
            printfn "%s | %.2f | Grade: %s"
                name marks grade
        )

        // FILTER - Passed Students
        printfn "\nPassed Students:"

        students
        |> getPassedStudents
        |> List.iter (fun s ->
            printfn "%s - %.2f"
                s.Name s.Marks
        )

        // UPDATE
        do! updateStudent 1 95.0

        // DELETE
        do! deleteStudent 3

        // FINAL RECORDS
        let! updatedStudents = getAllStudents()

        printfn "\nFinal Student Records:"

        updatedStudents
        |> List.iter (fun s ->
            printfn "%d | %s | %.2f"
                s.Id s.Name s.Marks
        )

    }
    |> Async.RunSynchronously

    0
