package main

import (
	"bufio"
	"fmt"
	"os"
)

type Person struct {
	Name   string
	Age    int
	Job    string
	Salary float64
}

func (p Person) readdata(reader *bufio.Reader) Person {

	fmt.Println("Enter Name:")
	fmt.Fscan(reader, &p.Name)

	fmt.Println("Enter Age:")
	fmt.Fscan(reader, &p.Age)

	fmt.Println("Enter Job:")
	fmt.Fscan(reader, &p.Job)

	fmt.Println("Enter Salary:")
	fmt.Fscan(reader, &p.Salary)

	return p
}

func (p Person) displaydata() {

	fmt.Println("Name:", p.Name)
	fmt.Println("Age:", p.Age)
	fmt.Println("Job:", p.Job)
	fmt.Println("Salary:", p.Salary)
}

func main() {

	reader := bufio.NewReader(os.Stdin)

	var p1 Person
	var p2 Person

	fmt.Println("Enter details for Person 1:")
	p1 = p1.readdata(reader)

	fmt.Println("\nEnter details for Person 2:")
	p2 = p2.readdata(reader)

	fmt.Println("\nDetails of Person 1:")
	p1.displaydata()

	fmt.Println("\nDetails of Person 2:")
	p2.displaydata()
}
