Imports Usergrid.Sdk
Imports Usergrid.Sdk.Model

Public Class App

    Public Function GetFollowers(userName As String) As IList
        Dim conn As Connection = New Connection()
        conn.ConnectorIdentifier = userName
        conn.ConnectorCollectionName = "users"
        conn.ConnectionName = "following"
        Return Globals.client.GetConnections(conn)
    End Function

    Public Function GetFollowed(userName As String) As IList
        Dim conn As Connection = New Connection()
        conn.ConnectorIdentifier = userName
        conn.ConnectorCollectionName = "users"
        conn.ConnectionName = "followed"
        Return Globals.client.GetConnections(conn)
    End Function

End Class
