Imports System.Data.SqlClient

Public Class cal_interest
    Dim cn As New SqlConnection("Data Source=LAPTOP-G9EG0LI8\SQLEXPRESS;Initial Catalog=master;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim tbl As New DataTable()
    Dim tbl1 As New DataTable()
    Dim str As String

    Private Sub cal_interest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MasterDataSet5.loan_repay' table. You can move, or remove it, as needed.
        Me.Loan_repayTableAdapter.Fill(Me.MasterDataSet5.loan_repay)
        'TODO: This line of code loads data into the 'MasterDataSet4.account_holder' table. You can move, or remove it, as needed.
        Me.Account_holderTableAdapter.Fill(Me.MasterDataSet4.account_holder)

    End Sub

    Private Sub BACK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim bal As Long
        Dim i As Integer
        Dim acc_no As Long
        Dim ins_bal As Long

        i = 0

        Do While (i <= tbl.Rows.Count())

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            str = "select * from account_holder"

            cmd = New SqlCommand(str, cn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds)
            tbl = ds.Tables(0)

            acc_no = ds.Tables(0).Rows(i).Item("acc_no")
            bal = ds.Tables(0).Rows(i).Item("ins_bal")
            ins_bal = (bal + (bal * 0.03))

            str = "update account_holder set ins_bal='" & ins_bal & "' where acc_no='" & acc_no & "'"
            cmd = New SqlCommand(str, cn)
            cn.Open()
            cmd.ExecuteNonQuery()

            If i + 1 >= tbl.Rows.Count() Then
                Exit Do
            Else
                i = i + 1
            End If

            acc_no = 0
            bal = 0

        Loop
        Label3.Text = "intrest of all saving accounts is calculated"
        Label3.ForeColor = Color.Green
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim intrest As Long
        Dim url As Long
        Dim uint As Long
        Dim a_loan As Long
        Dim rm_loan As Long
        Dim i_amt As Long
        Dim l_id As Long
        Dim i_loan As Long

        Dim i As Integer

        i = 0

        Do While (i <= tbl.Rows.Count())

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            str = "select * from loan_repay"

            cmd = New SqlCommand(str, cn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds)
            tbl = ds.Tables(0)

            a_loan = ds.Tables(0).Rows(i).Item("a_loan")
            rm_loan = ds.Tables(0).Rows(i).Item("rm_loan")
            i_amt = ds.Tables(0).Rows(i).Item("i_amt")
            l_id = ds.Tables(0).Rows(i).Item("l_id")

            str = "select * from loan"

            cmd = New SqlCommand(str, cn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds)
            tbl1 = ds.Tables(0)

            i_loan = ds.Tables(0).Rows(i).Item("i_loan")

            intrest = a_loan * ((i_loan / 100) / 12)
            uint = i_amt + intrest
            url = rm_loan + intrest

            str = "update loan_repay set i_amt='" & uint & "',rm_loan='" & url & "' where l_id='" & l_id & "'"

            cmd = New SqlCommand(str, cn)
            cn.Open()
            cmd.ExecuteNonQuery()

            If i + 1 >= tbl.Rows.Count() Then
                Exit Do
            Else
                i = i + 1
            End If

            a_loan = 0
            rm_loan = 0
            i_amt = 0
            l_id = 0
            i_loan = 0
            intrest = 0
            uint = 0
            url = 0

        Loop
        Label4.Text = "intrest of all loan is calculated"
        Label4.ForeColor = Color.Green
    End Sub

End Class