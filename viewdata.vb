Public Class viewdata

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub DataGridView4_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView4.CellContentClick

    End Sub

    Private Sub DataGridView3_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub BACK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BACK.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub viewdata_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MasterDataSet3.transction' table. You can move, or remove it, as needed.
        Me.TransctionTableAdapter.Fill(Me.MasterDataSet3.transction)
        'TODO: This line of code loads data into the 'MasterDataSet2.loan_repay' table. You can move, or remove it, as needed.
        Me.Loan_repayTableAdapter.Fill(Me.MasterDataSet2.loan_repay)
        'TODO: This line of code loads data into the 'MasterDataSet1.loan' table. You can move, or remove it, as needed.
        Me.LoanTableAdapter.Fill(Me.MasterDataSet1.loan)
        'TODO: This line of code loads data into the 'MasterDataSet.account_holder' table. You can move, or remove it, as needed.
        Me.Account_holderTableAdapter.Fill(Me.MasterDataSet.account_holder)

    End Sub
End Class