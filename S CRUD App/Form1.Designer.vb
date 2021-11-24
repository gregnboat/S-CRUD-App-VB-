<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Textproductid = New System.Windows.Forms.TextBox()
        Me.Textitemname = New System.Windows.Forms.TextBox()
        Me.Textdesign = New System.Windows.Forms.TextBox()
        Me.Combocolor = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerinsert = New System.Windows.Forms.DateTimePicker()
        Me.Radioallowed = New System.Windows.Forms.RadioButton()
        Me.Radionotallowed = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(437, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CRUD S Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(152, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(152, 574)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Warranty"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(152, 522)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Insert Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(152, 466)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Color"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(152, 415)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Design"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(152, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Item Name"
        '
        'Textproductid
        '
        Me.Textproductid.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Textproductid.Location = New System.Drawing.Point(391, 304)
        Me.Textproductid.Name = "Textproductid"
        Me.Textproductid.Size = New System.Drawing.Size(352, 30)
        Me.Textproductid.TabIndex = 7
        '
        'Textitemname
        '
        Me.Textitemname.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Textitemname.Location = New System.Drawing.Point(391, 360)
        Me.Textitemname.Name = "Textitemname"
        Me.Textitemname.Size = New System.Drawing.Size(352, 30)
        Me.Textitemname.TabIndex = 8
        '
        'Textdesign
        '
        Me.Textdesign.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Textdesign.Location = New System.Drawing.Point(391, 413)
        Me.Textdesign.Name = "Textdesign"
        Me.Textdesign.Size = New System.Drawing.Size(352, 30)
        Me.Textdesign.TabIndex = 9
        '
        'Combocolor
        '
        Me.Combocolor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Combocolor.FormattingEnabled = True
        Me.Combocolor.Items.AddRange(New Object() {"Black", "White", "Silver", "Gold"})
        Me.Combocolor.Location = New System.Drawing.Point(391, 467)
        Me.Combocolor.Name = "Combocolor"
        Me.Combocolor.Size = New System.Drawing.Size(352, 31)
        Me.Combocolor.TabIndex = 13
        '
        'DateTimePickerinsert
        '
        Me.DateTimePickerinsert.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePickerinsert.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerinsert.Location = New System.Drawing.Point(391, 524)
        Me.DateTimePickerinsert.Name = "DateTimePickerinsert"
        Me.DateTimePickerinsert.Size = New System.Drawing.Size(352, 30)
        Me.DateTimePickerinsert.TabIndex = 14
        '
        'Radioallowed
        '
        Me.Radioallowed.AutoSize = True
        Me.Radioallowed.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Radioallowed.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Radioallowed.Location = New System.Drawing.Point(391, 578)
        Me.Radioallowed.Name = "Radioallowed"
        Me.Radioallowed.Size = New System.Drawing.Size(91, 27)
        Me.Radioallowed.TabIndex = 15
        Me.Radioallowed.TabStop = True
        Me.Radioallowed.Text = "Allowed"
        Me.Radioallowed.UseVisualStyleBackColor = True
        '
        'Radionotallowed
        '
        Me.Radionotallowed.AutoSize = True
        Me.Radionotallowed.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Radionotallowed.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Radionotallowed.Location = New System.Drawing.Point(618, 578)
        Me.Radionotallowed.Name = "Radionotallowed"
        Me.Radionotallowed.Size = New System.Drawing.Size(125, 27)
        Me.Radionotallowed.TabIndex = 16
        Me.Radionotallowed.TabStop = True
        Me.Radionotallowed.Text = "Not Allowed"
        Me.Radionotallowed.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(391, 611)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 53)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(152, 687)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(731, 174)
        Me.DataGridView1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Location = New System.Drawing.Point(628, 611)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 53)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(510, 611)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 53)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button4.Location = New System.Drawing.Point(749, 300)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 41)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1087, 873)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Radionotallowed)
        Me.Controls.Add(Me.Radioallowed)
        Me.Controls.Add(Me.DateTimePickerinsert)
        Me.Controls.Add(Me.Combocolor)
        Me.Controls.Add(Me.Textdesign)
        Me.Controls.Add(Me.Textitemname)
        Me.Controls.Add(Me.Textproductid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Textproductid As TextBox
    Friend WithEvents Textitemname As TextBox
    Friend WithEvents Textdesign As TextBox
    Friend WithEvents Combocolor As ComboBox
    Friend WithEvents DateTimePickerinsert As DateTimePicker
    Friend WithEvents Radioallowed As RadioButton
    Friend WithEvents Radionotallowed As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
