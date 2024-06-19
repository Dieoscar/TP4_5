Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtvVectorPrincipal.ColumnCount = 10
        dtvVectorPrincipal.Rows.Add(1)


        For i = 0 To 9
            dtvVectorPrincipal.Columns(i).Width = 40
        Next


        dtvNuevoVector.ColumnCount = 15
        dtvNuevoVector.Rows.Add(1)
        For i = 0 To 14
            dtvNuevoVector.Columns(i).Width = 40

        Next
    End Sub

    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim VectorPrincipal(0 To 9) As Integer
        Dim NuevoVector(0 To 14) As Integer
		Dim contador As Integer
		Dim i As Integer
		Dim indice As Integer
		Dim primerelemento As Integer
		Dim segundoelemento As Integer
		Dim tercerelemento As Integer


		contador = 1
		indice = 0
		For i = 0 To 9
			VectorPrincipal(i) = dtvVectorPrincipal.Item(i, 0).Value
		Next i
		For i = 0 To 9
			If contador = 2 Then
				NuevoVector(indice) = VectorPrincipal(i)
				segundoelemento = VectorPrincipal(i)
				indice = indice + 1
				tercerelemento = primerelemento + segundoelemento
				NuevoVector(indice) = tercerelemento
				indice = indice + 1
				contador = 1
			Else
				NuevoVector(indice) = VectorPrincipal(i)
				primerelemento = VectorPrincipal(i)
				indice = indice + 1
				contador = contador + 1
			End If
		Next i

		For i = 0 To 9
			dtvVectorPrincipal.Item(i, 0).Value = VectorPrincipal(i)
		Next i

		For i = 0 To 14
			dtvNuevoVector.Item(i, 0).Value = NuevoVector(i)
		Next i

	End Sub
End Class
