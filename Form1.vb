Public Class Form1

    ' Arrays for encryption/decryption
    Dim inputArray() As Integer
    Dim keyArray() As Integer
    Dim outputArray() As Integer
    Dim gcdArray() As Integer   ' 🔑 used for reversibility

    ' Tab switching
    Private Sub EnTabBtn_Click(sender As Object, e As EventArgs) Handles EnTabBtn.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub DeTabBtn_Click(sender As Object, e As EventArgs) Handles DeTabBtn.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    ' Notice on load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Only Alphabets Supported!", MsgBoxStyle.Information, "Notice")
    End Sub

    ' 🔹 Encode Button
    Private Sub EncodeBtn_Click(sender As Object, e As EventArgs) Handles EncodeBtn.Click
        Dim input As String = EnText.Text
        Dim key As String = EnKey.Text

        If input.Length <> key.Length Then
            MsgBox("Key & Input Text must be same length")
            Exit Sub
        End If

        ReDim inputArray(input.Length - 1)
        ReDim keyArray(key.Length - 1)
        ReDim outputArray(input.Length - 1)
        ReDim gcdArray(input.Length - 1)

        ' Convert input and key to Unicode code points
        For i As Integer = 0 To input.Length - 1
            inputArray(i) = AscW(input(i))   ' ✅ FIXED (instead of Asc)
            keyArray(i) = AscW(key(i))
        Next

        ' Encode using GCD
        For i As Integer = 0 To inputArray.Length - 1
            Dim gcdValue As Integer = GCD(inputArray(i), keyArray(i))
            outputArray(i) = inputArray(i) + gcdValue
            gcdArray(i) = gcdValue ' store GCD
        Next

        ' Convert to string
        EnOutput.Clear()
        For i As Integer = 0 To outputArray.Length - 1
            EnOutput.Text &= ChrW(outputArray(i))  ' ✅ FIXED (instead of Convert.ToChar)
        Next
    End Sub

    ' 🔹 Decode Button
    ' 🔹 Decode Button
    Private Sub DecodeBtn_Click(sender As Object, e As EventArgs) Handles DecodeBtn.Click
        ' Ensure gcdArray is available
        If gcdArray Is Nothing Then
            MsgBox("No encryption history found! Please encode text first before decoding.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim cipherText As String = DeText.Text
        Dim key As String = DeKey.Text

        If cipherText.Length <> key.Length Then
            MsgBox("Key & Cipher Text must be same length")
            Exit Sub
        End If

        Dim cipherArray(cipherText.Length - 1) As Integer
        ReDim outputArray(cipherText.Length - 1)

        ' Convert cipher to Unicode code points
        For i As Integer = 0 To cipherText.Length - 1
            cipherArray(i) = AscW(cipherText(i))
        Next

        ' Decode using saved GCD
        For i As Integer = 0 To cipherArray.Length - 1
            outputArray(i) = cipherArray(i) - gcdArray(i)
        Next

        ' Convert back to original text
        DeOutput.Clear()
        For i As Integer = 0 To outputArray.Length - 1
            DeOutput.Text &= ChrW(outputArray(i))
        Next
    End Sub


    ' 🔹 Clear Button
    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ' Reset Encode fields
        EnText.Clear()
        EnKey.Clear()
        EnOutput.Clear()

        ' Reset Decode fields
        DeText.Clear()
        DeKey.Clear()
        DeOutput.Clear()

        ' Reset arrays
        inputArray = Nothing
        keyArray = Nothing
        outputArray = Nothing
        gcdArray = Nothing

        MsgBox("All fields and arrays have been reset!", MsgBoxStyle.Information, "Reset")
    End Sub

    ' 🔹 Close Button
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    ' GCD function
    Private Function GCD(a As Integer, b As Integer) As Integer
        While b <> 0
            Dim temp As Integer = b
            b = a Mod b
            a = temp
        End While
        Return a
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Reset Encode fields
        EnText.Clear()
        EnKey.Clear()
        EnOutput.Clear()

        ' Reset Decode fields
        DeText.Clear()
        DeKey.Clear()
        DeOutput.Clear()

        ' Reset arrays
        inputArray = Nothing
        keyArray = Nothing
        outputArray = Nothing
        gcdArray = Nothing

        MsgBox("All fields and arrays have been reset!", MsgBoxStyle.Information, "Reset")
    End Sub
End Class
