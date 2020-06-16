Public Class frmMain
    Private decA, decB, decC, decS, decArea As Decimal
    Private intDecimals As Integer
    Private Const intPRECISION As Integer = 3
    Private boolImaginary As Boolean = False

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        decA = 0
        decB = 0
        decC = 0
        boolImaginary = False
        FormatInputs()
        FormatOutputs()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intDecimals = intPRECISION
        btnClear.PerformClick()
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'get input
        GetInputs()
        'compute
        ComputeSemiPerimeter()
        ComputeArea()
        'display output
        FormatOutputs()
    End Sub

    Private Sub ComputeSemiPerimeter()
        decS = (decA + decB + decC) / 2
    End Sub

    Private Sub ComputeArea()
        Dim temp As Decimal = decS * (decS - decA) * (decS - decB) * (decS - decC)
        If temp < 0 Then
            MsgBox("Square root of " & temp.ToString("N" & intDecimals) & " returns an imaginary value.")
            boolImaginary = True
            decArea = 0
        Else
            decArea = temp ^ (1 / 2)
            boolImaginary = False
        End If

    End Sub

    Private Sub GetInputs()
        Integer.TryParse(txtDecimals.Text, intDecimals)
        Decimal.TryParse(txtA.Text, decA)
        Decimal.TryParse(txtB.Text, decB)
        Decimal.TryParse(txtC.Text, decC)
        ProcessPrecision(intDecimals)
        ProcessABC(decA)
        ProcessABC(decB)
        ProcessABC(decC)
        FormatInputs()
    End Sub

    Private Sub ProcessABC(ByRef side As Decimal)
        If side < 0 Then
            MsgBox("Sides A, B, and C cannot be less than 0.")
            side = 0
        End If
    End Sub

    Private Sub ProcessPrecision(ByRef numDecimals As Integer)
        If numDecimals < 0 Then
            MsgBox("Number of decimal places cannot be less than 0.")
            numDecimals = intPRECISION
        End If
    End Sub

    Private Sub textBox_LoseFocus(sender As Object, e As EventArgs) Handles txtDecimals.Leave, txtC.Leave, txtB.Leave, txtA.Leave
        GetInputs()
        FormatOutputs()
    End Sub

    Private Sub press_Enter(sender As Object, e As KeyPressEventArgs) Handles txtDecimals.KeyPress, txtC.KeyPress, txtB.KeyPress, txtA.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnCompute.PerformClick()
        End If
    End Sub

    Private Sub input_Changed(sender As Object, e As EventArgs) Handles txtC.TextChanged, txtB.TextChanged, txtA.TextChanged
        decS = 0
        decArea = 0
        FormatOutputs()
    End Sub

    Private Sub FormatInputs()
        txtDecimals.Text = intDecimals.ToString()
        txtA.Text = decA.ToString("N" & intDecimals)
        txtB.Text = decB.ToString("N" & intDecimals)
        txtC.Text = decC.ToString("N" & intDecimals)
    End Sub

    Private Sub FormatOutputs()
        txtSemiPerimeter.Text = decS.ToString("N" & intDecimals)
        txtArea.Text = If(boolImaginary, "Error", decArea.ToString("N" & intDecimals))
    End Sub

End Class
