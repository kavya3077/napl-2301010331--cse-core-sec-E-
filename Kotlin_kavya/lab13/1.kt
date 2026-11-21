fun main() {

    // (1) Hello Kotlin
    println("Hello Kotlin!!!")

    // (2) Employee Bonus using when expression
    val dept_code = "IT"
    val experience = 6
    val salary = 50000

    val bonusPercent = when {
        dept_code == "IT" && experience > 5 -> 20
        dept_code == "HR" && experience > 3 -> 15
        else -> 10
    }

    val bonus = salary * bonusPercent / 100

    println("Bonus Amount: $bonus")

    // (3) Average of individual digits
    print("Enter an integer: ")
    val num = readLine()!!.toInt()

    var n = kotlin.math.abs(num)
    var sum = 0
    var count = 0

    if (n == 0) {
        sum = 0
        count = 1
    } else {
        while (n > 0) {
            sum += n % 10
            count++
            n /= 10
        }
    }

    val average = sum.toDouble() / count
    println("Average of digits: $average")
}