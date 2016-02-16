Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClorToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = documents.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                documents.ForeColor = dlg.Color
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        documents.Clear()

    End Sub

    Private Sub GuardarComoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarComoToolStripMenuItem.Click
        Dim Save As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Save.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|All files(*.*)|*.*"
        Save.CheckPathExists = True
        Save.Title = "Guardar como"
        Save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.AppendText(Save.FileName)
            myStreamWriter.Write(documents.Text)
            myStreamWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim Open As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        Open.Filter = "Text [*.txt*]|*.txt|All Files [*,*]|*,*"
        Open.CheckFileExists = True
        Open.Title = "Abrir Archivo"
        Open.ShowDialog(Me)
        Try
            Open.OpenFile()
            myStreamReader = System.IO.File.OpenText(Open.FileName)
            documents.Text = myStreamReader.ReadToEnd()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AtrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtrasToolStripMenuItem.Click
        documents.Undo()
    End Sub

    Private Sub AdelanteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdelanteToolStripMenuItem.Click
        documents.Redo()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        documents.Copy()
    End Sub

    Private Sub PegarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarToolStripMenuItem.Click
        documents.Paste()
    End Sub

    Private Sub CortarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortarToolStripMenuItem.Click
        documents.Cut()
    End Sub

    Private Sub SeleccionarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarToolStripMenuItem.Click
        documents.SelectAll()
    End Sub

    Private Sub BorrarTodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarTodoToolStripMenuItem.Click
        documents.Clear()
    End Sub

    Private Sub FuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuenteToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = documents.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                documents.Font = dlg.Font
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub ColorDeFuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorDeFuenteToolStripMenuItem.Click
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = documents.BackColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                documents.BackColor = dlg.Color
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
