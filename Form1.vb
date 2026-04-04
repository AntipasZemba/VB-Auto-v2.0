Imports System.IO
imports System.Drawing.Printing

Public Class Form1

  ' Constants
  Private Constant Tax_Rate As Decimal = 0.08
  Private Constant Sound_Price as Decimal = 500
  Private Const Leather_Price As Decimal = 1000
  Private Const Nav_Price As Decimal = 1500

  ' Data 
  Private inventory As New List(OF Vehicle)

  ' Form Load
  Private Sub Form1_Load(sender as Object, e As EventArgs) Handles MyBase.Load
    LoadInventoryFromFile()
    RefreshInventory()
    radStandard.Checked = True
  End sub

  
End Class
