
Public Class Form1

        Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

            Dim salary As Double
        Dim dependants As Integer
        Dim schoolFees As Double
            Dim totalExpenses As Double
            Dim takeHomeBalance As Double

            salary = 2300000
        dependants = 4
        schoolFees = 430000

        totalExpenses = dependants * schoolFees
        takeHomeBalance = salary - totalExpenses

        MessageBox.Show("Total School Fees = UGX " & totalExpenses.ToString("N0") &
                         vbNewLine & "Take Home Balance = UGX " & takeHomeBalance.ToString("N0"))




        Dim nssf As Double
        Dim paye As Double
        Dim sacco As Double
        Dim totalDeductions As Double
        Dim balance As Double

        salary = 2300000

        nssf = salary * 10 / 100
        paye = salary * 9 / 100
        sacco = salary * 5 / 100

        totalDeductions = nssf + paye + sacco
        balance = salary - totalDeductions

        MessageBox.Show("NSSF = UGX " & nssf.ToString("N0") &
                        vbNewLine & "PAYE = UGX " & paye.ToString("N0") &
                        vbNewLine & "SACCO = UGX " & sacco.ToString("N0") &
                        vbNewLine & "Total Deductions = UGX " & totalDeductions.ToString("N0") &
                        vbNewLine & "Balance After Deductions = UGX " & balance.ToString("N0"))

    End Sub

End Class