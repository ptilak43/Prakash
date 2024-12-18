Imports System.Data.SqlClient

Public Class acc_open
    Dim cn As New SqlConnection("Data Source=LAPTOP-G9EG0LI8\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim str As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim gen As String

        Label11.ForeColor = Color.Red
        If TextBox1.Text = "" Then
            Label11.Text = "enter account holder name"
            Exit Sub
        End If

        If TextBox3.Text = "" Then
            Label11.Text = " enter contact number"
            Exit Sub
        Else
            If TextBox3.Text.Length = 10 Then
                GoTo phase1
            Else
                Label11.Text = ""
                Label11.Text = " contact number should be 10 digit"
                Exit Sub
            End If
        End If

phase1:
        If TextBox4.Text = "" Then
            Label11.Text = " enter email"
            Exit Sub
        End If

        If TextBox5.Text = "" Then
            Label11.Text = "enter address"
            Exit Sub
        End If

        If TextBox6.Text = "" Then
            Label11.Text = " enter aadhar card number"
            Exit Sub
        Else
            If TextBox6.Text.Length = 12 Then
                GoTo phase2
            Else
                Label11.Text = ""
                Label11.Text = "aadhar card number should be 12 digit"
                Exit Sub
            End If
        End If

phase2:
        If TextBox7.Text = "" Then
            Label11.Text = " enter initial balance"
            Exit Sub
        End If

        If RadioButton1.Checked = True Then
            gen = "male"
        Else
            gen = "female"
        End If

        Dim i As Integer
        Dim check As Integer
        i = 0

        Do While (i <= 0)
            Dim acc_no As Long
            acc_no = 3001010300000
            Randomize()

            acc_no = acc_no + Val((9999 * Rnd()) + 1)
            str = "select * from account_holder where acc_no='" & acc_no & "'"

            cmd = New SqlCommand(str, cn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds)

            tbl = ds.Tables(0)
            check = tbl.Rows.Count()

            If check = 0 Then
                i = i + 1
                TextBox2.Text = acc_no
                str = "insert into account_holder values('" + TextBox2.Text + "','" + TextBox1.Text + "','" + DateTimePicker1.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + gen + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')"

                cmd = New SqlCommand(str, cn)
                cn.Open()
                cmd.ExecuteNonQuery()
                cn.Close()

                Label11.Text = "bank account is opend"
                Label11.ForeColor = Color.Green
            End If
        Loop
    End Sub

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
        TextBox7.Clear()
        Label11.Text = ""
    End Sub

    Private Sub acc_open_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class