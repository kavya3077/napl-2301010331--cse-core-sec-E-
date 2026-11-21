// (1) Function with default parameters
fun display(name: String = "Kavya", age: Int = 21) {
    println("Name: $name")
    println("Age: $age")
}

// (2) Function using named arguments
fun student(name: String, age: Int, course: String) {
    println("Name: $name, Age: $age, Course: $course")
}

// (3) Vararg function
fun printNumbers(vararg numbers: Int) {
    for (num in numbers) {
        println(num)
    }
}

// (4) Higher-order function
fun calculate(numbers: List<Int>, operation: (Int) -> Int) {
    for (num in numbers) {
        println(operation(num))
    }
}

fun main() {

    // Default parameters
    display()
    display("Rahul", 20)

    // Named arguments
    student(course = "Kotlin", age = 20, name = "Aaman")

    // Vararg
    printNumbers(50, 60, 70)

    // Higher-order function
    calculate(listOf(4, 5, 6, 7)) { it * 2 }
}