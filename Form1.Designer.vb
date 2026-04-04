<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.chkNavigation = New System.Windows.Forms.CheckBox()
        Me.chkSound = New System.Windows.Forms.CheckBox()
        Me.chkLeather = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblAccessoriesFinish = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.radCustom = New System.Windows.Forms.RadioButton()
        Me.radPearlized = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.btnDeleteVehicle = New System.Windows.Forms.Button()
        Me.btnUpdateVehicle = New System.Windows.Forms.Button()
        Me.btnAddVehicle = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstInventory = New System.Windows.Forms.ListBox()
        Me.txtTradeIn = New System.Windows.Forms.TextBox()
        Me.txtBasePrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Checked = True
        Me.radStandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStandard.Location = New System.Drawing.Point(57, 41)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(162, 26)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard (Free)"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReceipt.Location = New System.Drawing.Point(734, 956)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(346, 61)
        Me.btnPrintReceipt.TabIndex = 32
        Me.btnPrintReceipt.Text = "Print Receipt"
        Me.btnPrintReceipt.UseVisualStyleBackColor = True
        '
        'chkNavigation
        '
        Me.chkNavigation.AutoSize = True
        Me.chkNavigation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNavigation.Location = New System.Drawing.Point(56, 125)
        Me.chkNavigation.Name = "chkNavigation"
        Me.chkNavigation.Size = New System.Drawing.Size(188, 26)
        Me.chkNavigation.TabIndex = 7
        Me.chkNavigation.Text = "Navigation ($1500)"
        Me.chkNavigation.UseVisualStyleBackColor = True
        '
        'chkSound
        '
        Me.chkSound.AutoSize = True
        Me.chkSound.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSound.Location = New System.Drawing.Point(56, 41)
        Me.chkSound.Name = "chkSound"
        Me.chkSound.Size = New System.Drawing.Size(214, 26)
        Me.chkSound.TabIndex = 5
        Me.chkSound.Text = "Sound System ($500) "
        Me.chkSound.UseVisualStyleBackColor = True
        '
        'chkLeather
        '
        Me.chkLeather.AutoSize = True
        Me.chkLeather.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLeather.Location = New System.Drawing.Point(56, 83)
        Me.chkLeather.Name = "chkLeather"
        Me.chkLeather.Size = New System.Drawing.Size(229, 26)
        Me.chkLeather.TabIndex = 6
        Me.chkLeather.Text = "Leather Interior ($1000) "
        Me.chkLeather.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTotalDue)
        Me.GroupBox5.Controls.Add(Me.lblSubtotal)
        Me.GroupBox5.Controls.Add(Me.lblTax)
        Me.GroupBox5.Controls.Add(Me.lblAccessoriesFinish)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(26, 804)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(683, 219)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Pricing Summary: "
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalDue.Location = New System.Drawing.Point(367, 165)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(244, 27)
        Me.lblTotalDue.TabIndex = 7
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(367, 123)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(244, 27)
        Me.lblSubtotal.TabIndex = 6
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(367, 84)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(244, 27)
        Me.lblTax.TabIndex = 5
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAccessoriesFinish
        '
        Me.lblAccessoriesFinish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAccessoriesFinish.Location = New System.Drawing.Point(367, 45)
        Me.lblAccessoriesFinish.Name = "lblAccessoriesFinish"
        Me.lblAccessoriesFinish.Size = New System.Drawing.Size(244, 27)
        Me.lblAccessoriesFinish.TabIndex = 4
        Me.lblAccessoriesFinish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(81, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 22)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Total Due:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(81, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 22)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Subtotal: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(81, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 22)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Sales Tax (8%):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(81, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 22)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Accessories and Finish: "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radCustom)
        Me.GroupBox4.Controls.Add(Me.radPearlized)
        Me.GroupBox4.Controls.Add(Me.radStandard)
        Me.GroupBox4.Location = New System.Drawing.Point(608, 123)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(416, 183)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Exterior Finish: "
        '
        'radCustom
        '
        Me.radCustom.AutoSize = True
        Me.radCustom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCustom.Location = New System.Drawing.Point(57, 125)
        Me.radCustom.Name = "radCustom"
        Me.radCustom.Size = New System.Drawing.Size(233, 26)
        Me.radCustom.TabIndex = 2
        Me.radCustom.Text = "Custom Detailing ($750) "
        Me.radCustom.UseVisualStyleBackColor = True
        '
        'radPearlized
        '
        Me.radPearlized.AutoSize = True
        Me.radPearlized.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPearlized.Location = New System.Drawing.Point(57, 83)
        Me.radPearlized.Name = "radPearlized"
        Me.radPearlized.Size = New System.Drawing.Size(166, 26)
        Me.radPearlized.TabIndex = 1
        Me.radPearlized.Text = "Pearlized ($500)"
        Me.radPearlized.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(734, 883)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(346, 61)
        Me.btnCalculate.TabIndex = 31
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(934, 822)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 48)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Red
        Me.btnClear.Location = New System.Drawing.Point(734, 822)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(146, 48)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkNavigation)
        Me.GroupBox3.Controls.Add(Me.chkSound)
        Me.GroupBox3.Controls.Add(Me.chkLeather)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 123)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 183)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Accessories: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.txtYear)
        Me.GroupBox2.Controls.Add(Me.txtModel)
        Me.GroupBox2.Controls.Add(Me.txtMake)
        Me.GroupBox2.Controls.Add(Me.btnDeleteVehicle)
        Me.GroupBox2.Controls.Add(Me.btnUpdateVehicle)
        Me.GroupBox2.Controls.Add(Me.btnAddVehicle)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lstInventory)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(26, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1054, 362)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Vehicle Inventory: "
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(226, 58)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(263, 28)
        Me.txtSearch.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(195, 29)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Search (Make/Model):"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(617, 212)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(407, 28)
        Me.txtPrice.TabIndex = 17
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(618, 166)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(407, 28)
        Me.txtYear.TabIndex = 16
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(617, 114)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(407, 28)
        Me.txtModel.TabIndex = 15
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(617, 56)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(407, 28)
        Me.txtMake.TabIndex = 14
        '
        'btnDeleteVehicle
        '
        Me.btnDeleteVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteVehicle.Location = New System.Drawing.Point(860, 272)
        Me.btnDeleteVehicle.Name = "btnDeleteVehicle"
        Me.btnDeleteVehicle.Size = New System.Drawing.Size(165, 42)
        Me.btnDeleteVehicle.TabIndex = 13
        Me.btnDeleteVehicle.Text = "Delete Vehicle"
        Me.btnDeleteVehicle.UseVisualStyleBackColor = True
        '
        'btnUpdateVehicle
        '
        Me.btnUpdateVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateVehicle.Location = New System.Drawing.Point(689, 272)
        Me.btnUpdateVehicle.Name = "btnUpdateVehicle"
        Me.btnUpdateVehicle.Size = New System.Drawing.Size(165, 42)
        Me.btnUpdateVehicle.TabIndex = 12
        Me.btnUpdateVehicle.Text = "Update"
        Me.btnUpdateVehicle.UseVisualStyleBackColor = True
        '
        'btnAddVehicle
        '
        Me.btnAddVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddVehicle.Location = New System.Drawing.Point(518, 272)
        Me.btnAddVehicle.Name = "btnAddVehicle"
        Me.btnAddVehicle.Size = New System.Drawing.Size(165, 42)
        Me.btnAddVehicle.TabIndex = 11
        Me.btnAddVehicle.Text = "Add Vehicle"
        Me.btnAddVehicle.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(514, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Price:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(514, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Year:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(514, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Model:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(514, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Make:"
        '
        'lstInventory
        '
        Me.lstInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInventory.FormattingEnabled = True
        Me.lstInventory.ItemHeight = 22
        Me.lstInventory.Location = New System.Drawing.Point(29, 122)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(460, 202)
        Me.lstInventory.TabIndex = 0
        '
        'txtTradeIn
        '
        Me.txtTradeIn.Location = New System.Drawing.Point(773, 53)
        Me.txtTradeIn.Name = "txtTradeIn"
        Me.txtTradeIn.Size = New System.Drawing.Size(251, 28)
        Me.txtTradeIn.TabIndex = 3
        '
        'txtBasePrice
        '
        Me.txtBasePrice.Location = New System.Drawing.Point(194, 53)
        Me.txtBasePrice.Name = "txtBasePrice"
        Me.txtBasePrice.Size = New System.Drawing.Size(251, 28)
        Me.txtBasePrice.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(604, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 22)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Trade-In:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Base Price:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txtTradeIn)
        Me.GroupBox1.Controls.Add(Me.txtBasePrice)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 444)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1054, 339)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales: "
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(313, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(490, 39)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "VB Auto Center Dealership System"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 1058)
        Me.Controls.Add(Me.btnPrintReceipt)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB Auto Center"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radStandard As RadioButton
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents chkNavigation As CheckBox
    Friend WithEvents chkSound As CheckBox
    Friend WithEvents chkLeather As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblAccessoriesFinish As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents radCustom As RadioButton
    Friend WithEvents radPearlized As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtMake As TextBox
    Friend WithEvents btnDeleteVehicle As Button
    Friend WithEvents btnUpdateVehicle As Button
    Friend WithEvents btnAddVehicle As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstInventory As ListBox
    Friend WithEvents txtTradeIn As TextBox
    Friend WithEvents txtBasePrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
End Class
