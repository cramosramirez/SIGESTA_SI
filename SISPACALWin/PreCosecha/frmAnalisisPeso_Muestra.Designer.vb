﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnalisisPeso_Muestra
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
        Me.components = New System.ComponentModel.Container()
        Me.lstLecturas = New System.Windows.Forms.ListBox()
        Me.gbAnalisisLab = New System.Windows.Forms.GroupBox()
        Me.lblFECHA_APLICA_MADURANTE = New System.Windows.Forms.Label()
        Me.lblMADURANTE = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPH = New System.Windows.Forms.TextBox()
        Me.etPH = New System.Windows.Forms.Label()
        Me.lblPOL_Lectura = New System.Windows.Forms.Label()
        Me.lblVARIEDAD = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.etBrix = New System.Windows.Forms.Label()
        Me.etPolAjustado = New System.Windows.Forms.Label()
        Me.lblBRIX = New System.Windows.Forms.Label()
        Me.lblPOL = New System.Windows.Forms.Label()
        Me.lblBAGAZO_NETO = New System.Windows.Forms.Label()
        Me.lblBAGAZO_BRUTO = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cbxTipoLectura = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbLecturas = New System.Windows.Forms.GroupBox()
        Me.btnCapturar = New System.Windows.Forms.Button()
        Me.btnLeerPuerto = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtTACO = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.lblTonsRecibidas = New System.Windows.Forms.Label()
        Me.gbAnalisisLab.SuspendLayout()
        Me.gbLecturas.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstLecturas
        '
        Me.lstLecturas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLecturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLecturas.ForeColor = System.Drawing.Color.DarkBlue
        Me.lstLecturas.FormattingEnabled = True
        Me.lstLecturas.ItemHeight = 25
        Me.lstLecturas.Location = New System.Drawing.Point(13, 34)
        Me.lstLecturas.Name = "lstLecturas"
        Me.lstLecturas.Size = New System.Drawing.Size(770, 104)
        Me.lstLecturas.TabIndex = 1
        '
        'gbAnalisisLab
        '
        Me.gbAnalisisLab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbAnalisisLab.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbAnalisisLab.Controls.Add(Me.lblFECHA_APLICA_MADURANTE)
        Me.gbAnalisisLab.Controls.Add(Me.lblMADURANTE)
        Me.gbAnalisisLab.Controls.Add(Me.Label6)
        Me.gbAnalisisLab.Controls.Add(Me.Label5)
        Me.gbAnalisisLab.Controls.Add(Me.txtPH)
        Me.gbAnalisisLab.Controls.Add(Me.etPH)
        Me.gbAnalisisLab.Controls.Add(Me.lblPOL_Lectura)
        Me.gbAnalisisLab.Controls.Add(Me.lblVARIEDAD)
        Me.gbAnalisisLab.Controls.Add(Me.Label4)
        Me.gbAnalisisLab.Controls.Add(Me.Label1)
        Me.gbAnalisisLab.Controls.Add(Me.etBrix)
        Me.gbAnalisisLab.Controls.Add(Me.etPolAjustado)
        Me.gbAnalisisLab.Controls.Add(Me.lblBRIX)
        Me.gbAnalisisLab.Controls.Add(Me.lblPOL)
        Me.gbAnalisisLab.Controls.Add(Me.lblBAGAZO_NETO)
        Me.gbAnalisisLab.Controls.Add(Me.lblBAGAZO_BRUTO)
        Me.gbAnalisisLab.Controls.Add(Me.Label25)
        Me.gbAnalisisLab.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAnalisisLab.Location = New System.Drawing.Point(12, 263)
        Me.gbAnalisisLab.Name = "gbAnalisisLab"
        Me.gbAnalisisLab.Size = New System.Drawing.Size(1018, 359)
        Me.gbAnalisisLab.TabIndex = 5
        Me.gbAnalisisLab.TabStop = False
        Me.gbAnalisisLab.Text = "Laboratorio"
        '
        'lblFECHA_APLICA_MADURANTE
        '
        Me.lblFECHA_APLICA_MADURANTE.AutoSize = True
        Me.lblFECHA_APLICA_MADURANTE.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFECHA_APLICA_MADURANTE.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFECHA_APLICA_MADURANTE.Location = New System.Drawing.Point(192, 95)
        Me.lblFECHA_APLICA_MADURANTE.Name = "lblFECHA_APLICA_MADURANTE"
        Me.lblFECHA_APLICA_MADURANTE.Size = New System.Drawing.Size(0, 18)
        Me.lblFECHA_APLICA_MADURANTE.TabIndex = 108
        '
        'lblMADURANTE
        '
        Me.lblMADURANTE.AutoSize = True
        Me.lblMADURANTE.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMADURANTE.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblMADURANTE.Location = New System.Drawing.Point(192, 64)
        Me.lblMADURANTE.Name = "lblMADURANTE"
        Me.lblMADURANTE.Size = New System.Drawing.Size(0, 18)
        Me.lblMADURANTE.TabIndex = 107
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 18)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Fecha aplicación:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Madurante:"
        '
        'txtPH
        '
        Me.txtPH.BackColor = System.Drawing.Color.White
        Me.txtPH.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPH.ForeColor = System.Drawing.Color.Navy
        Me.txtPH.Location = New System.Drawing.Point(570, 177)
        Me.txtPH.Name = "txtPH"
        Me.txtPH.Size = New System.Drawing.Size(172, 26)
        Me.txtPH.TabIndex = 101
        Me.txtPH.Tag = "LecturaAparatos"
        Me.txtPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'etPH
        '
        Me.etPH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etPH.AutoSize = True
        Me.etPH.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPH.Location = New System.Drawing.Point(523, 182)
        Me.etPH.Name = "etPH"
        Me.etPH.Size = New System.Drawing.Size(29, 18)
        Me.etPH.TabIndex = 102
        Me.etPH.Text = "PH"
        Me.etPH.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPOL_Lectura
        '
        Me.lblPOL_Lectura.BackColor = System.Drawing.Color.White
        Me.lblPOL_Lectura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPOL_Lectura.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOL_Lectura.ForeColor = System.Drawing.Color.Navy
        Me.lblPOL_Lectura.Location = New System.Drawing.Point(760, 132)
        Me.lblPOL_Lectura.Name = "lblPOL_Lectura"
        Me.lblPOL_Lectura.Size = New System.Drawing.Size(231, 39)
        Me.lblPOL_Lectura.TabIndex = 53
        Me.lblPOL_Lectura.Tag = "LecturaAparatos"
        Me.lblPOL_Lectura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblPOL_Lectura.Visible = False
        '
        'lblVARIEDAD
        '
        Me.lblVARIEDAD.AutoSize = True
        Me.lblVARIEDAD.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVARIEDAD.ForeColor = System.Drawing.Color.Navy
        Me.lblVARIEDAD.Location = New System.Drawing.Point(198, 33)
        Me.lblVARIEDAD.Name = "lblVARIEDAD"
        Me.lblVARIEDAD.Size = New System.Drawing.Size(0, 18)
        Me.lblVARIEDAD.TabIndex = 52
        Me.lblVARIEDAD.Tag = "Dato"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(448, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "PESO TORTA"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(437, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PESO BAGAZO"
        '
        'etBrix
        '
        Me.etBrix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etBrix.AutoSize = True
        Me.etBrix.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etBrix.Location = New System.Drawing.Point(506, 146)
        Me.etBrix.Name = "etBrix"
        Me.etBrix.Size = New System.Drawing.Size(46, 18)
        Me.etBrix.TabIndex = 7
        Me.etBrix.Text = "BRIX"
        Me.etBrix.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'etPolAjustado
        '
        Me.etPolAjustado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.etPolAjustado.AutoSize = True
        Me.etPolAjustado.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etPolAjustado.Location = New System.Drawing.Point(428, 110)
        Me.etPolAjustado.Name = "etPolAjustado"
        Me.etPolAjustado.Size = New System.Drawing.Size(124, 18)
        Me.etPolAjustado.TabIndex = 5
        Me.etPolAjustado.Text = "POL AJUSTADO"
        Me.etPolAjustado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBRIX
        '
        Me.lblBRIX.BackColor = System.Drawing.Color.White
        Me.lblBRIX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBRIX.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBRIX.ForeColor = System.Drawing.Color.Navy
        Me.lblBRIX.Location = New System.Drawing.Point(570, 141)
        Me.lblBRIX.Name = "lblBRIX"
        Me.lblBRIX.Size = New System.Drawing.Size(172, 29)
        Me.lblBRIX.TabIndex = 3
        Me.lblBRIX.Tag = "LecturaAparatos"
        Me.lblBRIX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPOL
        '
        Me.lblPOL.BackColor = System.Drawing.Color.White
        Me.lblPOL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPOL.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOL.ForeColor = System.Drawing.Color.Navy
        Me.lblPOL.Location = New System.Drawing.Point(570, 105)
        Me.lblPOL.Name = "lblPOL"
        Me.lblPOL.Size = New System.Drawing.Size(172, 29)
        Me.lblPOL.TabIndex = 2
        Me.lblPOL.Tag = "LecturaAparatos"
        Me.lblPOL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBAGAZO_NETO
        '
        Me.lblBAGAZO_NETO.BackColor = System.Drawing.Color.White
        Me.lblBAGAZO_NETO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBAGAZO_NETO.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBAGAZO_NETO.ForeColor = System.Drawing.Color.Navy
        Me.lblBAGAZO_NETO.Location = New System.Drawing.Point(570, 69)
        Me.lblBAGAZO_NETO.Name = "lblBAGAZO_NETO"
        Me.lblBAGAZO_NETO.Size = New System.Drawing.Size(172, 29)
        Me.lblBAGAZO_NETO.TabIndex = 1
        Me.lblBAGAZO_NETO.Tag = "LecturaAparatos"
        Me.lblBAGAZO_NETO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBAGAZO_BRUTO
        '
        Me.lblBAGAZO_BRUTO.BackColor = System.Drawing.Color.White
        Me.lblBAGAZO_BRUTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBAGAZO_BRUTO.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBAGAZO_BRUTO.ForeColor = System.Drawing.Color.Navy
        Me.lblBAGAZO_BRUTO.Location = New System.Drawing.Point(570, 33)
        Me.lblBAGAZO_BRUTO.Name = "lblBAGAZO_BRUTO"
        Me.lblBAGAZO_BRUTO.Size = New System.Drawing.Size(172, 29)
        Me.lblBAGAZO_BRUTO.TabIndex = 0
        Me.lblBAGAZO_BRUTO.Tag = "LecturaAparatos"
        Me.lblBAGAZO_BRUTO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(24, 33)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 18)
        Me.Label25.TabIndex = 21
        Me.Label25.Text = "Variedad"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.SISPACAL.My.Resources.Resources.RP_Save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(803, 113)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(182, 32)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'cbxTipoLectura
        '
        Me.cbxTipoLectura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoLectura.Enabled = False
        Me.cbxTipoLectura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cbxTipoLectura.FormattingEnabled = True
        Me.cbxTipoLectura.Location = New System.Drawing.Point(525, 47)
        Me.cbxTipoLectura.Name = "cbxTipoLectura"
        Me.cbxTipoLectura.Size = New System.Drawing.Size(235, 32)
        Me.cbxTipoLectura.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(396, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo de Lectura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N°  ORDEN:"
        '
        'gbLecturas
        '
        Me.gbLecturas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbLecturas.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbLecturas.Controls.Add(Me.btnCapturar)
        Me.gbLecturas.Controls.Add(Me.btnLeerPuerto)
        Me.gbLecturas.Controls.Add(Me.btnGuardar)
        Me.gbLecturas.Controls.Add(Me.lstLecturas)
        Me.gbLecturas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.gbLecturas.Location = New System.Drawing.Point(12, 96)
        Me.gbLecturas.Name = "gbLecturas"
        Me.gbLecturas.Size = New System.Drawing.Size(1018, 157)
        Me.gbLecturas.TabIndex = 4
        Me.gbLecturas.TabStop = False
        Me.gbLecturas.Text = "Lectura:"
        '
        'btnCapturar
        '
        Me.btnCapturar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCapturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCapturar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapturar.Image = Global.SISPACAL.My.Resources.Resources.Target
        Me.btnCapturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCapturar.Location = New System.Drawing.Point(803, 74)
        Me.btnCapturar.Name = "btnCapturar"
        Me.btnCapturar.Size = New System.Drawing.Size(182, 33)
        Me.btnCapturar.TabIndex = 2
        Me.btnCapturar.Text = "Capturar"
        Me.btnCapturar.UseVisualStyleBackColor = False
        '
        'btnLeerPuerto
        '
        Me.btnLeerPuerto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLeerPuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLeerPuerto.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeerPuerto.Image = Global.SISPACAL.My.Resources.Resources.ico_SerialInput
        Me.btnLeerPuerto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLeerPuerto.Location = New System.Drawing.Point(803, 34)
        Me.btnLeerPuerto.Name = "btnLeerPuerto"
        Me.btnLeerPuerto.Size = New System.Drawing.Size(182, 34)
        Me.btnLeerPuerto.TabIndex = 0
        Me.btnLeerPuerto.Text = "Leer puerto"
        Me.btnLeerPuerto.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'txtTACO
        '
        Me.txtTACO.BackColor = System.Drawing.Color.White
        Me.txtTACO.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTACO.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtTACO.Location = New System.Drawing.Point(123, 47)
        Me.txtTACO.MaxLength = 7
        Me.txtTACO.Name = "txtTACO"
        Me.txtTACO.Size = New System.Drawing.Size(163, 38)
        Me.txtTACO.TabIndex = 0
        Me.txtTACO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Black
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1020, 35)
        Me.lblTitulo.TabIndex = 56
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.SISPACAL.My.Resources.Resources.Logout
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(815, 43)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(182, 34)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Image = Global.SISPACAL.My.Resources.Resources.new_file_btn
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(286, 47)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(97, 38)
        Me.btnNuevo.TabIndex = 1
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'lblTonsRecibidas
        '
        Me.lblTonsRecibidas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTonsRecibidas.BackColor = System.Drawing.Color.Black
        Me.lblTonsRecibidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTonsRecibidas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTonsRecibidas.ForeColor = System.Drawing.Color.Lime
        Me.lblTonsRecibidas.Location = New System.Drawing.Point(726, 1)
        Me.lblTonsRecibidas.Name = "lblTonsRecibidas"
        Me.lblTonsRecibidas.Size = New System.Drawing.Size(310, 33)
        Me.lblTonsRecibidas.TabIndex = 57
        Me.lblTonsRecibidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTonsRecibidas.Visible = False
        '
        'frmAnalisisPeso_Muestra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1020, 636)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTonsRecibidas)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.txtTACO)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.gbLecturas)
        Me.Controls.Add(Me.cbxTipoLectura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbAnalisisLab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAnalisisPeso_Muestra"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Peso de muestra"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbAnalisisLab.ResumeLayout(False)
        Me.gbAnalisisLab.PerformLayout()
        Me.gbLecturas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstLecturas As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxTipoLectura As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbAnalisisLab As System.Windows.Forms.GroupBox
    Friend WithEvents etBrix As System.Windows.Forms.Label
    Friend WithEvents etPolAjustado As System.Windows.Forms.Label
    Friend WithEvents gbLecturas As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnLeerPuerto As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnCapturar As System.Windows.Forms.Button
    Friend WithEvents txtTACO As System.Windows.Forms.TextBox
    Friend WithEvents lblVARIEDAD As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblBAGAZO_BRUTO As System.Windows.Forms.Label
    Friend WithEvents lblBRIX As System.Windows.Forms.Label
    Friend WithEvents lblPOL As System.Windows.Forms.Label
    Friend WithEvents lblBAGAZO_NETO As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblPOL_Lectura As System.Windows.Forms.Label
    Friend WithEvents txtPH As System.Windows.Forms.TextBox
    Friend WithEvents etPH As System.Windows.Forms.Label
    Friend WithEvents lblTonsRecibidas As System.Windows.Forms.Label
    Friend WithEvents lblFECHA_APLICA_MADURANTE As System.Windows.Forms.Label
    Friend WithEvents lblMADURANTE As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
