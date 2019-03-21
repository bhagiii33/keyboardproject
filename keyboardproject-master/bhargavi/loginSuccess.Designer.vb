<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGINFORM
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
        Me.signout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN SUCCESSFUL"
        '
        'signout
        '
        Me.signout.Location = New System.Drawing.Point(358, 313)
        Me.signout.Name = "signout"
        Me.signout.Size = New System.Drawing.Size(75, 23)
        Me.signout.TabIndex = 1
        Me.signout.Text = "Sign out"
        Me.signout.UseVisualStyleBackColor = True
        '
        'LOGINFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 395)
        Me.Controls.Add(Me.signout)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LOGINFORM"
        Me.Text = "login successful form"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents signout As System.Windows.Forms.Button
End Class
