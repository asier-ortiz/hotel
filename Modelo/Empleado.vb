﻿Public Class Empleado

    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Private _password As String
    Public ReadOnly Property Password() As String
        Get
            Return _password
        End Get
    End Property



    Public Sub New()
    End Sub






End Class
