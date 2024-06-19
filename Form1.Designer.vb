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
        Label1 = New Label()
        Label2 = New Label()
        CType(dtvVectorPrincipal, ComponentModel.ISupportInitialize).BeginInit()
        CType(dtvNuevoVector, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtvVectorPrincipal
        ' 
        dtvVectorPrincipal.BackgroundColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        dtvVectorPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvVectorPrincipal.GridColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        dtvVectorPrincipal.Location = New Point(12, 89)
        dtvVectorPrincipal.Name = "dtvVectorPrincipal"
        dtvVectorPrincipal.RowHeadersWidth = 51
        dtvVectorPrincipal.Size = New Size(571, 56)
        dtvVectorPrincipal.TabIndex = 0
        ' 
        ' dtvNuevoVector
        ' 
        dtvNuevoVector.BackgroundColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        dtvNuevoVector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtvNuevoVector.Location = New Point(12, 282)
        dtvNuevoVector.Name = "dtvNuevoVector"
        dtvNuevoVector.RowHeadersWidth = 51
        dtvNuevoVector.Size = New Size(741, 53)
        dtvNuevoVector.TabIndex = 1
        ' 
        ' cmdEjecutar
        ' 
        cmdEjecutar.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        cmdEjecutar.Font = New Font("Segoe UI", 14F)
        cmdEjecutar.Location = New Point(562, 383)
        cmdEjecutar.Name = "cmdEjecutar"
        cmdEjecutar.Size = New Size(206, 46)
        cmdEjecutar.TabIndex = 2
        cmdEjecutar.Text = "Ejecutar"
        cmdEjecutar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(12, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(236, 28)
        Label1.TabIndex = 3
        Label1.Text = "Vector de 10 Elementos"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(12, 239)
        Label2.Name = "Label2"
        Label2.Size = New Size(304, 28)
        Label2.TabIndex = 4
        Label2.Text = "Nuevo Vector de 15 Elementos"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmdEjecutar)
        Controls.Add(dtvNuevoVector)
        Controls.Add(dtvVectorPrincipal)
        Name = "Form1"
        Text = "Vectores"
        CType(dtvVectorPrincipal, ComponentModel.ISupportInitialize).EndInit()
        CType(dtvNuevoVector, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtvVectorPrincipal As DataGridView
    Friend WithEvents dtvNuevoVector As DataGridView
    Friend WithEvents cmdEjecutar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
