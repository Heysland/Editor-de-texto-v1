Imports System.IO
Imports System.Drawing

Public Class frmBlocNotas

    Private rutaActual As String = String.Empty
    Private documentoModificado As Boolean = False

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuPrincipal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuPrincipal.ItemClicked

    End Sub

    Private Sub frmBlocNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rtbDocumento.Font = New Font("Consolas", 11)
        rtbDocumento.WordWrap = True
        mnuAjusteLinea.Checked = True


        tscbFuente.Items.AddRange(New String() {"Segoe UI", "Consolas", "Arial", "Times New Roman"})
        tscbFuente.SelectedIndex = 1
        tscbTamano.Items.AddRange(New String() {"8", "10", "11", "12", "14", "18", "24"})
        tscbTamano.SelectedIndex = 2

        ActualizarBarraEstado()
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
    End Sub

    Private Sub rtbDocumento_TextChanged(sender As Object, e As EventArgs) Handles rtbDocumento.TextChanged
        documentoModificado = True
        ActualizarBarraEstado()
    End Sub

    Private Sub rtbDocumento_SelectionChanged(sender As Object, e As EventArgs) Handles rtbDocumento.SelectionChanged
        ActualizarBarraEstado()
    End Sub

    Private Sub mnuNuevo_Click(sender As Object, e As EventArgs) Handles mnuNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub mnuAbrir_Click(sender As Object, e As EventArgs) Handles mnuAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub mnuGuardar_Click(sender As Object, e As EventArgs) Handles mnuGuardar.Click
        GuardarDocumento(False)
    End Sub

    Private Sub mnuGuardarComo_Click(sender As Object, e As EventArgs) Handles mnuGuardarComo.Click
        GuardarDocumento(True)
    End Sub

    Private Sub mnuSalir_Click(sender As Object, e As EventArgs) Handles mnuSalir.Click
        Me.Close()
    End Sub

    Private Sub mnuCortar_Click(sender As Object, e As EventArgs) Handles mnuCortar.Click
        rtbDocumento.Cut()
    End Sub

    Private Sub mnuCopiar_Click(sender As Object, e As EventArgs) Handles mnuCopiar.Click
        rtbDocumento.Copy()
    End Sub

    Private Sub mnuPegar_Click(sender As Object, e As EventArgs) Handles mnuPegar.Click
        rtbDocumento.Paste()
    End Sub


    Private Sub mnuFuente_Click(sender As Object, e As EventArgs) Handles mnuFuente.Click
        dlgFuente.Font = rtbDocumento.SelectionFont
        If dlgFuente.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionFont = dlgFuente.Font
        End If

    End Sub


    Private Sub mnuAjusteLinea_Click(sender As Object, e As EventArgs)
        rtbDocumento.WordWrap = mnuAjusteLinea.Checked
    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        NuevoDocumento()
    End Sub

    Private Sub tsbAbrir_Click(sender As Object, e As EventArgs) Handles tsbAbrir.Click
        AbrirDocumento()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        GuardarDocumento(False)
    End Sub

    Private Sub tsbNegrita_Click(sender As Object, e As EventArgs) Handles tsbNegrita.Click
        AplicarEstiloFuente(FontStyle.Bold)
    End Sub

    Private Sub tsbCursiva_Click(sender As Object, e As EventArgs) Handles tsbCursiva.Click
        AplicarEstiloFuente(FontStyle.Italic)
    End Sub

    Private Sub tsbSubrayado_Click(sender As Object, e As EventArgs) Handles tsbSubrayado.Click
        AplicarEstiloFuente(FontStyle.Underline)
    End Sub

    Private Sub tscbFuente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbFuente.SelectedIndexChanged
        If rtbDocumento Is Nothing OrElse String.IsNullOrEmpty(tscbFuente.Text) Then Exit Sub
        Dim fuenteBase As Font = If(rtbDocumento.SelectionFont, rtbDocumento.Font)
        If fuenteBase Is Nothing Then Exit Sub
        rtbDocumento.SelectionFont = New Font(tscbFuente.Text, fuenteBase.Size, fuenteBase.Style)
    End Sub

    Private Sub tscbTamano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tscbTamano.SelectedIndexChanged
        If rtbDocumento Is Nothing OrElse String.IsNullOrEmpty(tscbTamano.Text) Then Exit Sub
        Dim tam As Single
        If Single.TryParse(tscbTamano.Text, tam) Then
            Dim fuenteBase As Font = If(rtbDocumento.SelectionFont, rtbDocumento.Font)
            If fuenteBase Is Nothing Then Exit Sub
            rtbDocumento.SelectionFont = New Font(fuenteBase.FontFamily, tam, fuenteBase.Style)
        End If
    End Sub


    Private Sub AplicarEstiloFuente(estilo As FontStyle)
        Dim fuenteActual As Font = rtbDocumento.SelectionFont
        If fuenteActual Is Nothing Then Exit Sub
        Dim nuevoEstilo As FontStyle
        If fuenteActual.Style.HasFlag(estilo) Then
            nuevoEstilo = fuenteActual.Style And Not estilo
        Else
            nuevoEstilo = fuenteActual.Style Or estilo
        End If
        rtbDocumento.SelectionFont = New Font(fuenteActual, nuevoEstilo)
    End Sub

    Private Sub tmrReloj_Tick(sender As Object, e As EventArgs) Handles tmrReloj.Tick
        stsFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss")
    End Sub

    Private Sub ActualizarBarraEstado()
        Dim linea As Integer = rtbDocumento.GetLineFromCharIndex(rtbDocumento.SelectionStart) + 1
        Dim inicioLinea As Integer = rtbDocumento.GetFirstCharIndexOfCurrentLine()
        Dim columna As Integer = rtbDocumento.SelectionStart - inicioLinea + 1

        stsPosicion.Text = $"Línea: {linea}   Columna: {columna}"
        stsCaracteres.Text = $"Caracteres: {rtbDocumento.TextLength}"
        stsEstado.Text = If(documentoModificado, "Modificado", "Listo")
    End Sub

    Private Sub NuevoDocumento()
        If documentoModificado Then
            Dim r = MessageBox.Show("¿Desea guardar los cambios antes de continuar?",
                                     "Bloc de Notas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If r = DialogResult.Cancel Then Exit Sub
            If r = DialogResult.Yes Then GuardarDocumento(False)
        End If
        rtbDocumento.Clear()
        rutaActual = String.Empty
        documentoModificado = False
        Me.Text = "Bloc de Notas VB.NET - [Nuevo documento]"
        ActualizarBarraEstado()
    End Sub

    Private Sub AbrirDocumento()
        If dlgAbrir.ShowDialog() = DialogResult.OK Then
            rtbDocumento.LoadFile(dlgAbrir.FileName, RichTextBoxStreamType.PlainText)
            rutaActual = dlgAbrir.FileName
            documentoModificado = False
            Me.Text = $"Bloc de Notas VB.NET - [{Path.GetFileName(rutaActual)}]"
            ActualizarBarraEstado()
        End If
    End Sub

    Private Sub GuardarDocumento(forzarDialogo As Boolean)
        If String.IsNullOrEmpty(rutaActual) OrElse forzarDialogo Then
            If dlgGuardar.ShowDialog() = DialogResult.OK Then
                rutaActual = dlgGuardar.FileName
            Else
                Exit Sub
            End If
        End If
        rtbDocumento.SaveFile(rutaActual, RichTextBoxStreamType.PlainText)
        documentoModificado = False
        Me.Text = $"Bloc de Notas VB.NET - [{Path.GetFileName(rutaActual)}]"
        stsEstado.Text = "Guardado correctamente"
    End Sub

    Private Sub mnuEdicion_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ArchivoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.Click

    End Sub

    Private Sub mnuSalir_Click_1(sender As Object, e As EventArgs) Handles mnuSalir.Click

    End Sub

    Private Sub mnuGuardarComo_Click_1(sender As Object, e As EventArgs) Handles mnuGuardarComo.Click

    End Sub

    Private Sub mnuDeshacer_Click(sender As Object, e As EventArgs) Handles mnuDeshacer.Click
        If rtbDocumento.CanUndo Then rtbDocumento.Undo()
    End Sub

    Private Sub mnuRehacer_Click(sender As Object, e As EventArgs) Handles mnuRehacer.Click
        If rtbDocumento.CanRedo Then rtbDocumento.Redo()
    End Sub

    Private Sub mnuSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles mnuSeleccionarTodo.Click
        rtbDocumento.SelectAll()
    End Sub

    Private Sub mnuBuscar_Click(sender As Object, e As EventArgs) Handles mnuBuscar.Click
        Dim textoBuscar As String = InputBox("Ingrese el texto que desea buscar:", "Buscar")
        If Not String.IsNullOrEmpty(textoBuscar) Then
            Dim inicio As Integer = rtbDocumento.Find(textoBuscar)
            If inicio <> -1 Then
                rtbDocumento.Select(inicio, textoBuscar.Length)
                rtbDocumento.Focus()
            Else
                MessageBox.Show("No se encontró el texto especificado.", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub mnuColorTexto_Click(sender As Object, e As EventArgs) Handles mnuColorTexto.Click
        If dlgColor.ShowDialog() = DialogResult.OK Then
            rtbDocumento.SelectionColor = dlgColor.Color
        End If
    End Sub

    Private Sub mnuAcercaDe_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        MessageBox.Show("Bloc de Notas" & vbCrLf & "UNI 2026 - Ingenieros de Sistemas" & vbCrLf & "Futuros campeones de Tenis De Mesa",
                     "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuContarPalabras_Click(sender As Object, e As EventArgs) Handles mnuContarPalabras.Click
        Dim texto As String = rtbDocumento.Text.Trim()
        Dim palabras As Integer = 0

        If Not String.IsNullOrEmpty(texto) Then
            Dim listaPalabras As String() = texto.Split(New Char() {" "c, ControlChars.Lf, ControlChars.Cr, ControlChars.Tab}, StringSplitOptions.RemoveEmptyEntries)
            palabras = listaPalabras.Length
        End If

        MessageBox.Show($"El texto tiene {palabras} palabra(s).", "Contar Palabras", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub mnuContarCaracteres_Click(sender As Object, e As EventArgs) Handles mnuContarCaracteres.Click
        Dim totalConEspacios As Integer = rtbDocumento.Text.Length
        Dim totalSinEspacios As Integer = rtbDocumento.Text.Replace(" ", "").Replace(vbCr, "").Replace(vbLf, "").Length

        Dim mensaje As String = $"Total de caracteres con espacios: {totalConEspacios}" & vbCrLf &
                               $"Total de caracteres sin espacios: {totalSinEspacios}"

        MessageBox.Show(mensaje, "Contar Caracteres", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function ConfirmarGuardarCambios() As Boolean
        If documentoModificado Then
            Dim resultado As DialogResult = MessageBox.Show(
            "¿Desea guardar los cambios en el documento actual?",
            "Guardar cambios",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question
        )

            If resultado = DialogResult.Yes Then
                GuardarDocumento(False)
                Return Not documentoModificado
            ElseIf resultado = DialogResult.No Then
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not ConfirmarGuardarCambios() Then
            e.Cancel = True
        End If
    End Sub

End Class