<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpInputs = New System.Windows.Forms.GroupBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDecimals = New System.Windows.Forms.TextBox()
        Me.grpOutputs = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSemiPerimeter = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInputs.SuspendLayout()
        Me.grpOutputs.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.prjHeronsFormula.My.Resources.Resources._0214
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(541, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'grpInputs
        '
        Me.grpInputs.Controls.Add(Me.Label3)
        Me.grpInputs.Controls.Add(Me.txtC)
        Me.grpInputs.Controls.Add(Me.Label2)
        Me.grpInputs.Controls.Add(Me.txtB)
        Me.grpInputs.Controls.Add(Me.Label1)
        Me.grpInputs.Controls.Add(Me.txtA)
        Me.grpInputs.Location = New System.Drawing.Point(12, 278)
        Me.grpInputs.Name = "grpInputs"
        Me.grpInputs.Size = New System.Drawing.Size(541, 100)
        Me.grpInputs.TabIndex = 1
        Me.grpInputs.TabStop = False
        Me.grpInputs.Text = "Input"
        '
        'txtA
        '
        Me.txtA.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtA.Location = New System.Drawing.Point(77, 34)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 32)
        Me.txtA.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "a:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "b:"
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(241, 34)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(100, 32)
        Me.txtB.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(359, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "c:"
        '
        'txtC
        '
        Me.txtC.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtC.Location = New System.Drawing.Point(405, 34)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 32)
        Me.txtC.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(403, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Decimals:"
        '
        'txtDecimals
        '
        Me.txtDecimals.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecimals.Location = New System.Drawing.Point(503, 220)
        Me.txtDecimals.Name = "txtDecimals"
        Me.txtDecimals.Size = New System.Drawing.Size(50, 29)
        Me.txtDecimals.TabIndex = 8
        Me.txtDecimals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpOutputs
        '
        Me.grpOutputs.Controls.Add(Me.Label6)
        Me.grpOutputs.Controls.Add(Me.txtArea)
        Me.grpOutputs.Controls.Add(Me.Label5)
        Me.grpOutputs.Controls.Add(Me.txtSemiPerimeter)
        Me.grpOutputs.Location = New System.Drawing.Point(12, 381)
        Me.grpOutputs.Name = "grpOutputs"
        Me.grpOutputs.Size = New System.Drawing.Size(541, 100)
        Me.grpOutputs.TabIndex = 10
        Me.grpOutputs.TabStop = False
        Me.grpOutputs.Text = "Output"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 24)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "s ="
        '
        'txtSemiPerimeter
        '
        Me.txtSemiPerimeter.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemiPerimeter.Location = New System.Drawing.Point(84, 34)
        Me.txtSemiPerimeter.Name = "txtSemiPerimeter"
        Me.txtSemiPerimeter.ReadOnly = True
        Me.txtSemiPerimeter.Size = New System.Drawing.Size(150, 32)
        Me.txtSemiPerimeter.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(270, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Area ="
        '
        'txtArea
        '
        Me.txtArea.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArea.Location = New System.Drawing.Point(351, 34)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(150, 32)
        Me.txtArea.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Coral
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(302, 510)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 34)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Cl&ear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.PaleGreen
        Me.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompute.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(187, 510)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(109, 34)
        Me.btnCompute.TabIndex = 11
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 556)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.grpOutputs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDecimals)
        Me.Controls.Add(Me.grpInputs)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Heron's Formula"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInputs.ResumeLayout(False)
        Me.grpInputs.PerformLayout()
        Me.grpOutputs.ResumeLayout(False)
        Me.grpOutputs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpInputs As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDecimals As TextBox
    Friend WithEvents grpOutputs As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSemiPerimeter As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCompute As Button
End Class
