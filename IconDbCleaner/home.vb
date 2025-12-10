' IconDbCleaner (Kagansoft System Maintenance Project)
' Copyright (C) 2025 Kagansoft Corporation

' This program Is free software: you can redistribute it And/Or modify
' it under the terms Of the GNU General Public License As published by
' the Free Software Foundation, either version 3 Of the License, Or
' (at your Option) any later version.

' This program Is distributed In the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty Of
' MERCHANTABILITY Or FITNESS For A PARTICULAR PURPOSE. See the
' GNU General Public License For more details.

' You should have received a copy Of the GNU General Public License
' along With this program. If Not, see <https://www.gnu.org/licenses/>.

Imports System
Imports System.IO

Public Class home
    Dim oldLog As String = "idbc.log"

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        homelbl.Location = New Point(44, 121)
        verlbl.Text = "Version " + CommonItems.ver
    End Sub

    Private Sub startcmd_Click(sender As Object, e As EventArgs) Handles startcmd.Click

        If File.Exists(oldLog) Then
            File.Delete(oldLog)
        End If

        homelbl.Text = "Please Wait..."
        homelbl.Location = New Point(107, 121)
        startcmd.Enabled = False

        Try
            For Each explorer In Process.GetProcessesByName("explorer")
                explorer.Kill()
            Next

            Dim cachePath As String =
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                             "Microsoft\Windows\Explorer")

            If Not Directory.Exists(cachePath) Then
                Throw New DirectoryNotFoundException(cachePath)
            End If

            Dim cacheFiles = Directory.GetFiles(cachePath, "*.db")

            For Each cfiles In cacheFiles
                Try
                    File.Delete(cfiles)
                Catch ex As Exception
                    DebugLog.Log(ex)
                End Try
            Next

            Process.Start("explorer.exe")

            MessageBox.Show("Thumbnail cleanup operation is completed!" & vbCrLf &
                            "For details, please refer to the idbc.log file.",
                            "IconDbCleaner",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            homelbl.Text = "To begin cleaning, click the Start button."
            homelbl.Location = New Point(44, 121)
            startcmd.Enabled = True

        Catch ex As Exception
            DebugLog.Log(ex)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CheckOutMyGitHubPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckOutMyGitHubPageToolStripMenuItem.Click
        Process.Start("https://github.com/KagansoftCorporationTR")
    End Sub
End Class
