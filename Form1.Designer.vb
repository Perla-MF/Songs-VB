<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Label1 = New Label()
        cbArtist = New ComboBox()
        DataGVsongs = New DataGridView()
        btnBuscar = New Button()
        CType(DataGVsongs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold Or FontStyle.Italic)
        Label1.Location = New Point(102, 79)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 34)
        Label1.TabIndex = 0
        Label1.Text = "Artista"
        ' 
        ' cbArtist
        ' 
        cbArtist.Font = New Font("Arial", 18F, FontStyle.Bold Or FontStyle.Italic)
        cbArtist.FormattingEnabled = True
        cbArtist.Location = New Point(258, 79)
        cbArtist.Name = "cbArtist"
        cbArtist.Size = New Size(370, 42)
        cbArtist.TabIndex = 3
        ' 
        ' DataGVsongs
        ' 
        DataGVsongs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGVsongs.BackgroundColor = SystemColors.GradientActiveCaption
        DataGVsongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGVsongs.GridColor = SystemColors.InactiveCaption
        DataGVsongs.Location = New Point(29, 180)
        DataGVsongs.Name = "DataGVsongs"
        DataGVsongs.RightToLeft = RightToLeft.No
        DataGVsongs.RowHeadersWidth = 51
        DataGVsongs.Size = New Size(945, 544)
        DataGVsongs.TabIndex = 6
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.Location = New Point(724, 59)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(187, 83)
        btnBuscar.TabIndex = 7
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1008, 749)
        Controls.Add(btnBuscar)
        Controls.Add(DataGVsongs)
        Controls.Add(cbArtist)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Songs"
        CType(DataGVsongs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbArtist As ComboBox
    Friend WithEvents DataGVsongs As DataGridView
    Friend WithEvents btnBuscar As Button

End Class
