package main

import (
	"fmt"
)

type Item struct {
	ID       int
	Name     string
	Quantity int
	Price    float64
}

type Summary struct {
	Count int
	Value float64
}

var stock []Item

func insertItem(nItem Item) error {

	if nItem.ID <= 0 || nItem.Name == "" ||
		nItem.Quantity < 0 || nItem.Price < 0 {
		return fmt.Errorf("Invalid item details")
	}

	for _, item := range stock {
		if item.ID == nItem.ID {
			return fmt.Errorf("Item already exists")
		}
	}

	stock = append(stock, nItem)
	return nil
}

func changeItem(updatedItem Item) error {

	if updatedItem.ID <= 0 || updatedItem.Name == "" ||
		updatedItem.Quantity < 0 || updatedItem.Price < 0 {
		return fmt.Errorf("Invalid item details")
	}

	for i, item := range stock {
		if item.ID == updatedItem.ID {
			stock[i] = updatedItem
			return nil
		}
	}

	return fmt.Errorf("Item not found")
}

func deleteItem(id int) error {

	for i, item := range stock {
		if item.ID == id {
			stock = append(stock[:i], stock[i+1:]...)
			return nil
		}
	}

	return fmt.Errorf("Item not found")
}

func getSummary() Summary {

	ch := make(chan Summary)

	go func() {
		var total float64

		for _, item := range stock {
			total += float64(item.Quantity) * item.Price
		}

		ch <- Summary{
			Count: len(stock),
			Value: total,
		}
	}()

	result := <-ch
	return result
}

func showStock() {

	fmt.Println("\n--- Inventory Details ---")

	for _, item := range stock {
		fmt.Println("ID:", item.ID)
		fmt.Println("Name:", item.Name)
		fmt.Println("Quantity:", item.Quantity)
		fmt.Println("Price:", item.Price)
		fmt.Println("-------------------")
	}
}

func main() {

	err := insertItem(Item{1, "msi Laptop", 6, 70000})
	if err != nil {
		fmt.Println(err)
	}

	err = insertItem(Item{2, "Mouse", 9, 570})
	if err != nil {
		fmt.Println(err)
	}

	err = insertItem(Item{3, "Keyboard", 5, 1000})
	if err != nil {
		fmt.Println(err)
	}

	err = changeItem(Item{1, "MSI Laptop", 8, 77000})
	if err != nil {
		fmt.Println(err)
	}

	err = deleteItem(2)
	if err != nil {
		fmt.Println(err)
	}

	showStock()

	result := getSummary()

	fmt.Println("\n--- Inventory Summary ---")
	fmt.Println("Total Items:", result.Count)
	fmt.Println("Total Inventory Value:", result.Value)
}
