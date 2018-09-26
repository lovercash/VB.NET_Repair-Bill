Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Clear Fields
        lstDisplay.Items.Clear()

        Dim custName As String
        Dim labor, parts, total As Double

        If IsNumeric(txtLabor.Text) And IsNumeric(txtParts.Text) And txtName.Text <> "" Then

            labor = CDbl(txtLabor.Text)
            parts = CDbl(txtParts.Text)
            custName = txtName.Text

            Dim laborCost As Double = labor * 35
            Dim partsCost As Double = parts + (parts * 0.05)
            total = laborCost + partsCost

            lstDisplay.Items.Add("Customer: " & custName)
            lstDisplay.Items.Add("Labor: " & FormatCurrency(laborCost))
            lstDisplay.Items.Add("Parts: " & FormatCurrency(partsCost))
            lstDisplay.Items.Add("Total Cost:" & FormatCurrency(total))

        Else
            MessageBox.Show("All fields required")


        End If

    End Sub
End Class
