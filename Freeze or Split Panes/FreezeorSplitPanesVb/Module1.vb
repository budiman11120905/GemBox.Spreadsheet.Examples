Imports GemBox.Spreadsheet

Module Module1

    Sub Main()

        ' If using Professional version, put your serial key below.
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY")

        Dim ef As ExcelFile = New ExcelFile

        ' Frozen Rows (first 2 rows are frozen)
        Dim ws1 As ExcelWorksheet = ef.Worksheets.Add("Frozen rows")
        ws1.Panes = New WorksheetPanes(PanesState.Frozen, 0, 2, "A3", PanePosition.BottomLeft)

        ' Frozen Columns (first column is frozen)
        Dim ws2 As ExcelWorksheet = ef.Worksheets.Add("Frozen columns")
        ws2.Panes = New WorksheetPanes(PanesState.Frozen, 1, 0, "B1", PanePosition.TopRight)

        ' Frozen Rows and Columns (first 2 rows and first 3 columns are frozen)
        Dim ws3 As ExcelWorksheet = ef.Worksheets.Add("Frozen rows and columns")
        ws3.Panes = New WorksheetPanes(PanesState.Frozen, 3, 2, "E5", PanePosition.BottomRight)

        ' Split pane
        Dim ws4 As ExcelWorksheet = ef.Worksheets.Add("Split pane")
        ws4.Panes = New WorksheetPanes(PanesState.Split, 2310, 1500, "D7", PanePosition.BottomRight)

        ef.Save("Freeze or Split Panes.xlsx")

    End Sub

End Module