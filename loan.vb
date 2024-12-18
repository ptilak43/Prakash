Imports System.Data.SqlClient

Public Class loan
    Dim cn As New SqlConnection("Data Source=LAPTOP-G9EG0LI8\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim str As String

    Private Sub BACK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        Label8.Text = ""
        Label9.Text = ""
        Label10.Text = ""

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Dim emi As Long
        emi = 0

        Label9.ForeColor = Color.Red
        If TextBox1.Text = "" Then
            Label9.Text = "enter account no"
            Exit Sub
        Else
            If TextBox1.Text.Length = 13 Then
                GoTo phase1
            Else
                Label9.Text = ""
                Label9.Text = "account number should be 13 digit"
                Exit Sub
            End If
        End If

phase1:

        If TextBox2.Text = "" Then
            Label9.Text = " enter income per month"
            Exit Sub
        End If

        If TextBox3.Text = "" Then
            Label9.Text = " enter amount of loan"
            Exit Sub
        End If

        If TextBox4.Text = "" Then
            Label9.Text = "enter duration of loan"
            Exit Sub
        End If

        If TextBox5.Text = "" Then
            Label9.Text = " enter intrest of loan"
            Exit Sub
        End If

        emi = (Val(TextBox3.Text) / (12 * Val(TextBox4.Text)))

        If emi > (Val(TextBox2.Text) / 2) Then
            Label9.Text = "you are not eligible for the loan"
            Label9.ForeColor = Color.Red
        Else
            Dim str As String
            str = emi

            Label9.Text = "you are eligible for the loan, your emi will " + str + "per month"
            Label9.ForeColor = Color.Green

            Button1.Visible = True
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        Dim i As Integer

        i = Val(TextBox4.Text)

        If i <= 7 Then
            Label8.Text = "loan duration is eligible"
            Label8.ForeColor = Color.Green
        Else
            Label8.Text = "loan Duration should be between 1 to 7 years"
            Label8.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
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
                Label10.Text = "account is closed, can't get loan"
                Label10.ForeColor = Color.Red
                Exit Sub
            Else
                Dim digit As Long = 1000
                Dim i As Integer

                i = 0

                Do While (i <= 0)
                    Randomize()
                    digit = digit + Val((999 * Rnd()) + 1)
                    Randomize()

                    str = "select * from loan where l_id='" & digit & "'"

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

                        TextBox6.Text = digit1

                        str = "insert into loan values('" + digit1 + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')"

                        cmd = New SqlCommand(str, cn)
                        cn.Open()
                        cmd.ExecuteNonQuery()
                        cn.Close()


                        str = "insert into loan_repay values('" + digit1 + "',0,'" + TextBox3.Text + "','" + TextBox1.Text + "','" + TextBox3.Text + "')"

                        cmd = New SqlCommand(str, cn)
                        cn.Open()
                        cmd.ExecuteNonQuery()

                        Label10.Text = "loan granted"
                        Label10.ForeColor = Color.Green
                        Button1.Visible = False
                        cn.Close()
                    End If
                Loop
            End If
        Else
            Label10.Text = "account number does not exist"
            Label10.ForeColor = Color.Red
        End If

    End Sub
End Class