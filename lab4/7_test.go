package main

import "testing"

func TestDivide(t *testing.T) {
	// valid input
	result, err := divide(10, 2)
	if err != nil {
		t.Errorf("expected no error, got %v", err)
	}
	if result != 5 {
		t.Errorf("expected 5, got %v", result)
	}

	// error case: division by zero
	_, err = divide(10, 0)
	if err == nil {
		t.Errorf("expected division by zero error, got nil")
	}
}

func TestSquareRoot(t *testing.T) {
	// valid input
	result, err := squareRoot(16)
	if err != nil {
		t.Errorf("expected no error, got %v", err)
	}
	if result != 4 {
		t.Errorf("expected 4, got %v", result)
	}

	// error case: negative number
	_, err = squareRoot(-4)
	if err == nil {
		t.Errorf("expected negative square root error, got nil")
	}
}

func TestCheckInput(t *testing.T) {
	// valid input
	text, err := checkInput("Hello")
	if err != nil {
		t.Errorf("expected no error, got %v", err)
	}
	if text != "Hello" {
		t.Errorf("expected Hello, got %v", text)
	}

	// error case: empty input
	_, err = checkInput("")
	if err == nil {
		t.Errorf("expected empty input error, got nil")
	}
}
