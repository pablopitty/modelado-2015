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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NoBuildTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.PatternTextBox = New System.Windows.Forms.TextBox()
        Me.TeamProjectCollectionTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Soluciones sin Build"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Soluciones halladas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Patron por buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Conexion TFS"
        '
        'NoBuildTextBox
        '
        Me.NoBuildTextBox.Location = New System.Drawing.Point(137, 228)
        Me.NoBuildTextBox.Multiline = True
        Me.NoBuildTextBox.Name = "NoBuildTextBox"
        Me.NoBuildTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.NoBuildTextBox.Size = New System.Drawing.Size(511, 133)
        Me.NoBuildTextBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Buscar soluciones en teamproject"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(137, 89)
        Me.ResultTextBox.Multiline = True
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ResultTextBox.Size = New System.Drawing.Size(511, 133)
        Me.ResultTextBox.TabIndex = 11
        '
        'PatternTextBox
        '
        Me.PatternTextBox.Location = New System.Drawing.Point(137, 31)
        Me.PatternTextBox.Name = "PatternTextBox"
        Me.PatternTextBox.Size = New System.Drawing.Size(223, 20)
        Me.PatternTextBox.TabIndex = 10
        Me.PatternTextBox.Text = "$/vss/*.sln"
        '
        'TeamProjectCollectionTextBox
        '
        Me.TeamProjectCollectionTextBox.Location = New System.Drawing.Point(137, 4)
        Me.TeamProjectCollectionTextBox.Name = "TeamProjectCollectionTextBox"
        Me.TeamProjectCollectionTextBox.Size = New System.Drawing.Size(223, 20)
        Me.TeamProjectCollectionTextBox.TabIndex = 9
        Me.TeamProjectCollectionTextBox.Text = "http://dorado:8080/tfs"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 365)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NoBuildTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.PatternTextBox)
        Me.Controls.Add(Me.TeamProjectCollectionTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NoBuildTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ResultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatternTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TeamProjectCollectionTextBox As System.Windows.Forms.TextBox

End Class
