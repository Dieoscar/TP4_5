<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        dtvVectorPrincipal = New DataGridView()
        dtvNuevoVector = New DataGridView()
        cmdEjecutar = New Button()
        CType(dtvVectorPrincipal, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvNuevoVector, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtvVectorPrincipal
        ' 
        dtvVectorPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvVectorPrincipal.Location = New Point(39, 25)
        dtvVectorPrincipal.Name = "dtvVectorPrincipal"
        dtvVectorPrincipal.RowHeadersWidth = 51
        dtvVectorPrincipal.Size = New Size(571, 56)
        dtvVectorPrincipal.TabIndex = 0
        ' 
        ' dtvNuevoVector
        ' 
        dtvNuevoVector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvNuevoVector.Location = New Point(27, 211)
        dtvNuevoVector.Name = "dtvNuevoVector"
        dtvNuevoVector.RowHeadersWidth = 51
        dtvNuevoVector.Size = New Size(741, 53)
        dtvNuevoVector.TabIndex = 1
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.Location = New Point(205, 342)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(206, 46)
        cmdEjecutar.TabIndex = 2
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(cmdEjecutar)
        Controls.Add(dtvNuevoVector)
        Controls.Add(dtvVectorPrincipal)
        Name = "Form1"
        Text = "Form1"
        CType(dtvVectorPrincipal, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvNuevoVector, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dtvVectorPrincipal As DataGridView
    Friend WithEvents dtvNuevoVector As DataGridView
    Friend WithEvents cmdEjecutar As Button

End Class
