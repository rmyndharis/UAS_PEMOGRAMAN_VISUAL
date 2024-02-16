<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTaskManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ListBoxTasks = New ListBox()
        GroupBox1 = New GroupBox()
        ButtonDisplayTasks = New Button()
        ButtonAddTask = New Button()
        ButtonEditTask = New Button()
        ButtonDeleteTask = New Button()
        ButtonCompleteTask = New Button()
        Label1 = New Label()
        ButtonViewSelesai = New Button()
        SuspendLayout()
        ' 
        ' ListBoxTasks
        ' 
        ListBoxTasks.FormattingEnabled = True
        ListBoxTasks.Location = New Point(255, 114)
        ListBoxTasks.Name = "ListBoxTasks"
        ListBoxTasks.Size = New Size(522, 516)
        ListBoxTasks.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Location = New Point(120, 232)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(8, 8)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' ButtonDisplayTasks
        ' 
        ButtonDisplayTasks.Location = New Point(255, 23)
        ButtonDisplayTasks.Name = "ButtonDisplayTasks"
        ButtonDisplayTasks.Size = New Size(249, 61)
        ButtonDisplayTasks.TabIndex = 2
        ButtonDisplayTasks.Text = "Daftar Tugas Berjalan"
        ButtonDisplayTasks.UseVisualStyleBackColor = True
        ' 
        ' ButtonAddTask
        ' 
        ButtonAddTask.Location = New Point(28, 114)
        ButtonAddTask.Name = "ButtonAddTask"
        ButtonAddTask.Size = New Size(206, 46)
        ButtonAddTask.TabIndex = 3
        ButtonAddTask.Text = "Tambah Tugas"
        ButtonAddTask.UseVisualStyleBackColor = True
        ' 
        ' ButtonEditTask
        ' 
        ButtonEditTask.Location = New Point(28, 166)
        ButtonEditTask.Name = "ButtonEditTask"
        ButtonEditTask.Size = New Size(206, 46)
        ButtonEditTask.TabIndex = 4
        ButtonEditTask.Text = "Edit Tugas"
        ButtonEditTask.UseVisualStyleBackColor = True
        ' 
        ' ButtonDeleteTask
        ' 
        ButtonDeleteTask.Location = New Point(28, 218)
        ButtonDeleteTask.Name = "ButtonDeleteTask"
        ButtonDeleteTask.Size = New Size(206, 46)
        ButtonDeleteTask.TabIndex = 5
        ButtonDeleteTask.Text = "Hapus Tugas"
        ButtonDeleteTask.UseVisualStyleBackColor = True
        ' 
        ' ButtonCompleteTask
        ' 
        ButtonCompleteTask.Location = New Point(28, 270)
        ButtonCompleteTask.Name = "ButtonCompleteTask"
        ButtonCompleteTask.Size = New Size(206, 46)
        ButtonCompleteTask.TabIndex = 6
        ButtonCompleteTask.Text = "Tandai Selesai"
        ButtonCompleteTask.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(150, 390)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 32)
        Label1.TabIndex = 7
        ' 
        ' ButtonViewSelesai
        ' 
        ButtonViewSelesai.Location = New Point(528, 23)
        ButtonViewSelesai.Name = "ButtonViewSelesai"
        ButtonViewSelesai.Size = New Size(249, 61)
        ButtonViewSelesai.TabIndex = 9
        ButtonViewSelesai.Text = "Daftar Tugas Selesai"
        ButtonViewSelesai.UseVisualStyleBackColor = True
        ' 
        ' FormTaskManager
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(808, 660)
        Controls.Add(ButtonViewSelesai)
        Controls.Add(Label1)
        Controls.Add(ButtonCompleteTask)
        Controls.Add(ButtonDeleteTask)
        Controls.Add(ButtonEditTask)
        Controls.Add(ButtonAddTask)
        Controls.Add(ButtonDisplayTasks)
        Controls.Add(GroupBox1)
        Controls.Add(ListBoxTasks)
        MaximizeBox = False
        MaximumSize = New Size(834, 731)
        Name = "FormTaskManager"
        Text = "Tugas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBoxTasks As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonDisplayTasks As Button
    Friend WithEvents ButtonAddTask As Button
    Friend WithEvents ButtonEditTask As Button
    Friend WithEvents ButtonDeleteTask As Button
    Friend WithEvents ButtonCompleteTask As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonViewSelesai As Button

End Class
