<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Brad_Haydell_P3
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
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.AddToList = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DailyCost = New System.Windows.Forms.TextBox()
        Me.SelectedApp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WaterFieldBox = New System.Windows.Forms.GroupBox()
        Me.costPerGal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.WaterPerHour = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Header = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataEntryList = New System.Windows.Forms.RichTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DisplayMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AppLabel = New System.Windows.Forms.Label()
        Me.SelectAppliance = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBCost = New System.Windows.Forms.TextBox()
        Me.TBAppliance = New System.Windows.Forms.TextBox()
        Me.TBHours = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.WaterFieldBox.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(244, 587)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(215, 55)
        Me.ResetButton.TabIndex = 4
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'AddToList
        '
        Me.AddToList.Location = New System.Drawing.Point(12, 587)
        Me.AddToList.Name = "AddToList"
        Me.AddToList.Size = New System.Drawing.Size(215, 55)
        Me.AddToList.TabIndex = 3
        Me.AddToList.Text = "Add to List"
        Me.AddToList.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DailyCost)
        Me.GroupBox2.Controls.Add(Me.SelectedApp)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 413)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 168)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Summary"
        '
        'DailyCost
        '
        Me.DailyCost.BackColor = System.Drawing.SystemColors.Menu
        Me.DailyCost.Location = New System.Drawing.Point(241, 99)
        Me.DailyCost.Name = "DailyCost"
        Me.DailyCost.ReadOnly = True
        Me.DailyCost.Size = New System.Drawing.Size(177, 31)
        Me.DailyCost.TabIndex = 1
        Me.DailyCost.TabStop = False
        Me.DailyCost.Text = "0.00"
        Me.DailyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SelectedApp
        '
        Me.SelectedApp.BackColor = System.Drawing.SystemColors.Menu
        Me.SelectedApp.Location = New System.Drawing.Point(241, 41)
        Me.SelectedApp.Name = "SelectedApp"
        Me.SelectedApp.ReadOnly = True
        Me.SelectedApp.Size = New System.Drawing.Size(177, 31)
        Me.SelectedApp.TabIndex = 0
        Me.SelectedApp.TabStop = False
        Me.SelectedApp.Text = "None"
        Me.SelectedApp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 26)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Selected Appliance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 26)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Daily Cost"
        '
        'WaterFieldBox
        '
        Me.WaterFieldBox.Controls.Add(Me.costPerGal)
        Me.WaterFieldBox.Controls.Add(Me.Label10)
        Me.WaterFieldBox.Controls.Add(Me.WaterPerHour)
        Me.WaterFieldBox.Controls.Add(Me.Label11)
        Me.WaterFieldBox.Location = New System.Drawing.Point(12, 253)
        Me.WaterFieldBox.Name = "WaterFieldBox"
        Me.WaterFieldBox.Size = New System.Drawing.Size(447, 154)
        Me.WaterFieldBox.TabIndex = 1
        Me.WaterFieldBox.TabStop = False
        Me.WaterFieldBox.Text = "Water-Based Appliance Field"
        '
        'costPerGal
        '
        Me.costPerGal.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.costPerGal.Location = New System.Drawing.Point(241, 100)
        Me.costPerGal.Name = "costPerGal"
        Me.costPerGal.Size = New System.Drawing.Size(177, 31)
        Me.costPerGal.TabIndex = 1
        Me.costPerGal.Text = "0.00"
        Me.costPerGal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 26)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Water Per Hour"
        '
        'WaterPerHour
        '
        Me.WaterPerHour.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.WaterPerHour.Location = New System.Drawing.Point(241, 42)
        Me.WaterPerHour.Name = "WaterPerHour"
        Me.WaterPerHour.Size = New System.Drawing.Size(177, 31)
        Me.WaterPerHour.TabIndex = 0
        Me.WaterPerHour.Text = "0"
        Me.WaterPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 105)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(166, 26)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Cost Per Gallon"
        '
        'Header
        '
        Me.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.Location = New System.Drawing.Point(489, 3)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(232, 42)
        Me.Header.TabIndex = 18
        Me.Header.Text = "Appliance"
        Me.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1015, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 42)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "|"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(767, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(232, 42)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Hours Per Day"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(718, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 42)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "|"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1041, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 41)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Cost Per Day"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataEntryList
        '
        Me.DataEntryList.AcceptsTab = True
        Me.DataEntryList.AutoWordSelection = True
        Me.DataEntryList.Location = New System.Drawing.Point(494, 53)
        Me.DataEntryList.Name = "DataEntryList"
        Me.DataEntryList.Size = New System.Drawing.Size(779, 590)
        Me.DataEntryList.TabIndex = 5
        Me.DataEntryList.TabStop = False
        Me.DataEntryList.Text = ""
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplayMessage})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 658)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1286, 40)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = " "
        '
        'DisplayMessage
        '
        Me.DisplayMessage.Name = "DisplayMessage"
        Me.DisplayMessage.Size = New System.Drawing.Size(22, 35)
        Me.DisplayMessage.Text = " "
        '
        'AppLabel
        '
        Me.AppLabel.AutoSize = True
        Me.AppLabel.Location = New System.Drawing.Point(25, 37)
        Me.AppLabel.Name = "AppLabel"
        Me.AppLabel.Size = New System.Drawing.Size(108, 26)
        Me.AppLabel.TabIndex = 4
        Me.AppLabel.Text = "Appliance"
        '
        'SelectAppliance
        '
        Me.SelectAppliance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelectAppliance.FormattingEnabled = True
        Me.SelectAppliance.Items.AddRange(New Object() {"None", "Air Conditioner", "Clothes Washer", "Dishwasher", "Refrigerator", "TV", "Space Heater", "Fan", "Dryer", "Oven"})
        Me.SelectAppliance.Location = New System.Drawing.Point(200, 30)
        Me.SelectAppliance.Name = "SelectAppliance"
        Me.SelectAppliance.Size = New System.Drawing.Size(218, 33)
        Me.SelectAppliance.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cost kWh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 26)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Appliance kWh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 26)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Hours per Day"
        '
        'TBCost
        '
        Me.TBCost.Location = New System.Drawing.Point(241, 81)
        Me.TBCost.Name = "TBCost"
        Me.TBCost.Size = New System.Drawing.Size(177, 31)
        Me.TBCost.TabIndex = 2
        Me.TBCost.Text = "0.00"
        Me.TBCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBAppliance
        '
        Me.TBAppliance.Location = New System.Drawing.Point(241, 132)
        Me.TBAppliance.Name = "TBAppliance"
        Me.TBAppliance.Size = New System.Drawing.Size(177, 31)
        Me.TBAppliance.TabIndex = 3
        Me.TBAppliance.Text = "0.00"
        Me.TBAppliance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TBHours
        '
        Me.TBHours.Location = New System.Drawing.Point(241, 182)
        Me.TBHours.Name = "TBHours"
        Me.TBHours.Size = New System.Drawing.Size(177, 31)
        Me.TBHours.TabIndex = 4
        Me.TBHours.Text = "0"
        Me.TBHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SelectAppliance)
        Me.GroupBox1.Controls.Add(Me.TBHours)
        Me.GroupBox1.Controls.Add(Me.AppLabel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBAppliance)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TBCost)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 222)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Brad_Haydell_P3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1286, 698)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.WaterFieldBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.AddToList)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.DataEntryList)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Brad_Haydell_P3"
        Me.Text = "Enhanced Home Utility Auditing Program"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.WaterFieldBox.ResumeLayout(False)
        Me.WaterFieldBox.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ResetButton As Button
    Friend WithEvents AddToList As Button
    Friend WithEvents DailyCost As TextBox
    Friend WithEvents SelectedApp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents WaterFieldBox As GroupBox
    Friend WithEvents costPerGal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents WaterPerHour As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Header As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataEntryList As RichTextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents DisplayMessage As ToolStripStatusLabel
    Friend WithEvents AppLabel As Label
    Friend WithEvents SelectAppliance As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBCost As TextBox
    Friend WithEvents TBAppliance As TextBox
    Friend WithEvents TBHours As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
