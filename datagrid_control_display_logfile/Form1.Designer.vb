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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuCopyPaste1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuCopyPaste2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkboxDO = New System.Windows.Forms.CheckBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch2 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplayPdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.Error2LetterLegendsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuOptima = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuXRD = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuDefinium = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuMammo = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuOther = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.txtHide = New System.Windows.Forms.TextBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvData.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvData.Location = New System.Drawing.Point(12, 97)
        Me.dgvData.MultiSelect = False
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.Size = New System.Drawing.Size(975, 593)
        Me.dgvData.TabIndex = 0
        Me.dgvData.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuCopyPaste1, Me.cmnuCopyPaste2, Me.cmnuHide, Me.cmnuCopy})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(218, 92)
        '
        'cmnuCopyPaste1
        '
        Me.cmnuCopyPaste1.Name = "cmnuCopyPaste1"
        Me.cmnuCopyPaste1.Size = New System.Drawing.Size(217, 22)
        Me.cmnuCopyPaste1.Text = "Copy and Paste to Search 1"
        '
        'cmnuCopyPaste2
        '
        Me.cmnuCopyPaste2.Name = "cmnuCopyPaste2"
        Me.cmnuCopyPaste2.Size = New System.Drawing.Size(217, 22)
        Me.cmnuCopyPaste2.Text = "Copy and Paste to Search 2"
        '
        'cmnuHide
        '
        Me.cmnuHide.Name = "cmnuHide"
        Me.cmnuHide.Size = New System.Drawing.Size(217, 22)
        Me.cmnuHide.Text = "Copy and Paste to Hide"
        '
        'cmnuCopy
        '
        Me.cmnuCopy.Name = "cmnuCopy"
        Me.cmnuCopy.Size = New System.Drawing.Size(217, 22)
        Me.cmnuCopy.Text = "Copy"
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.SystemColors.Control
        Me.btnLoad.Location = New System.Drawing.Point(12, 30)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(297, 24)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Selects file then loads error log"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Hide DO = debug only"
        '
        'chkboxDO
        '
        Me.chkboxDO.AutoSize = True
        Me.chkboxDO.Location = New System.Drawing.Point(6, 16)
        Me.chkboxDO.Name = "chkboxDO"
        Me.chkboxDO.Size = New System.Drawing.Size(15, 14)
        Me.chkboxDO.TabIndex = 2
        Me.chkboxDO.TabStop = False
        Me.chkboxDO.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.BackColor = System.Drawing.SystemColors.Control
        Me.btnSort.Enabled = False
        Me.btnSort.Location = New System.Drawing.Point(12, 67)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(297, 24)
        Me.btnSort.TabIndex = 1
        Me.btnSort.Text = "Show All"
        Me.btnSort.UseVisualStyleBackColor = False
        '
        'btnAnalyze
        '
        Me.btnAnalyze.BackColor = System.Drawing.SystemColors.Control
        Me.btnAnalyze.Enabled = False
        Me.btnAnalyze.Location = New System.Drawing.Point(847, 31)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(140, 24)
        Me.btnAnalyze.TabIndex = 5
        Me.btnAnalyze.Text = "Analyze"
        Me.btnAnalyze.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtSearch.Location = New System.Drawing.Point(6, 19)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(110, 20)
        Me.txtSearch.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.Enabled = False
        Me.btnSearch.Location = New System.Drawing.Point(847, 68)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(140, 24)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search for Errors"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSearch2
        '
        Me.txtSearch2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtSearch2.Location = New System.Drawing.Point(131, 19)
        Me.txtSearch2.Name = "txtSearch2"
        Me.txtSearch2.Size = New System.Drawing.Size(110, 20)
        Me.txtSearch2.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.FilterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(999, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuDisplayPdf, Me.Error2LetterLegendsToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem1.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(217, 22)
        Me.mnuAbout.Text = "About"
        '
        'mnuDisplayPdf
        '
        Me.mnuDisplayPdf.Name = "mnuDisplayPdf"
        Me.mnuDisplayPdf.Size = New System.Drawing.Size(217, 22)
        Me.mnuDisplayPdf.Text = "How to download Error log"
        '
        'Error2LetterLegendsToolStripMenuItem
        '
        Me.Error2LetterLegendsToolStripMenuItem.Name = "Error2LetterLegendsToolStripMenuItem"
        Me.Error2LetterLegendsToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.Error2LetterLegendsToolStripMenuItem.Text = "Error 2 letter Legends"
        '
        'FilterToolStripMenuItem
        '
        Me.FilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuOptima, Me.cmnuXRD, Me.cmnuDefinium, Me.cmnuMammo, Me.cmnuOther})
        Me.FilterToolStripMenuItem.Name = "FilterToolStripMenuItem"
        Me.FilterToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.FilterToolStripMenuItem.Text = "Filter"
        '
        'cmnuOptima
        '
        Me.cmnuOptima.Enabled = False
        Me.cmnuOptima.Name = "cmnuOptima"
        Me.cmnuOptima.Size = New System.Drawing.Size(185, 22)
        Me.cmnuOptima.Text = "Optima"
        '
        'cmnuXRD
        '
        Me.cmnuXRD.Enabled = False
        Me.cmnuXRD.Name = "cmnuXRD"
        Me.cmnuXRD.Size = New System.Drawing.Size(185, 22)
        Me.cmnuXRD.Text = "XRD"
        '
        'cmnuDefinium
        '
        Me.cmnuDefinium.Enabled = False
        Me.cmnuDefinium.Name = "cmnuDefinium"
        Me.cmnuDefinium.Size = New System.Drawing.Size(185, 22)
        Me.cmnuDefinium.Text = "Definium / Discovery"
        '
        'cmnuMammo
        '
        Me.cmnuMammo.Enabled = False
        Me.cmnuMammo.Name = "cmnuMammo"
        Me.cmnuMammo.Size = New System.Drawing.Size(185, 22)
        Me.cmnuMammo.Text = "Mammo"
        '
        'cmnuOther
        '
        Me.cmnuOther.Enabled = False
        Me.cmnuOther.Name = "cmnuOther"
        Me.cmnuOther.Size = New System.Drawing.Size(185, 22)
        Me.cmnuOther.Text = "Other"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch2)
        Me.GroupBox1.Location = New System.Drawing.Point(583, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 61)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Show these Errors"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnHide)
        Me.GroupBox2.Controls.Add(Me.txtHide)
        Me.GroupBox2.Controls.Add(Me.chkboxDO)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(315, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(238, 61)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hide these Errors"
        '
        'btnHide
        '
        Me.btnHide.BackColor = System.Drawing.SystemColors.Control
        Me.btnHide.Enabled = False
        Me.btnHide.Location = New System.Drawing.Point(122, 31)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(98, 24)
        Me.btnHide.TabIndex = 11
        Me.btnHide.Text = "Hide this Error"
        Me.btnHide.UseVisualStyleBackColor = False
        '
        'txtHide
        '
        Me.txtHide.ContextMenuStrip = Me.ContextMenuStrip1
        Me.txtHide.Location = New System.Drawing.Point(6, 35)
        Me.txtHide.Name = "txtHide"
        Me.txtHide.Size = New System.Drawing.Size(110, 20)
        Me.txtHide.TabIndex = 4
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(999, 702)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvData)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Error Log Reader for Definium 8K"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkboxDO As System.Windows.Forms.CheckBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents btnAnalyze As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch2 As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDisplayPdf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuCopyPaste1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuCopyPaste2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Error2LetterLegendsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHide As System.Windows.Forms.TextBox
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents cmnuHide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuOptima As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuXRD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuDefinium As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuMammo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuOther As System.Windows.Forms.ToolStripMenuItem

End Class
