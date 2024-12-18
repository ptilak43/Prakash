<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewdata
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.BACK = New System.Windows.Forms.Button()
        Me.MasterDataSet = New bank_management_system.masterDataSet()
        Me.AccountholderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Account_holderTableAdapter = New bank_management_system.masterDataSetTableAdapters.account_holderTableAdapter()
        Me.AccnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AhnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddharnumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InsbalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasterDataSet1 = New bank_management_system.masterDataSet1()
        Me.LoanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoanTableAdapter = New bank_management_system.masterDataSet1TableAdapters.loanTableAdapter()
        Me.LidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccnoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IpmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AloanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DloanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IloanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasterDataSet2 = New bank_management_system.masterDataSet2()
        Me.LoanrepayBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Loan_repayTableAdapter = New bank_management_system.masterDataSet2TableAdapters.loan_repayTableAdapter()
        Me.MasterDataSet3 = New bank_management_system.masterDataSet3()
        Me.TransctionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransctionTableAdapter = New bank_management_system.masterDataSet3TableAdapters.transctionTableAdapter()
        Me.LidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AloanDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccnoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RmloanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccnoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountholderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoanrepayBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransctionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(506, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "View Data Form"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1.Account Holder Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(814, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2.Loan Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(227, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "3.Transcation Data"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(814, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "4.Loan Repay Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccnoDataGridViewTextBoxColumn, Me.AhnameDataGridViewTextBoxColumn, Me.DobDataGridViewTextBoxColumn, Me.ConnumDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.AddharnumDataGridViewTextBoxColumn, Me.InsbalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AccountholderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(54, 115)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(447, 211)
        Me.DataGridView1.TabIndex = 5
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LidDataGridViewTextBoxColumn, Me.AccnoDataGridViewTextBoxColumn1, Me.IpmDataGridViewTextBoxColumn, Me.AloanDataGridViewTextBoxColumn, Me.DloanDataGridViewTextBoxColumn, Me.IloanDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.LoanBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(617, 115)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(447, 211)
        Me.DataGridView2.TabIndex = 6
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LidDataGridViewTextBoxColumn1, Me.IamtDataGridViewTextBoxColumn, Me.AloanDataGridViewTextBoxColumn1, Me.AccnoDataGridViewTextBoxColumn3, Me.RmloanDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.LoanrepayBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(617, 387)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(447, 211)
        Me.DataGridView3.TabIndex = 7
        '
        'DataGridView4
        '
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TidDataGridViewTextBoxColumn, Me.AccnoDataGridViewTextBoxColumn2, Me.TotDataGridViewTextBoxColumn, Me.AmtDataGridViewTextBoxColumn, Me.TtDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.TransctionBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(54, 387)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(447, 211)
        Me.DataGridView4.TabIndex = 8
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
        'MasterDataSet
        '
        Me.MasterDataSet.DataSetName = "masterDataSet"
        Me.MasterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountholderBindingSource
        '
        Me.AccountholderBindingSource.DataMember = "account_holder"
        Me.AccountholderBindingSource.DataSource = Me.MasterDataSet
        '
        'Account_holderTableAdapter
        '
        Me.Account_holderTableAdapter.ClearBeforeFill = True
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
        'MasterDataSet1
        '
        Me.MasterDataSet1.DataSetName = "masterDataSet1"
        Me.MasterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoanBindingSource
        '
        Me.LoanBindingSource.DataMember = "loan"
        Me.LoanBindingSource.DataSource = Me.MasterDataSet1
        '
        'LoanTableAdapter
        '
        Me.LoanTableAdapter.ClearBeforeFill = True
        '
        'LidDataGridViewTextBoxColumn
        '
        Me.LidDataGridViewTextBoxColumn.DataPropertyName = "l_id"
        Me.LidDataGridViewTextBoxColumn.HeaderText = "l_id"
        Me.LidDataGridViewTextBoxColumn.Name = "LidDataGridViewTextBoxColumn"
        '
        'AccnoDataGridViewTextBoxColumn1
        '
        Me.AccnoDataGridViewTextBoxColumn1.DataPropertyName = "acc_no"
        Me.AccnoDataGridViewTextBoxColumn1.HeaderText = "acc_no"
        Me.AccnoDataGridViewTextBoxColumn1.Name = "AccnoDataGridViewTextBoxColumn1"
        '
        'IpmDataGridViewTextBoxColumn
        '
        Me.IpmDataGridViewTextBoxColumn.DataPropertyName = "ipm"
        Me.IpmDataGridViewTextBoxColumn.HeaderText = "ipm"
        Me.IpmDataGridViewTextBoxColumn.Name = "IpmDataGridViewTextBoxColumn"
        '
        'AloanDataGridViewTextBoxColumn
        '
        Me.AloanDataGridViewTextBoxColumn.DataPropertyName = "a_loan"
        Me.AloanDataGridViewTextBoxColumn.HeaderText = "a_loan"
        Me.AloanDataGridViewTextBoxColumn.Name = "AloanDataGridViewTextBoxColumn"
        '
        'DloanDataGridViewTextBoxColumn
        '
        Me.DloanDataGridViewTextBoxColumn.DataPropertyName = "d_loan"
        Me.DloanDataGridViewTextBoxColumn.HeaderText = "d_loan"
        Me.DloanDataGridViewTextBoxColumn.Name = "DloanDataGridViewTextBoxColumn"
        '
        'IloanDataGridViewTextBoxColumn
        '
        Me.IloanDataGridViewTextBoxColumn.DataPropertyName = "i_loan"
        Me.IloanDataGridViewTextBoxColumn.HeaderText = "i_loan"
        Me.IloanDataGridViewTextBoxColumn.Name = "IloanDataGridViewTextBoxColumn"
        '
        'MasterDataSet2
        '
        Me.MasterDataSet2.DataSetName = "masterDataSet2"
        Me.MasterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoanrepayBindingSource
        '
        Me.LoanrepayBindingSource.DataMember = "loan_repay"
        Me.LoanrepayBindingSource.DataSource = Me.MasterDataSet2
        '
        'Loan_repayTableAdapter
        '
        Me.Loan_repayTableAdapter.ClearBeforeFill = True
        '
        'MasterDataSet3
        '
        Me.MasterDataSet3.DataSetName = "masterDataSet3"
        Me.MasterDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TransctionBindingSource
        '
        Me.TransctionBindingSource.DataMember = "transction"
        Me.TransctionBindingSource.DataSource = Me.MasterDataSet3
        '
        'TransctionTableAdapter
        '
        Me.TransctionTableAdapter.ClearBeforeFill = True
        '
        'LidDataGridViewTextBoxColumn1
        '
        Me.LidDataGridViewTextBoxColumn1.DataPropertyName = "l_id"
        Me.LidDataGridViewTextBoxColumn1.HeaderText = "l_id"
        Me.LidDataGridViewTextBoxColumn1.Name = "LidDataGridViewTextBoxColumn1"
        '
        'IamtDataGridViewTextBoxColumn
        '
        Me.IamtDataGridViewTextBoxColumn.DataPropertyName = "i_amt"
        Me.IamtDataGridViewTextBoxColumn.HeaderText = "i_amt"
        Me.IamtDataGridViewTextBoxColumn.Name = "IamtDataGridViewTextBoxColumn"
        '
        'AloanDataGridViewTextBoxColumn1
        '
        Me.AloanDataGridViewTextBoxColumn1.DataPropertyName = "a_loan"
        Me.AloanDataGridViewTextBoxColumn1.HeaderText = "a_loan"
        Me.AloanDataGridViewTextBoxColumn1.Name = "AloanDataGridViewTextBoxColumn1"
        '
        'AccnoDataGridViewTextBoxColumn3
        '
        Me.AccnoDataGridViewTextBoxColumn3.DataPropertyName = "acc_no"
        Me.AccnoDataGridViewTextBoxColumn3.HeaderText = "acc_no"
        Me.AccnoDataGridViewTextBoxColumn3.Name = "AccnoDataGridViewTextBoxColumn3"
        '
        'RmloanDataGridViewTextBoxColumn
        '
        Me.RmloanDataGridViewTextBoxColumn.DataPropertyName = "rm_loan"
        Me.RmloanDataGridViewTextBoxColumn.HeaderText = "rm_loan"
        Me.RmloanDataGridViewTextBoxColumn.Name = "RmloanDataGridViewTextBoxColumn"
        '
        'TidDataGridViewTextBoxColumn
        '
        Me.TidDataGridViewTextBoxColumn.DataPropertyName = "t_id"
        Me.TidDataGridViewTextBoxColumn.HeaderText = "t_id"
        Me.TidDataGridViewTextBoxColumn.Name = "TidDataGridViewTextBoxColumn"
        '
        'AccnoDataGridViewTextBoxColumn2
        '
        Me.AccnoDataGridViewTextBoxColumn2.DataPropertyName = "acc_no"
        Me.AccnoDataGridViewTextBoxColumn2.HeaderText = "acc_no"
        Me.AccnoDataGridViewTextBoxColumn2.Name = "AccnoDataGridViewTextBoxColumn2"
        '
        'TotDataGridViewTextBoxColumn
        '
        Me.TotDataGridViewTextBoxColumn.DataPropertyName = "tot"
        Me.TotDataGridViewTextBoxColumn.HeaderText = "tot"
        Me.TotDataGridViewTextBoxColumn.Name = "TotDataGridViewTextBoxColumn"
        '
        'AmtDataGridViewTextBoxColumn
        '
        Me.AmtDataGridViewTextBoxColumn.DataPropertyName = "amt"
        Me.AmtDataGridViewTextBoxColumn.HeaderText = "amt"
        Me.AmtDataGridViewTextBoxColumn.Name = "AmtDataGridViewTextBoxColumn"
        '
        'TtDataGridViewTextBoxColumn
        '
        Me.TtDataGridViewTextBoxColumn.DataPropertyName = "tt"
        Me.TtDataGridViewTextBoxColumn.HeaderText = "tt"
        Me.TtDataGridViewTextBoxColumn.Name = "TtDataGridViewTextBoxColumn"
        '
        'viewdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 611)
        Me.Controls.Add(Me.BACK)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "viewdata"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountholderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoanrepayBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransctionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents BACK As System.Windows.Forms.Button
    Friend WithEvents MasterDataSet As bank_management_system.masterDataSet
    Friend WithEvents AccountholderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Account_holderTableAdapter As bank_management_system.masterDataSetTableAdapters.account_holderTableAdapter
    Friend WithEvents AccnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AhnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddharnumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InsbalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MasterDataSet1 As bank_management_system.masterDataSet1
    Friend WithEvents LoanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoanTableAdapter As bank_management_system.masterDataSet1TableAdapters.loanTableAdapter
    Friend WithEvents LidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccnoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IpmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AloanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DloanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IloanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MasterDataSet2 As bank_management_system.masterDataSet2
    Friend WithEvents LoanrepayBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Loan_repayTableAdapter As bank_management_system.masterDataSet2TableAdapters.loan_repayTableAdapter
    Friend WithEvents MasterDataSet3 As bank_management_system.masterDataSet3
    Friend WithEvents TransctionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TransctionTableAdapter As bank_management_system.masterDataSet3TableAdapters.transctionTableAdapter
    Friend WithEvents LidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IamtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AloanDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccnoDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RmloanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccnoDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
