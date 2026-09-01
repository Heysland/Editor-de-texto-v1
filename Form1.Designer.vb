<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBlocNotas
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        mnuPrincipal = New MenuStrip()
        ArchivoToolStripMenuItem = New ToolStripMenuItem()
        mnuNuevo = New ToolStripMenuItem()
        mnuAbrir = New ToolStripMenuItem()
        mnuGuardar = New ToolStripMenuItem()
        mnuGuardarComo = New ToolStripMenuItem()
        mnuSalir = New ToolStripMenuItem()
        EdicionToolStripMenuItem = New ToolStripMenuItem()
        mnuDeshacer = New ToolStripMenuItem()
        mnuRehacer = New ToolStripMenuItem()
        mnuCortar = New ToolStripMenuItem()
        mnuCopiar = New ToolStripMenuItem()
        mnuPegar = New ToolStripMenuItem()
        mnuSeleccionarTodo = New ToolStripMenuItem()
        FormatoToolStripMenuItem = New ToolStripMenuItem()
        mnuFuente = New ToolStripMenuItem()
        mnuColorTexto = New ToolStripMenuItem()
        HerramientasToolStripMenuItem = New ToolStripMenuItem()
        mnuBuscar = New ToolStripMenuItem()
        mnuContarPalabras = New ToolStripMenuItem()
        mnuContarCaracteres = New ToolStripMenuItem()
        mnuAjusteLinea = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        tlsBarraHerramientas = New ToolStrip()
        tsbNuevo = New ToolStripButton()
        tsbAbrir = New ToolStripButton()
        tsbGuardar = New ToolStripButton()
        tsbNegrita = New ToolStripButton()
        tsbCursiva = New ToolStripButton()
        tsbSubrayado = New ToolStripButton()
        tscbFuente = New ToolStripComboBox()
        tscbTamano = New ToolStripComboBox()
        rtbDocumento = New RichTextBox()
        cmsTexto = New ContextMenuStrip(components)
        stsInferior = New StatusStrip()
        stsEstado = New ToolStripStatusLabel()
        stsPosicion = New ToolStripStatusLabel()
        stsCaracteres = New ToolStripStatusLabel()
        stsFechaHora = New ToolStripStatusLabel()
        dlgAbrir = New OpenFileDialog()
        dlgGuardar = New SaveFileDialog()
        dlgFuente = New FontDialog()
        dlgColor = New ColorDialog()
        tmrReloj = New Timer(components)
        mnuPrincipal.SuspendLayout()
        tlsBarraHerramientas.SuspendLayout()
        stsInferior.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(311, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(311, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 1
        ' 
        ' mnuPrincipal
        ' 
        mnuPrincipal.Items.AddRange(New ToolStripItem() {ArchivoToolStripMenuItem, EdicionToolStripMenuItem, FormatoToolStripMenuItem, HerramientasToolStripMenuItem, AyudaToolStripMenuItem})
        mnuPrincipal.Location = New Point(0, 0)
        mnuPrincipal.Name = "mnuPrincipal"
        mnuPrincipal.Size = New Size(800, 24)
        mnuPrincipal.TabIndex = 2
        mnuPrincipal.Text = "MenuStrip1"
        ' 
        ' ArchivoToolStripMenuItem
        ' 
        ArchivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuNuevo, mnuAbrir, mnuGuardar, mnuGuardarComo, mnuSalir})
        ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        ArchivoToolStripMenuItem.Size = New Size(63, 20)
        ArchivoToolStripMenuItem.Text = "Archivo "
        ' 
        ' mnuNuevo
        ' 
        mnuNuevo.Name = "mnuNuevo"
        mnuNuevo.ShortcutKeys = Keys.Control Or Keys.N
        mnuNuevo.Size = New Size(180, 22)
        mnuNuevo.Text = "&Nuevo"
        ' 
        ' mnuAbrir
        ' 
        mnuAbrir.Name = "mnuAbrir"
        mnuAbrir.ShortcutKeys = Keys.Control Or Keys.O
        mnuAbrir.Size = New Size(180, 22)
        mnuAbrir.Text = "&Abrir"
        ' 
        ' mnuGuardar
        ' 
        mnuGuardar.Name = "mnuGuardar"
        mnuGuardar.ShortcutKeys = Keys.Control Or Keys.S
        mnuGuardar.Size = New Size(180, 22)
        mnuGuardar.Text = "&Guardar"
        ' 
        ' mnuGuardarComo
        ' 
        mnuGuardarComo.Name = "mnuGuardarComo"
        mnuGuardarComo.Size = New Size(180, 22)
        mnuGuardarComo.Text = "Guardar &como..."
        ' 
        ' mnuSalir
        ' 
        mnuSalir.Name = "mnuSalir"
        mnuSalir.ShortcutKeys = Keys.Alt Or Keys.F4
        mnuSalir.Size = New Size(180, 22)
        mnuSalir.Text = "&Salir"
        ' 
        ' EdicionToolStripMenuItem
        ' 
        EdicionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuDeshacer, mnuRehacer, mnuCortar, mnuCopiar, mnuPegar, mnuSeleccionarTodo})
        EdicionToolStripMenuItem.Name = "EdicionToolStripMenuItem"
        EdicionToolStripMenuItem.Size = New Size(58, 20)
        EdicionToolStripMenuItem.Text = "Edicion"
        ' 
        ' mnuDeshacer
        ' 
        mnuDeshacer.Name = "mnuDeshacer"
        mnuDeshacer.ShortcutKeys = Keys.Control Or Keys.Z
        mnuDeshacer.Size = New Size(227, 22)
        mnuDeshacer.Text = "Deshacer "
        ' 
        ' mnuRehacer
        ' 
        mnuRehacer.Name = "mnuRehacer"
        mnuRehacer.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.Z
        mnuRehacer.Size = New Size(227, 22)
        mnuRehacer.Text = "Rehacer"
        ' 
        ' mnuCortar
        ' 
        mnuCortar.Name = "mnuCortar"
        mnuCortar.ShortcutKeys = Keys.Control Or Keys.X
        mnuCortar.Size = New Size(227, 22)
        mnuCortar.Text = "Cortar"
        ' 
        ' mnuCopiar
        ' 
        mnuCopiar.Name = "mnuCopiar"
        mnuCopiar.ShortcutKeys = Keys.Control Or Keys.C
        mnuCopiar.Size = New Size(227, 22)
        mnuCopiar.Text = "Copiar"
        ' 
        ' mnuPegar
        ' 
        mnuPegar.Name = "mnuPegar"
        mnuPegar.ShortcutKeys = Keys.Control Or Keys.V
        mnuPegar.Size = New Size(227, 22)
        mnuPegar.Text = "Pegar"
        ' 
        ' mnuSeleccionarTodo
        ' 
        mnuSeleccionarTodo.Name = "mnuSeleccionarTodo"
        mnuSeleccionarTodo.ShortcutKeys = Keys.Control Or Keys.E
        mnuSeleccionarTodo.Size = New Size(227, 22)
        mnuSeleccionarTodo.Text = "Seleccionar Todo "
        ' 
        ' FormatoToolStripMenuItem
        ' 
        FormatoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuFuente, mnuColorTexto})
        FormatoToolStripMenuItem.Name = "FormatoToolStripMenuItem"
        FormatoToolStripMenuItem.Size = New Size(64, 20)
        FormatoToolStripMenuItem.Text = "Formato"
        ' 
        ' mnuFuente
        ' 
        mnuFuente.Name = "mnuFuente"
        mnuFuente.Size = New Size(134, 22)
        mnuFuente.Text = "Fuente"
        ' 
        ' mnuColorTexto
        ' 
        mnuColorTexto.Name = "mnuColorTexto"
        mnuColorTexto.Size = New Size(134, 22)
        mnuColorTexto.Text = "Color Texto"
        ' 
        ' HerramientasToolStripMenuItem
        ' 
        HerramientasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuBuscar, mnuContarPalabras, mnuContarCaracteres, mnuAjusteLinea})
        HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        HerramientasToolStripMenuItem.Size = New Size(90, 20)
        HerramientasToolStripMenuItem.Text = "Herramientas"
        ' 
        ' mnuBuscar
        ' 
        mnuBuscar.Name = "mnuBuscar"
        mnuBuscar.ShortcutKeys = Keys.Control Or Keys.B
        mnuBuscar.Size = New Size(166, 22)
        mnuBuscar.Text = "Buscar"
        ' 
        ' mnuContarPalabras
        ' 
        mnuContarPalabras.Name = "mnuContarPalabras"
        mnuContarPalabras.Size = New Size(166, 22)
        mnuContarPalabras.Text = "Contar Palabras"
        ' 
        ' mnuContarCaracteres
        ' 
        mnuContarCaracteres.Name = "mnuContarCaracteres"
        mnuContarCaracteres.Size = New Size(166, 22)
        mnuContarCaracteres.Text = "Contar caracteres"
        ' 
        ' mnuAjusteLinea
        ' 
        mnuAjusteLinea.CheckOnClick = True
        mnuAjusteLinea.Name = "mnuAjusteLinea"
        mnuAjusteLinea.Size = New Size(166, 22)
        mnuAjusteLinea.Text = "Ajuste Linea"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AcercaDeToolStripMenuItem})
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(53, 20)
        AyudaToolStripMenuItem.Text = "Ayuda"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(126, 22)
        AcercaDeToolStripMenuItem.Text = "Acerca de"
        ' 
        ' tlsBarraHerramientas
        ' 
        tlsBarraHerramientas.GripStyle = ToolStripGripStyle.Hidden
        tlsBarraHerramientas.Items.AddRange(New ToolStripItem() {tsbNuevo, tsbAbrir, tsbGuardar, tsbNegrita, tsbCursiva, tsbSubrayado, tscbFuente, tscbTamano})
        tlsBarraHerramientas.LayoutStyle = ToolStripLayoutStyle.Flow
        tlsBarraHerramientas.Location = New Point(0, 24)
        tlsBarraHerramientas.Name = "tlsBarraHerramientas"
        tlsBarraHerramientas.Size = New Size(800, 23)
        tlsBarraHerramientas.TabIndex = 3
        tlsBarraHerramientas.Text = "ToolStrip1"
        ' 
        ' tsbNuevo
        ' 
        tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbNuevo.Name = "tsbNuevo"
        tsbNuevo.Size = New Size(46, 19)
        tsbNuevo.Text = "Nuevo"
        ' 
        ' tsbAbrir
        ' 
        tsbAbrir.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbAbrir.Name = "tsbAbrir"
        tsbAbrir.Size = New Size(37, 19)
        tsbAbrir.Text = "Abrir"
        ' 
        ' tsbGuardar
        ' 
        tsbGuardar.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbGuardar.Name = "tsbGuardar"
        tsbGuardar.Size = New Size(53, 19)
        tsbGuardar.Text = "Guardar"
        ' 
        ' tsbNegrita
        ' 
        tsbNegrita.CheckOnClick = True
        tsbNegrita.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbNegrita.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        tsbNegrita.Name = "tsbNegrita"
        tsbNegrita.Size = New Size(23, 19)
        tsbNegrita.Text = "N"
        ' 
        ' tsbCursiva
        ' 
        tsbCursiva.CheckOnClick = True
        tsbCursiva.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbCursiva.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        tsbCursiva.Name = "tsbCursiva"
        tsbCursiva.Size = New Size(23, 19)
        tsbCursiva.Text = "K"
        ' 
        ' tsbSubrayado
        ' 
        tsbSubrayado.CheckOnClick = True
        tsbSubrayado.DisplayStyle = ToolStripItemDisplayStyle.Text
        tsbSubrayado.Font = New Font("Segoe UI", 9F, FontStyle.Underline)
        tsbSubrayado.Name = "tsbSubrayado"
        tsbSubrayado.Size = New Size(23, 19)
        tsbSubrayado.Text = "S"
        ' 
        ' tscbFuente
        ' 
        tscbFuente.Name = "tscbFuente"
        tscbFuente.Size = New Size(121, 23)
        ' 
        ' tscbTamano
        ' 
        tscbTamano.Name = "tscbTamano"
        tscbTamano.Size = New Size(75, 23)
        ' 
        ' rtbDocumento
        ' 
        rtbDocumento.ContextMenuStrip = cmsTexto
        rtbDocumento.Dock = DockStyle.Fill
        rtbDocumento.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rtbDocumento.Location = New Point(0, 47)
        rtbDocumento.Name = "rtbDocumento"
        rtbDocumento.Size = New Size(800, 403)
        rtbDocumento.TabIndex = 4
        rtbDocumento.Text = ""
        ' 
        ' cmsTexto
        ' 
        cmsTexto.Name = "cmsTexto"
        cmsTexto.Size = New Size(61, 4)
        ' 
        ' stsInferior
        ' 
        stsInferior.Items.AddRange(New ToolStripItem() {stsEstado, stsPosicion, stsCaracteres, stsFechaHora})
        stsInferior.Location = New Point(0, 428)
        stsInferior.Name = "stsInferior"
        stsInferior.Size = New Size(800, 22)
        stsInferior.TabIndex = 6
        stsInferior.Text = "StatusStrip1"
        ' 
        ' stsEstado
        ' 
        stsEstado.Name = "stsEstado"
        stsEstado.Size = New Size(566, 17)
        stsEstado.Spring = True
        stsEstado.Text = "Listo"
        ' 
        ' stsPosicion
        ' 
        stsPosicion.Name = "stsPosicion"
        stsPosicion.Size = New Size(80, 17)
        stsPosicion.Text = "Línea: 1 Col: 1"
        ' 
        ' stsCaracteres
        ' 
        stsCaracteres.Name = "stsCaracteres"
        stsCaracteres.Size = New Size(74, 17)
        stsCaracteres.Text = "Caracteres: 0"
        ' 
        ' stsFechaHora
        ' 
        stsFechaHora.Name = "stsFechaHora"
        stsFechaHora.Size = New Size(65, 17)
        stsFechaHora.Text = "00/00/0000"
        ' 
        ' dlgAbrir
        ' 
        dlgAbrir.Filter = "Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        ' 
        ' dlgGuardar
        ' 
        dlgGuardar.DefaultExt = "txt"
        dlgGuardar.Filter = "Archivos de texto (*.txt)|*.txt|Todos (*.*)|*.*"
        ' 
        ' dlgFuente
        ' 
        dlgFuente.ShowColor = True
        ' 
        ' dlgColor
        ' 
        dlgColor.FullOpen = True
        ' 
        ' tmrReloj
        ' 
        tmrReloj.Enabled = True
        tmrReloj.Interval = 1000
        ' 
        ' frmBlocNotas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(stsInferior)
        Controls.Add(rtbDocumento)
        Controls.Add(tlsBarraHerramientas)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(mnuPrincipal)
        MainMenuStrip = mnuPrincipal
        MinimumSize = New Size(600, 400)
        Name = "frmBlocNotas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bloc de Notas VB.NET"
        mnuPrincipal.ResumeLayout(False)
        mnuPrincipal.PerformLayout()
        tlsBarraHerramientas.ResumeLayout(False)
        tlsBarraHerramientas.PerformLayout()
        stsInferior.ResumeLayout(False)
        stsInferior.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents tlsBarraHerramientas As ToolStrip
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents rtbDocumento As RichTextBox
    Friend WithEvents cmsTexto As ContextMenuStrip
    Friend WithEvents stsInferior As StatusStrip
    Friend WithEvents dlgAbrir As OpenFileDialog
    Friend WithEvents dlgGuardar As SaveFileDialog
    Friend WithEvents dlgFuente As FontDialog
    Friend WithEvents dlgColor As ColorDialog
    Friend WithEvents tmrReloj As Timer
    Friend WithEvents tsbAbrir As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbNegrita As ToolStripButton
    Friend WithEvents tsbCursiva As ToolStripButton
    Friend WithEvents tsbSubrayado As ToolStripButton
    Friend WithEvents tscbFuente As ToolStripComboBox
    Friend WithEvents tscbTamano As ToolStripComboBox
    Friend WithEvents stsEstado As ToolStripStatusLabel
    Friend WithEvents stsPosicion As ToolStripStatusLabel
    Friend WithEvents stsCaracteres As ToolStripStatusLabel
    Friend WithEvents stsFechaHora As ToolStripStatusLabel
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuNuevo As ToolStripMenuItem
    Friend WithEvents mnuAbrir As ToolStripMenuItem
    Friend WithEvents mnuGuardar As ToolStripMenuItem
    Friend WithEvents mnuGuardarComo As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents EdicionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDeshacer As ToolStripMenuItem
    Friend WithEvents mnuRehacer As ToolStripMenuItem
    Friend WithEvents mnuCortar As ToolStripMenuItem
    Friend WithEvents mnuCopiar As ToolStripMenuItem
    Friend WithEvents mnuPegar As ToolStripMenuItem
    Friend WithEvents mnuSeleccionarTodo As ToolStripMenuItem
    Friend WithEvents FormatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFuente As ToolStripMenuItem
    Friend WithEvents mnuColorTexto As ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuBuscar As ToolStripMenuItem
    Friend WithEvents mnuContarPalabras As ToolStripMenuItem
    Friend WithEvents mnuContarCaracteres As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAjusteLinea As ToolStripMenuItem

End Class