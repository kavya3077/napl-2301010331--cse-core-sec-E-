package main

import "fmt"

type Student struct {
	name  string
	age   int
	marks float64
}

func addDataInStructure(s1 *Student) {

	s1.name = "Kavya Mudgil"
	s1.age = 22
	s1.marks = 90.5

}

func modifyVariable(a *int) {
	*a = 20
}

func main() {

	// part 1
	x := 10

	p := &x

	fmt.Println("Address of x:", p)
	fmt.Println("Value using pointer:", *p)

	// part 2
	fmt.Println("value of x before modification:", x)

	modifyVariable(&x)

	fmt.Println("value of x after modification:", x)

	// part 3
	s1 := new(Student)

	fmt.Println("Before:")
	fmt.Println("Name:", s1.name)
	fmt.Println("Age:", s1.age)
	fmt.Println("Marks:", s1.marks)

	addDataInStructure(s1)

	fmt.Println("After adding data")
	fmt.Println("Name:", s1.name)
	fmt.Println("Age:", s1.age)
	fmt.Println("Marks:", s1.marks)
}
