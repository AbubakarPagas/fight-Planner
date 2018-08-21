<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlight
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstCities = New System.Windows.Forms.ListBox()
        Me.cboSeat = New System.Windows.Forms.ComboBox()
        Me.cboMeal = New System.Windows.Forms.ComboBox()
        Me.cmdAssign = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Destination City"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(276, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Seat Loaction"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(517, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Meal Preference"
        '
        'lstCities
        '
        Me.lstCities.FormattingEnabled = True
        Me.lstCities.Location = New System.Drawing.Point(3, 86)
        Me.lstCities.Name = "lstCities"
        Me.lstCities.Size = New System.Drawing.Size(189, 160)
        Me.lstCities.Sorted = True
        Me.lstCities.TabIndex = 3
        '
        'cboSeat
        '
        Me.cboSeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeat.FormattingEnabled = True
        Me.cboSeat.Location = New System.Drawing.Point(236, 86)
        Me.cboSeat.Name = "cboSeat"
        Me.cboSeat.Size = New System.Drawing.Size(185, 21)
        Me.cboSeat.TabIndex = 4
        '
        'cboMeal
        '
        Me.cboMeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboMeal.FormattingEnabled = True
        Me.cboMeal.Location = New System.Drawing.Point(474, 86)
        Me.cboMeal.Name = "cboMeal"
        Me.cboMeal.Size = New System.Drawing.Size(223, 163)
        Me.cboMeal.TabIndex = 5
        '
        'cmdAssign
        '
        Me.cmdAssign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAssign.Location = New System.Drawing.Point(197, 287)
        Me.cmdAssign.Name = "cmdAssign"
        Me.cmdAssign.Size = New System.Drawing.Size(99, 37)
        Me.cmdAssign.TabIndex = 6
        Me.cmdAssign.Text = "&Assign"
        Me.cmdAssign.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(378, 287)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(99, 37)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 358)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdAssign)
        Me.Controls.Add(Me.cboMeal)
        Me.Controls.Add(Me.cboSeat)
        Me.Controls.Add(Me.lstCities)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmFlight"
        Me.Text = "Flight Planner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstCities As System.Windows.Forms.ListBox
    Friend WithEvents cboSeat As System.Windows.Forms.ComboBox
    Friend WithEvents cboMeal As System.Windows.Forms.ComboBox
    Friend WithEvents cmdAssign As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button

End Class
