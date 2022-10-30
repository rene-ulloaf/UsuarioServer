<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerUsuarios
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
        Me.gbSeleccion = New System.Windows.Forms.GroupBox
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.cboServer = New System.Windows.Forms.ComboBox
        Me.lblSeleccionar = New System.Windows.Forms.Label
        Me.fpDatos = New FarPoint.Win.Spread.FpSpread
        Me.fpDatos_Sheet1 = New FarPoint.Win.Spread.SheetView
        Me.gbSeleccion.SuspendLayout()
        CType(Me.fpDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fpDatos_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSeleccion
        '
        Me.gbSeleccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSeleccion.Controls.Add(Me.btnExportar)
        Me.gbSeleccion.Controls.Add(Me.btnBuscar)
        Me.gbSeleccion.Controls.Add(Me.cboServer)
        Me.gbSeleccion.Controls.Add(Me.lblSeleccionar)
        Me.gbSeleccion.Location = New System.Drawing.Point(13, 13)
        Me.gbSeleccion.Name = "gbSeleccion"
        Me.gbSeleccion.Size = New System.Drawing.Size(889, 43)
        Me.gbSeleccion.TabIndex = 0
        Me.gbSeleccion.TabStop = False
        Me.gbSeleccion.Text = "Seleccion"
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(566, 17)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(149, 23)
        Me.btnExportar.TabIndex = 3
        Me.btnExportar.Text = "&Exportar Excel"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(359, 15)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cboServer
        '
        Me.cboServer.FormattingEnabled = True
        Me.cboServer.Location = New System.Drawing.Point(118, 17)
        Me.cboServer.Name = "cboServer"
        Me.cboServer.Size = New System.Drawing.Size(235, 21)
        Me.cboServer.TabIndex = 1
        '
        'lblSeleccionar
        '
        Me.lblSeleccionar.AutoSize = True
        Me.lblSeleccionar.Location = New System.Drawing.Point(7, 20)
        Me.lblSeleccionar.Name = "lblSeleccionar"
        Me.lblSeleccionar.Size = New System.Drawing.Size(105, 13)
        Me.lblSeleccionar.TabIndex = 0
        Me.lblSeleccionar.Text = "Seleccionar Servidor"
        '
        'fpDatos
        '
        Me.fpDatos.AccessibleDescription = ""
        Me.fpDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fpDatos.Location = New System.Drawing.Point(13, 67)
        Me.fpDatos.Name = "fpDatos"
        Me.fpDatos.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.fpDatos_Sheet1})
        Me.fpDatos.Size = New System.Drawing.Size(889, 444)
        Me.fpDatos.TabIndex = 1
        '
        'fpDatos_Sheet1
        '
        Me.fpDatos_Sheet1.Reset()
        Me.fpDatos_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.fpDatos_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.fpDatos_Sheet1.AllowNoteEdit = True
        Me.fpDatos_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'frmVerUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 523)
        Me.Controls.Add(Me.fpDatos)
        Me.Controls.Add(Me.gbSeleccion)
        Me.Name = "frmVerUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar y Exportar Datos"
        Me.gbSeleccion.ResumeLayout(False)
        Me.gbSeleccion.PerformLayout()
        CType(Me.fpDatos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fpDatos_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbSeleccion As System.Windows.Forms.GroupBox
    Friend WithEvents lblSeleccionar As System.Windows.Forms.Label
    Friend WithEvents cboServer As System.Windows.Forms.ComboBox
    Friend WithEvents fpDatos As FarPoint.Win.Spread.FpSpread
    Friend WithEvents fpDatos_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button

End Class
