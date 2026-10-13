<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCalculate = New Button()
        lblSalary = New Label()
        lblDependants = New Label()
        lblSchoolfees = New Label()
        lblTotalExpenses = New Label()
        lblTakeHomeBalance = New Label()
        txtSalary = New TextBox()
        txtDependants = New TextBox()
        txtTakeHomeBalance = New TextBox()
        txtSchoolfees = New TextBox()
        txtTotalExpenses = New TextBox()
        SuspendLayout()
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 18.0F)
        btnCalculate.Location = New Point(211, 376)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(125, 35)
        btnCalculate.TabIndex = 0
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' lblSalary
        ' 
        lblSalary.AutoSize = True
        lblSalary.Font = New Font("Segoe UI", 18.0F)
        lblSalary.Location = New Point(23, 30)
        lblSalary.Name = "lblSalary"
        lblSalary.Size = New Size(74, 32)
        lblSalary.TabIndex = 1
        lblSalary.Text = "salary"
        ' 
        ' lblDependants
        ' 
        lblDependants.AutoSize = True
        lblDependants.Font = New Font("Segoe UI", 18.0F)
        lblDependants.Location = New Point(23, 94)
        lblDependants.Name = "lblDependants"
        lblDependants.Size = New Size(143, 32)
        lblDependants.TabIndex = 4
        lblDependants.Text = "Dependants"
        lblDependants.Visible = False
        ' 
        ' lblSchoolfees
        ' 
        lblSchoolfees.AutoSize = True
        lblSchoolfees.Font = New Font("Segoe UI", 18.0F)
        lblSchoolfees.Location = New Point(23, 153)
        lblSchoolfees.Name = "lblSchoolfees"
        lblSchoolfees.Size = New Size(130, 32)
        lblSchoolfees.TabIndex = 5
        lblSchoolfees.Text = "Schoolfees"
        ' 
        ' lblTotalExpenses
        ' 
        lblTotalExpenses.AutoSize = True
        lblTotalExpenses.Font = New Font("Segoe UI", 18.0F)
        lblTotalExpenses.Location = New Point(23, 221)
        lblTotalExpenses.Name = "lblTotalExpenses"
        lblTotalExpenses.Size = New Size(169, 32)
        lblTotalExpenses.TabIndex = 6
        lblTotalExpenses.Text = "Total Expenses"
        ' 
        ' lblTakeHomeBalance
        ' 
        lblTakeHomeBalance.AutoSize = True
        lblTakeHomeBalance.Font = New Font("Segoe UI", 18.0F)
        lblTakeHomeBalance.Location = New Point(23, 291)
        lblTakeHomeBalance.Name = "lblTakeHomeBalance"
        lblTakeHomeBalance.Size = New Size(222, 32)
        lblTakeHomeBalance.TabIndex = 7
        lblTakeHomeBalance.Text = "Take Home Balance"
        ' 
        ' txtSalary
        ' 
        txtSalary.Location = New Point(274, 39)
        txtSalary.Name = "txtSalary"
        txtSalary.Size = New Size(100, 23)
        txtSalary.TabIndex = 8
        ' 
        ' txtDependants
        ' 
        txtDependants.Font = New Font("Segoe UI", 18.0F)
        txtDependants.Location = New Point(274, 87)
        txtDependants.Name = "txtDependants"
        txtDependants.Size = New Size(100, 39)
        txtDependants.TabIndex = 9
        ' 
        ' txtTakeHomeBalance
        ' 
        txtTakeHomeBalance.Font = New Font("Segoe UI", 18.0F)
        txtTakeHomeBalance.Location = New Point(283, 302)
        txtTakeHomeBalance.Name = "txtTakeHomeBalance"
        txtTakeHomeBalance.Size = New Size(100, 39)
        txtTakeHomeBalance.TabIndex = 10
        ' 
        ' txtSchoolfees
        ' 
        txtSchoolfees.Font = New Font("Segoe UI", 18.0F)
        txtSchoolfees.Location = New Point(274, 162)
        txtSchoolfees.Name = "txtSchoolfees"
        txtSchoolfees.Size = New Size(100, 39)
        txtSchoolfees.TabIndex = 11
        ' 
        ' txtTotalExpenses
        ' 
        txtTotalExpenses.Font = New Font("Segoe UI", 18.0F)
        txtTotalExpenses.Location = New Point(283, 232)
        txtTotalExpenses.Name = "txtTotalExpenses"
        txtTotalExpenses.Size = New Size(100, 39)
        txtTotalExpenses.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(915, 450)
        Controls.Add(txtTotalExpenses)
        Controls.Add(txtSchoolfees)
        Controls.Add(txtTakeHomeBalance)
        Controls.Add(txtDependants)
        Controls.Add(txtSalary)
        Controls.Add(lblTakeHomeBalance)
        Controls.Add(lblTotalExpenses)
        Controls.Add(lblSchoolfees)
        Controls.Add(lblDependants)
        Controls.Add(lblSalary)
        Controls.Add(btnCalculate)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblSalary As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSchoolfees As Label
    Friend WithEvents lblTotalExpenses As Label
    Friend WithEvents lblDependants As Label
    Friend WithEvents txtBalance As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtDependants As TextBox
    Friend WithEvents txtTakeHomeBalance As TextBox
    Friend WithEvents txtSchoolfees As TextBox
    Friend WithEvents txtTotalExpenses As TextBox
    Friend WithEvents lblTakeHomeBalance As Label
    Friend WithEvents txtSalary As TextBox

End Class
