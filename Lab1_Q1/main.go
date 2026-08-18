package main

import (
	"fmt"
)

func main() {

	// QUESTION 1:
	// CODE 1
	fmt.Println("Hello, Kavya Mudgil")

	// CODE 2
	name := "Kavya Mudgil"
	rollno := "2301010331"
	fmt.Printf("%s Btech CSE %s\n", name, rollno)

	// CODE 3
	num1 := 9
	num2 := 10

	fmt.Printf("Sum: %d\n", num1+num2)
	fmt.Printf("Subtraction: %d\n", num1-num2)
	fmt.Printf("Multiplication: %d\n", num1*num2)
	fmt.Printf("Division: %d\n", num1/num2)
	/*
		// QUESTION 2
		for {
			fmt.Println("\n===== MENU =====")
			fmt.Println("1. Integer Operations")
			fmt.Println("2. Floating-Point Operations")
			fmt.Println("3. Exit")

			var choice int
			fmt.Print("Enter your choice: ")
			fmt.Scan(&choice)

			if choice == 1 {

				var num1, num2 int

				fmt.Print("Enter first integer: ")
				fmt.Scan(&num1)

				fmt.Print("Enter second integer: ")
				fmt.Scan(&num2)

				fmt.Println("Addition:", num1+num2)
				fmt.Println("Subtraction:", num1-num2)
				fmt.Println("Multiplication:", num1*num2)
				fmt.Println("Division:", num1/num2)

			} else if choice == 2 {

				var float1, float2 float64

				fmt.Print("Enter first float: ")
				fmt.Scan(&float1)

				fmt.Print("Enter second float: ")
				fmt.Scan(&float2)

				fmt.Println("Addition:", float1+float2)
				fmt.Println("Subtraction:", float1-float2)
				fmt.Println("Multiplication:", float1*float2)
				fmt.Println("Division:", float1/float2)

			} else if choice == 3 {

				fmt.Println("Program ended.")
				break

			} else {

				fmt.Println("Invalid choice!")
			}
		}
	*/
}
