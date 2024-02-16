Imports System.IO
Public Class FormTaskManager
    ' Deklarasi variabel global
    Dim tasks As New List(Of String)
    Dim completedTasks As New List(Of String)

    ' Fungsi untuk membaca daftar tugas dari file teks
    Private Sub ReadTasksFromFile()
        If File.Exists("tasks.txt") Then
            tasks = File.ReadAllLines("tasks.txt").ToList()
        End If
    End Sub

    ' Fungsi untuk menyimpan daftar tugas ke file teks
    Private Sub SaveTasksToFile()
        File.WriteAllLines("tasks.txt", tasks)
    End Sub

    ' Prosedur untuk menampilkan daftar tugas
    Private Sub DisplayTasks(taskList As List(Of String), taskType As String)
        ListBoxTasks.Items.Clear()
        ListBoxTasks.Items.Add($"Daftar Tugas {taskType}:")
        For Each taskItem As String In taskList
            ListBoxTasks.Items.Add(taskItem)
        Next
    End Sub

    ' Prosedur untuk menambah tugas
    Private Sub AddTask()
        Dim newTask As String = InputBox("Masukkan tugas baru:", "Tambah Tugas")
        If Not String.IsNullOrEmpty(newTask) Then
            tasks.Add(newTask)
            MessageBox.Show("Tugas berhasil ditambahkan.", "Informasi")
        End If
    End Sub

    ' Prosedur untuk mengedit tugas
    Private Sub EditTask()
        If ListBoxTasks.SelectedIndex <> -1 Then
            Dim selectedIndex As Integer = ListBoxTasks.SelectedIndex
            Dim editedTask As String = InputBox($"Edit tugas: {tasks(selectedIndex - 1)}", "Edit Tugas", tasks(selectedIndex - 1))
            If Not String.IsNullOrEmpty(editedTask) Then
                tasks(selectedIndex - 1) = editedTask
                MessageBox.Show("Tugas berhasil diubah.", "Informasi")
            End If
        Else
            MessageBox.Show("Pilih tugas yang akan diubah.", "Peringatan")
        End If
    End Sub

    ' Prosedur untuk menghapus tugas
    Private Sub DeleteTask()
        If ListBoxTasks.SelectedIndex <> -1 Then
            Dim selectedIndex As Integer = ListBoxTasks.SelectedIndex
            tasks.RemoveAt(selectedIndex - 1)
            MessageBox.Show("Tugas berhasil dihapus.", "Informasi")
        Else
            MessageBox.Show("Pilih tugas yang akan dihapus.", "Peringatan")
        End If
    End Sub

    ' Prosedur untuk menandai tugas sebagai selesai
    Private Sub CompleteTask()
        If ListBoxTasks.SelectedIndex <> -1 Then
            Dim selectedIndex As Integer = ListBoxTasks.SelectedIndex
            completedTasks.Add(tasks(selectedIndex - 1))
            tasks.RemoveAt(selectedIndex - 1)
            MessageBox.Show("Tugas berhasil ditandai sebagai selesai.", "Informasi")
        Else
            MessageBox.Show("Pilih tugas yang akan ditandai sebagai selesai.", "Peringatan")
        End If
    End Sub

    ' Prosedur untuk disable button saat view tugas selesai
    Private Sub DisableButton()
        ButtonAddTask.Enabled = False
        ButtonCompleteTask.Enabled = False
        ButtonEditTask.Enabled = False
        ButtonDeleteTask.Enabled = False
    End Sub

    ' Prosedur untuk enable button saat view tugas selesai
    Private Sub EnableButton()
        ButtonAddTask.Enabled = True
        ButtonCompleteTask.Enabled = True
        ButtonEditTask.Enabled = True
        ButtonDeleteTask.Enabled = True
    End Sub


    ' Handler untuk menampilkan daftar tugas saat form dimuat
    Private Sub FormTaskManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadTasksFromFile()
        DisplayTasks(tasks, "Belum Selesai")
    End Sub

    ' Handler untuk tombol Tampilkan Tugas
    Private Sub ButtonDisplayTasks_Click(sender As Object, e As EventArgs) Handles ButtonDisplayTasks.Click
        DisplayTasks(tasks, "Belum Selesai")
        EnableButton()
    End Sub

    ' Handler untuk melihat tugas yang sudah selesai
    Private Sub ButtonViewSelesai_Click(sender As Object, e As EventArgs) Handles ButtonViewSelesai.Click
        DisplayTasks(completedTasks, "Selesai")
        DisableButton()
    End Sub

    ' Handler untuk tombol Tambah Tugas
    Private Sub ButtonAddTask_Click(sender As Object, e As EventArgs) Handles ButtonAddTask.Click
        AddTask()
        DisplayTasks(tasks, "Belum Selesai")
    End Sub

    ' Handler untuk tombol Edit Tugas
    Private Sub ButtonEditTask_Click(sender As Object, e As EventArgs) Handles ButtonEditTask.Click
        EditTask()
        DisplayTasks(tasks, "Belum Selesai")
    End Sub

    ' Handler untuk tombol Hapus Tugas
    Private Sub ButtonDeleteTask_Click(sender As Object, e As EventArgs) Handles ButtonDeleteTask.Click
        DeleteTask()
        DisplayTasks(tasks, "Belum Selesai")
    End Sub

    ' Handler untuk tombol Tandai Selesai
    Private Sub ButtonCompleteTask_Click(sender As Object, e As EventArgs) Handles ButtonCompleteTask.Click
        CompleteTask()
        DisplayTasks(tasks, "Belum Selesai")
    End Sub

    ' Handler untuk menyimpan tugas saat form ditutup
    Private Sub FormTaskManager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        SaveTasksToFile()
    End Sub

End Class