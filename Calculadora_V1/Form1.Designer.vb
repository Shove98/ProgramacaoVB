<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoma
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtOper1 = New System.Windows.Forms.TextBox()
        Me.txtOper2 = New System.Windows.Forms.TextBox()
        Me.lbISinal = New System.Windows.Forms.Label()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOper1
        '
        Me.txtOper1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOper1.Location = New System.Drawing.Point(171, 73)
        Me.txtOper1.Name = "txtOper1"
        Me.txtOper1.Size = New System.Drawing.Size(100, 30)
        Me.txtOper1.TabIndex = 0
        '
        'txtOper2
        '
        Me.txtOper2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOper2.Location = New System.Drawing.Point(505, 73)
        Me.txtOper2.Name = "txtOper2"
        Me.txtOper2.Size = New System.Drawing.Size(100, 30)
        Me.txtOper2.TabIndex = 1
        '
        'lbISinal
        '
        Me.lbISinal.AutoSize = True
        Me.lbISinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbISinal.Location = New System.Drawing.Point(363, 73)
        Me.lbISinal.Name = "lbISinal"
        Me.lbISinal.Size = New System.Drawing.Size(33, 36)
        Me.lbISinal.TabIndex = 2
        Me.lbISinal.Text = "+"
        '
        'btnIgual
        '
        Me.btnIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIgual.Location = New System.Drawing.Point(339, 155)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(75, 47)
        Me.btnIgual.TabIndex = 3
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblResultado.Location = New System.Drawing.Point(318, 254)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(113, 38)
        Me.lblResultado.TabIndex = 4
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(505, 348)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(109, 40)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmSoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnIgual)
        Me.Controls.Add(Me.lbISinal)
        Me.Controls.Add(Me.txtOper2)
        Me.Controls.Add(Me.txtOper1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSoma"
        Me.Text = "Soma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOper1 As TextBox
    Friend WithEvents txtOper2 As TextBox
    Friend WithEvents lbISinal As Label
    Friend WithEvents btnIgual As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnSair As Button
End Class
