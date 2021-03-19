Public Class Form1

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click
        ' suma
        suma.Text = Val(num1.Text) + Val(num2.Text) + Val(num3.Text)
        ' resta
        resta.Text = Val(num1.Text) - Val(num2.Text) - Val(num3.Text)
        ' producto
        producto.Text = Val(num1.Text) * Val(num2.Text) * Val(num3.Text)
        ' cociente
        cociente.Text = Val(num1.Text) / Val(num2.Text)
        ' logN
        longn.Text = Val(Math.Log(Val(num1.Text)))
        ' log10
        long10.Text = Val(Math.Log10(Val(num1.Text)))
        ' seno
        seno.Text = Val(Math.Sin(Val(num1.Text)))
        ' cosceno
        coseno.Text = Val(Math.Cos(Val(num1.Text)))
        ' raiz
        raiz.Text = Val(Math.Sqrt(Val(producto.Text)))

        'reciduo
        residuo.Text = Val(num1.Text) Mod Val(num2.Text)

        'potencia 
        potencia.Text = Val(Math.Pow(Val(num1.Text), Val(num3.Text)))



    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        ' limpiar
        num1.Clear()
        num2.Clear()
        num3.Clear()
        suma.Clear()
        resta.Clear()
        producto.Clear()
        cociente.Clear()

    End Sub

 
End Class
