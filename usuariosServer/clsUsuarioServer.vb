Public Class clsUsuarioServer

    Public Class clsArchivosServer
        Private _user As String
        Private _group As String
        Private _createTime As String
        Private _updTime As String
        Private _lastAccess As String
        Private _lastAccessTime As String
        Private _comment As String
        Private _pwdLastChange As String
        Private _adminPwdCahnge As String
        Private _pwdChangedBy As String

        Public Sub New()
            _user = ""
            _group = ""
            _createTime = ""
            _updTime = ""
            _lastAccess = ""
            _lastAccessTime = ""
            _comment = ""
            _pwdLastChange = ""
            _adminPwdCahnge = ""
            _pwdChangedBy = ""
        End Sub

        Public Property user() As String
            Get
                Return _user
            End Get
            Set(ByVal value As String)
                _user = value
            End Set
        End Property

        Public Property group() As String
            Get
                Return _group
            End Get
            Set(ByVal value As String)
                _group = value
            End Set
        End Property

        Public Property createTime() As String
            Get
                Return _createTime
            End Get
            Set(ByVal value As String)
                _createTime = value
            End Set
        End Property

        Public Property updTime() As String
            Get
                Return _updTime
            End Get
            Set(ByVal value As String)
                _updTime = value
            End Set
        End Property

        Public Property lastAccess() As String
            Get
                Return _lastAccess
            End Get
            Set(ByVal value As String)
                _lastAccess = value
            End Set
        End Property

        Public Property comment() As String
            Get
                Return _comment
            End Get
            Set(ByVal value As String)
                _comment = value
            End Set
        End Property

        Public Property pwdLastChange() As String
            Get
                Return _pwdLastChange
            End Get
            Set(ByVal value As String)
                _pwdLastChange = value
            End Set
        End Property

        Public Property adminPwdCahnge() As String
            Get
                Return _adminPwdCahnge
            End Get
            Set(ByVal value As String)
                _adminPwdCahnge = value
            End Set
        End Property

        Public Property pwdChangedBy() As String
            Get
                Return _pwdChangedBy
            End Get
            Set(ByVal value As String)
                _pwdChangedBy = value
            End Set
        End Property
    End Class

    Public Class clsComboBox
        Private _codigo As String
        Private _glosa As String

        Sub New()
            _codigo = ""
            _glosa = ""
        End Sub

        Public Property codigo() As String
            Get
                Return _codigo
            End Get
            Set(ByVal value As String)
                _codigo = value
            End Set
        End Property

        Public Property glosa() As String
            Get
                Return _glosa
            End Get
            Set(ByVal value As String)
                _glosa = value
            End Set
        End Property
    End Class
End Class