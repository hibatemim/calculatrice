Imports System.Linq.Expressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        result.Text = result.Text + "1"

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        result.Text = result.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        result.Text = result.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        result.Text = result.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        result.Text = result.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        result.Text = result.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        result.Text = result.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        result.Text = result.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        result.Text = result.Text + "9"
    End Sub

    Private Sub btnp_Click(sender As Object, e As EventArgs) Handles btnp.Click
        If result.Text <> "" Then 'man7ot + wala - wala ay haja ken ki tebda chaine fyha 7ourouf
            If Not "+-/*.".Contains(result.Text(result.Text.Length - 1)) Then 'hetheya  test bch may5alinech nektbou 2 operations wra b3adhhom
                result.Text = result.Text + "."
            End If

        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        result.Text = result.Text + "0"
    End Sub

    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btno.Click
        result.Text = result.Text + "00"
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        If result.Text <> "" Then
            If Not "+-/*.".Contains(result.Text(result.Text.Length - 1)) Then

                result.Text = result.Text + "+"
            End If
        End If

    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        Try
            If Not ".".Contains(result.Text(result.Text.Length - 1)) Then
                result.Text = result.Text + "-"
            End If
        Catch ex As Exception
            result.Text = result.Text + "-"
        End Try


    End Sub

    Private Sub btnmult_Click(sender As Object, e As EventArgs) Handles btnmult.Click
        If result.Text <> "" Then
            If Not "+-/*.".Contains(result.Text(result.Text.Length - 1)) Then
                result.Text = result.Text + "*"
            End If

        End If
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        If result.Text <> "" Then
            If Not "+-/*.".Contains(result.Text(result.Text.Length - 1)) Then
                result.Text = result.Text + "/"
            End If

        End If
    End Sub

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        If result.Text <> "" Then
            result.Text = result.Text.Substring(0, result.Text.Length - 1) 'sous chaine bch nfas5ou ekher harf fel 3amaliya
        End If
    End Sub

    Private Sub btneq_Click(sender As Object, e As EventArgs) Handles btneq.Click
        If result.Text <> "" Then
            Dim res As Double = New DataTable().Compute(result.Text, Nothing) 'la fonction compute de la class table ta3tih 3amaliya fi chakel chaine w howa ya3tik ntija toul w y5abiha fi res
            result.Text = result.Text + "=" + CStr(res)
        End If
    End Sub

    Private Sub btnce_Click(sender As Object, e As EventArgs) Handles btnce.Click
        result.Text = ""

    End Sub
End Class
