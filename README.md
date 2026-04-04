# VB Auto Center

I design a **VB.NET Windows Forms Application** that allows users to manage a vehicle inventory, calculate pricing estimates (including tax and accessories), and print detailed receipts. 
This project demonstrates practical object-oriented programming, file I/O, and UI interaction in Visual Basic.

---

## Features
<img width="366" height="358" alt="image" src="https://github.com/user-attachments/assets/9c3d2a5e-4c21-40fb-89cb-03a8fe5e6c25" />


### Vehicle Management
- Add, update, and delete vehicles from inventory.
- Display a list of available vehicles.
- Load and save inventory automatically to a text file (`inventory.txt`).

### Search Functionality
- Real-time filtering of vehicles by **Make** or **Model**.

### Price Calculation
- Calculate vehicle pricing including:
  - Base price
  - Accessories (Sound, Leather, Navigation)
  - Finish options (Standard, Pearlized, Custom)
  - Tax rate (8%)
  - Trade-in value
- Displays:
  - Accessories & Finish total
  - Tax
  - Subtotal
  - Total Due
 <img width="368" height="357" alt="image" src="https://github.com/user-attachments/assets/ccbd65ee-864d-4aea-9d33-4e6e87dd5a76" />


### Printing Receipts
- Generates a **formatted printout** summarizing the order details.

### Data Persistence
- Vehicles are automatically loaded from and saved to `inventory.txt` when the form starts and closes.

---


## Code Overview

### Vehicle Class (`Vehicle.vb`)
Represents a vehicle with attributes for make, model, year, and price.

```vb
Public Class Vehicle
    Public Property Make As String
    Public Property Model As String
    Public Property Year As Integer
    Public Property Price As Decimal

    Public Overrides Function ToString() As String
        Return $"{Year} {Make} {Model} - {Price:C}"
    End Function
End Class
```

### Main Form (`Form1.vb`)
Handles:
- UI events (button clicks, selections, text changes)
- Price calculation and formatting
- File I/O for saving/loading `inventory.txt`
- Printing receipts via `PrintDocument`

---

## Constants

Defined in `Form1.vb` for easy configuration:

| Constant | Description | Value |
|-----------|--------------|--------|
| `Tax_Rate` | Sales tax rate | `0.08` |
| `Sound_Price` | Optional sound system | `$500` |
| `Leather_Price` | Leather interior | `$1000` |
| `Nav_Price` | Navigation system | `$1500` |

---

## Calculation Formula

Total price is calculated as:

\[
\text{Total Due} = ((\text{Base Price} + \text{Accessories} + \text{Finish Cost}) \times (1 + \text{Tax Rate})) - \text{Trade-In}
\]

---

## Example Receipt Output

```
==============================
=== VB Auto Center Receipt ===
==============================

Base Price: $28,000.00
Accessories & Finish: $2,000.00
Tax: $2,400.00
Subtotal: $32,400.00
Trade-In: $5,000.00
TOTAL DUE: $27,400.00
=============================
```

---

## File Operations

- **Load Inventory:** Automatically executed during `Form1_Load`.
- **Save Inventory:** Saves on `FormClosing` event.
- Stored format in `inventory.txt`:
  ```
  Make,Model,Year,Price
  Toyota,Corolla,2020,22000
  Honda,Civic,2021,25000
  ```

---

## Requirements

- **Platform:** Windows
- **Language:** Visual Basic .NET  
- **Framework:** .NET Framework 4.7.2 or later
- **IDE:** Visual Studio 2019 or newer

---

## How to Run

1. Open the project in **Visual Studio**.
2. Build and run (`F5`).
3. Use the form to:
   - Add vehicles to inventory
   - Manage accessories and finishes
   - Calculate prices
   - Print a customer receipt

---

## Future Enhancements

- [ ] Implement full search and filter functionality.
- [ ] Add data validation improvements.
- [ ] Include file format versioning or JSON storage.
- [ ] Support exporting receipts to PDF.

---

## Author

**Antipas Zemba**  
📧 [[LinkedIn]](https://www.linkedin.com/in/antipas-zemba-6b94a6290) 
💼 [[GitHub]](https://www.linkedin.com/in/antipas-zemba-6b94a6290)

---

## License

Antipas Zemba @ 2026

---
```
