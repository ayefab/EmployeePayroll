<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployeePayroll
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.btnEmployeeAndHours = New System.Windows.Forms.Button()
        Me.btnDisplayPayroll = New System.Windows.Forms.Button()
        Me.lbDisplayPayroll = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(12, 51)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(33, 13)
        Me.lblRate.TabIndex = 1
        Me.lblRate.Text = "Rate:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(12, 90)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(38, 13)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "Hours:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(57, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(235, 20)
        Me.txtName.TabIndex = 3
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(57, 51)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 4
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(57, 90)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 5
        '
        'btnEmployeeAndHours
        '
        Me.btnEmployeeAndHours.Location = New System.Drawing.Point(15, 136)
        Me.btnEmployeeAndHours.Name = "btnEmployeeAndHours"
        Me.btnEmployeeAndHours.Size = New System.Drawing.Size(285, 23)
        Me.btnEmployeeAndHours.TabIndex = 6
        Me.btnEmployeeAndHours.Text = "Record Employee and Hours"
        Me.btnEmployeeAndHours.UseVisualStyleBackColor = True
        '
        'btnDisplayPayroll
        '
        Me.btnDisplayPayroll.Location = New System.Drawing.Point(15, 166)
        Me.btnDisplayPayroll.Name = "btnDisplayPayroll"
        Me.btnDisplayPayroll.Size = New System.Drawing.Size(285, 23)
        Me.btnDisplayPayroll.TabIndex = 7
        Me.btnDisplayPayroll.Text = "Display Payroll"
        Me.btnDisplayPayroll.UseVisualStyleBackColor = True
        '
        'lbDisplayPayroll
        '
        Me.lbDisplayPayroll.FormattingEnabled = True
        Me.lbDisplayPayroll.Location = New System.Drawing.Point(15, 196)
        Me.lbDisplayPayroll.Name = "lbDisplayPayroll"
        Me.lbDisplayPayroll.Size = New System.Drawing.Size(285, 95)
        Me.lbDisplayPayroll.TabIndex = 8
        '
        'frmEmployeePayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 301)
        Me.Controls.Add(Me.lbDisplayPayroll)
        Me.Controls.Add(Me.btnDisplayPayroll)
        Me.Controls.Add(Me.btnEmployeeAndHours)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmEmployeePayroll"
        Me.Text = "QCC Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtHours As TextBox
    Friend WithEvents btnEmployeeAndHours As Button
    Friend WithEvents btnDisplayPayroll As Button
    Friend WithEvents lbDisplayPayroll As ListBox
End Class
