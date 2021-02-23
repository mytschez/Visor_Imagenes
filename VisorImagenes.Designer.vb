<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVisorImagenes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.FBDCarpetaFotos = New System.Windows.Forms.FolderBrowserDialog()
        Me.TimerFotos = New System.Windows.Forms.Timer(Me.components)
        Me.Panelbtns = New System.Windows.Forms.Panel()
        Me.btnLupa = New System.Windows.Forms.Button()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelbtns.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicBox
        '
        Me.PicBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.PicBox.Location = New System.Drawing.Point(0, 0)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(1209, 579)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 0
        Me.PicBox.TabStop = False
        '
        'btnAnterior
        '
        Me.btnAnterior.Enabled = False
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Webdings", 26.0!, System.Drawing.FontStyle.Bold)
        Me.btnAnterior.Location = New System.Drawing.Point(0, 1)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(90, 90)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "7"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Enabled = False
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Webdings", 26.0!, System.Drawing.FontStyle.Bold)
        Me.btnPlay.Location = New System.Drawing.Point(106, 1)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(90, 90)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "4"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Enabled = False
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Webdings", 26.0!, System.Drawing.FontStyle.Bold)
        Me.btnSiguiente.Location = New System.Drawing.Point(212, 1)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(90, 90)
        Me.btnSiguiente.TabIndex = 3
        Me.btnSiguiente.Text = "8"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Webdings", 26.0!, System.Drawing.FontStyle.Bold)
        Me.btnCerrar.Location = New System.Drawing.Point(1107, 587)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(90, 90)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "r"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FBDCarpetaFotos
        '
        Me.FBDCarpetaFotos.ShowNewFolderButton = False
        '
        'TimerFotos
        '
        Me.TimerFotos.Interval = 3000
        '
        'Panelbtns
        '
        Me.Panelbtns.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panelbtns.Controls.Add(Me.btnPlay)
        Me.Panelbtns.Controls.Add(Me.btnSiguiente)
        Me.Panelbtns.Controls.Add(Me.btnAnterior)
        Me.Panelbtns.Location = New System.Drawing.Point(433, 586)
        Me.Panelbtns.Name = "Panelbtns"
        Me.Panelbtns.Size = New System.Drawing.Size(303, 91)
        Me.Panelbtns.TabIndex = 1
        '
        'btnLupa
        '
        Me.btnLupa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLupa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnLupa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLupa.Font = New System.Drawing.Font("Webdings", 26.0!, System.Drawing.FontStyle.Bold)
        Me.btnLupa.Location = New System.Drawing.Point(12, 586)
        Me.btnLupa.Name = "btnLupa"
        Me.btnLupa.Size = New System.Drawing.Size(90, 90)
        Me.btnLupa.TabIndex = 0
        Me.btnLupa.Text = "L"
        Me.btnLupa.UseVisualStyleBackColor = True
        '
        'frmVisorImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1209, 695)
        Me.Controls.Add(Me.btnLupa)
        Me.Controls.Add(Me.Panelbtns)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.PicBox)
        Me.MinimumSize = New System.Drawing.Size(650, 450)
        Me.Name = "frmVisorImagenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visor de imágenes"
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelbtns.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicBox As PictureBox
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents FBDCarpetaFotos As FolderBrowserDialog
    Friend WithEvents TimerFotos As Timer
    Friend WithEvents Panelbtns As Panel
    Friend WithEvents btnLupa As Button
End Class
