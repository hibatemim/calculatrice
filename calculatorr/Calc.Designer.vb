<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calc
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btneq = New System.Windows.Forms.Button()
        Me.btnce = New System.Windows.Forms.Button()
        Me.btnc = New System.Windows.Forms.Button()
        Me.btndiv = New System.Windows.Forms.Button()
        Me.btnmult = New System.Windows.Forms.Button()
        Me.btnminus = New System.Windows.Forms.Button()
        Me.btnplus = New System.Windows.Forms.Button()
        Me.btno = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnp = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btneq
        '
        Me.btneq.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btneq.Location = New System.Drawing.Point(472, 339)
        Me.btneq.Name = "btneq"
        Me.btneq.Size = New System.Drawing.Size(137, 46)
        Me.btneq.TabIndex = 39
        Me.btneq.Text = "="
        Me.btneq.UseVisualStyleBackColor = True
        '
        'btnce
        '
        Me.btnce.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btnce.Location = New System.Drawing.Point(547, 272)
        Me.btnce.Name = "btnce"
        Me.btnce.Size = New System.Drawing.Size(62, 46)
        Me.btnce.TabIndex = 38
        Me.btnce.Text = "CE"
        Me.btnce.UseVisualStyleBackColor = True
        '
        'btnc
        '
        Me.btnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btnc.Location = New System.Drawing.Point(472, 272)
        Me.btnc.Name = "btnc"
        Me.btnc.Size = New System.Drawing.Size(62, 46)
        Me.btnc.TabIndex = 37
        Me.btnc.Text = "C"
        Me.btnc.UseVisualStyleBackColor = True
        '
        'btndiv
        '
        Me.btndiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btndiv.Location = New System.Drawing.Point(547, 206)
        Me.btndiv.Name = "btndiv"
        Me.btndiv.Size = New System.Drawing.Size(62, 46)
        Me.btndiv.TabIndex = 36
        Me.btndiv.Text = "/"
        Me.btndiv.UseVisualStyleBackColor = True
        '
        'btnmult
        '
        Me.btnmult.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btnmult.Location = New System.Drawing.Point(472, 206)
        Me.btnmult.Name = "btnmult"
        Me.btnmult.Size = New System.Drawing.Size(62, 46)
        Me.btnmult.TabIndex = 35
        Me.btnmult.Text = "*"
        Me.btnmult.UseVisualStyleBackColor = True
        '
        'btnminus
        '
        Me.btnminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btnminus.Location = New System.Drawing.Point(547, 141)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(62, 46)
        Me.btnminus.TabIndex = 34
        Me.btnminus.Text = "-"
        Me.btnminus.UseVisualStyleBackColor = True
        '
        'btnplus
        '
        Me.btnplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btnplus.Location = New System.Drawing.Point(472, 141)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(62, 46)
        Me.btnplus.TabIndex = 33
        Me.btnplus.Text = "+"
        Me.btnplus.UseVisualStyleBackColor = True
        '
        'btno
        '
        Me.btno.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btno.Location = New System.Drawing.Point(338, 339)
        Me.btno.Name = "btno"
        Me.btno.Size = New System.Drawing.Size(62, 46)
        Me.btno.TabIndex = 32
        Me.btno.Text = "00"
        Me.btno.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btn0.Location = New System.Drawing.Point(263, 339)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(62, 46)
        Me.btn0.TabIndex = 31
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnp
        '
        Me.btnp.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btnp.Location = New System.Drawing.Point(191, 339)
        Me.btnp.Name = "btnp"
        Me.btnp.Size = New System.Drawing.Size(62, 46)
        Me.btnp.TabIndex = 30
        Me.btnp.Text = "."
        Me.btnp.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btn9.Location = New System.Drawing.Point(338, 272)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(62, 46)
        Me.btn9.TabIndex = 29
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btn8.Location = New System.Drawing.Point(263, 272)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(62, 46)
        Me.btn8.TabIndex = 28
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btn7.Location = New System.Drawing.Point(191, 272)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(62, 46)
        Me.btn7.TabIndex = 27
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btn6.Location = New System.Drawing.Point(338, 206)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(62, 46)
        Me.btn6.TabIndex = 26
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btn5.Location = New System.Drawing.Point(263, 206)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(62, 46)
        Me.btn5.TabIndex = 25
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btn4.Location = New System.Drawing.Point(191, 206)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(62, 46)
        Me.btn4.TabIndex = 24
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btn3.Location = New System.Drawing.Point(338, 141)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(62, 46)
        Me.btn3.TabIndex = 23
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btn2.Location = New System.Drawing.Point(263, 141)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(62, 46)
        Me.btn2.TabIndex = 22
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btn1.Location = New System.Drawing.Point(191, 141)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(62, 46)
        Me.btn1.TabIndex = 21
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'result
        '
        Me.result.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.result.Location = New System.Drawing.Point(191, 65)
        Me.result.Multiline = True
        Me.result.Name = "result"
        Me.result.ReadOnly = True
        Me.result.Size = New System.Drawing.Size(418, 54)
        Me.result.TabIndex = 20
        '
        'Calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btneq)
        Me.Controls.Add(Me.btnce)
        Me.Controls.Add(Me.btnc)
        Me.Controls.Add(Me.btndiv)
        Me.Controls.Add(Me.btnmult)
        Me.Controls.Add(Me.btnminus)
        Me.Controls.Add(Me.btnplus)
        Me.Controls.Add(Me.btno)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnp)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.result)
        Me.Name = "Calc"
        Me.Text = "Calc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btneq As Button
    Friend WithEvents btnce As Button
    Friend WithEvents btnc As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btnmult As Button
    Friend WithEvents btnminus As Button
    Friend WithEvents btnplus As Button
    Friend WithEvents btno As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnp As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents result As TextBox
End Class
