Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO


Public Class Form1
    Dim con As New SqlConnection("Data Source=LAPTOP-F8APJRBB;Initial Catalog=SDatabase;Integrated Security=True")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pid As Integer = Textproductid.Text
        Dim iname As String = Textitemname.Text
        Dim design As String = Textdesign.Text
        Dim color As String = Combocolor.Text
        Dim insertdate As DateTime = DateTimePickerinsert.Text
        Dim wtype As String = ""
        If Radioallowed.Checked = True Then
            wtype = "Allowed"
        Else
            wtype = "Not Allowed"
        End If
        con.Open()
        Dim command As New SqlCommand("Insert into Product_Setup_Tab values('" & pid & "', '" & iname & "', '" & design & "', '" & color & "', '" & insertdate & "', '" & wtype & "')", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Inserted.")
        LoadDataInGrid()


    End Sub
    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("select * from Product_Setup_Tab", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()

        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"

        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pid As Integer = Textproductid.Text
        Dim iname As String = Textitemname.Text
        Dim design As String = Textdesign.Text
        Dim color As String = Combocolor.Text
        Dim insertdate As DateTime = DateTimePickerinsert.Text
        Dim wtype As String = ""
        If Radioallowed.Checked = True Then
            wtype = "Allowed"
        Else
            wtype = "Not Allowed"
        End If
        con.Open()
        Dim command As New SqlCommand("update Product_Setup_Tab set ItemName = '" & iname & "', Design = '" & design & "', Color = '" & color & "', ItemDate =  '" & insertdate & "', WarrantyType = '" & wtype & "' where Product_ID = '" & pid & "'", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Updated.")
        LoadDataInGrid()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show("are you sure to delete?", "Delete Document", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim pid As Integer = Textproductid.Text
            con.Open()
            Dim command As New SqlCommand("delete Product_Setup_Tab where Product_ID = '" & pid & "'", con)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully Deleted.")
            con.Close()
            LoadDataInGrid()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim pid As Integer = Textproductid.Text
        Dim command As New SqlCommand("select * from Product_Setup_Tab where Product_ID = '" & pid & "'", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox2.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Paragraph As New Paragraph
        Dim PdfFile As New Document(PageSize.A4, 40, 40, 40, 20)
        PdfFile.AddTitle(TextBox1.Text)
        Dim Write As PdfWriter = PdfWriter.GetInstance(PdfFile, New FileStream(TextBox2.Text, FileMode.Create))
        PdfFile.Open()

        Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pTable As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

        Paragraph = New Paragraph(New Chunk(TextBox1.Text, pTitle))
        Paragraph.Alignment = Element.ALIGN_CENTER
        Paragraph.SpacingAfter = 5.0F

        PdfFile.Add(Paragraph)

        Dim PdfTable As New PdfPTable(DataGridView1.Columns.Count)

        PdfTable.TotalWidth = 500.0F
        PdfTable.LockedWidth = True

        Dim widths(0 To DataGridView1.Columns.Count - 1) As Single
        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            widths(i) = 1.0F
        Next

        PdfTable.SetWidths(widths)
        PdfTable.HorizontalAlignment = 0
        PdfTable.SpacingBefore = 5.0F

        Dim pdfcell As PdfPCell = New PdfPCell

        For i As Integer = 0 To DataGridView1.Columns.Count - 1

            pdfcell = New PdfPCell(New Phrase(New Chunk(DataGridView1.Columns(i).HeaderText, pTable)))

            pdfcell.HorizontalAlignment = PdfPCell.ALIGN_LEFT

            PdfTable.AddCell(pdfcell)



        Next

        For i As Integer = 0 To DataGridView1.Rows.Count - 2

            For j As Integer = 0 To DataGridView1.Columns.Count - 1
                pdfcell = New PdfPCell(New Phrase(DataGridView1(j, i).Value.ToString(), pTable))
                PdfTable.HorizontalAlignment = PdfPCell.ALIGN_LEFT
                PdfTable.AddCell(pdfcell)
            Next
        Next
        PdfFile.Add(PdfTable)
        PdfFile.Close()

        MessageBox.Show("PDF format success exported !", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)



    End Sub
End Class
