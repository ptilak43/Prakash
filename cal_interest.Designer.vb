<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cal_interest
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AccnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AhnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddharnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsbalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountholderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterDataSet4 = New bank_management_system.masterDataSet4()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AloanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccnoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RmloanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoanrepayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MasterDataSet5 = New bank_management_system.masterDataSet5()
        Me.BACK = New System.Windows.Forms.Button()
        Me.Account_holderTableAdapter = New bank_management_system.masterDataSet4TableAdapters.account_holderTableAdapter()
        Me.Loan_repayTableAdapter = New bank_management_system.masterDataSet5TableAdapters.loan_repayTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountholderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanrepayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1.Calculate Saving Account Intrest"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(703, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2.Calculate Loan Intrest"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(724, 98)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccnoDataGridViewTextBoxColumn, Me.AhnameDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.ConnumDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.AddharnumDataGridViewTextBoxColumn, Me.InsbalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AccountholderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(42, 175)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(415, 219)
        Me.DataGridView1.TabIndex = 4
        '
        'AccnoDataGridViewTextBoxColumn
        '
        Me.AccnoDataGridViewTextBoxColumn.DataPropertyName = "acc_no"
        Me.AccnoDataGridViewTextBoxColumn.HeaderText = "acc_no"
        Me.AccnoDataGridViewTextBoxColumn.Name = "AccnoDataGridViewTextBoxColumn"
        '
        'AhnameDataGridViewTextBoxColumn
        '
        Me.AhnameDataGridViewTextBoxColumn.DataPropertyName = "ah_name"
        Me.AhnameDataGridViewTextBoxColumn.HeaderText = "ah_name"
        Me.AhnameDataGridViewTextBoxColumn.Name = "AhnameDataGridViewTextBoxColumn"
        '
        'DobDataGridViewTextBoxColumn
        '
        Me.DobDataGridViewTextBoxColumn.DataPropertyName = "dob"
        Me.DobDataGridViewTextBoxColumn.HeaderText = "dob"
        Me.DobDataGridViewTextBoxColumn.Name = "DobDataGridViewTextBoxColumn"
        '
        'ConnumDataGridViewTextBoxColumn
        '
        Me.ConnumDataGridViewTextBoxColumn.DataPropertyName = "con_num"
        Me.ConnumDataGridViewTextBoxColumn.HeaderText = "con_num"
        Me.ConnumDataGridViewTextBoxColumn.Name = "ConnumDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'AddharnumDataGridViewTextBoxColumn
        '
        Me.AddharnumDataGridViewTextBoxColumn.DataPropertyName = "addhar_num"
        Me.AddharnumDataGridViewTextBoxColumn.HeaderText = "addhar_num"
        Me.AddharnumDataGridViewTextBoxColumn.Name = "AddharnumDataGridViewTextBoxColumn"
        '
        'InsbalDataGridViewTextBoxColumn
        '
        Me.InsbalDataGridViewTextBoxColumn.DataPropertyName = "ins_bal"
        Me.InsbalDataGridViewTextBoxColumn.HeaderText = "ins_bal"
        Me.InsbalDataGridViewTextBoxColumn.Name = "InsbalDataGridViewTextBoxColumn"
        '
        'AccountholderBindingSource
        '
        Me.AccountholderBindingSource.DataMember = "account_holder"
        Me.AccountholderBindingSource.DataSource = Me.MasterDataSet4
        '
        'MasterDataSet4
        '
        Me.MasterDataSet4.DataSetName = "masterDataSet4"
        Me.MasterDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LidDataGridViewTextBoxColumn, Me.IamtDataGridViewTextBoxColumn, Me.AloanDataGridViewTextBoxColumn, Me.AccnoDataGridViewTextBoxColumn1, Me.RmloanDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.LoanrepayBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(571, 175)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(414, 219)
        Me.DataGridView2.TabIndex = 5
        '
        'LidDataGridViewTextBoxColumn
        '
        Me.LidDataGridViewTextBoxColumn.DataPropertyName = "l_id"
        Me.LidDataGridViewTextBoxColumn.HeaderText = "l_id"
        Me.LidDataGridViewTextBoxColumn.Name = "LidDataGridViewTextBoxColumn"
        '
        'IamtDataGridViewTextBoxColumn
        '
        Me.IamtDataGridViewTextBoxColumn.DataPropertyName = "i_amt"
        Me.IamtDataGridViewTextBoxColumn.HeaderText = "i_amt"
        Me.IamtDataGridViewTextBoxColumn.Name = "IamtDataGridViewTextBoxColumn"
        '
        'AloanDataGridViewTextBoxColumn
        '
        Me.AloanDataGridViewTextBoxColumn.DataPropertyName = "a_loan"
        Me.AloanDataGridViewTextBoxColumn.HeaderText = "a_loan"
        Me.AloanDataGridViewTextBoxColumn.Name = "AloanDataGridViewTextBoxColumn"
        '
        'AccnoDataGridViewTextBoxColumn1
        '
        Me.AccnoDataGridViewTextBoxColumn1.DataPropertyName = "acc_no"
        Me.AccnoDataGridViewTextBoxColumn1.HeaderText = "acc_no"
        Me.AccnoDataGridViewTextBoxColumn1.Name = "AccnoDataGridViewTextBoxColumn1"
        '
        'RmloanDataGridViewTextBoxColumn
        '
        Me.RmloanDataGridViewTextBoxColumn.DataPropertyName = "rm_loan"
        Me.RmloanDataGridViewTextBoxColumn.HeaderText = "rm_loan"
        Me.RmloanDataGridViewTextBoxColumn.Name = "RmloanDataGridViewTextBoxColumn"
        '
        'LoanrepayBindingSource
        '
        Me.LoanrepayBindingSource.DataMember = "loan_repay"
        Me.LoanrepayBindingSource.DataSource = Me.MasterDataSet5
        '
        'MasterDataSet5
        '
        Me.MasterDataSet5.DataSetName = "masterDataSet5"
        Me.MasterDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BACK
        '
        Me.BACK.Location = New System.Drawing.Point(12, 12)
        Me.BACK.Name = "BACK"
        Me.BACK.Size = New System.Drawing.Size(75, 23)
        Me.BACK.TabIndex = 37
        Me.BACK.Text = "BACK"
        Me.BACK.UseVisualStyleBackColor = True
        '
        'Account_holderTableAdapter
        '
        Me.Account_holderTableAdapter.ClearBeforeFill = True
        '
        'Loan_repayTableAdapter
        '
        Me.Loan_repayTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(742, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 39
        '
        'cal_interest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 440)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BACK)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cal_interest"
        Me.Text = "Form9"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountholderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanrepayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents BACK As System.Windows.Forms.Button
    Friend WithEvents MasterDataSet4 As bank_management_system.masterDataSet4
    Friend WithEvents AccountholderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Account_holderTableAdapter As bank_management_system.masterDataSet4TableAdapters.account_holderTableAdapter
    Friend WithEvents AccnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AhnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddharnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsbalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MasterDataSet5 As bank_management_system.masterDataSet5
    Friend WithEvents LoanrepayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Loan_repayTableAdapter As bank_management_system.masterDataSet5TableAdapters.loan_repayTableAdapter
    Friend WithEvents LidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IamtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AloanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccnoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RmloanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
