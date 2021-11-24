Imports System.Data.SqlClient

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
End Class
