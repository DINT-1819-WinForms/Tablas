Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Cargamos los valores del ComboBox
        For index = 1 To 10
            NumerosComboBox.Items.Add(index)
        Next
    End Sub

    Private Sub NumerosComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NumerosComboBox.SelectedIndexChanged

        'Limpiamos el ListBox
        TablaListBox.Items.Clear()

        'Generamos la tabla de multiplicar
        For index = 1 To 10
            TablaListBox.Items.Add(String.Format("{0} x {1} = {2}", NumerosComboBox.SelectedItem, index.ToString(), CInt(NumerosComboBox.SelectedItem) * index))
        Next
    End Sub
End Class
