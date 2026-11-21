class Student(
    private var rollNo: Int,
    private var name: String,
    private var course: String,
    private var percentage: Double
) {
    fun acceptData() {
        print("Enter Roll No: ")
        rollNo = readLine()!!.toInt()

        print("Enter Name: ")
        name = readLine()!!

        print("Enter Course: ")
        course = readLine()!!

        print("Enter Percentage: ")
        percentage = readLine()!!.toDouble()
    }

    fun displayData() {
        println("\nStudent Information")
        println("Roll No: $rollNo")
        println("Name: $name")
        println("Course: $course")
        println("Percentage: $percentage%")
    }
}

fun main() {
    val s1 = Student(101, "Arjun", "BCA", 78.5)
    val s2 = Student(102, "Neha", "B.Sc", 82.0)

    println("Enter details for Student 1:")
    s1.acceptData()
    s1.displayData()

    println("\nEnter details for Student 2:")
    s2.acceptData()
    s2.displayData()
}