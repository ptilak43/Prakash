Imports System.Data.SqlClient
Public Class login
    Dim cn As New SqlConnection("Data Source=LAPTOP-G9EG0LI8\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim str As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub cancel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_btn.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click

        If cn.State = ConnectionState.Closed Then
            cn.Close()
        End If

        str = "select *from login where u_id='" + TextBox1.Text + "'and pwd='" + TextBox2.Text + "'"

        cmd = New SqlCommand(str, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds)

        Dim temp As Integer
        temp = ds.Tables(0).Rows.Count

        If temp > 0 Then
            Me.Hide()
            home.Show()
        Else
            Label3.Text = "Username or Password is Incorrect."
            Label3.ForeColor = System.Drawing.Color.Red
        End If

    End Sub

End Class