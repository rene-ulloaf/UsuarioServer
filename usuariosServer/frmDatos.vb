Imports System.IO

Public Class frmVerUsuarios
    Private datosServer As New System.Collections.Generic.List(Of clsUsuarioServer.clsArchivosServer)

    Enum enuCol
        user = 0
        fullName = 1
        group = 2
        createTime = 3
        updTime = 4
        lastAccess = 5
        lastAccessTime = 6
        comment = 7
        pwdLastChange = 8
        adminPwdCahnge = 9
        pwdChangedBy = 10
    End Enum

    Private Sub frmVerUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Inicializar()
    End Sub

    Private Sub Inicializar()
        Me.configuraGrilla()
        Me.cargaComboArchivos()
    End Sub

    Private Sub cargaComboArchivos()
        Dim datos As New System.Collections.Generic.List(Of clsUsuarioServer.clsComboBox)
        Dim aux As clsUsuarioServer.clsComboBox
        Dim Mi_directorio As DirectoryInfo = New DirectoryInfo("C:\levantamiento")

        If Directory.Exists("C:\levantamiento") Then
            For Each Mi_archivo As FileInfo In Mi_directorio.GetFiles()
                aux = New clsUsuarioServer.clsComboBox

                aux.codigo = Mi_archivo.Name.Split(".")(0)
                aux.glosa = Mi_archivo.Name.Split(".")(0)
                datos.Add(aux)
            Next
        Else
            MessageBox.Show("No Existe el directorio 'levantamiento', donde esten guardados lo archivos .txt", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        aux = New clsUsuarioServer.clsComboBox
        aux.codigo = 0
        aux.glosa = "Seleccionar"
        datos.Insert(0, aux)

        cboServer.ValueMember = "codigo"
        cboServer.DisplayMember = "glosa"
        cboServer.DataSource = datos
    End Sub

    Private Sub configuraGrilla()
        fpDatos_Sheet1.RowCount = 0
        fpDatos_Sheet1.ColumnCount = 11

        fpDatos_Sheet1.Columns.Item(enuCol.user).Locked = True
        fpDatos_Sheet1.Columns.Item(enuCol.user).Label = "User"
        fpDatos_Sheet1.Columns.Item(enuCol.user).Width = 100
        fpDatos_Sheet1.Columns.Item(enuCol.user).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        fpDatos_Sheet1.Columns.Item(enuCol.user).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        fpDatos_Sheet1.Columns.Item(enuCol.user).Resizable = False

        fpDatos_Sheet1.Columns.Item(enuCol.fullName).Locked = True
        fpDatos_Sheet1.Columns.Item(enuCol.fullName).Label = "Full Name"
        fpDatos_Sheet1.Columns.Item(enuCol.fullName).Width = 200
        fpDatos_Sheet1.Columns.Item(enuCol.fullName).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        fpDatos_Sheet1.Columns.Item(enuCol.fullName).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        fpDatos_Sheet1.Columns.Item(enuCol.fullName).Resizable = True

        fpDatos_Sheet1.Columns.Item(enuCol.group).Locked = True
        fpDatos_Sheet1.Columns.Item(enuCol.group).Label = "Group"
        fpDatos_Sheet1.Columns.Item(enuCol.group).Width = 150
        fpDatos_Sheet1.Columns.Item(enuCol.group).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        fpDatos_Sheet1.Columns.Item(enuCol.group).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        fpDatos_Sheet1.Columns.Item(enuCol.group).Resizable = True

        fpDatos_Sheet1.Columns.Item(enuCol.createTime).Locked = True
        fpDatos_Sheet1.Columns.Item(enuCol.createTime).Label = "Create Time"
        fpDatos_Sheet1.Columns.Item(enuCol.createTime).Width = 100
        fpDatos_Sheet1.Columns.Item(enuCol.createTime).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        fpDatos_Sheet1.Columns.Item(enuCol.createTime).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        fpDatos_Sheet1.Columns.Item(enuCol.createTime).Resizable = False

        fpDatos_Sheet1.Columns.Item(enuCol.updTime).Locked = True
        fpDatos_Sheet1.Columns.Item(enuCol.updTime).Label = "update Time"
        fpDatos_Sheet1.Columns.Item(enuCol.updTime).Width = 100
        fpDatos_Sheet1.Columns.Item(enuCol.updTime).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        fpDatos_Sheet1.Columns.Item(enuCol.updTime).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        fpDatos_Sheet1.Columns.Item(enuCol.updTime).Resizable = False

        fpDatos_Sheet1.Columns.Item(enuCol.lastAccess).Locked = True
        fpDatos_Sheet1.Columns.Item(enuCol.lastAccess).Label = "Last Access"
        fpDatos_Sheet1.Columns.Item(enuCol.lastAccess).Width = 100
        fpDatos_Sheet1.Columns.Item(enuCol.lastAccess).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        fpDatos_Sheet1.Columns.Item(enuCol.lastAccess).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        fpDatos_Sheet1.Columns.Item(enuCol.lastAccess).Resizable = False

        fpDatos_Sheet1.Columns.Item(enuCol.lastAccessTime).Locked = True
        fpDatos_Sheet1.Columns.Item(enuCol.lastAccessTime).Label = "Last Access Time"
        fpDatos_Sheet1.Columns.Item(enuCol.lastAccessTime).Width = 110
        fpDatos_Sheet1.Columns.Item(enuCol.lastAccessTime).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        fpDatos_Sheet1.Columns.Item(enuCol.lastAccessTime).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        fpDatos_Sheet1.Columns.Item(enuCol.lastAccessTime).Resizable = False

        fpDatos_Sheet1.Columns.Item(enuCol.comment).Locked = True
        fpDatos_Sheet1.Columns.Item(enuCol.comment).Label = "Comment"
        fpDatos_Sheet1.Columns.Item(enuCol.comment).Width = 250
        fpDatos_Sheet1.Columns.Item(enuCol.comment).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        fpDatos_Sheet1.Columns.Item(enuCol.comment).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        fpDatos_Sheet1.Columns.Item(enuCol.comment).Resizable = True

        fpDatos_Sheet1.Columns.Item(enuCol.pwdLastChange).Locked = True
        fpDatos_Sheet1.Columns.Item(enuCol.pwdLastChange).Label = "Pwd Last Change"
        fpDatos_Sheet1.Columns.Item(enuCol.pwdLastChange).Width = 100
        fpDatos_Sheet1.Columns.Item(enuCol.pwdLastChange).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        fpDatos_Sheet1.Columns.Item(enuCol.pwdLastChange).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        fpDatos_Sheet1.Columns.Item(enuCol.pwdLastChange).Resizable = False

        fpDatos_Sheet1.Columns.Item(enuCol.adminPwdCahnge).Locked = True
        fpDatos_Sheet1.Columns.Item(enuCol.adminPwdCahnge).Label = "Admin Pwd Cahnge"
        fpDatos_Sheet1.Columns.Item(enuCol.adminPwdCahnge).Width = 110
        fpDatos_Sheet1.Columns.Item(enuCol.adminPwdCahnge).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        fpDatos_Sheet1.Columns.Item(enuCol.adminPwdCahnge).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        fpDatos_Sheet1.Columns.Item(enuCol.adminPwdCahnge).Resizable = False

        fpDatos_Sheet1.Columns.Item(enuCol.pwdChangedBy).Locked = True
        fpDatos_Sheet1.Columns.Item(enuCol.pwdChangedBy).Label = "Pwd Change dBy"
        fpDatos_Sheet1.Columns.Item(enuCol.pwdChangedBy).Width = 100
        fpDatos_Sheet1.Columns.Item(enuCol.pwdChangedBy).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        fpDatos_Sheet1.Columns.Item(enuCol.pwdChangedBy).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left
        fpDatos_Sheet1.Columns.Item(enuCol.pwdChangedBy).Resizable = False
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If cboServer.SelectedValue <> "0" Then
            Me.cargaGrilla()
        End If
    End Sub

    Private Sub cargaGrilla()
        Try
            fpDatos_Sheet1.RowCount = 0
            Me.ObtenerDatos()

            For Each Registros In datosServer
                fpDatos_Sheet1.Rows.Count += 1

                'fpDatos_Sheet1.SetText(fpDatos_Sheet1.RowCount - 1, enuCol.codDocumento, Registros.Codigo)
                'fpDatos_Sheet1.SetText(fpDatos_Sheet1.RowCount - 1, enuCol.Caso, Registros.Caso)
                'fpDatos_Sheet1.SetText(fpDatos_Sheet1.RowCount - 1, enuCol.CodTipoDocumento, Registros.TipoDocumento.Codigo)
                'fpDatos_Sheet1.SetText(fpDatos_Sheet1.RowCount - 1, enuCol.CodPlantilla, Registros.Plantilla.Codigo)
                'fpDatos_Sheet1.SetText(fpDatos_Sheet1.RowCount - 1, enuCol.TipoDocumentoNombre, Registros.nombreDoc)
                'fpDatos_Sheet1.SetText(fpDatos_Sheet1.RowCount - 1, enuCol.PlantillaNombre, Registros.Plantilla.Nombre)
                'fpDatos_Sheet1.SetText(fpDatos_Sheet1.RowCount - 1, enuCol.FechaCreacion, Registros.FechaCreacion.Date)
                'fpDatos_Sheet1.SetText(fpDatos_Sheet1.RowCount - 1, enuCol.Tamano, Math.Round((Registros.TamanoArch / 1000)).ToString + " KB")
                'fpDatos_Sheet1.SetText(fpDatos_Sheet1.RowCount - 1, enuCol.UsuarioCreador, Registros.UsuarioCreador)
                'fpDatos_Sheet1.SetText(fpDatos_Sheet1.RowCount - 1, enuCol.EmpleadoNombre, Registros.NombreTrabajador)
                'fpDatos_Sheet1.SetText(fpDatos_Sheet1.RowCount - 1, enuCol.Terminado, IIf(Registros.Terminado, "Si", "No"))
            Next
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Private Sub ObtenerDatos()
        Dim aux As clsUsuarioServer.clsArchivosServer
        Dim fs As New System.IO.FileStream("C:\levantamiento\" & cboServer.SelectedValue.ToString & ".txt", IO.FileMode.Open, IO.FileAccess.Read)
        Dim strArch As New StreamReader(fs)

        strArch.BaseStream.Seek(0, IO.SeekOrigin.Begin)
        While strArch.Peek() > -1
            For Each linea In strArch.ReadLine.Split(vbCrLf)
                aux = New clsUsuarioServer.clsArchivosServer


            Next
        End While
    End Sub
End Class