package main

import (
	"fmt"
	"math"
)

func divide(a, b float64) (float64, error) {
	if b == 0 {
		return 0, fmt.Errorf("division by zero: cannot divide %v by %v", a, b)
	}
	return a / b, nil
}

func squareRoot(n float64) (float64, error) {
	if n < 0 {
		return 0, fmt.Errorf("negative square root: cannot find square root of %v", n)
	}
	return math.Sqrt(n), nil
}

func checkInput(s string) (string, error) {
	if s == "" {
		return "", fmt.Errorf("empty input: got %q, expected a non-empty string", s)
	}
	return s, nil
}

func main() {
	result, err := divide(10, 2)
	if err != nil {
		fmt.Println("Error:", err)
	} else {
		fmt.Println("Divide result:", result)
	}

	result, err = divide(10, 0)
	if err != nil {
		fmt.Println("Error:", err)
	} else {
		fmt.Println("Divide result:", result)
	}

	result, err = squareRoot(16)
	if err != nil {
		fmt.Println("Error:", err)
	} else {
		fmt.Println("Square root result:", result)
	}

	result, err = squareRoot(-4)
	if err != nil {
		fmt.Println("Error:", err)
	} else {
		fmt.Println("Square root result:", result)
	}

	text, err := checkInput("Hello")
	if err != nil {
		fmt.Println("Error:", err)
	} else {
		fmt.Println("Valid input:", text)
	}

	text, err = checkInput("")
	if err != nil {
		fmt.Println("Error:", err)
	} else {
		fmt.Println("Valid input:", text)
	}
}
