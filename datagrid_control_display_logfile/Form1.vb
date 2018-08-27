

Public Class Form1

    'modular variable used to show how many rows of errors are being shown
    Dim MRowsShowing As Integer

    Public Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

        Me.dgvData.Rows.Clear()
        Me.dgvData.Columns.Clear()
        Me.dgvData.Refresh()
        MRowsShowing = 0
        Me.UncheckedCMNU()

        'This opens the file dialog box
        Try
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim file As String
                file = OpenFileDialog1.FileName

                Dim coordsreader As New System.IO.StreamReader(file) 'this is the file it is looking for
                Dim linereadingnow As String
                Dim inforeadingnow As Array
                Dim linescounter As Integer = 0

                Do Until coordsreader.EndOfStream = True

                    'linereading now will turn into inforeadingnow after the split in the second line
                    linereadingnow = coordsreader.ReadLine
                    inforeadingnow = linereadingnow.Split(",")

                    'this line creates the columns from the first line of data
                    If linescounter = 0 Then
                        'I am sizing column widths based on the property auto size to fill try doing it in code to make more efficient
                        '(COLUMN #, what info is in this column)
                        Me.dgvData.Columns.Add(0, inforeadingnow(0))
                        Me.dgvData.Columns.Add(1, inforeadingnow(1))
                        Me.dgvData.Columns.Add(2, inforeadingnow(2))
                        Me.dgvData.Columns.Add(3, inforeadingnow(3))
                        Me.dgvData.Columns.Add(4, inforeadingnow(4))
                        Me.dgvData.Columns.Add(5, inforeadingnow(5))
                        Me.dgvData.Columns.Add(6, inforeadingnow(7))
                        'added this column for optima debug text for generator errors
                        Me.dgvData.Columns.Add(7, inforeadingnow(16))

                        'do column width programming here
                        Me.dgvData.Columns(0).Width = 25
                        Me.dgvData.Columns(1).Width = 40
                        Me.dgvData.Columns(2).Width = 40
                        Me.dgvData.Columns(3).Width = 30
                        Me.dgvData.Columns(4).Width = 40
                        Me.dgvData.Columns(5).Width = 200
                        Me.dgvData.Columns(6).Width = 20
                        'added this column for optima debug text for generator errors
                        Me.dgvData.Columns(7).Width = 105
                    End If

                    If linescounter > 0 Then

                        'the linescounter -1 places the second row of data on row 0
                        '(column index, row index).value = whats going in that cell 
                        Me.dgvData.Rows.Add()
                        Me.dgvData.Item(0, (linescounter - 1)).Value = (inforeadingnow(0))
                        Me.dgvData.Item(1, (linescounter - 1)).Value = (inforeadingnow(1))
                        Me.dgvData.Item(2, (linescounter - 1)).Value = (inforeadingnow(2))
                        Me.dgvData.Item(3, (linescounter - 1)).Value = (inforeadingnow(3))
                        Me.dgvData.Item(4, (linescounter - 1)).Value = (inforeadingnow(4))
                        Me.dgvData.Item(5, (linescounter - 1)).Value = (inforeadingnow(5))
                        Me.dgvData.Item(6, (linescounter - 1)).Value = (inforeadingnow(7))
                        'added this column for optima debug text for generator errors
                        Me.dgvData.Item(7, (linescounter - 1)).Value = (inforeadingnow(16))

                        MRowsShowing = MRowsShowing + 1

                    End If

                    linescounter = linescounter + 1

                Loop

            End If

            btnLoad.Text = "Load a different error log"
            btnSort.Enabled = True
            btnAnalyze.Enabled = True
            btnSearch.Enabled = True
            btnHide.Enabled = True
            Me.EnableCMNU()

        Catch
            MessageBox.Show("You must select a valid error log.  Program was designed to handle error logs on GE X-Ray Equipment." & ControlChars.NewLine & "Please select a different error log", "Data Not Valid")

        End Try

    End Sub


    Private Sub btnSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        'This is now the show all button

        chkboxDO.Checked = False

        Dim NumberRows As Integer
        NumberRows = Me.dgvData.RowCount
        Dim ReadInfo As String
        Dim linescounter As Integer
        MRowsShowing = 0

        'this if statement may now be useless??

        If chkboxDO.Checked = False Then

            Do Until linescounter = NumberRows

                'Read a cell content based on (column index and row index) column can be hard coded row index would be linescounter
                'store the info to the currentinfo variable
                ReadInfo = Me.dgvData.Item(6, linescounter).Value
                'do If statement comparing the current info to the target of what you want removed then hide the row index based on linescounter
                Me.dgvData.Rows(linescounter).Visible = True
                linescounter = linescounter + 1
                MRowsShowing = MRowsShowing + 1
            Loop

        End If

        Me.txtSearch.Text = ""
        Me.txtSearch2.Text = ""
        Me.txtHide.Text = ""

        Me.UncheckedCMNU()
        Me.EnableCMNU()


    End Sub


    Private Sub chkboxDO_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkboxDO.CheckStateChanged

        Dim NumberRows As Integer
        NumberRows = Me.dgvData.RowCount
        MRowsShowing = 0

        Dim ReadInfo As String

        Dim linescounter As Integer

        If chkboxDO.Checked = True Then

            Do Until linescounter = NumberRows
                'Read a cell content based on (column index and row index) column can be hard coded row index would be linescounter
                'store the info to the currentinfo variable
                ReadInfo = Me.dgvData.Item(6, linescounter).Value

                'do If statement comparing the current info to the target of what you want removed then hide the row index based on linescounter
                If ReadInfo = "DO" Then
                    Me.dgvData.Rows(linescounter).Visible = False
                Else
                    MRowsShowing = MRowsShowing + 1
                End If

                linescounter = linescounter + 1
            Loop

        End If

    End Sub


    Private Sub btnAnalyze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalyze.Click

        'Gets info from each row in error column and assigns to array of variable
        Dim NumberRows As Integer
        NumberRows = Me.dgvData.RowCount

        Dim TopDate As Date
        Dim BottomDate As Date
        Dim TimeEllapsed As TimeSpan
        Dim ErrorCounter(NumberRows) As String
       
        TopDate = Me.dgvData.Item(1, 0).Value
        BottomDate = Me.dgvData.Item(1, (NumberRows - 1)).Value
        TimeEllapsed = BottomDate - TopDate

        MessageBox.Show("There are " & NumberRows & " Errors in this log.  The first error was on " & TopDate & ".  The last error occured on " & BottomDate &
                        ".  The errors occured in a span of " & TimeEllapsed.Days & " days." & ControlChars.NewLine & ControlChars.NewLine & "There are currently " & MRowsShowing & " errors being displayed.", "Error Reader")

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'gets value from txtSearch and searches the error column and hides all values that dont match

        Dim NumberRows As Integer
        NumberRows = Me.dgvData.RowCount
        Dim ReadInfo As String
        Dim linescounter As Integer
        Dim Search As String
        Dim Search2 As String
        Search = Me.txtSearch.Text
        Search2 = Me.txtSearch2.Text

        Me.txtHide.Text = ""

        MRowsShowing = 0

        Do Until linescounter = NumberRows
            'Read a cell content based on (column index and row index) column can be hard coded row index would be linescounter
            'store the info to the currentinfo variable
            ReadInfo = Me.dgvData.Item(4, linescounter).Value

            'do If statement comparing the current info to the target of what you want removed then hide the row index based on linescounter
            If ReadInfo = Search Or ReadInfo = Search2 Then
                Me.dgvData.Rows(linescounter).Visible = True
                MRowsShowing = MRowsShowing + 1
            Else
                Me.dgvData.Rows(linescounter).Visible = False
            End If

            linescounter = linescounter + 1
        Loop

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        'need to either clear the checkbox hide DO or incorporate that code here as function?
        If chkboxDO.Checked = True Then
            chkboxDO.Checked = False

        End If

        Dim NumberRows As Integer
        NumberRows = Me.dgvData.RowCount
        Dim ReadInfo As String
        Dim linescounter As Integer
        Dim Hide As String
        Hide = Me.txtHide.Text

        MRowsShowing = 0

        Do Until linescounter = NumberRows
            'Read a cell content based on (column index and row index) column can be hard coded row index would be linescounter
            'store the info to the currentinfo variable
            ReadInfo = Me.dgvData.Item(4, linescounter).Value

            'if statement to hide certain errors
            If ReadInfo = Hide Then
                Me.dgvData.Rows(linescounter).Visible = False
            Else
                Me.dgvData.Rows(linescounter).Visible = True
                MRowsShowing = MRowsShowing + 1

            End If

            linescounter = linescounter + 1
        Loop
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        MessageBox.Show("This program is designed to read the error logs of GE's xray line of products.  Should properly open sysError.log" & ControlChars.NewLine & "Start by clicking the 'Selects file then loads error log' button and then select an error log that was pulled from the machine." & ControlChars.NewLine & ControlChars.NewLine & "This program was created by Shane Talbert FE for GE Healthcare.  Please email any recommendations to shane.talbert@ge.com", "About Error Reader")
    End Sub

    Private Sub mnuDisplayPdf_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuDisplayPdf.Click
        'displays or loads 2nd form
        frmPdf.Show()
        'On the second form display the pdf file on how to pull files.
    End Sub

    Private Sub cmnuCopyPaste1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnuCopyPaste1.Click
        'Takes the currently highlighted cell and paste it into the first search box
        Me.txtSearch.Text = Me.dgvData.CurrentCell.Value
    End Sub

    Private Sub cmnuCopyPaste2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnuCopyPaste2.Click
        'Takes the currently highlighted cell and paste it into the second search box
        Me.txtSearch2.Text = Me.dgvData.CurrentCell.Value
    End Sub

    Private Sub cmnuCopy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnuCopy.Click
        Clipboard.SetText(Me.dgvData.CurrentCell.Value)
    End Sub

    Private Sub Error2LetterLegendsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Error2LetterLegendsToolStripMenuItem.Click
        MessageBox.Show("DO = Debug Only" & ControlChars.NewLine & "HL = Halt (Requires Reboot)" & ControlChars.NewLine & "WR = Warning" & ControlChars.NewLine & "RC = Restart Comms (IDC/ADS recoverable event)" & ControlChars.NewLine & "IH = Inhibit (May need acknowledgement)", "2 Letter error legend")
    End Sub

    Private Sub cmnuHide_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnuHide.Click
        Me.txtHide.Text = Me.dgvData.CurrentCell.Value
    End Sub

    'this is going to be my sub procedure filer.  What are the arguments(Inside the bracket)
    Private Sub Filter(ByVal HideFile As String, ByVal HighlightFile As String)

        Try
            Dim NumberRows As Integer
            NumberRows = Me.dgvData.RowCount
            Dim ErrorCounter(NumberRows) As String
            Dim linescounter As Integer
            Dim ReadInfo As String

            'used to store the error codes as a string of array to look for common solutions
            Do Until linescounter = NumberRows
                'Read a cell content based on (column index and row index) column can be hard coded row index would be linescounter
                'store the info to the currentinfo variable
                ErrorCounter(linescounter) = Me.dgvData.Item(4, linescounter).Value
                linescounter = linescounter + 1
            Loop

            'This is the code that was inserted into the program
            '3 stages of a query

            'stage 1 get the data source and load the collection
            Dim ErrorTextReader As New System.IO.StreamReader(HideFile)

            'taking the strings that are in optima hide and placing in HideErrors collection
            Dim HideErrors As New List(Of String)
            Do While ErrorTextReader.Peek <> -1
                Dim row As String = ErrorTextReader.ReadLine
                HideErrors.Add(row)
            Loop

            Dim ErrorHighlightReader As New System.IO.StreamReader(HighlightFile)

            Dim HighlightErrors As New List(Of String)
            Do While ErrorHighlightReader.Peek <> -1
                Dim row As String = ErrorHighlightReader.ReadLine
                HighlightErrors.Add(row)
            Loop

            'stage 2 define the query expression

            'here is the magic...  instead of comparing 2 collections.  comparing one array to one collection.
            Dim DifHideShown As IEnumerable(Of String) = ErrorCounter.OfType(Of String).Intersect(HideErrors.OfType(Of String))
            Dim SameHighlightShown As IEnumerable(Of String) = ErrorCounter.OfType(Of String).Intersect(HighlightErrors.OfType(Of String))

            MRowsShowing = 0
            linescounter = 0

            'stage 3 execute query and return results
            Do Until linescounter = NumberRows
                'Read a cell content based on (column index and row index) column can be hard coded row index would be linescounter
                'store the info to the currentinfo variable
                ReadInfo = Me.dgvData.Item(4, linescounter).Value

                'do If statement comparing the current info to the target of what you want removed then hide the row index based on linescounter
                If DifHideShown.Contains(ReadInfo) Then
                    Me.dgvData.Rows(linescounter).Visible = False
                Else
                    '2nd if statement to determine if row needs to be highlighted
                    Me.dgvData.Rows(linescounter).Visible = True
                    MRowsShowing = MRowsShowing + 1
                    If SameHighlightShown.Contains(ReadInfo) Then
                        Me.dgvData.Rows(linescounter).DefaultCellStyle.BackColor = Color.Gainsboro
                    End If
                End If
                linescounter = linescounter + 1
            Loop

        Catch ex As Exception
            MessageBox.Show("There is a problem.  There should be a file named " & HideFile & " and " & HighlightFile & ".  Either the file is missing or the format is corrupt.", "Error Message")

        End Try

    End Sub

    Private Sub DisableCMNU()
        cmnuOptima.Enabled = False
        cmnuXRD.Enabled = False
        cmnuMammo.Enabled = False
        cmnuDefinium.Enabled = False
        cmnuOther.Enabled = False
    End Sub

    Private Sub EnableCMNU()
        cmnuOptima.Enabled = True
        cmnuXRD.Enabled = True
        cmnuMammo.Enabled = True
        cmnuDefinium.Enabled = True
        cmnuOther.Enabled = True
    End Sub

    Private Sub UncheckedCMNU()
        cmnuOptima.Checked = False
        cmnuXRD.Checked = False
        cmnuMammo.Checked = False
        cmnuDefinium.Checked = False
        cmnuOther.Checked = False
    End Sub

    Private Sub cmnuOptima_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnuOptima.Click

        cmnuOptima.Checked = True
        'to get this to work on the laptop need to look for C:\Error_Reader\OptimaHide.txt and on deployment machine need to move the Release folder to the root of c and rename in Error_Reader.  
        'Also change the error message to reflect the location of the file.
        Dim HideFile As String = "OptimaHide.txt"
        Dim HighlightFile As String = "OptimaHighlight.txt"

        'Call Filter procedure
        Me.Filter(HideFile, HighlightFile)
        Me.DisableCMNU()

    End Sub

    Private Sub cmnuXRD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmnuXRD.Click
        cmnuXRD.Checked = True
        Dim HideFile As String = "XRDHide.txt"
        Dim HighlightFile As String = "XRDHighlight.txt"

        Me.Filter(HideFile, HighlightFile)
        Me.DisableCMNU()

    End Sub

    Private Sub cmnuMammo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnuMammo.Click
        cmnuMammo.Checked = True
        Dim HideFile As String = "MammoHide.txt"
        Dim HighlightFile As String = "MammoHighlight.txt"

        Me.Filter(HideFile, HighlightFile)
        Me.DisableCMNU()

    End Sub

    Private Sub cmnuDefinium_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnuDefinium.Click
        cmnuDefinium.Checked = True
        Dim HideFile As String = "Definium_DiscoveryHide.txt"
        Dim HighlightFile As String = "Definium_DiscoveryHighlight.txt"

        Me.Filter(HideFile, HighlightFile)
        Me.DisableCMNU()
    End Sub

    Private Sub cmnuOther_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmnuOther.Click
        cmnuOther.Checked = True
        Dim HideFile As String = "OtherHide.txt"
        Dim HighlightFile As String = "OtherHighlight.txt"

        Me.Filter(HideFile, HighlightFile)
        Me.DisableCMNU()
    End Sub

End Class





