<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.MOSTRAR = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Btn_Minimizar = New System.Windows.Forms.PictureBox()
        Me.Btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.OCULTAR = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.MOSTRAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OCULTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MOSTRAR
        '
        Me.MOSTRAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MOSTRAR.BackgroundImage = Global.Software_Login.My.Resources.Resources.Mostrar
        Me.MOSTRAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MOSTRAR.Cursor = System.Windows.Forms.Cursors.Help
        Me.MOSTRAR.Image = Global.Software_Login.My.Resources.Resources.Mostrar
        Me.MOSTRAR.Location = New System.Drawing.Point(668, 145)
        Me.MOSTRAR.Name = "MOSTRAR"
        Me.MOSTRAR.Size = New System.Drawing.Size(34, 22)
        Me.MOSTRAR.TabIndex = 58
        Me.MOSTRAR.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(361, 145)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 57
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(361, 84)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 56
        Me.PictureBox4.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabel1.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Lime
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Aquamarine
        Me.LinkLabel1.Location = New System.Drawing.Point(154, 660)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(161, 15)
        Me.LinkLabel1.TabIndex = 55
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Has olvidado tu contraseña?"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Location = New System.Drawing.Point(42, 642)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(360, 2)
        Me.Panel2.TabIndex = 54
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Silver
        Me.btnLogin.Location = New System.Drawing.Point(358, 236)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(351, 39)
        Me.btnLogin.TabIndex = 53
        Me.btnLogin.Text = "INGRESAR"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox2.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.CheckBox2.Location = New System.Drawing.Point(371, 184)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(113, 21)
        Me.CheckBox2.TabIndex = 52
        Me.CheckBox2.Text = "Remember me"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(389, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 21)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "CONTRASEÑA"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsuario.Location = New System.Drawing.Point(391, 84)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(311, 22)
        Me.txtUsuario.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(389, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "USUARIO"
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtContraseña.Location = New System.Drawing.Point(391, 146)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(311, 22)
        Me.txtContraseña.TabIndex = 51
        '
        'Btn_Minimizar
        '
        Me.Btn_Minimizar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Minimizar.Image = Global.Software_Login.My.Resources.Resources.Minimiza
        Me.Btn_Minimizar.Location = New System.Drawing.Point(661, 12)
        Me.Btn_Minimizar.Name = "Btn_Minimizar"
        Me.Btn_Minimizar.Size = New System.Drawing.Size(43, 37)
        Me.Btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_Minimizar.TabIndex = 60
        Me.Btn_Minimizar.TabStop = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Cerrar.Image = Global.Software_Login.My.Resources.Resources.Cerrar
        Me.Btn_Cerrar.Location = New System.Drawing.Point(710, 12)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(43, 37)
        Me.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Btn_Cerrar.TabIndex = 59
        Me.Btn_Cerrar.TabStop = False
        '
        'OCULTAR
        '
        Me.OCULTAR.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OCULTAR.BackgroundImage = Global.Software_Login.My.Resources.Resources.Oculta
        Me.OCULTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OCULTAR.Cursor = System.Windows.Forms.Cursors.Help
        Me.OCULTAR.Image = Global.Software_Login.My.Resources.Resources.Oculta
        Me.OCULTAR.Location = New System.Drawing.Point(668, 145)
        Me.OCULTAR.Name = "OCULTAR"
        Me.OCULTAR.Size = New System.Drawing.Size(34, 22)
        Me.OCULTAR.TabIndex = 62
        Me.OCULTAR.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Software_Login.My.Resources.Resources.Fondo
        Me.PictureBox1.Location = New System.Drawing.Point(33, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 206)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Software_Login.My.Resources.Resources.logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(765, 302)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Minimizar)
        Me.Controls.Add(Me.MOSTRAR)
        Me.Controls.Add(Me.OCULTAR)
        Me.Controls.Add(Me.Btn_Cerrar)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContraseña)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.MOSTRAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OCULTAR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MOSTRAR As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Btn_Minimizar As PictureBox
    Friend WithEvents Btn_Cerrar As PictureBox
    Friend WithEvents OCULTAR As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
