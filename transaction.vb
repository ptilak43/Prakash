Imports System.Data.SqlClient

Public Class transaction
    Dim cn As New SqlConnection("Data Source=LAPTOP-G9EG0LI8\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim bm As BindingManagerBase
    Dim str As String
    Dim msg As String

    Private Sub BACK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length = 13 Then
            If cn.State = ConnectionState.Closed Then
                cn.Close()
            End If

            str = "select * from account_holder where acc_no='" + TextBox1.Text + "'"

            cmd = New SqlCommand(str, cn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds)

            tbl = ds.Tables(0)
            bm = Me.BindingContext(tbl)

            Label6.DataBindings.Clear()
            Label6.DataBindings.Add("text", tbl, "ins_bal")
            Label7.Text = "balance"
            Label6.ForeColor = Color.Green
            Label7.ForeColor = Color.Green
            Exit Sub
        Else
            Label7.Text = "enter account number"
            Label6.ForeColor = Color.Red
            Label7.ForeColor = Color.Red
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Label8.ForeColor = Color.Red
        If TextBox1.Text = "" Then
            Label8.Text = "enter account no"
            Exit Sub
        Else
            If TextBox1.Text.Length = 13 Then
                GoTo phase1
            Else
                Label8.Text = ""
                Label8.Text = "account number should be 13 digit"
                Exit Sub
            End If
        End If

phase1:

        If ComboBox1.Text = "" Then
            Label8.Text = " enter type of transcation"
            Exit Sub
        End If

        If TextBox3.Text = "" Then
            Label8.Text = " enter amount of transction."
            Exit Sub
        End If

        Dim check As Integer

        str = "select * from account_holder where acc_no='" & TextBox1.Text & "'"

        cmd = New SqlCommand(str, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds)

        tbl = ds.Tables(0)
        check = tbl.Rows.Count()

        If check = 1 Then
            Dim subs As String()

            str = ds.Tables(0).Rows(0).Item("address")

            subs = str.Split(" ")

            If "closed113" = subs(0) Then
                Label8.Text = "account is closed, can't do transcation"
                Label8.ForeColor = Color.Red
                Exit Sub
            Else
                Dim digit As Integer = 10000
                Dim i As Integer
                Dim d As Date

                d = DateAndTime.Today
                i = 0

                Do While (i <= 0)
                    Randomize()
                    digit = digit + Val((9999 * Rnd()) + 1)
                    Randomize()

                    str = "select * from transction where t_id='" & digit & "'"

                    cmd = New SqlCommand(str, cn)
                    da = New SqlDataAdapter(cmd)
                    ds = New DataSet()
                    da.Fill(ds)

                    tbl = ds.Tables(0)
                    check = tbl.Rows.Count()

                    If check = 0 Then
                        Dim digit1 As String
                        digit1 = digit
                        i = i + 1

                        If ComboBox1.Text = "Withdraw" Then
                            Dim bal As Long
                            Dim wamt As Long
                            Dim wbal As Long

                            bal = Val(Label6.Text)
                            wamt = Val(TextBox3.Text)

                            If wamt <= bal Then
                                wbal = bal - wamt

                                str = "update account_holder set ins_bal='" & wbal & "' where acc_no='" & TextBox1.Text & "'"

                                cmd = New SqlCommand(str, cn)
                                cn.Open()
                                cmd.ExecuteNonQuery()
                                cn.Close()

                                str = "insert into transction values('" + digit1 + "','" + TextBox1.Text + "','" + ComboBox1.Text + "','" + TextBox3.Text + "','" + d + "' )"

                                cmd = New SqlCommand(str, cn)
                                cn.Open()
                                cmd.ExecuteNonQuery()
                                cn.Close()

                                Label8.Text = "withdraw is successfull"
                                Label8.ForeColor = Color.Green
                                Label6.Text = wbal
                                TextBox2.Text = digit1
                            Else
                                Label8.Text = "withdraw is not successfull due to low balance"
                                Label8.ForeColor = Color.Red
                            End If
                        ElseIf ComboBox1.Text = "Deposit" Then

                            Dim bal As Long
                            Dim damt As Long
                            Dim dbal As Long

                            bal = Val(Label6.Text)
                            damt = Val(TextBox3.Text)

                            If damt < 50000 Then
                                dbal = bal + damt

                                str = "update account_holder set ins_bal='" & dbal & "' where acc_no='" & TextBox1.Text & "'"

                                cmd = New SqlCommand(str, cn)
                                cn.Open()
                                cmd.ExecuteNonQuery()
                                cn.Close()

                                str = "insert into transction values('" + digit1 + "','" + TextBox1.Text + "','" + ComboBox1.Text + "','" + TextBox3.Text + "','" + d + "')"

                                cmd = New SqlCommand(str, cn)
                                cn.Open()
                                cmd.ExecuteNonQuery()
                                cn.Close()

                                Label8.Text = "deposit is successfull"
                                Label8.ForeColor = Color.Green
                                Label6.Text = dbal
                                TextBox2.Text = digit1
                            Else
                                Label8.Text = "deposit is not successfull due to high amount"
                                Label8.ForeColor = Color.Red
                            End If
                        End If
                    End If
                Loop
               
            End If
        Else
            Label8.Text = "account number does not exist"
            Label8.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub transaction_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class