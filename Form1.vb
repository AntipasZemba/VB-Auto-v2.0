Imports System.IO
imports System.Drawing.Printing

Public Class Form1

  ' Constants
  ' These values are fixed and used throught the program
  Private Constant Tax_Rate As Decimal = 0.08
  Private Constant Sound_Price as Decimal = 500
  Private Const Leather_Price As Decimal = 1000
  Private Const Nav_Price As Decimal = 1500

  ' Data: List that stores all vehicles in memory
  Private inventory As New List(OF Vehicle)

  ' Form Load : Runs when form first opens
  Private Sub Form1_Load(sender as Object, e As EventArgs) Handles MyBase.Load
    LoadInventoryFromFile()
    RefreshInventory()
    radStandard.Checked = True
  End sub

  ' Inventory Methods: Refreshes the ListBox display with current inventory
  Private Sub RefreshInventory()
    lstInventory.DataSource = Nothing
    lstInventory.DataSource = Inventory
  End Sub

  ' adds a new vehicle to the inventory
  Private Sub btnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
    Dim v As New Vehicle

    ' validate required fields
    If txtMake.Text = "" Or txtModel.Text = "" Then
        MessageBox.Show("Enter Make and Model")
        Exit Sub
    End If

      ' validate year input
    If Not Integer.TryParse(txtYear.Text, v.Year) Then
        MessageBox.Show("Invalid Year")
        Exit Sub
    End If

    ' Validate price input
    If Not Decimal.TryParse(txtPrice.Text, v.Price) Then
        MessageBox.Show("Invalid Price")
        Exit Sub
    End If

    ' Assign remaining properties
    v.Make = txtMake.Text
    v.Model = txtModel.Text

    ' Add to list and refresh display
    inventory.Add(v)
    RefreshInventory()
  End Sub

  ' Updates selected vehicle with new values
  Private Sub btnUpdateVehicle_Click(sender As Object, e As EventArgs) Handles btnUpdateVehicle.Click
    Dim selected As Vehicle = CType(lstInventory.SelectedItem, Vehicle)

    ' Ensure a vehicle is selected
    If selected Is Nothing Then
        MessageBox.Show("Select a vehicle to update")
        Exit Sub
    End If

    ' update properties
    selected.Make = txtMake.Text
    selected.Model = txtModel.Text
    Integer.TryParse(txtYear.Text, selected.Year)
    Decimal.TryParse(txtPrice.Text, selected.Price)

    ' Refresh Display
    RefreshInventory()
  End Sub

  ' Deletes selected vehicle from inventory
  Private Sub btnDeleteVehicle_Click(sender As Object, e As EventArgs) Handles btnDeleteVehicle.Click
    Dim selected As Vehicle = CType(lstInventory.SelectedItem, Vehicle)

    ' Ensure a vehicle is selected
    If selected Is Nothing Then
        MessageBox.Show("Select a vehicle to delete")
        Exit Sub
    End If

    ' Confirm before deleting
    If MessageBox.Show("Delete this vehicle?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        inventory.Remove(selected)
        RefreshInventory()
    End If
  End Sub
End Class
