<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSetIP = New System.Windows.Forms.Button()
        Me.btnTestPing = New System.Windows.Forms.Button()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtSM = New System.Windows.Forms.TextBox()
        Me.txtGW = New System.Windows.Forms.TextBox()
        Me.txtTest1 = New System.Windows.Forms.TextBox()
        Me.txtTest2 = New System.Windows.Forms.TextBox()
        Me.txtTest3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblCurrIP = New System.Windows.Forms.Label()
        Me.lblCurrGW = New System.Windows.Forms.Label()
        Me.lblCurrSM = New System.Windows.Forms.Label()
        Me.lblAdapter = New System.Windows.Forms.Label()
        Me.cmbAdapters = New System.Windows.Forms.ComboBox()
        Me.btnAdaptRef = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSetIP
        '
        Me.btnSetIP.Location = New System.Drawing.Point(236, 34)
        Me.btnSetIP.Name = "btnSetIP"
        Me.btnSetIP.Size = New System.Drawing.Size(75, 20)
        Me.btnSetIP.TabIndex = 0
        Me.btnSetIP.Text = "Set IP"
        Me.btnSetIP.UseVisualStyleBackColor = True
        '
        'btnTestPing
        '
        Me.btnTestPing.Location = New System.Drawing.Point(236, 60)
        Me.btnTestPing.Name = "btnTestPing"
        Me.btnTestPing.Size = New System.Drawing.Size(75, 23)
        Me.btnTestPing.TabIndex = 1
        Me.btnTestPing.Text = "Test Ping"
        Me.btnTestPing.UseVisualStyleBackColor = True
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(78, 34)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(152, 20)
        Me.txtIP.TabIndex = 2
        '
        'txtSM
        '
        Me.txtSM.Location = New System.Drawing.Point(78, 60)
        Me.txtSM.Name = "txtSM"
        Me.txtSM.Size = New System.Drawing.Size(152, 20)
        Me.txtSM.TabIndex = 3
        '
        'txtGW
        '
        Me.txtGW.Location = New System.Drawing.Point(78, 86)
        Me.txtGW.Name = "txtGW"
        Me.txtGW.Size = New System.Drawing.Size(152, 20)
        Me.txtGW.TabIndex = 4
        '
        'txtTest1
        '
        Me.txtTest1.Location = New System.Drawing.Point(78, 112)
        Me.txtTest1.Name = "txtTest1"
        Me.txtTest1.Size = New System.Drawing.Size(152, 20)
        Me.txtTest1.TabIndex = 5
        '
        'txtTest2
        '
        Me.txtTest2.Location = New System.Drawing.Point(78, 138)
        Me.txtTest2.Name = "txtTest2"
        Me.txtTest2.Size = New System.Drawing.Size(152, 20)
        Me.txtTest2.TabIndex = 6
        '
        'txtTest3
        '
        Me.txtTest3.Location = New System.Drawing.Point(78, 164)
        Me.txtTest3.Name = "txtTest3"
        Me.txtTest3.Size = New System.Drawing.Size(152, 20)
        Me.txtTest3.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "IP Addr"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Subnet"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "GW Addr"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Test 1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Test 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Test 3"
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.Enabled = False
        Me.txtLog.Location = New System.Drawing.Point(12, 194)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(533, 193)
        Me.txtLog.TabIndex = 14
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(236, 84)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear Log"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(236, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 20)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(236, 138)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 20)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(236, 164)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 20)
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'lblCurrIP
        '
        Me.lblCurrIP.AutoSize = True
        Me.lblCurrIP.Location = New System.Drawing.Point(317, 38)
        Me.lblCurrIP.Name = "lblCurrIP"
        Me.lblCurrIP.Size = New System.Drawing.Size(16, 13)
        Me.lblCurrIP.TabIndex = 19
        Me.lblCurrIP.Text = "---"
        '
        'lblCurrGW
        '
        Me.lblCurrGW.AutoSize = True
        Me.lblCurrGW.Location = New System.Drawing.Point(317, 89)
        Me.lblCurrGW.Name = "lblCurrGW"
        Me.lblCurrGW.Size = New System.Drawing.Size(16, 13)
        Me.lblCurrGW.TabIndex = 20
        Me.lblCurrGW.Text = "---"
        '
        'lblCurrSM
        '
        Me.lblCurrSM.AutoSize = True
        Me.lblCurrSM.Location = New System.Drawing.Point(317, 66)
        Me.lblCurrSM.Name = "lblCurrSM"
        Me.lblCurrSM.Size = New System.Drawing.Size(16, 13)
        Me.lblCurrSM.TabIndex = 21
        Me.lblCurrSM.Text = "---"
        '
        'lblAdapter
        '
        Me.lblAdapter.AutoSize = True
        Me.lblAdapter.Location = New System.Drawing.Point(12, 9)
        Me.lblAdapter.Name = "lblAdapter"
        Me.lblAdapter.Size = New System.Drawing.Size(44, 13)
        Me.lblAdapter.TabIndex = 22
        Me.lblAdapter.Text = "Adapter"
        '
        'cmbAdapters
        '
        Me.cmbAdapters.FormattingEnabled = True
        Me.cmbAdapters.Location = New System.Drawing.Point(78, 6)
        Me.cmbAdapters.MaxDropDownItems = 12
        Me.cmbAdapters.Name = "cmbAdapters"
        Me.cmbAdapters.Size = New System.Drawing.Size(233, 21)
        Me.cmbAdapters.TabIndex = 23
        '
        'btnAdaptRef
        '
        Me.btnAdaptRef.Location = New System.Drawing.Point(320, 4)
        Me.btnAdaptRef.Name = "btnAdaptRef"
        Me.btnAdaptRef.Size = New System.Drawing.Size(115, 23)
        Me.btnAdaptRef.TabIndex = 24
        Me.btnAdaptRef.Text = "Adapter Refresh"
        Me.btnAdaptRef.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 399)
        Me.Controls.Add(Me.btnAdaptRef)
        Me.Controls.Add(Me.cmbAdapters)
        Me.Controls.Add(Me.lblAdapter)
        Me.Controls.Add(Me.lblCurrSM)
        Me.Controls.Add(Me.lblCurrGW)
        Me.Controls.Add(Me.lblCurrIP)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTest3)
        Me.Controls.Add(Me.txtTest2)
        Me.Controls.Add(Me.txtTest1)
        Me.Controls.Add(Me.txtGW)
        Me.Controls.Add(Me.txtSM)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.btnTestPing)
        Me.Controls.Add(Me.btnSetIP)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSetIP As Button
    Friend WithEvents btnTestPing As Button
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtSM As TextBox
    Friend WithEvents txtGW As TextBox
    Friend WithEvents txtTest1 As TextBox
    Friend WithEvents txtTest2 As TextBox
    Friend WithEvents txtTest3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLog As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblCurrIP As Label
    Friend WithEvents lblCurrGW As Label
    Friend WithEvents lblCurrSM As Label
    Friend WithEvents lblAdapter As Label
    Friend WithEvents cmbAdapters As ComboBox
    Friend WithEvents btnAdaptRef As Button
End Class
