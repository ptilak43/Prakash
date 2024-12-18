Public Class home

    Private Sub OpenAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAccountToolStripMenuItem.Click
        Me.Hide()
        acc_open.Show()
    End Sub

    Private Sub CloseAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAccountToolStripMenuItem.Click
        Me.Hide()
        acc_close.Show()
    End Sub

    Private Sub ApplyForLoanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApplyForLoanToolStripMenuItem.Click
        Me.Hide()
        loan.Show()
    End Sub

    Private Sub RepayLoanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepayLoanToolStripMenuItem.Click
        Me.Hide()
        loanrepay.Show()
    End Sub

    Private Sub DoATransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoATransactionToolStripMenuItem.Click
        Me.Hide()
        transaction.Show()
    End Sub

    Private Sub CalculateInterestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateInterestToolStripMenuItem.Click
        Me.Hide()
        cal_interest.Show()
    End Sub

    Private Sub ViewDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDataToolStripMenuItem.Click
        Me.Hide()
        viewdata.Show()
    End Sub

    Private Function accc_close() As Object
        Throw New NotImplementedException
    End Function

End Class