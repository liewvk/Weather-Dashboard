<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtCity = New TextBox()
        btnSearch = New Button()
        lblStatus = New Label()
        lblCity = New Label()
        lblTemp = New Label()
        lblHumid = New Label()
        lblWind = New Label()
        lblEnterCityName = New Label()
        SuspendLayout()
        ' 
        ' txtCity
        ' 
        txtCity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCity.Location = New Point(279, 100)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(231, 34)
        txtCity.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(243, 188)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(145, 36)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(104, 251)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(374, 28)
        lblStatus.TabIndex = 2
        lblStatus.Text = "Displays search status and error messages"
        ' 
        ' lblCity
        ' 
        lblCity.AutoSize = True
        lblCity.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCity.Location = New Point(104, 296)
        lblCity.Name = "lblCity"
        lblCity.Size = New Size(230, 28)
        lblCity.TabIndex = 3
        lblCity.Text = "Displays city and country"
        ' 
        ' lblTemp
        ' 
        lblTemp.AutoSize = True
        lblTemp.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTemp.Location = New Point(442, 296)
        lblTemp.Name = "lblTemp"
        lblTemp.Size = New Size(190, 28)
        lblTemp.TabIndex = 4
        lblTemp.Text = "Display Temperature"
        ' 
        ' lblHumid
        ' 
        lblHumid.AutoSize = True
        lblHumid.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHumid.Location = New Point(104, 348)
        lblHumid.Name = "lblHumid"
        lblHumid.Size = New Size(167, 28)
        lblHumid.TabIndex = 5
        lblHumid.Text = "Displays humidity"
        ' 
        ' lblWind
        ' 
        lblWind.AutoSize = True
        lblWind.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblWind.Location = New Point(446, 344)
        lblWind.Name = "lblWind"
        lblWind.Size = New Size(196, 28)
        lblWind.TabIndex = 6
        lblWind.Text = "Displays WInd Speed"
        ' 
        ' lblEnterCityName
        ' 
        lblEnterCityName.AutoSize = True
        lblEnterCityName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEnterCityName.Location = New Point(104, 100)
        lblEnterCityName.Name = "lblEnterCityName"
        lblEnterCityName.Size = New Size(157, 28)
        lblEnterCityName.TabIndex = 7
        lblEnterCityName.Text = "Enter CIty Name:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblEnterCityName)
        Controls.Add(lblWind)
        Controls.Add(lblHumid)
        Controls.Add(lblTemp)
        Controls.Add(lblCity)
        Controls.Add(lblStatus)
        Controls.Add(btnSearch)
        Controls.Add(txtCity)
        Name = "Form1"
        Text = "Weather Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCity As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents lblHumid As Label
    Friend WithEvents lblWind As Label
    Friend WithEvents lblEnterCityName As Label

End Class
