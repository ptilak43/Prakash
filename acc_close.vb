Imports System.Data.SqlClient

Public Class acc_close
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim check As Integer

        str = "select * from account_holder where acc_no='" & t1.Text & "'"

        cmd = New SqlCommand(str, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds)

        tbl = ds.Tables(0)
        check = tbl.Rows.Count()

        If check = 1 Then
            Dim subs As String()
            Dim str2 As String

            str = ds.Tables(0).Rows(0).Item("address")

            subs = str.Split(" ")

            If "closed113" = subs(0) Then
                Label5.Text = "account is closed"
                Label5.ForeColor = Color.Red
                Exit Sub
            Else
                str2 = "closed113 " + t4.Text
                str = "update account_holder set address='" & str2 & "' where acc_no='" & t1.Text & "'"

                cmd = New SqlCommand(str, cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()

                Label5.Text = "account close"
                Label5.ForeColor = Color.Green
                Button1.Visible = False
            End If
        Else
            Label5.Text = "account number does not exist"
            Label5.ForeColor = Color.Red
        End If
    End Sub

    Private Sub t1_TextChanged(sender As Object, e As System.EventArgs) Handles t1.TextChanged
        If t1.Text.Length = 13 Then
            If cn.State = ConnectionState.Closed Then
                cn.Close()
            End If

            str = "select * from account_holder where acc_no='" + t1.Text + "'"

            cmd = New SqlCommand(str, cn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds)

            tbl = ds.Tables(0)
            bm = Me.BindingContext(tbl)

            t2.DataBindings.Clear()
            t3.DataBindings.Clear()
            t5.DataBindings.Clear()

            t2.DataBindings.Add("text", tbl, "ah_name")
            t3.DataBindings.Add("text", tbl, "dob")
            t5.DataBindings.Add("text", tbl, "ins_bal")
        Else

        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Label5.ForeColor = Color.Red
        If t1.Text = "" Then
            Label5.Text = "enter account no"
            Exit Sub
        Else
            If t1.Text.Length = 13 Then
                GoTo phase1
            Else
                Label5.Text = ""
                Label5.Text = "account number should be 13 digit"
                Exit Sub
            End If
        End If

phase1:

        If t4.Text = "" Then
            Label5.Text = "enter reason of closing"
            Exit Sub
        End If

        If t5.Text = "0" Then
            Label5.Text = "you are eligable to close account"
            Label5.ForeColor = Color.Green
            Button1.Visible = True
        Else
            Label5.Text = "remaining balance should be zero"
            Label5.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        t1.Clear()
        t2.Clear()
        t3.Clear()
        t4.Clear()
        t5.Clear()
        Label5.Text = ""

    End Sub

    Private Sub acc_close_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class