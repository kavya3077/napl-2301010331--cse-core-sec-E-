package main

/*
import "fmt"

func square(ch chan string) {
	fmt.Println("Square Goroutine Started")

	result := 5 * 5

	fmt.Println("Square Goroutine Completed")
	ch <- fmt.Sprint("Square Result: ", result)
}

func cube(ch chan string) {
	fmt.Println("Cube Goroutine Started")

	result := 3 * 3 * 3

	fmt.Println("Cube Goroutine Completed")
	ch <- fmt.Sprint("Cube Result: ", result)
}

func fibonacci(ch chan string) {
	fmt.Println("Fibonacci Goroutine Started")

	a, b := 0, 1
	for i := 0; i < 10; i++ {
		a, b = b, a+b
	}

	fmt.Println("Fibonacci Goroutine Completed")
	ch <- fmt.Sprint("Fibonacci Result (10th number): ", a)
}

func main() {
	ch := make(chan string)

	go square(ch)
	go cube(ch)
	go fibonacci(ch)

	for i := 0; i < 3; i++ {
		fmt.Println(<-ch)
	}
}
*/
