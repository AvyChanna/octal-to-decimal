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
        Me.InputOctal = New System.Windows.Forms.TextBox()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InputOctal
        '
        Me.InputOctal.Location = New System.Drawing.Point(160, 21)
        Me.InputOctal.Name = "InputOctal"
        Me.InputOctal.Size = New System.Drawing.Size(90, 20)
        Me.InputOctal.TabIndex = 0
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(108, 196)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "Button1"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.InputOctal)
        Me.Name = "Form1"
        Me.Text = "Octal To Decimal Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InputOctal As System.Windows.Forms.TextBox
    Friend WithEvents OkButton As System.Windows.Forms.Button

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        'Obtain input from user in textbox.
        Dim s As String = InputOctal.Text

        'Validate input 
        If (validateInput(s) = False) Then
            'user entered input in wrong format
            InputOctal.Text = s + "6"
            Return
        End If

        'Valid input entered by user .Now find res
        'Split string into 2 parts .one containing digits before decimal and other containing digits after decimal

        Dim befDec, aftDec As String
        befDec = ""
        aftDec = ""

        Dim foundDot As Boolean = False
        For Each c As Char In s
            If c = "." Then
                foundDot = True
            ElseIf foundDot Then
                aftDec += c
            Else
                befDec += c
            End If
        Next

        System.Console.WriteLine(aftDec)
        System.Console.WriteLine(befDec)

        'Do visualisation as you find answer
        'visualisation method unknows till now

    End Sub
End Class

