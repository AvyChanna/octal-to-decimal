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
        Dim s As String = InputOctal.Text
        Dim notFirst, hasDot, hasSign As Boolean
        notFirst = False
        hasDot = False
        hasSign = False
        For Each c As Char In s
            If Asc(c) >= Asc("0") AndAlso Asc(c) <= Asc("7") Then
                Continue For
            ElseIf Asc(c) = Asc("-") AndAlso notFirst = False AndAlso hasSign = False Then
                hasSign = True
                Continue For
            ElseIf Asc(c) = Asc("+") AndAlso notFirst = False AndAlso hasSign = False Then
                hasSign = True
                Continue For
            ElseIf Asc(c) >= Asc(".") AndAlso hasDot = False Then
                hasDot = True
                Continue For
            End If
            notFirst = True

        Next

    End Sub

