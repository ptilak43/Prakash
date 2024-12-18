Imports System.Data.SqlClient

Public Class loanrepay
    Dim cn As New SqlConnection("Data Source=LAPTOP-G9EG0LI8\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim bm As BindingManagerBase
    Dim str As String

    Private Sub BACK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

        If Val(TextBox1.Text) < 2000 Then

            If TextBox1.Text = "" Then
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                Exit Sub
            End If

            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()

            If cn.State = ConnectionState.Closed Then
                cn.Close()
            End If

            str = "select * from loan_repay where l_id='" + TextBox1.Text + "'"

            cmd = New SqlCommand(str, cn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds)

            tbl = ds.Tables(0)
            bm = Me.BindingContext(tbl)

            TextBox2.DataBindings.Clear()
            TextBox3.DataBindings.Clear()
            TextBox4.DataBindings.Clear()
            TextBox5.DataBindings.Clear()

            TextBox2.DataBindings.Add("text", tbl, "i_amt")
            TextBox3.DataBindings.Add("text", tbl, "a_loan")
            TextBox4.DataBindings.Add("text", tbl, "acc_no")
            TextBox5.DataBindings.Add("text", tbl, "rm_loan")

            Exit Sub

        Else
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        Label2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim repay As Long
        Dim rloan As Long
        Dim uamt As Long

        repay = InputBox("enter the amount to repay of loan")

        rloan = (Val(TextBox5.Text) - repay)
        uamt = (Val(TextBox3.Text) - repay)

        str = "update loan_repay set rm_loan='" & rloan & "',a_loan='" & uamt & "' where l_id='" & TextBox1.Text & "'"

        cmd = New SqlCommand(str, cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()

        Label2.Text = "loan repayed successfully"
        Label2.ForeColor = Color.Green

        TextBox5.Text = rloan
        TextBox3.Text = uamt

        repay = 0
        rloan = 0
        uamt = 0

    End Sub

    Private Sub loanrepay_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class