Imports System.Data.OleDb
Imports System.Data


Public Class login

    Dim connection As New OleDbConnection(My.Settings.logindataConnectionString)

    Dim Alphabets() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", ".", ",", ";", ":", "(", ")", "{", "}", "[", "]"}

    Dim showpass As Integer = 0
    Dim randarr(35) As Char
    Dim numarr(35) As Integer
    Dim num As Integer
    Dim keyselected As Integer = 1
    Dim temparr(5) As Char
    Dim open As Integer = 0
    Dim keyboardarr(6, 6) As Char
    Dim inversearr(6, 6) As Char
    Dim temprow As Integer
    Dim word As Char
    Dim col As Integer
    Dim passcode As String
    Private Sub GetNumber()
        num = Math.Ceiling(Rnd() * 36)
    End Sub
    Private Sub wordselect()
        If keyselected = 1 Then
            For q = 0 To 5
                temparr(q) = keyboardarr(q, temprow)
                keyselected = 2
            Next
            secondKeyboard()
            inversekeyboardfilling()

        ElseIf keyselected = 2 Then
            word = temparr(col)
            keyselected = 1
            firstKeyboard()
            firstkeyboardfilling()


        End If

    End Sub
    Private Sub randnumarr()
        Dim i As Integer = 0
        Dim j As Integer = 0
        While i < 36
            GetNumber()
            j = 0
            While j < i
                If numarr(j) = num Then
                    j = i
                End If
                j = j + 1
            End While
            If j = i Then
                randarr(i) = Alphabets(num - 1)
                numarr(i) = num
                i = i + 1
            End If
        End While
    End Sub
    Private Sub firstKeyboard()
        Dim m, n As Integer
        Dim k As Integer
        m = 0
        n = 0
        k = 0

        randnumarr()

        For m = 0 To 5
            For n = 0 To 5
                keyboardarr(m, n) = randarr(k)
                k = k + 1

            Next n
        Next m

    End Sub
    Private Sub secondKeyboard()
        Dim m, n As Integer

        m = 0
        n = 0

        For m = 0 To 6
            For n = 0 To 6
                inversearr(m, n) = keyboardarr(n, m)
            Next n
        Next m

    End Sub
    Private Sub inversekeyboardfilling()
        K1.Text = inversearr(0, 0)
        K2.Text = inversearr(0, 1)
        K3.Text = inversearr(0, 2)
        K4.Text = inversearr(0, 3)
        K5.Text = inversearr(0, 4)
        K6.Text = inversearr(0, 5)
        K7.Text = inversearr(1, 0)
        K8.Text = inversearr(1, 1)
        K9.Text = inversearr(1, 2)
        K10.Text = inversearr(1, 3)
        K11.Text = inversearr(1, 4)
        K12.Text = inversearr(1, 5)
        K13.Text = inversearr(2, 0)
        K14.Text = inversearr(2, 1)
        K15.Text = inversearr(2, 2)
        K16.Text = inversearr(2, 3)
        K17.Text = inversearr(2, 4)
        K18.Text = inversearr(2, 5)
        K19.Text = inversearr(3, 0)
        K20.Text = inversearr(3, 1)
        K21.Text = inversearr(3, 2)
        K22.Text = inversearr(3, 3)
        K23.Text = inversearr(3, 4)
        K24.Text = inversearr(3, 5)
        K25.Text = inversearr(4, 0)
        K26.Text = inversearr(4, 1)
        K27.Text = inversearr(4, 2)
        K28.Text = inversearr(4, 3)
        K29.Text = inversearr(4, 4)
        K30.Text = inversearr(4, 5)
        K31.Text = inversearr(5, 0)
        K32.Text = inversearr(5, 1)
        K33.Text = inversearr(5, 2)
        K34.Text = inversearr(5, 3)
        K35.Text = inversearr(5, 4)
        K36.Text = inversearr(5, 5)

    End Sub
    Private Sub firstkeyboardfilling()
        K1.Text = keyboardarr(0, 0)
        K2.Text = keyboardarr(0, 1)
        K3.Text = keyboardarr(0, 2)
        K4.Text = keyboardarr(0, 3)
        K5.Text = keyboardarr(0, 4)
        K6.Text = keyboardarr(0, 5)
        K7.Text = keyboardarr(1, 0)
        K8.Text = keyboardarr(1, 1)
        K9.Text = keyboardarr(1, 2)
        K10.Text = keyboardarr(1, 3)
        K11.Text = keyboardarr(1, 4)
        K12.Text = keyboardarr(1, 5)
        K13.Text = keyboardarr(2, 0)
        K14.Text = keyboardarr(2, 1)
        K15.Text = keyboardarr(2, 2)
        K16.Text = keyboardarr(2, 3)
        K17.Text = keyboardarr(2, 4)
        K18.Text = keyboardarr(2, 5)
        K19.Text = keyboardarr(3, 0)
        K20.Text = keyboardarr(3, 1)
        K21.Text = keyboardarr(3, 2)
        K22.Text = keyboardarr(3, 3)
        K23.Text = keyboardarr(3, 4)
        K24.Text = keyboardarr(3, 5)
        K25.Text = keyboardarr(4, 0)
        K26.Text = keyboardarr(4, 1)
        K27.Text = keyboardarr(4, 2)
        K28.Text = keyboardarr(4, 3)
        K29.Text = keyboardarr(4, 4)
        K30.Text = keyboardarr(4, 5)
        K31.Text = keyboardarr(5, 0)
        K32.Text = keyboardarr(5, 1)
        K33.Text = keyboardarr(5, 2)
        K34.Text = keyboardarr(5, 3)
        K35.Text = keyboardarr(5, 4)
        K36.Text = keyboardarr(5, 5)

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

    End Sub

    Private Sub KeyGen_Click(sender As Object, e As EventArgs) Handles KeyGen.Click

        If open = 0 Then
            firstKeyboard()
            firstkeyboardfilling()
            CapitalRb.Checked = True
            open = 1
        End If
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click

        If keyselected = 1 Then
            temprow = 0
            wordselect()
        ElseIf keyselected = 2 Then
            col = 0
            wordselect()
            passcode = passcode + word
            Password.Text = passcode
        End If


    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        If keyselected = 1 Then
            temprow = 1
            wordselect()
        ElseIf keyselected = 2 Then
            col = 1
            wordselect()
            passcode = passcode + word
            Password.Text = passcode
        End If
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        If keyselected = 1 Then
            temprow = 2
            wordselect()
        ElseIf keyselected = 2 Then
            col = 2
            wordselect()
            passcode = passcode + word
            Password.Text = passcode
        End If
    End Sub

    Private Sub C4_Click(sender As Object, e As EventArgs) Handles C4.Click
        If keyselected = 1 Then
            temprow = 3
            wordselect()
        ElseIf keyselected = 2 Then
            col = 3
            wordselect()
            passcode = passcode + word
            Password.Text = passcode
        End If
    End Sub

    Private Sub C5_Click(sender As Object, e As EventArgs) Handles C5.Click
        If keyselected = 1 Then
            temprow = 4
            wordselect()
        ElseIf keyselected = 2 Then
            col = 4
            wordselect()
            passcode = passcode + word
            Password.Text = passcode
        End If
    End Sub

    Private Sub C6_Click(sender As Object, e As EventArgs) Handles C6.Click
        If keyselected = 1 Then
            temprow = 5
            wordselect()
        ElseIf keyselected = 2 Then
            col = 5
            wordselect()
            passcode = passcode + word
            Password.Text = passcode
        End If
    End Sub

    Private Sub LoginBt_Click(sender As Object, e As EventArgs) Handles LoginBt.Click
        If UserName.Text = Nothing Or Password.Text = Nothing Then
            MsgBox("Enter credentials", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()

            End If
            Dim cmd As New OleDbCommand("Select count(*) from loginTable where username=? and password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = UserName.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = Password.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                MsgBox("Login success", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Account not found", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub SmallRb_CheckedChanged(sender As Object, e As EventArgs) Handles SmallRb.CheckedChanged
        If keyselected = 1 Then


            Alphabets = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", ".", ",", ";", ":", "(", ")", "{", "}", "[", "]"}
            firstKeyboard()
            firstkeyboardfilling()

        End If

    End Sub

    Private Sub CapitalRb_CheckedChanged(sender As Object, e As EventArgs) Handles CapitalRb.CheckedChanged
        If keyselected = 1 Then


            Alphabets = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", ".", ",", ";", ":", "(", ")", "{", "}", "[", "]"}
            firstKeyboard()
            firstkeyboardfilling()

        End If

    End Sub

    Private Sub NumberRb_CheckedChanged(sender As Object, e As EventArgs) Handles NumberRb.CheckedChanged
        If keyselected = 1 Then


            Alphabets = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "^", "\&", "*", "-", "+", "=", "/", "?", "~", "<", ">", "\", "|", "_", "(", ")", "{", "}", "\", "[", "]"}
            firstKeyboard()
            firstkeyboardfilling()

        End If
    End Sub

    Private Sub ResetBt_Click(sender As Object, e As EventArgs) Handles ResetBt.Click
        UserName.Text = ""
        Password.Text = ""
        passcode = ""
        keyselected = 1
        open = 0


        For m = 0 To 5
            For n = 0 To 5
                keyboardarr(m, n) = ""
            Next n
        Next m
        firstkeyboardfilling()

    End Sub

    Private Sub DeleteBt_Click(sender As Object, e As EventArgs) Handles DeleteBt.Click
        If Password.Text.Length > 0 Then
            Password.Text = Password.Text.Substring(0, Password.Text.Length - 1)
            passcode = Password.Text

        End If
    End Sub

    Private Sub Password_Click(sender As Object, e As EventArgs) Handles Password.Click

        If open = 0 Then
            firstKeyboard()
            firstkeyboardfilling()
            CapitalRb.Checked = True
            open = 1
        End If

    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Password.PasswordChar = ""
    End Sub

    Private Sub ShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged

        If showpass = 0 Then
            Password.PasswordChar = ""
            showpass = 1
        ElseIf showpass = 1 Then
            Password.PasswordChar = "*"
            showpass = 0
        End If


    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Homebt.Click
        Me.Close()
        Home.Show()

    End Sub

    Private Sub UserName_TextChanged(sender As Object, e As EventArgs) Handles UserName.TextChanged

    End Sub
End Class