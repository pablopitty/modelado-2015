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
        Me.TeamProjectCollectionTextBox = New System.Windows.Forms.TextBox()
        Me.PatternTextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NoBuildTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TeamProjectCollectionTextBox
        '
        Me.TeamProjectCollectionTextBox.Location = New System.Drawing.Point(164, 30)
        Me.TeamProjectCollectionTextBox.Name = "TeamProjectCollectionTextBox"
        Me.TeamProjectCollectionTextBox.Size = New System.Drawing.Size(223, 20)
        Me.TeamProjectCollectionTextBox.TabIndex = 0
        Me.TeamProjectCollectionTextBox.Text = "http://dorado:8080/tfs"
        '
        'PatternTextBox
        '
        Me.PatternTextBox.Location = New System.Drawing.Point(164, 57)
        Me.PatternTextBox.Name = "PatternTextBox"
        Me.PatternTextBox.Size = New System.Drawing.Size(223, 20)
        Me.PatternTextBox.TabIndex = 1
        Me.PatternTextBox.Text = "$/vss/*.sln"
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(164, 115)
        Me.ResultTextBox.Multiline = True
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ResultTextBox.Size = New System.Drawing.Size(511, 133)
        Me.ResultTextBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(164, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(223, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Buscar soluciones en teamproject"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NoBuildTextBox
        '
        Me.NoBuildTextBox.Location = New System.Drawing.Point(164, 254)
        Me.NoBuildTextBox.Multiline = True
        Me.NoBuildTextBox.Name = "NoBuildTextBox"
        Me.NoBuildTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.NoBuildTextBox.Size = New System.Drawing.Size(511, 133)
        Me.NoBuildTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Conexion TFS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Patron por buscar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Soluciones halladas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Soluciones sin Build"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 389)
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
        Me.Text = "Busqueda de Soluciones sin Builds"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TeamProjectCollectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PatternTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ResultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NoBuildTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
