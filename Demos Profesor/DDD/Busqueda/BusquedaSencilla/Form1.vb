Imports Microsoft.TeamFoundation.Client
Imports Microsoft.TeamFoundation.VersionControl.Client

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get Team Project collection form Uri
        Dim teamProjectCollection = GetTeamProjectCollection(New Uri(TeamProjectCollectionTextBox.Text))

        ' Get version control instance from team project collection
        Dim versionControlServer = GetVersionControlServer(teamProjectCollection)

        ' Get server path for all files with pattern
        Dim pathList = GetPathList(PatternTextBox.Text, versionControlServer)

        ' Comma separate results
        ResultTextBox.Text = String.Join(",", pathList)

        Dim db As New LASDataContext
        Dim builds = db.Proyectos.Select(Function(c) c.RutaControladorVersiones).ToList
        Dim rutasBuildsCompletas As New List(Of String)
        For Each b In builds
            If b IsNot Nothing And Not String.Empty.Equals(b) Then
                rutasBuildsCompletas.Add(b & "/")
            End If
        Next

        Dim rutasSoluciones As New List(Of String)

        For Each p In pathList
            Dim fileName = p.Split("/").Last
            rutasSoluciones.Add(p.Replace(fileName, String.Empty))
        Next

        Dim noBuild As New List(Of String)

        For Each s In rutasSoluciones
            If Not SolucionEstaEnBuild(s, rutasBuildsCompletas) Then
                noBuild.Add(s)
            End If
        Next

        NoBuildTextBox.Text = String.Join(vbNewLine, noBuild.Distinct)
    End Sub

    Private Function GetPathList(pattern As String, versionControlServer As VersionControlServer) As IEnumerable(Of String)

        Dim solutionList As List(Of String) = New List(Of String)

        ' Get items with pattern (must be prefixed with root path (server or local))
        '  for example $/ or C:\sc
        ' Version sepc = latest code
        '  recursionType = Full =  search sub folders
        '  DeletedState =  only non-deleted files
        ' ItemType = files
        Dim lists = versionControlServer.GetItems(pattern,
        VersionSpec.Latest,
        RecursionType.Full,
        DeletedState.NonDeleted,
        ItemType.File)

        If (lists.Items.Any()) Then
            Dim List = lists.Items.Select(Function(c) c.ServerItem).ToList()
            solutionList.AddRange(List)
        End If

        Return solutionList
    End Function


    Private Function GetVersionControlServer(tfsTeamProjectcollection As TfsTeamProjectCollection) As VersionControlServer

        Dim versionControlServer = tfsTeamProjectcollection.GetService(Of VersionControlServer)()
        Return versionControlServer

    End Function

    Private Function GetTeamProjectCollection(uri As Uri) As TfsTeamProjectCollection

        Dim tfs = TfsTeamProjectCollectionFactory.GetTeamProjectCollection(uri)
        tfs.EnsureAuthenticated()
        Return tfs

    End Function

    Function SolucionEstaEnBuild(solucion As String, builds As IList(Of String)) As Boolean

        Dim busqueda As String = builds.Where(Function(c) solucion.Contains(c)).Select(Function(c) c).FirstOrDefault
        Return busqueda IsNot Nothing

    End Function
End Class
