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
        components = New ComponentModel.Container()
        Label6 = New Label()
        lblClock = New Label()
        Timer1 = New Timer(components)
        Button1 = New Button()
        Timer2 = New Timer(components)
        ErrorProvider1 = New ErrorProvider(components)
        DataGridView1 = New DataGridView()
        Mon_Col = New DataGridViewTextBoxColumn()
        MonE_Col = New DataGridViewTextBoxColumn()
        Tue_Col = New DataGridViewTextBoxColumn()
        TueE_Col = New DataGridViewTextBoxColumn()
        Wed_Col = New DataGridViewTextBoxColumn()
        WedE_Col = New DataGridViewTextBoxColumn()
        Thr_Col = New DataGridViewTextBoxColumn()
        ThuE_Col = New DataGridViewTextBoxColumn()
        Fri_Col = New DataGridViewTextBoxColumn()
        FriE_Col = New DataGridViewTextBoxColumn()
        btnSave = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        TimeTillBreak = New Label()
        TimeTillClass = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15F)
        Label6.Location = New Point(9, 505)
        Label6.Name = "Label6"
        Label6.Size = New Size(284, 28)
        Label6.TabIndex = 5
        Label6.Text = "Bulcom (C) 2026, Андрей Янев"
        ' 
        ' lblClock
        ' 
        lblClock.AutoSize = True
        lblClock.BackColor = SystemColors.ControlText
        lblClock.Font = New Font("Segoe UI", 20F)
        lblClock.ForeColor = Color.Yellow
        lblClock.Location = New Point(12, 468)
        lblClock.Name = "lblClock"
        lblClock.Size = New Size(428, 37)
        lblClock.TabIndex = 6
        lblClock.Text = "ЗАРЕЖДАМ ВРЕМЕТО, ИЗКАЧАЙ!"
        lblClock.TextAlign = ContentAlignment.BottomRight
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 19F)
        Button1.Location = New Point(1069, 78)
        Button1.Name = "Button1"
        Button1.Size = New Size(138, 48)
        Button1.TabIndex = 7
        Button1.Text = "РЪЧНО"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 5000
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Mon_Col, MonE_Col, Tue_Col, TueE_Col, Wed_Col, WedE_Col, Thr_Col, ThuE_Col, Fri_Col, FriE_Col})
        DataGridView1.Location = New Point(12, 24)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1043, 404)
        DataGridView1.TabIndex = 19
        ' 
        ' Mon_Col
        ' 
        Mon_Col.HeaderText = "Понеделник"
        Mon_Col.Name = "Mon_Col"
        ' 
        ' MonE_Col
        ' 
        MonE_Col.HeaderText = "Край"
        MonE_Col.Name = "MonE_Col"
        ' 
        ' Tue_Col
        ' 
        Tue_Col.HeaderText = "Вторник"
        Tue_Col.Name = "Tue_Col"
        ' 
        ' TueE_Col
        ' 
        TueE_Col.HeaderText = "Край"
        TueE_Col.Name = "TueE_Col"
        ' 
        ' Wed_Col
        ' 
        Wed_Col.HeaderText = "Сряда"
        Wed_Col.Name = "Wed_Col"
        ' 
        ' WedE_Col
        ' 
        WedE_Col.HeaderText = "Край"
        WedE_Col.Name = "WedE_Col"
        ' 
        ' Thr_Col
        ' 
        Thr_Col.HeaderText = "Четвъртък"
        Thr_Col.Name = "Thr_Col"
        ' 
        ' ThuE_Col
        ' 
        ThuE_Col.HeaderText = "Край"
        ThuE_Col.Name = "ThuE_Col"
        ' 
        ' Fri_Col
        ' 
        Fri_Col.HeaderText = "Петък"
        Fri_Col.Name = "Fri_Col"
        ' 
        ' FriE_Col
        ' 
        FriE_Col.HeaderText = "Край"
        FriE_Col.Name = "FriE_Col"
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 19F)
        btnSave.Location = New Point(1069, 186)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(138, 48)
        btnSave.TabIndex = 20
        btnSave.Text = "ЗАПАЗИ"
        btnSave.TextAlign = ContentAlignment.TopCenter
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 19F)
        Button3.Location = New Point(1069, 132)
        Button3.Name = "Button3"
        Button3.Size = New Size(138, 48)
        Button3.TabIndex = 21
        Button3.Text = "1 ЧАС"
        Button3.TextAlign = ContentAlignment.TopCenter
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Red
        Button4.Font = New Font("Segoe UI", 19F)
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(1069, 24)
        Button4.Name = "Button4"
        Button4.Size = New Size(138, 48)
        Button4.TabIndex = 22
        Button4.Text = "СПРИ!!!"
        Button4.TextAlign = ContentAlignment.TopCenter
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 19F)
        Button5.Location = New Point(1069, 240)
        Button5.Name = "Button5"
        Button5.Size = New Size(138, 48)
        Button5.TabIndex = 24
        Button5.Text = "About"
        Button5.TextAlign = ContentAlignment.TopCenter
        Button5.UseVisualStyleBackColor = True
        ' 
        ' TimeTillBreak
        ' 
        TimeTillBreak.AutoSize = True
        TimeTillBreak.BackColor = SystemColors.ActiveCaptionText
        TimeTillBreak.Font = New Font("Segoe UI", 20F)
        TimeTillBreak.ForeColor = Color.Lime
        TimeTillBreak.Location = New Point(480, 468)
        TimeTillBreak.Name = "TimeTillBreak"
        TimeTillBreak.Size = New Size(374, 37)
        TimeTillBreak.TabIndex = 25
        TimeTillBreak.Text = "ПОДГРЯВАМЕ МАШИНИТЕ...."
        ' 
        ' TimeTillClass
        ' 
        TimeTillClass.AutoSize = True
        TimeTillClass.BackColor = SystemColors.ActiveCaptionText
        TimeTillClass.Font = New Font("Segoe UI", 20F)
        TimeTillClass.ForeColor = Color.Red
        TimeTillClass.Location = New Point(870, 468)
        TimeTillClass.Name = "TimeTillClass"
        TimeTillClass.Size = New Size(137, 37)
        TimeTillClass.TabIndex = 26
        TimeTillClass.Text = "ЗАРЕЖДА"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Desktop
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.ForeColor = Color.Yellow
        Label1.Location = New Point(12, 431)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 37)
        Label1.TabIndex = 27
        Label1.Text = "ТЕКУЩО ВРЕМЕ"
        Label1.TextAlign = ContentAlignment.BottomRight
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ActiveCaptionText
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(480, 431)
        Label2.Name = "Label2"
        Label2.Size = New Size(333, 37)
        Label2.TabIndex = 28
        Label2.Text = "ВРЕМЕ ДО МЕЖДУЧАСИЕ"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaptionText
        Label3.Font = New Font("Segoe UI", 20F)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(870, 431)
        Label3.Name = "Label3"
        Label3.Size = New Size(204, 37)
        Label3.TabIndex = 29
        Label3.Text = "ВРЕМЕ ДО ЧАС"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1219, 539)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TimeTillClass)
        Controls.Add(TimeTillBreak)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(btnSave)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(lblClock)
        Controls.Add(Label6)
        Name = "Form1"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents lblClock As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Mon_Col As DataGridViewTextBoxColumn
    Friend WithEvents MonE_Col As DataGridViewTextBoxColumn
    Friend WithEvents Tue_Col As DataGridViewTextBoxColumn
    Friend WithEvents TueE_Col As DataGridViewTextBoxColumn
    Friend WithEvents Wed_Col As DataGridViewTextBoxColumn
    Friend WithEvents WedE_Col As DataGridViewTextBoxColumn
    Friend WithEvents Thr_Col As DataGridViewTextBoxColumn
    Friend WithEvents ThuE_Col As DataGridViewTextBoxColumn
    Friend WithEvents Fri_Col As DataGridViewTextBoxColumn
    Friend WithEvents FriE_Col As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TimeTillClass As Label
    Friend WithEvents TimeTillBreak As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label

End Class
