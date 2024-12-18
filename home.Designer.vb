<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplyForLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepayLoanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoATransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateInterestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(626, 23)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenAccountToolStripMenuItem, Me.CloseAccountToolStripMenuItem, Me.ApplyForLoanToolStripMenuItem, Me.RepayLoanToolStripMenuItem, Me.DoATransactionToolStripMenuItem, Me.CalculateInterestToolStripMenuItem, Me.ViewDataToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(26, 19)
        Me.ToolStripMenuItem1.Text = "#"
        '
        'OpenAccountToolStripMenuItem
        '
        Me.OpenAccountToolStripMenuItem.Name = "OpenAccountToolStripMenuItem"
        Me.OpenAccountToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.OpenAccountToolStripMenuItem.Text = "Open Account"
        '
        'CloseAccountToolStripMenuItem
        '
        Me.CloseAccountToolStripMenuItem.Name = "CloseAccountToolStripMenuItem"
        Me.CloseAccountToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CloseAccountToolStripMenuItem.Text = "Close Account"
        '
        'ApplyForLoanToolStripMenuItem
        '
        Me.ApplyForLoanToolStripMenuItem.Name = "ApplyForLoanToolStripMenuItem"
        Me.ApplyForLoanToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ApplyForLoanToolStripMenuItem.Text = "Apply for Loan"
        '
        'RepayLoanToolStripMenuItem
        '
        Me.RepayLoanToolStripMenuItem.Name = "RepayLoanToolStripMenuItem"
        Me.RepayLoanToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RepayLoanToolStripMenuItem.Text = "Repay Loan"
        '
        'DoATransactionToolStripMenuItem
        '
        Me.DoATransactionToolStripMenuItem.Name = "DoATransactionToolStripMenuItem"
        Me.DoATransactionToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DoATransactionToolStripMenuItem.Text = "Do a Transaction "
        '
        'CalculateInterestToolStripMenuItem
        '
        Me.CalculateInterestToolStripMenuItem.Name = "CalculateInterestToolStripMenuItem"
        Me.CalculateInterestToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CalculateInterestToolStripMenuItem.Text = "Calculate Interest"
        '
        'ViewDataToolStripMenuItem
        '
        Me.ViewDataToolStripMenuItem.Name = "ViewDataToolStripMenuItem"
        Me.ViewDataToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ViewDataToolStripMenuItem.Text = "View Data"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 384)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "home"
        Me.Text = "Form7"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyForLoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepayLoanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DoATransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateInterestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
