<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContas
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
        Me.txtOper1 = New System.Windows.Forms.TextBox()
        Me.txtOper2 = New System.Windows.Forms.TextBox()
        Me.lblAdicao = New System.Windows.Forms.Label()
        Me.lblMultiplicacao = New System.Windows.Forms.Label()
        Me.lblSubtracao = New System.Windows.Forms.Label()
        Me.lblDivisao = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtOper1
        '
        Me.txtOper1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOper1.Location = New System.Drawing.Point(110, 71)
        Me.txtOper1.Name = "txtOper1"
        Me.txtOper1.Size = New System.Drawing.Size(100, 30)
        Me.txtOper1.TabIndex = 0
        '
        'txtOper2
        '
        Me.txtOper2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOper2.Location = New System.Drawing.Point(110, 215)
        Me.txtOper2.Name = "txtOper2"
        Me.txtOper2.Size = New System.Drawing.Size(100, 30)
        Me.txtOper2.TabIndex = 1
        '
        'lblAdicao
        '
        Me.lblAdicao.AutoSize = True
        Me.lblAdicao.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdicao.Location = New System.Drawing.Point(393, 68)
        Me.lblAdicao.Name = "lblAdicao"
        Me.lblAdicao.Size = New System.Drawing.Size(33, 36)
        Me.lblAdicao.TabIndex = 2
        Me.lblAdicao.Text = "+"
        '
        'lblMultiplicacao
        '
        Me.lblMultiplicacao.AutoSize = True
        Me.lblMultiplicacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiplicacao.Location = New System.Drawing.Point(589, 65)
        Me.lblMultiplicacao.Name = "lblMultiplicacao"
        Me.lblMultiplicacao.Size = New System.Drawing.Size(31, 36)
        Me.lblMultiplicacao.TabIndex = 3
        Me.lblMultiplicacao.Text = "x"
        '
        'lblSubtracao
        '
        Me.lblSubtracao.AutoSize = True
        Me.lblSubtracao.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtracao.Location = New System.Drawing.Point(393, 209)
        Me.lblSubtracao.Name = "lblSubtracao"
        Me.lblSubtracao.Size = New System.Drawing.Size(26, 36)
        Me.lblSubtracao.TabIndex = 4
        Me.lblSubtracao.Text = "-"
        '
        'lblDivisao
        '
        Me.lblDivisao.AutoSize = True
        Me.lblDivisao.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisao.Location = New System.Drawing.Point(589, 209)
        Me.lblDivisao.Name = "lblDivisao"
        Me.lblDivisao.Size = New System.Drawing.Size(24, 36)
        Me.lblDivisao.TabIndex = 5
        Me.lblDivisao.Text = "/"
        '
        'lblResultado
        '
        Me.lblResultado.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblResultado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblResultado.Location = New System.Drawing.Point(460, 342)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(129, 22)
        Me.lblResultado.TabIndex = 6
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSair
        '
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Location = New System.Drawing.Point(632, 393)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 34)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextBox3.Location = New System.Drawing.Point(382, 342)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(72, 22)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "Resultado:"
        '
        'frmContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblDivisao)
        Me.Controls.Add(Me.lblSubtracao)
        Me.Controls.Add(Me.lblMultiplicacao)
        Me.Controls.Add(Me.lblAdicao)
        Me.Controls.Add(Me.txtOper2)
        Me.Controls.Add(Me.txtOper1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmContas"
        Me.Text = "Contas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOper1 As TextBox
    Friend WithEvents txtOper2 As TextBox
    Friend WithEvents lblAdicao As Label
    Friend WithEvents lblMultiplicacao As Label
    Friend WithEvents lblSubtracao As Label
    Friend WithEvents lblDivisao As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnSair As Button
    Friend WithEvents TextBox3 As TextBox
End Class
