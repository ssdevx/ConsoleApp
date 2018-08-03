Module Module1
    Dim strCadena As String
    Dim C As String
    Dim MAX_LONGITUD As Integer
    Dim strToken As String
    Dim q0 As Boolean
    Dim q1 As Boolean

    Sub Main()
        q0 = False
        q1 = False
        Dim i As Long
        strCadena = "simplementeLorem Ipsum Tel: 435306568 Email:  correo@dominio.com email@dominio.com, correo1@dominio.com  mxmxmxmxmx@dominio.com Finibus Bonorum et Malorum 60s con la creación"
        MAX_LONGITUD = Len(strCadena)
        For i = 1 To MAX_LONGITUD
            C = Mid(strCadena, i, 1)
            Select Case C
                Case " ", ",", ":"
                    If (q0 = True) Then
                        If (C = ",") Then
                            If q1 = True Then
                                Console.WriteLine(strToken)
                            End If
                            strToken = ""
                            q0 = False
                            q1 = False
                        Else
                            strToken = strToken + C
                            If q1 = True Then
                                Console.WriteLine(strToken)
                            End If
                            strToken = ""
                            q0 = False
                            q1 = False
                        End If
                    Else
                        q0 = False
                    End If
                Case "@"
                    If q0 = True Then
                        strToken = strToken + C
                        q0 = True
                        q1 = True
                    End If

                Case Else
                    If q0 = True Then
                        strToken = strToken + C
                        q0 = True
                    Else
                        strToken = strToken + C
                        q0 = True
                    End If
            End Select
        Next
        Console.ReadLine()
    End Sub
End Module
