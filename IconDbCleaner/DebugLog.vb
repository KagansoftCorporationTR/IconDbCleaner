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

Module DebugLog
    Private ReadOnly LOG_FILE As String =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "idbc.log")

    Public Sub Log(ByVal ex As Exception)
        Try
            Dim LogTime As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            Dim LogMessage As String =
                $"[{LogTime}] Type: {ex.GetType().Name}" & Environment.NewLine &
                $"[{LogTime}] Message: {ex.Message}" & Environment.NewLine &
                $"[{LogTime}] Source: {ex.Source}" & Environment.NewLine &
                $"[{LogTime}] StackTrace: {ex.StackTrace}" & Environment.NewLine &
                $" " & Environment.NewLine

            File.AppendAllText(LOG_FILE, LogMessage)

        Catch

        End Try
    End Sub
End Module
