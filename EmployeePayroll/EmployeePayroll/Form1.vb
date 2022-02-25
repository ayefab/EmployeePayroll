Public Class frmEmployeePayroll

    Const MAX_EMPLOYEES As Integer = 20

    Public Employees(MAX_EMPLOYEES) As Employee
    Public currentIndex As Integer = 0

    Public Sub ClearForm()

        txtName.Clear()
        txtRate.Clear()
        txtHours.Clear()


    End Sub

    Public Sub AddEmployee(ByVal name As String, ByVal hours As Double, ByVal rate As Double)

        Employees(currentIndex) = New Employee()
        Employees(currentIndex).SetName(name)
        Employees(currentIndex).SetHours(hours)
        Employees(currentIndex).SetRate(rate)

        MessageBox.Show("Employee Added: " & Employees(currentIndex).GetName(), "Employee Added", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ClearForm()

        currentIndex = currentIndex + 1

        If currentIndex = MAX_EMPLOYEES - 1 Then

            MessageBox.Show("System has reached its capacity.", "System Full", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtName.Enabled = False
            txtHours.Enabled = False
            txtRate.Enabled = False

            btnEmployeeAndHours.Enabled = False


        End If
    End Sub

    Private Sub btnEmployeeAndHours_Click(sender As Object, e As EventArgs) Handles btnEmployeeAndHours.Click

        Dim errors As String = ""

        If String.IsNullOrEmpty(txtName.Text) Then

            errors &= "Please enter employee name." & vbLf

        End If

        If String.IsNullOrEmpty(txtRate.Text) Then

            errors &= "Enter hourly rate for the employee." & vbLf

        ElseIf Not IsNumeric(txtRate.Text) Then

            errors &= "Enter valid employee rate." & vbLf

        End If

        If String.IsNullOrEmpty(txtHours.Text) Then

            errors &= "Enter hours for the employee." & vbLf

        ElseIf Not IsNumeric(txtHours.Text) Then

            errors &= "Enter valid hours worked." & vbLf

        End If

        If Not String.IsNullOrEmpty(errors) Then

            MessageBox.Show(errors, "Errors Found!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return

        End If

        AddEmployee(txtName.Text, CDbl(txtHours.Text), CDbl(txtRate.Text))


    End Sub

    Private Sub btnDisplayPayroll_Click(sender As Object, e As EventArgs) Handles btnDisplayPayroll.Click

        lbDisplayPayroll.Items.Clear()

        If currentIndex = 0 Then

            MessageBox.Show("No employees are in the system.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return
        End If

        For index As Integer = 0 To currentIndex - 1

            lbDisplayPayroll.Items.Add("Name: " & Employees(index).GetName())
            lbDisplayPayroll.Items.Add("Hours: " & Employees(index).GetHours())
            lbDisplayPayroll.Items.Add("Rate : " & Employees(index).GetRate())
            lbDisplayPayroll.Items.Add("Pay: " & Employees(index).GetPay().ToString("C2"))
            lbDisplayPayroll.Items.Add("")
        Next

    End Sub
End Class
