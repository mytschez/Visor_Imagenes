Imports System.IO

Public Class frmVisorImagenes
    'variables
    Dim listaFotos() As String 'vector para guardar cada una de las fotos de la carpeta
    Dim carpeta As String 'para cargar la ruta de la carpeta
    Dim longvector As Integer 'para recoger el tamaño del array puesto que es dinámico
    Dim i As Integer
    Dim play As Boolean = False
    Dim foto As Integer

    'BUSCAR
    Private Sub btnLupa_Click(sender As Object, e As EventArgs) Handles btnLupa.Click
        CargarFotos()
    End Sub

    'CERRAR
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    'SIGUIENTE
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        play = False
        TimerFotos.Stop()
        AntSigFoto("siguiente")
    End Sub
    'ANTERIOR
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        play = False
        TimerFotos.Stop()
        AntSigFoto("anterior")
    End Sub
    'TIMER
    Private Sub TimerFotos_Tick(sender As Object, e As EventArgs) Handles TimerFotos.Tick
        AntSigFoto("siguiente")
    End Sub
    'PLAY
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        play = Not play
        If play Then
            TimerFotos.Start()
            btnPlay.Text = ";"
        Else
            TimerFotos.Stop()
            btnPlay.Text = "4"
        End If
    End Sub
    'REAJUSTAR LOS BOTONES
    Private Sub frmVisorImagenes_ResizeEnd(sender As Object, e As EventArgs) Handles MyBase.ResizeEnd
        resizeForm()
    End Sub
    'procedimiento para cargar las fotos
    Private Sub CargarFotos()
        Try
            If FBDCarpetaFotos.ShowDialog() = DialogResult.OK Then
                carpeta = FBDCarpetaFotos.SelectedPath ' guardamos la ruta
                longvector = Directory.GetFiles(carpeta, "*.jpg").Length 'longitud del vector

                'redimensionar el vector con el tamaño
                ReDim listaFotos(longvector - 1)

                'habilitar botones
                If longvector > 0 Then
                    btnAnterior.Enabled = True
                    btnPlay.Enabled = True
                    btnSiguiente.Enabled = True
                End If

                i = 0 'inicializamos el índice a cero

                'Directory.GetFiles(carpeta, "*jpg") coleccionable con la ruta de todas 
                'las fotos de la carpeta con formato .jpg
                For Each archivo In Directory.GetFiles(carpeta, "*jpg")
                    listaFotos(i) = archivo
                    i += 1
                Next
                i = 0
                PicBox.Load(listaFotos(i)) 'cargar las fotos en el pictureBox
            End If
        Catch ex As Exception
            MessageBox.Show("La carpeta seleccionada no contiene ninguna imagen JPG", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'procedimiento para pasar de foto hacia adelante o hacia atrás
    Private Sub AntSigFoto(pasar As String)

        If pasar = "siguiente" Then
            'si es la última foto vuelve a mostrar la primera
            If foto = longvector - 1 Then
                foto = 0
            Else
                foto += 1
            End If
        Else
            If pasar = "anterior" Then
                'si es la primera foto vuelve a mostrar la última
                If foto = 0 Then
                    foto = longvector - 1
                Else
                    foto -= 1
                End If
            End If
        End If
        PicBox.Load(listaFotos(foto))
    End Sub

    'procedimiento para reajustar los botones si se modifica el tamaño del formulario
    Private Sub resizeForm()
        'variables
        Dim posicion As Point
        Dim AnchoForm As Integer = Me.Width
        Dim AltoForm As Integer = Me.Height
        Dim AnchoPanel As Integer = Panelbtns.Width
        Dim AltoPanel As Integer = Panelbtns.Height
        Dim AnchobtnCerrar As Integer = btnCerrar.Width

        'reajuste de los botones anterior, play y siguiente
        posicion.X = (AnchoForm - AnchoPanel) / 2
        posicion.Y = AltoForm - (50 + AltoPanel)
        Panelbtns.Location = posicion

        'reajuste del botón buscar
        posicion.X = 12
        btnLupa.Location = posicion

        'reajuste del botón cerrar
        posicion.X = AnchoForm - (AnchobtnCerrar + 30)
        btnCerrar.Location = posicion

        'reajuste del picture box
        PicBox.Height = AltoForm - 120
        PicBox.Width = AnchoForm

    End Sub

End Class
