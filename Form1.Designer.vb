<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        DeTabBtn = New Button()
        EnTabBtn = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        CloseBtn = New Button()
        ClearBtn = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        EnOutput = New TextBox()
        EncodeBtn = New Button()
        EnKey = New TextBox()
        EnText = New TextBox()
        TabPage2 = New TabPage()
        Button2 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        DeOutput = New TextBox()
        DecodeBtn = New Button()
        DeKey = New TextBox()
        DeText = New TextBox()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(DeTabBtn)
        Panel1.Controls.Add(EnTabBtn)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(529, 50)
        Panel1.TabIndex = 0
        ' 
        ' DeTabBtn
        ' 
        DeTabBtn.Dock = DockStyle.Left
        DeTabBtn.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        DeTabBtn.Location = New Point(140, 0)
        DeTabBtn.Name = "DeTabBtn"
        DeTabBtn.Size = New Size(140, 50)
        DeTabBtn.TabIndex = 1
        DeTabBtn.Text = "DECODE"
        DeTabBtn.UseVisualStyleBackColor = True
        ' 
        ' EnTabBtn
        ' 
        EnTabBtn.Dock = DockStyle.Left
        EnTabBtn.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        EnTabBtn.Location = New Point(0, 0)
        EnTabBtn.Name = "EnTabBtn"
        EnTabBtn.Size = New Size(140, 50)
        EnTabBtn.TabIndex = 0
        EnTabBtn.Text = "ENCODE"
        EnTabBtn.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(-11, 16)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(552, 482)
        TabControl1.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Black
        TabPage1.Controls.Add(CloseBtn)
        TabPage1.Controls.Add(ClearBtn)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(EnOutput)
        TabPage1.Controls.Add(EncodeBtn)
        TabPage1.Controls.Add(EnKey)
        TabPage1.Controls.Add(EnText)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(544, 444)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        ' 
        ' CloseBtn
        ' 
        CloseBtn.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        CloseBtn.Location = New Point(335, 192)
        CloseBtn.Name = "CloseBtn"
        CloseBtn.Size = New Size(140, 50)
        CloseBtn.TabIndex = 8
        CloseBtn.Text = "CLOSE"
        CloseBtn.UseVisualStyleBackColor = True
        ' 
        ' ClearBtn
        ' 
        ClearBtn.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        ClearBtn.Location = New Point(176, 192)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(140, 50)
        ClearBtn.TabIndex = 7
        ClearBtn.Text = "RESET"
        ClearBtn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveBorder
        Label3.Location = New Point(19, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(185, 36)
        Label3.TabIndex = 6
        Label3.Text = "Encoded Text"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ActiveBorder
        Label2.Location = New Point(19, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(272, 36)
        Label2.TabIndex = 5
        Label2.Text = "Enter Key To Encode"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ActiveBorder
        Label1.Location = New Point(19, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(283, 36)
        Label1.TabIndex = 4
        Label1.Text = "Enter Text To Encode"
        ' 
        ' EnOutput
        ' 
        EnOutput.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EnOutput.Location = New Point(19, 297)
        EnOutput.Name = "EnOutput"
        EnOutput.ReadOnly = True
        EnOutput.Size = New Size(474, 35)
        EnOutput.TabIndex = 3
        ' 
        ' EncodeBtn
        ' 
        EncodeBtn.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        EncodeBtn.Location = New Point(19, 192)
        EncodeBtn.Name = "EncodeBtn"
        EncodeBtn.Size = New Size(140, 50)
        EncodeBtn.TabIndex = 2
        EncodeBtn.Text = "ENCODE"
        EncodeBtn.UseVisualStyleBackColor = True
        ' 
        ' EnKey
        ' 
        EnKey.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EnKey.Location = New Point(19, 141)
        EnKey.Name = "EnKey"
        EnKey.Size = New Size(474, 35)
        EnKey.TabIndex = 1
        ' 
        ' EnText
        ' 
        EnText.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EnText.Location = New Point(19, 55)
        EnText.Name = "EnText"
        EnText.Size = New Size(474, 35)
        EnText.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.Black
        TabPage2.Controls.Add(Button2)
        TabPage2.Controls.Add(Button1)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(DeOutput)
        TabPage2.Controls.Add(DecodeBtn)
        TabPage2.Controls.Add(DeKey)
        TabPage2.Controls.Add(DeText)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(544, 444)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        Button2.Location = New Point(335, 195)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 50)
        Button2.TabIndex = 15
        Button2.Text = "CLOSE"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        Button1.Location = New Point(177, 195)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 50)
        Button1.TabIndex = 14
        Button1.Text = "RESET"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ActiveBorder
        Label4.Location = New Point(19, 259)
        Label4.Name = "Label4"
        Label4.Size = New Size(187, 36)
        Label4.TabIndex = 13
        Label4.Text = "Decoded Text"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ActiveBorder
        Label5.Location = New Point(19, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(274, 36)
        Label5.TabIndex = 12
        Label5.Text = "Enter Key To Decode"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ActiveBorder
        Label6.Location = New Point(19, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(285, 36)
        Label6.TabIndex = 11
        Label6.Text = "Enter Text To Decode"
        ' 
        ' DeOutput
        ' 
        DeOutput.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeOutput.Location = New Point(19, 298)
        DeOutput.Name = "DeOutput"
        DeOutput.ReadOnly = True
        DeOutput.Size = New Size(474, 35)
        DeOutput.TabIndex = 10
        ' 
        ' DecodeBtn
        ' 
        DecodeBtn.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold)
        DecodeBtn.Location = New Point(19, 195)
        DecodeBtn.Name = "DecodeBtn"
        DecodeBtn.Size = New Size(140, 50)
        DecodeBtn.TabIndex = 9
        DecodeBtn.Text = "DECODE"
        DecodeBtn.UseVisualStyleBackColor = True
        ' 
        ' DeKey
        ' 
        DeKey.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeKey.Location = New Point(19, 142)
        DeKey.Name = "DeKey"
        DeKey.Size = New Size(474, 35)
        DeKey.TabIndex = 8
        ' 
        ' DeText
        ' 
        DeText.Font = New Font("HP Simplified Jpan", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DeText.Location = New Point(19, 56)
        DeText.Name = "DeText"
        DeText.Size = New Size(474, 35)
        DeText.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(529, 408)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cipher"
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents EnText As TextBox
    Friend WithEvents EnTabBtn As Button
    Friend WithEvents EnKey As TextBox
    Friend WithEvents DeTabBtn As Button
    Friend WithEvents EncodeBtn As Button
    Friend WithEvents EnOutput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DeOutput As TextBox
    Friend WithEvents DecodeBtn As Button
    Friend WithEvents DeKey As TextBox
    Friend WithEvents DeText As TextBox
    Friend WithEvents CloseBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button

End Class
