package main

import "testing"

func Test_Insert_Item(t *testing.T) {

	stock = nil

	err := insertItem(Item{1, "Laptop", 5, 50000})

	if err != nil {
		t.Fatal("Item not added")
	}

	if len(stock) != 1 {
		t.Error("Inventory count is incorrect")
	}
}
func Test_Change_Item(t *testing.T) {

	stock = nil

	insertItem(Item{1, "MSI Laptop", 5, 50000})

	err := changeItem(Item{1, "MSI Laptop", 10, 55000})

	if err != nil {
		t.Fatal("update failed")
	}

	if stock[0].Quantity != 10 {
		t.Error("Quantity not updated")
	}
}

func TestDeleteItem(t *testing.T) {

	stock = nil

	insertItem(Item{1, "MSI Laptop", 5, 50000})

	err := deleteItem(1)

	if err != nil {
		t.Fatal("deletion failed")
	}

	if len(stock) != 0 {
		t.Error("Item not deleted")
	}
}

func Test_Invalid_Item(t *testing.T) {

	stock = nil

	err := insertItem(Item{0, "", -5, -100})

	if err == nil {
		t.Error("Invalid item")
	}
}
